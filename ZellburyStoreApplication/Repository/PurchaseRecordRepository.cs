using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZellburyStoreApplication.Contracts;
using ZellburyStoreApplication.Data;

namespace ZellburyStoreApplication.Repository
{
    public class PurchaseRecordRepository : IPurchaseRecordRepository
    {

        private readonly ApplicationDbContext _db;

        public PurchaseRecordRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(PurchaseRecord entity)
        {
            _db.purchaseRecords.Add(entity);
            return Save();
        }

        public bool Delete(PurchaseRecord entity)
        {
            _db.purchaseRecords.Remove(entity);
            return Save();
        }

        public ICollection<PurchaseRecord> FindAll()
        {
            var records = _db.purchaseRecords.ToList();
            return records;
        }

        public PurchaseRecord FindById(int id)
        {
            var record = _db.purchaseRecords.Find(id);
            return record;
        }

        public bool isExist(int id)
        {
            var exists = _db.purchaseRecords.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(PurchaseRecord entity)
        {
            _db.purchaseRecords.Update(entity);
            return Save();
        }
    }
}
