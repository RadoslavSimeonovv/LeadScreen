namespace LeadScreen.Services
{
    using LeadScreen.Data;
    using LeadScreen.Services.Contracts;
    using LeadScreen.Services.DTOs;
    using LeadScreen.Services.Mappers;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class SubareaService : ISubareaService
    {
        private readonly LeadScreenContext _leadScreenContext;
        public SubareaService(LeadScreenContext leadScreenContext)
        {
            this._leadScreenContext = leadScreenContext;
        }

        /*
        * Fetch subareas by pincode
        */
        public async Task<List<SubareaDTO>> GetSubareasByPincode(string pincode)
        {
            var subareas = await this._leadScreenContext.Subarea
                .Where(x => x.Pincode == pincode)
                .ToListAsync();

            if (subareas.Count == 0)
            {
                throw new ArgumentNullException("No subareas found!");
            }

            var subareasDTO = subareas
                .Select(x => SubareaMapper.MapSubareaToDTO(x))
                .ToList();

            return subareasDTO;
        }

    }
}
