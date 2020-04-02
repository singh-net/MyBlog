import { Photo } from './photo';

export interface User {
    id: number;
    username: string;
    name: string;
    email: string;
    age: number;
    lastActive: Date;
    registerDate: Date;
    status: string;
    photoUrl: string;
    introduction?: string;
    photos?: Photo[];
}
