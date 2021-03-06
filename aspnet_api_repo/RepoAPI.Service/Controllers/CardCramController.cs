﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepoAPI.Service.Models;
using Newtonsoft.Json;


namespace RepoAPI.Service.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CardCramController : ControllerBase
  {
    private string apiUrl = "https://localhost:5441/api";
    private HttpClient _http = new HttpClient();

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var response = await _http.GetAsync(apiUrl);

      if (response.IsSuccessStatusCode)
      {
        var content = JsonConvert.DeserializeObject<CardCramModel>(await response.Content.ReadAsStringAsync());

        return Ok(content);

      }

      return NotFound();
    }
  }
}