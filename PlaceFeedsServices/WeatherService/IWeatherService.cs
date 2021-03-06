﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaceFeedsServices.WeatherService
{
    public interface IWeatherService
    {
        Task<string> GetWeatherData(double latitude, double longitude);
    }
}
