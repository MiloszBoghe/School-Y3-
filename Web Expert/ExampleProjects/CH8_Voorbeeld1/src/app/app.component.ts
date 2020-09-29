import { Component, OnInit } from '@angular/core';
import { MovieService } from './services/movie.service';
import { Observable } from 'rxjs';
import { Movie } from './shared/movie.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  movies$: Observable<Movie[]>;
  movieList: Movie[];

  constructor(private ms: MovieService) { }

  ngOnInit(): void {
    this.movies$ = this.ms.getMovies();

    // Alternatief kan je ook zelf subscriben:
    // this.ms.getMovies().subscribe(data => this.movieList = data);
    // 
    // Om bovenstaande te gebruiken moet je wel in de *ngFor movies$ aanpassen naar movieList
  }

}
