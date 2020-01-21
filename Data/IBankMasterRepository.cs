using System.Collections.Generic;
using System.Threading.Tasks;
using BankService.API.Models;

namespace BankService.API.Data
{
    public interface IBankMasterRepository
    {
         Task<BankMaster> CreateBankMaster(BankMaster bankMaster);
         BankMaster EditBankMaster(BankMaster bankMaster);
         void DeleteBankMaster(int bankMasterId);
         Task<IEnumerable<BankMaster>> GetAllBankMaster();
         Task<BankMaster> GetBankMasterById(int bankMasterId);
         
    }
}