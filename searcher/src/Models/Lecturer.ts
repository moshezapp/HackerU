import { Language } from './Language';

export class Lecturer {
    id : number = 0;
    name : string = "";
    email : string = "";
    languages : number[] = [];
    languagesLiterals : Language[] = [];
}