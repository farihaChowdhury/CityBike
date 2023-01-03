import { Component, Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';

@Injectable()
export class BikeStationService {
  public bikeStations: BikeStation[] = [];
  private apiURL: string;

  constructor(private http: HttpClient) {
    this.apiURL = 'https://localhost:44412/';
  }

  getAllBikeStations(): Observable<BikeStation[]>  {
    return this.http.get<BikeStation[]>(this.apiURL + 'bikestation/GetAllBikeStations')
      .pipe(retry(1));   
  }
}

interface BikeStation {
  name: string;
  address: number;
  kaupunki: number;
  operaattor: string;
}
