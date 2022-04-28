using LeadScreen.Services.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeadScreen.Services.Contracts
{
    public interface ISubareaService
    {
        Task<List<SubareaDTO>> GetSubareasByPincode(string pincode);
    }
}
