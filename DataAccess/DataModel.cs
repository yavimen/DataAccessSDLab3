using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess
{
    public class DataModel
    {
        public MedicalHistoriesContext _dbContext;
        public IEnumerable<History> Histories { get; set; }
        public DataModel()
        {

        }
        public DataModel(MedicalHistoriesContext dbContext)
        {
            _dbContext = dbContext;
            Histories = dbContext.Histories;
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
