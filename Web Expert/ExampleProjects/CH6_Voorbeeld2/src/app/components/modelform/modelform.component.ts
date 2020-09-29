import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl } from '@angular/forms';
import { validateEmail } from './email.validator'; // Custom validator


@Component({
  selector: 'app-modelform',
  templateUrl: './modelform.component.html',
  styleUrls: ['./modelform.component.css']
})
/*
De FormGroup 'myForm' wordt gebruikt om het formulier te linken aan logica
in de component klasse.

Iedere FormControl in deze FormGroup linkt terug naar een input veld op
het HTML formulier. Volgende argumenten worden meegegeven aan een
FormControl object:
- Een default value (hier de string 'Dries' ; kan ook null zijn)
- Eén validator of een array van validators. Bij de FormControl 'first'
  zijn er geen validators voorzien. Bij de FormControl 'last' is er één
  validator voorzien in een array.

De code kan eenvoudiger door gebruik te maken van een FormBuilder. Meer
informatie op: https://angular.io/api/forms/FormBuilder
*/
export class ModelformComponent implements OnInit {
  myForm: FormGroup;

  ngOnInit(): void {
    this.myForm = new FormGroup({
      first: new FormControl('Dries', [Validators.required, Validators.minLength(3)]),
      last: new FormControl('Swinnen', [Validators.pattern('^[A-Z][a-z]*')]),
      email: new FormControl(null, [ Validators.required, validateEmail ]),
      address: new FormGroup({
        street: new FormControl(null, []),
        city: new FormControl(null, [Validators.required])
      })
    });
  }

  onSubmit() {
    console.log('Submitted: ' + this.myForm.get('first').value);
    console.log('Submitted:' + JSON.stringify(this.myForm.value, null, 2));
  }
}
