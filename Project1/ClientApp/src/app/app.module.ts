import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { BikeStationsComponent } from './bike-stations/bike-stations.component';
import { JourneyComponent } from './journey/journey.component';


import { TableModule } from 'primeng/table';
import { InputTextModule } from 'primeng/inputtext';
import { BikeStationService } from '../services/bike-station.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    BikeStationsComponent,
    JourneyComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'bike-stations', component: BikeStationsComponent },
      { path: 'journey', component: JourneyComponent },

    ]),
    TableModule,
    InputTextModule
  ],
  providers: [BikeStationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
