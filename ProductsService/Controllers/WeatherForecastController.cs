﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace ProductsService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var rng = new Random();
            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Post(WeatherForecast forecastToCreate)
        {
            forecastToCreate.Date = DateTime.Now;
            return  Created("/5",forecastToCreate) ;
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, WeatherForecast weatherForecast)
        {
            if (id == 5)
            {
                return Ok(weatherForecast);
            }

            return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(new WeatherForecast());
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(id);
        }
    }
}