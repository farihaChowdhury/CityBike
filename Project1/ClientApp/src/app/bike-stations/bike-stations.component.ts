import { Component } from '@angular/core';
import { BikeStationService } from '../../services/bike-station.service';
import { BikeStation } from '../../models/bike-station.model';


@Component({
  selector: 'app-fetch-data',
  templateUrl: './bike-stations.component.html'
})
export class BikeStationsComponent {
  public bikeStations: BikeStation[] = [];
  public isLoading: boolean = false;

  constructor(private bikeStationService: BikeStationService) {

  }

  ngOnInit() {
    this.isLoading = true;
    this.bikeStationService.getAllBikeStations().
      subscribe(data => {
        this.bikeStations = data;
        this.isLoading = false;
      },
        error => {
          this.isLoading = false;
          console.log(error)
        });
  }
}
