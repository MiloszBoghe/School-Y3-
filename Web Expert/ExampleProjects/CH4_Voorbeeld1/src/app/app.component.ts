import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  voornaam: string;
  achternaam: string;

  constructor(){

  }

  ngOnInit(): void {
      this.voornaam = "default value";
  }

  submit(): void{
    alert(`Submitted: ${this.voornaam} ${this.achternaam}`)
  }

  onKey(event: any): void{
    console.log(event);
  }
  
}
