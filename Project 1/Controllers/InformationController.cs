﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_1.Services;

namespace Project_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        private readonly IInformationServices _informationServices;

        public InformationController(IInformationServices informationServices)
        {
            _informationServices = informationServices;
        }
        [HttpPut("id")]
        public async Task<IActionResult> UpdateAsync(string name)
        {
            var information = await _informationServices.GetById(name); 
            if (information == null)
                return NotFound("No genre was found ");
            _informationServices.update(information);
            return Ok(information);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync(string name)
        {
            var information = await _informationServices.GetById(name);
            if (information == null)
                return NotFound("No information was found" );
            _informationServices.Delete(information);
            return Ok(information);
        }
    }
}
