import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-templateform',
  templateUrl: './templateform.component.html',
  styleUrls: ['./templateform.component.css']
})
export class TemplateformComponent {
  onSubmit(form) {
    console.log('Submitted:' + JSON.stringify(form.value, null, 2));
  }
}
