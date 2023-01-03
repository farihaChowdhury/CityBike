import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './bike-stations.component.html'
})
export class BikeStationsComponent {
  public bikeStations: BikeStation[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<BikeStation[]>('https://localhost:44412/bikestation/GetAllBikeStations').subscribe(result => {
      this.bikeStations = result;
    }, error => console.error(error));
  }
}

interface BikeStation {
  name: string;
  address: number;
  kaupunki: number;
  operaattor: string;
}
