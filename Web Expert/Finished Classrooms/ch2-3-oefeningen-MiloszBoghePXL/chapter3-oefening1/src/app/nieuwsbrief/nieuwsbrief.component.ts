import {Component, OnInit} from '@angular/core';

@Component({
  selector: 'app-nieuwsbrief',
  templateUrl: './nieuwsbrief.component.html',
  styleUrls: ['./nieuwsbrief.component.css']
})
export class NieuwsbriefComponent implements OnInit {

  email: string;
  test: string;

  constructor() {
  }

  ngOnInit(): void {
  }

  changeEmail(): void {
    this.email = this.test;
  }

}
