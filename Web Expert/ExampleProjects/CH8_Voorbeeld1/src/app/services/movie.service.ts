import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs'
import { catchError, tap, map } from 'rxjs/operators'
import { Movie } from '../shared/movie.model';

@Injectable()
export class MovieService {
    moviesUrl = 'assets/movies.json';

    constructor(private http: HttpClient) { }

    getMovies(): Observable<Movie[]>{
        return this.http.get<Movie[]>(this.moviesUrl).pipe(
            // tap gaat inhaken op de observable en voert een console.log uit voor elke value die binnenkomt
            // in dit geval enkel de movie array uit het json bestand.
            // De data uit movieArr wordt niet gewijzigd.
            tap(movieArr => console.log('fetched movies')),
            // map gaat inhaken op de observable en voert een functie uit waarbij de values uit het object dat binnekomt
            // aangepast worden en teruggegeven worden in een nieuwe observable.
            map(movieArr => {
                movieArr[0].title = 'test map';
                return movieArr;
            }),
            map(arrMovies => {
                arrMovies[1].title = 'test map 2';
                return arrMovies;
            }),
            catchError(this.handleError)
        );
    }

    private handleError(error: HttpErrorResponse) {
        if (error.error instanceof ErrorEvent) {
          // Opvangen van clientside errors
          console.error('An error occurred:', error.error.message);
        } else {
          // Opvangen van response codes van de backend zelf
          console.error(
            `Backend returned code ${error.status}, ` +
            `body was: ${error.error}`);
        }

        return throwError(
          'Something bad happened; please try again later.');
      };
}