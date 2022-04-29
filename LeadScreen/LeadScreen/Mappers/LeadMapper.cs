using LeadScreen.Services.DTOs;
using LeadScreen.Web.Models;

namespace LeadScreen.Web.Mappers
{
    /// <summary>
    /// Lead view model and dto mappers
    /// </summary>
   internal static class LeadMapper
    {
        internal static LeadViewModel MapLeadToVM(this LeadDTO leadDTO)
        {
            var leadVM = new LeadViewModel();
            leadVM.Id = leadDTO.Id;
            leadVM.Name = leadDTO.Name;
            leadVM.MobileNumber = leadDTO.MobileNumber;
            leadVM.Email = leadDTO.Email;
            leadVM.Address = leadDTO.Address;
            leadVM.Pincode = leadDTO.Pincode;
            leadVM.SubAreaId = leadDTO.SubAreaId;

            return leadVM;
        }

        internal static LeadDTO MapLeadVMToDTO(this LeadViewModel leadVM)
        {
            var leadDTO = new LeadDTO();
            leadDTO.Name = leadVM.Name;
            leadDTO.MobileNumber = leadVM.MobileNumber;
            leadDTO.Address = leadVM.Address;
            leadDTO.Email = leadVM.Email;
            leadDTO.Pincode = leadVM.Pincode;
            leadDTO.SubAreaId = leadVM.SubAreaId;

            return leadDTO;
        }
    }
}
