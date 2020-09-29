import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-page3',
  templateUrl: './page3.component.html',
  styleUrls: ['./page3.component.css']
})
export class Page3Component implements OnInit {
  param: any;
  constructor(private route: ActivatedRoute ) { }

  ngOnInit() {
    this.param = this.route.snapshot.params['param1'];
  }

}
