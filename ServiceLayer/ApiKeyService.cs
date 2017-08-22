﻿using PlaceFeeds.ServiceLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceFeeds.ServiceLayer
{
    public class ApiKeyService: IApiKeyService
    {
        private static List<ApiKey> apiKeys = new List<ApiKey> {
           new ApiKey { Type = ApiType.Location, Key = "GoogleKey", Secret = "GoogleSecret"},
           new ApiKey { Type = ApiType.Weather, Key = "OpenWeatherKey"},
           new ApiKey { Type = ApiType.Image, Key = "FlickrKey"},
           new ApiKey { Type = ApiType.Twitter, Key = "TwitterKey", Secret = "TwitterSecret"}
        };

        public string GetApiKey(ApiType apiType)
        {
            var key = (apiKeys.FirstOrDefault(a => a.Type == apiType)).Key;
            return key;
        }

        public string GetApiSecret(ApiType apiType)
        {
            return (apiKeys.FirstOrDefault(a => a.Type == apiType)).Secret;
        }
    
    }

    public class ApiKey
    {
        public ApiType Type { get; set; }
        public string Key { get; set; }
        public string Secret { get; set; }
    }
}

