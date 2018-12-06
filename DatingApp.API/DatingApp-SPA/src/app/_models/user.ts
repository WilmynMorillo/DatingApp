export interface User {
    id: number;
    user: string;
    knownAs: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    photoUrl: string;
    citiy: string;
    country: string;
    interest?: string;
    introduction?: string;
    lookingFor?: string;
    photos?: Photo[];


}
