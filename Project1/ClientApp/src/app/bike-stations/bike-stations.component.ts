import { Component } from '@angular/core';
import { BikeStationService } from '../../services/bike-station.service';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './bike-stations.component.html'
})
export class BikeStationsComponent {
  public bikeStations: BikeStation[] = [];

  constructor(private bikeStationService: BikeStationService) {
   
  }

  ngOnInit() {
    this.bikeStationService.getAllBikeStations().
      subscribe(data => {
        this.bikeStations = data;

      });

  }
}

interface BikeStation {
  name: string;
  address: number;
  kaupunki: number;
  operaattor: string;
}
