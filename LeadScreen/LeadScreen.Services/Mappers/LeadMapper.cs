using LeadScreen.Data.Entities;
using LeadScreen.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeadScreen.Services.Mappers
{
    internal static class LeadMapper
    {
        internal static LeadDTO MapLeadToDTO(this Lead lead)
        {
            var leadDTO = new LeadDTO();
            leadDTO.Id = lead.Id;
            leadDTO.Name = lead.Name;
            leadDTO.Pincode = lead.Pincode;
            leadDTO.Email = lead.Email; 
            leadDTO.SubAreaId = lead.SubAreaId;
            leadDTO.Address = lead.Address;
            leadDTO.MobileNumber = lead.MobileNumber;

            return leadDTO;
        }

        internal static Lead MapDTOToLead(this LeadDTO leadDTO)
        {
            var lead = new Lead();
            lead.Id = leadDTO.Id;
            lead.Name = leadDTO.Name;
            lead.Pincode = leadDTO.Pincode;
            lead.Email = leadDTO.Email;
            lead.SubAreaId = leadDTO.SubAreaId;
            lead.Address = leadDTO.Address;
            lead.MobileNumber = leadDTO.MobileNumber;

            return lead;
        }
    }
}
