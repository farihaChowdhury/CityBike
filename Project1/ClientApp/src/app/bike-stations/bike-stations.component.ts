import { Component, ViewChild } from '@angular/core';
import { BikeStationService } from '../../services/bike-station.service';
import { BikeStation } from '../../models/bike-station.model';
import { Table } from 'primeng/table';


@Component({
  selector: 'app-fetch-data',
  templateUrl: './bike-stations.component.html'
})
export class BikeStationsComponent {
  public bikeStations: BikeStation[] = [];
  public isLoading: boolean = false;

  @ViewChild('dt')
    dt!: Table;

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

  applyFilterGlobal($event: any, stringVal: string) {
    this.dt.filterGlobal(($event.target as HTMLInputElement).value, stringVal);
  }
}
