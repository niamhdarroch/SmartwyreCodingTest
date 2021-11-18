using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartwyre.DeveloperTest.Types;

namespace Smartwyre.DeveloperTest.Data
{
    /// <summary>
    /// Account Data Store interface
    /// </summary>
    public interface IAccountDataStore
    {
        Account GetAccount(string accountNumber);

        void UpdateAccount(Account account);
    }
}
