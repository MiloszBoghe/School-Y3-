import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent implements OnInit {
  private quotes: string[];

  constructor() { }

  ngOnInit() {
    this.quotes = [];
    this.quotes.push("You can do anything, but not everything");
    this.quotes.push("Run you fools");
    this.quotes.push("Waar zijn die handjes");
  }

  // koppeling zit in de app.component.html
  vangOp(event: string): void{
    alert('Opgevangen in de parent: ' + event);
  }

}
