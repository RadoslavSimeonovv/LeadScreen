using LeadScreen.Services.DTOs;
using LeadScreen.Web.Models;

namespace LeadScreen.Web.Mappers
{
   internal static class LeadMapper
    {
        internal static LeadViewModel MapLeadToVM(this LeadDTO leadDTO)
        {
            var leadVM = new LeadViewModel();
            leadVM.Id = leadDTO.Id;
            leadVM.Name = leadDTO.Name;
            leadVM.MobileNumber = leadDTO.MobileNumber;
            leadVM.Address = leadDTO.Address;
            leadVM.Pincode = leadDTO.Pincode;
            leadVM.SubAreaId = leadDTO.SubAreaId;

            return leadVM;
        }

        internal static LeadDTO MapLeadVMToDTO(this LeadViewModel leadVM)
        {
            var leadDTO = new LeadDTO();
            leadDTO.Id = leadVM.Id;
            leadDTO.Name = leadVM.Name;
            leadDTO.MobileNumber = leadVM.MobileNumber;
            leadDTO.Address = leadVM.Address;
            leadDTO.Pincode = leadVM.Pincode;
            leadDTO.SubAreaId = leadVM.SubAreaId;

            return leadDTO;
        }
    }
}
