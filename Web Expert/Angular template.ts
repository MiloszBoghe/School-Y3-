//Angular install:
//npm install -g @angular/cli

//nieuw angular project:
//ng new (projectnaam)

//nieuw angular component:
//ng generate component (componentnaam)

Binding{
	//in .ts file een variabel zetten, bv:
	export class NieuwsbriefComponent implements OnInit {
		email: string;
		  constructor() { }
		  ngOnInit(): void {}
	}
	//dan in .html:
	  <input id="id" [(ngModel)]="email">
	//wat je invult in dit input veld zal automatisch in de variabele "email" terecht komen.
}