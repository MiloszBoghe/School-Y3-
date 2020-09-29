import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { CourseService } from './shared/course.service';
import { HeaderComponent } from './components/header/header.component';
import { NewCourseComponent } from './components/new-course/new-course.component';
import { UpdateCourseComponent } from './components/update-course/update-course.component';
import { CourseFormComponent } from './components/course-form/course-form.component';

@NgModule({
  declarations: [
    AppComponent,
    CourseFormComponent,
    NewCourseComponent,
    UpdateCourseComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule
  ],
  providers: [CourseService],
  bootstrap: [AppComponent]
})
export class AppModule { }
