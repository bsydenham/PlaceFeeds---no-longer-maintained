﻿import { Component } from '@angular/core';

import { TransferService } from '../../services/shared/transfer/transfer.service';
import { WeatherService } from '../../services/weather/weather.service';
import { IPlaceObject } from '../../interfaces/IPlaceObject';
import { WeatherTemperaturePipe } from './weather-temp.pipe';

@Component({
    selector: 'weather-component',
    templateUrl: './weather.component.html',
    providers: [WeatherService]
})
export class WeatherComponent {

    placeObject: IPlaceObject;
    weatherData: any;

    constructor(private _TransferService: TransferService, private _WeatherService: WeatherService) {
        this._TransferService.placeSearched$
            .subscribe(data => {
                this.placeObject = data;

                if (this.placeObject != null) {
                    this.getData(this.placeObject);
                }
            })
    }

    getData(placeObject: IPlaceObject) {
        this._WeatherService.getWeatherData(placeObject.latitude, placeObject.longitude)
            .subscribe(data => {
                this.weatherData = data.list.slice(0, 5);
                console.log(this.weatherData)
            })
    }
}