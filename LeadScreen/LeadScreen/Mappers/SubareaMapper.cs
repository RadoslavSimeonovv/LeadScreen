using LeadScreen.Services.DTOs;
using LeadScreen.Web.Models;

namespace LeadScreen.Web.Mappers
{
    internal static class SubareaMapper
    {
        internal static SubareaViewModel MapSubareaToVM(this SubareaDTO subareaDTO)
        {
            var subareaVM = new SubareaViewModel();
            subareaVM.Id = subareaDTO.Id;
            subareaVM.Name = subareaDTO.Name;
            subareaVM.Pincode = subareaDTO.Pincode;

            return subareaVM;
        }

        internal static SubareaDTO MapSubareaVMToDTO(this SubareaViewModel subareaVM)
        {
            var subareaDTO = new SubareaDTO();
            subareaDTO.Id = subareaVM.Id;
            subareaDTO.Name = subareaVM.Name;
            subareaDTO.Pincode = subareaVM.Pincode;

            return subareaDTO;
        }
    }
}
