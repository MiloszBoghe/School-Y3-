import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-stijl',
  templateUrl: './stijl.component.html',
  styleUrls: ['./stijl.component.css']
})
export class StijlComponent implements OnInit {
  stijlen: Object[];

  constructor() { }

  ngOnInit() {
    this.stijlen = [
      { border: '2px solid blue', fontSize: '16px' },
      { border: '2px dotted red', fontSize: '16px' },
      { border: '4px solid green', fontSize: '16px'},
      { fontSize: '16px', backgroundColor: '#efefef' }
    ];
  }

  randomStijl() {
    return this.stijlen[Math.floor(Math.random() * this.stijlen.length)]
  }

}
