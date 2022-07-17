import store from "../../Redux/store";
import axios from "axios";
import { useEffect } from "react";
import { useSelector } from 'react-redux';
import { Lecturer } from "../../Models/Lecturer";
import { Language } from "../../Models/Language";
import './SearchBox.css'
import { IState } from "../../Models/IState";
import env from "react-dotenv";

function SearchBox() {
    const SERVER_URL = env.SERVER_URL;

    const allLecturersList = useSelector((state: IState) => state.allLecturersList);
    const filteredLecturersList = useSelector((state: IState) => state.filteredLecturersList);

    function filterLecturers(text: any) {
        store.dispatch({ type: "updateFilteredLecturersList", filteredLecturersList: allLecturersList.filter((lecturer: Lecturer) => lecturer.name.toLocaleLowerCase().includes(text.toLocaleLowerCase())) });
    }

    useEffect(() => {
        axios.get<Lecturer[]>(SERVER_URL).then(lecturersResponse => {
            axios.get<Language[]>(SERVER_URL).then(langsResponse => {
                let updatedLecturerList = lecturersResponse.data.map((lecturer: Lecturer) => ({
                    ...lecturer, languagesLiterals: langsResponse.data
                        .filter((lang: Language) => lecturer.languages.includes(lang.id))
                }));
                store.dispatch({ type: 'updateAllLecturersList', lecturersList: updatedLecturerList });
            }).catch(err => { console.error("An error occured while fetching languages list.", err); });
        }).catch(err => { console.error("An error occured while fetching lecturers list.", err); });
    }, []);

    return (
        <>
            {allLecturersList.length > 0 ? (
                <div>
                    <input type="text" id="searchBox" className="searchBox" onChange={event => {
                        filterLecturers(event.target.value);
                    }} />
                    <ul>

                        {filteredLecturersList.map((lecturer: Lecturer) => {
                            return (
                                <div key={lecturer.id} className="lecturer" >
                                    Name : {lecturer.name}<br />
                                    Languages :  {lecturer.languagesLiterals.map(lang => lang.name).join(", ")}
                                </div>
                            )
                        })}

                    </ul>
                </div>
            ) : (
                <div>
                    <h1>
                        No data.
                    </h1>
                </div>
            )}
        </>
    )
}

export default SearchBox;