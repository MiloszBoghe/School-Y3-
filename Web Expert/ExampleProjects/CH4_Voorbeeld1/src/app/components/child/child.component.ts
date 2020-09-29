import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {
  @Input() inputTest: string;
  @Output() klikKnop = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  klik(){
    this.klikKnop.emit(this.inputTest);
  }

}
