using LeadScreen.Data.Entities;
using LeadScreen.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeadScreen.Services.Mappers
{
    internal static class SubareaMapper
    {
        internal static SubareaDTO MapSubareaToDTO(this Subarea subarea)
        {
            var subareaDTO = new SubareaDTO();
            subareaDTO.Id = subarea.Id;
            subareaDTO.Name = subarea.Name;
            subareaDTO.Pincode = subarea.Pincode;
            subareaDTO.Leads = subarea.Leads
                .Select(x => LeadMapper.MapLeadToDTO(x))
                .ToList();
                
            return subareaDTO;
        }

        internal static Subarea MapDTOToSubarea(this SubareaDTO subareaDTO)
        {
            var subarea = new Subarea();
            subarea.Id = subareaDTO.Id;
            subarea.Name = subareaDTO.Name;
            subarea.Pincode = subareaDTO.Pincode;

            return subarea;
        }
    }
}
