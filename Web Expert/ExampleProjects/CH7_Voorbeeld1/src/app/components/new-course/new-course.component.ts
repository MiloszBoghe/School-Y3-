import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Course } from 'src/app/shared/course.model';
import { CourseService } from 'src/app/shared/course.service';

@Component({
  selector: 'app-new-course',
  templateUrl: './new-course.component.html',
  styleUrls: ['./new-course.component.css']
})
export class NewCourseComponent implements OnInit {
  @Output() insertCourse = new EventEmitter();

  constructor(private courseService: CourseService) { }

  ngOnInit(): void{
  }

  newCourse(course: Course): void{
    this.courseService.addCourse(course);
    this.insertCourse.emit(course);
  }

}
