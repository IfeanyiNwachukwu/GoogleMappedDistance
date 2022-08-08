﻿using GoogleMap.Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mapped.Api.Controllers
{
    [Route("[controller]")]
    [Route("[controller]/[action]")]
    [ApiController]
    public class MapInfoController : ControllerBase
    {
        private readonly GoogleDistanceApi _googleDistanceApi;
        public MapInfoController(GoogleDistanceApi googleDistanceApi)
        {
            _googleDistanceApi = googleDistanceApi;
        }

        [HttpGet]
        public async Task<GoogleDistanceData> GetDistance(string originCity, string destinationCity)
        {
            return await _googleDistanceApi.GetMapDistance(originCity, destinationCity);
        }
    }
}
