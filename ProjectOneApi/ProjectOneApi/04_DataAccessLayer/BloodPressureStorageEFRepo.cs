using Microsoft.EntityFrameworkCore;
using ProjectOneApi.Models;

namespace ProjectOneApi.DataAccessLayer
{
    public class BloodPressureStorageEFRepo : IBloodPressureRecordStorageEFRepo
    {
        private readonly ProjectOneApiContext _context;
        public BloodPressureStorageEFRepo(ProjectOneApiContext contextFromBuilder)
        {
            _context = contextFromBuilder;
        }
    }
}