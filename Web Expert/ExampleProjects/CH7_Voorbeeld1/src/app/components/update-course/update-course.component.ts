import { Component, OnInit, Input, Output } from '@angular/core';
import { Course } from 'src/app/shared/course.model';
import { EventEmitter } from '@angular/core';

@Component({
  selector: 'app-update-course',
  templateUrl: './update-course.component.html',
  styleUrls: ['./update-course.component.css']
})
export class UpdateCourseComponent implements OnInit {
  @Input() course: Course;
  @Output() updateCourse = new EventEmitter();
  
  constructor() { }

  ngOnInit(): void {
  }

  onUpdateCourse(crs: Course): void{
    this.updateCourse.emit(crs);
  }

}
