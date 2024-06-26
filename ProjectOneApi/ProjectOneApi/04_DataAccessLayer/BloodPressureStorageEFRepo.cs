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
        public async Task<BloodPressureRecord?> CreateNewBloodPressureRecordInDBAsync(BloodPressureRecord newBloodPressureRecordSentFromService)


        {
            _context.BloodPressureRecords.Add(newBloodPressureRecordSentFromService);
            await _context.SaveChangesAsync();
            return newBloodPressureRecordSentFromService;
        }


    }
}
