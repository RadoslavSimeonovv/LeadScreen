using LeadScreen.Services.DTOs;
using System.Threading.Tasks;

namespace LeadScreen.Services.Contracts
{
    public interface ILeadService
    {
        Task<LeadDTO> GetLeadById(int id);
        Task<LeadDTO> CreateLead(LeadDTO leadDTO);
    }
}
