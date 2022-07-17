import { Language } from './Language';
import { Lecturer } from './Lecturer';

export interface IState {
    allLecturersList: Lecturer[],
    filteredLecturersList : Lecturer[],
    allLanguagesList: Language[]
}