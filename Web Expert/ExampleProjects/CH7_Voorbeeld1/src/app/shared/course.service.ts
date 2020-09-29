import { Injectable } from '@angular/core';
import { Course } from './course.model';

@Injectable()
export class CourseService {
    private courseList: Course[] = [
        new Course('Angular fundamentals', 'Hasselt', 'Dries Swinnen', 1),
        new Course('Angular Advanced', 'Zonhoven', 'Luc Doumen', 2),
        new Course('Angular Expert', 'Neerpelt', 'Steve Jobs', 3),
    ];
    constructor() { }

    getCourses(): Course[]{
        return this.courseList;
    }

    getCourse(index: number): Course{
        return this.courseList[index];
    }

    addCourse(course: Course): void{
        this.courseList.push(course);
    }

    updateCourse(course: Course, index): void{
        this.courseList[index] = course;
    }

    removeCourse(index): void{
        this.courseList.splice(index,1);
    }
}