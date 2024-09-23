using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZellburyStoreApplication.Data;

namespace ZellburyStoreApplication.Contracts
{
    public interface IPurchaseRecordRepository : IRepositoryBase<PurchaseRecord>
    {

        ICollection<PurchaseRecord> GetProductByCustomer(String Customerid);

    }
}
