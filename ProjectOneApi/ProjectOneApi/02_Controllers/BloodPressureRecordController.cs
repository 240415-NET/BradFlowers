using Microsoft.AspNetCore.Mvc;
using ProjectOneApi.Models;
using ProjectOneApi.Services;

namespace ProjectOneApi.Controllers
{
    [ApiController]
    public class BloodPressureRecordController : ControllerBase
    {
        private readonly IBloodPressureRecordService _bloodPressureRecordService;
        public BloodPressureRecordController(IBloodPressureRecordService bloodPressureRecordServiceFromBuilder)
        {
            _bloodPressureRecordService = bloodPressureRecordServiceFromBuilder;
        }

        [HttpPost("BloodPressureRecord")]
        public async Task<ActionResult<BloodPressureRecord>> PostBloodPressureRecord(BloodPressureRecord newBloodPressureRecord)
        {
            try
            {
                await _bloodPressureRecordService.CreateNewBloodPressureRecordInDBAsync(newBloodPressureRecord);
                return Ok(newBloodPressureRecord);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

