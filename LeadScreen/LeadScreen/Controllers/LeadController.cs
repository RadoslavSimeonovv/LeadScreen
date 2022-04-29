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
        private readonly IWriteIntoJsonService _writeIntoJsonService;
        public LeadController(ILeadService leadService, IWriteIntoJsonService writeIntoJsonService)
        {
            this._leadService = leadService;
            this._writeIntoJsonService = writeIntoJsonService;
        }

        /// <summary>
        ///  Fetch a lead by id 
        /// http://localhost:5000/api/lead/id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Found lead or exception that it doesnt exist</returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetLeadById(int id)
        {
            var lead = await this._leadService.GetLeadById(id);

            if(lead == null)
            {
                throw new ArgumentNullException("Lead does not exist");
            }

            var leadVM = lead.MapLeadToVM();

            return Ok(leadVM);
        }

        /// <summary>
        /// Create lead
        /// Can be created in the MSSQL db or in a local json storage file
        /// http://localhost:5000/api/lead
        /// </summary>
        /// <param name=leadVM></param>
        /// <returns>Created lead</returns>
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateLead([FromBody] LeadViewModel leadVM)
        {
            try
            {
                var leadDTO = leadVM.MapLeadVMToDTO();
                
                // use for local json storage
                var fileName = "leads.json";
                this._writeIntoJsonService.Write(leadDTO, fileName);
                
                // use for MSSQL db
                var lead = await _leadService.CreateLead(leadDTO);

                return Created("Post", leadDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
