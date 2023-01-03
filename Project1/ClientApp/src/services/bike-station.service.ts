import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { retry } from 'rxjs/operators';
import { environment } from '../environments/environment';
import { BikeStation } from '../models/bike-station.model';


@Injectable()
export class BikeStationService {
  public bikeStations: BikeStation[] = [];
  private apiURL: string;

  constructor(private http: HttpClient) {
    this.apiURL = environment.baseUrl;
  }

  getAllBikeStations(): Observable<BikeStation[]>  {
    return this.http.get<BikeStation[]>(this.apiURL + 'bikestation/GetAllBikeStations')
      .pipe(retry(1));   
  }
}

