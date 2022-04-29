using LeadScreen.Services.DTOs;
using LeadScreen.Web.Models;

namespace LeadScreen.Web.Mappers
{
    /// <summary>
    /// Subarea view model and dto mapper
    /// </summary>
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
    }
}
