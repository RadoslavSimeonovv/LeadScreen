﻿namespace LeadScreen.Web.Controllers
{
    using LeadScreen.Services.Contracts;
    using LeadScreen.Web.Mappers;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class SubareaController : ControllerBase
    {
        private readonly ISubareaService _subareaService;
        public SubareaController(ISubareaService subareaService)
        {
            this._subareaService = subareaService;
        }

        /// <summary>
        /// Fetch subareas by pincode
        /// http://localhost:5000/api/subarea/pincode
        /// </summary>
        /// <param name="pincode"></param>
        /// <returns>List of subareas</returns>

        [HttpGet]
        [Route("{pincode}")]
        public async Task<IActionResult> GetSubareasByPincode(string pincode)
        {
            var subareas = await this._subareaService.GetSubareasByPincode(pincode);

            var subareasVM = subareas
                .Select(s => s.MapSubareaToVM())
                .ToList();

            return Ok(subareasVM);
        }
    }
}
