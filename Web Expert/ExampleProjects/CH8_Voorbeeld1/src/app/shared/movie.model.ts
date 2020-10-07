export class Movie{
    title: string;
    rating: number;
    isReleased: boolean;

    constructor(title: string, rating: number, isReleased: boolean){
        this.title = title;
        this.rating = rating;
        this.isReleased = isReleased;
    }
}