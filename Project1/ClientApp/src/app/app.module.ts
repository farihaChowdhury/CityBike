import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { BikeStationsComponent } from './bike-stations/bike-stations.component';
import { BikeStationsDetailComponent } from './bike-stations-detail/bike-stations-detail.component';
import { JourneyComponent } from './journey/journey.component';


import { TableModule } from 'primeng/table';
import { InputTextModule } from 'primeng/inputtext';
import { DialogModule } from 'primeng/dialog';
import { MenubarModule } from 'primeng/menubar';
import { ButtonModule } from 'primeng/button';

import { BikeStationService } from '../services/bike-station.service';
import { JourneyService } from '../services/journey.service';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    BikeStationsComponent,
    BikeStationsDetailComponent,
    JourneyComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'bike-stations', component: BikeStationsComponent },
      { path: 'journey', component: JourneyComponent },

    ]),
    TableModule,
    InputTextModule,
    DialogModule,
    MenubarModule,
    ButtonModule
  ],
  providers: [
    BikeStationService,
    JourneyService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
