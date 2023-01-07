import { Component, ViewChild } from '@angular/core';
import { LazyLoadEvent } from 'primeng/api';
import { Table } from 'primeng/table';
import { Journey } from '../../models/journey.model';
import { JourneyService } from '../../services/journey.service';


@Component({
  selector: 'app-journey',
  templateUrl: './journey.component.html'
})
export class JourneyComponent {
  public journeys: Journey[] = [];
  public dataSource: Journey[] = [];

  public isLoading: boolean = false;
  public totalRecords: number = 0;

  @ViewChild('dt')
  dt!: Table;

  constructor(private journeyService: JourneyService) {

  }

  ngOnInit() {
    this.isLoading = true;
    this.journeyService.getAllJourneys().
      subscribe(data => {
        this.journeys = data;
        this.totalRecords = data.length;
        this.isLoading = false;
      },
        error => {
          this.isLoading = false;
          console.log(error)
        });
  }

  //loadJourneys(event: any) {
  //  this.isLoading = true;
  //  setTimeout(() => {
  //    if (this.journeys && this.journeys.length > 0) {
  //      this.journeys = this.journeys.slice(event.first, (event.first + event.rows));
  //      this.isLoading = false;
  //    }
  //  }, 1000);

  //}

  applyFilterGlobal($event: any, stringVal: string) {
    this.dt.filterGlobal(($event.target as HTMLInputElement).value, stringVal);
  }

}
