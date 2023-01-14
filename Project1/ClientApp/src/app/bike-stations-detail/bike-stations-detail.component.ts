import { Component, Input } from '@angular/core';
import { BikeStation } from '../../models/bike-station.model';
import { BikeStationService } from '../../services/bike-station.service';


@Component({
  selector: 'app-bike-station-detail',
  templateUrl: './bike-stations-detail.component.html'
})
export class BikeStationsDetailComponent {
  //@Input() bikeStation!: BikeStation;
  public bikeStation!: BikeStation;

  public isOpenDetailDialogBox: boolean = false; 

  constructor(private bikeStationService: BikeStationService) {

  }

  openDetailDialogBox(bikeStation: BikeStation) {
    this.isOpenDetailDialogBox = true;
    this.bikeStation = bikeStation;
  }


}
