import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { retry } from 'rxjs/operators';
import { environment } from '../environments/environment';
import { BikeStation } from '../models/bike-station.model';
import { Journey } from '../models/journey.model';


@Injectable()
export class JourneyService {
  public bikeStations: BikeStation[] = [];
  private apiURL: string;

  constructor(private http: HttpClient) {
    this.apiURL = environment.baseUrl;
  }

  getAllJourneys(): Observable<Journey[]> {
    return this.http.get<Journey[]>(this.apiURL + 'journey/GetAllJourneys')
      .pipe(retry(1));
  }
}

