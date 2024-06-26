using Microsoft.AspNetCore.Mvc;
using ProjectOneApi.Models;
using ProjectOneApi.Services;

namespace ProjectOneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BloodPressureRecordController : ControllerBase
    {
        private readonly IBloodPressureRecordService _bloodPressureRecordService;
        public BloodPressureRecordController(IBloodPressureRecordService bloodPressureRecordServiceFromBuilder)
        {
            _bloodPressureRecordService = bloodPressureRecordServiceFromBuilder;
        }
    }
}
