import {Component, OnInit} from '@angular/core';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  bericht: string;
  email: string;

  constructor() {
  }

  ngOnInit() {
  }

  send() {
    alert('bericht ontvangen:' + this.bericht);
  }

}
