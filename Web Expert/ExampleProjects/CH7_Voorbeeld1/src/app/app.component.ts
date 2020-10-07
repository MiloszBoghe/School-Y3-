import { Component } from '@angular/core';
import { Course } from './shared/course.model';
import { CourseService } from './shared/course.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  courses: Course[];
  isUpdating: boolean = false;
  updatingIndex: number;
  updatingCourse: Course;

  constructor(private courseService: CourseService) { }

  ngOnInit() {
   this.refreshList();
  }

  refreshList(): void{
    this.courses = this.courseService.getCourses();
  }

  triggerUpdate(index: number){
    this.isUpdating = true;
    this.updatingIndex = index;
    this.updatingCourse = this.courseService.getCourse(index);
  }

  finishUpdate(course: Course){
    this.courseService.updateCourse(course, this.updatingIndex);
    this.isUpdating = false;
    this.updatingCourse = undefined;
    this.refreshList();
  }

}
