namespace LeadScreen.Web.Controllers
{
    using LeadScreen.Services.Contracts;
    using LeadScreen.Web.Mappers;
    using LeadScreen.Web.Models;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        private readonly ILeadService _leadService;
        public LeadController(ILeadService leadService)
        {
            this._leadService = leadService;
        }

        /*
       * Create a new lead  
       * by using the appropriate service method
       * http://localhost:5000/api/lead/ - request URL
       */
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateLead([FromBody] LeadViewModel leadVM)
        {
            try
            {
                var leadDTO = leadVM.MapLeadVMToDTO();
                var lead = await _leadService.CreateLead(leadDTO);

                return Created("Post", lead);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
