using System.Collections.Generic;
using System.Threading.Tasks;
using BankService.API.Models;

namespace BankService.API.Data
{
    public interface IBankLedgerRepository
    {
         Task<BankLedger> CreateBankLedger(BankLedger bankLedger);
         BankLedger EditBankLedger(BankLedger bankLedger);
         void DeleteBankLedger(int bankLedgerId);
         Task<IEnumerable<BankLedger>> GetAllBankLedger();
         Task<BankLedger> GetBankLedgerById(int bankLedgerId);         
    }
}