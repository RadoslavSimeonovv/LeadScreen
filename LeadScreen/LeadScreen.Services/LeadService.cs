namespace LeadScreen.Services
{
    using LeadScreen.Data;
    using LeadScreen.Services.Contracts;
    using LeadScreen.Services.DTOs;
    using LeadScreen.Services.Mappers;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Lead service
    /// </summary>
    public class LeadService : ILeadService
    {
        private readonly LeadScreenContext _leadScreenContext;
        public LeadService(LeadScreenContext leadScreenContext)
        {
            this._leadScreenContext = leadScreenContext;
        }

        /*
         * Fetch lead by id
         */
        public async Task<LeadDTO> GetLeadById(int id)
        {
            var lead = await this._leadScreenContext.Lead.FindAsync(id);

            if (lead == null)
            {
                throw new ArgumentNullException("Lead doesn't exist!");
            }

            var leadDTO = lead.MapLeadToDTO();

            return leadDTO;
        }

        /*
         * Create lead method
         */
        public async Task<LeadDTO> CreateLead(LeadDTO leadDTO)
        {
            if (leadDTO == null)
            {
                throw new ArgumentNullException("Lead doesn't exist!");
            }

            var lead = leadDTO.MapDTOToLead();

            await _leadScreenContext.Lead.AddAsync(lead);
            await _leadScreenContext.SaveChangesAsync();

            return leadDTO;
        }


    }
}
