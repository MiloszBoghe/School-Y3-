import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-page5',
  templateUrl: './page5.component.html',
  styleUrls: ['./page5.component.css']
})
export class Page5Component implements OnInit {
  par1: any;
  par2: any;

  constructor(private router: ActivatedRoute) { }

  ngOnInit() {
    this.par1 = this.router.snapshot.params['par1'];
    this.par2 = this.router.snapshot.params['par2'];
  }

}
