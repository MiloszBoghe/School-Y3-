import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Course } from 'src/app/shared/course.model';

@Component({
  selector: 'app-course-form',
  templateUrl: './course-form.component.html',
  styleUrls: ['./course-form.component.css']
})
export class CourseFormComponent implements OnInit {
  courseForm: FormGroup;
  @Input() course?: Course;
  @Output() submitForm = new EventEmitter();

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.generateForm();
  }

  ngOnChanges(): void{
    this.generateForm();
  }

  generateForm(): void{
    this.courseForm = this.formBuilder.group({
      name: [(this.course ? this.course.name : null), Validators.required],
      location: [(this.course ? this.course.location : null), Validators.required],
      speaker: [(this.course ? this.course.speaker : null)],
      level: [(this.course ? this.course.level : 0)]
    });
  }

  onSubmit(): void{
    let submittedCourse: Course = this.courseForm.value;
    this.submitForm.emit(submittedCourse);
  }

}
