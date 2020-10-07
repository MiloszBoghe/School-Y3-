export class Course{
    name: string;
    location: string;
    speaker: string;
    level: number;

    constructor(name: string, location: string, speaker: string, level: number){
        this.name = name;
        this.location = location;
        this.speaker = speaker;
        this.level = level;
    }
}