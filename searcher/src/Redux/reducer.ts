import { Language } from './../Models/Language';
import { IState } from "../Models/IState";
import { Lecturer } from "../Models/Lecturer";

const _state_: IState | any = {
    allLecturersList: [],
    allLanguagesList: [],
    filteredLecturersList: []
}

export default function reducer(state = _state_, action: any) {
    switch (action.type) {
        case 'init':
            return state;

        case 'updateAllLecturersList':
            return { ...state, allLecturersList: action.lecturersList, filteredLecturersList: action.lecturersList };

        case 'updateFilteredLecturersList':
            return { ...state, filteredLecturersList : action.filteredLecturersList };
    }
}