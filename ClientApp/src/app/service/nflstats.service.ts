import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable, of} from 'rxjs';
import {catchError} from 'rxjs/operators'
import {NflPlayers} from '../model/nfl-players';
import {NflTeams} from '../model/nfl-teams';

@Injectable({
  providedIn: 'root'
})
export class NflstatsService {

  constructor(private http: HttpClient) {
  }

  getPlayers(): Observable<NflPlayers> {
    return this.http.get<NflPlayers>('api/players').pipe(
      catchError(this.handleError<NflPlayers>(`getPlayers`))
    );
  }

  getTeams(): Observable<NflTeams> {
    return this.http.get<NflTeams>('api/teams').pipe(
      catchError(this.handleError<NflTeams>(`getTeams`))
    );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    };
  }
}
