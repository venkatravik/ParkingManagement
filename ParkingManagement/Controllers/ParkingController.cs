using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ParkingManagement.Interfaces;
using System;
using System.Threading.Tasks;
using Dapper;

namespace ParkingManagement.Controllers
{


    [ApiController]
    [Route("parking")]
    public class ParkingController : ControllerBase
    {
        private readonly IParkingService _parkingService;

        private readonly ParkingManegmentContext _parkingManegmentContext;

        public ParkingController(ParkingManegmentContext parkingManegmentContext)
        {
            _parkingManegmentContext = parkingManegmentContext;
        }

        [HttpGet("{Date}")]
        public async Task<ActionResult> Get([FromRoute] string date)
        {
            var datime = Convert.ToDateTime(date);
            var List = await _parkingManegmentContext.Parkings.FirstOrDefaultAsync(m => m.Date == datime);
            if (List == null && List.BookedSlots <= 0)
            {
                return null;
            }

            return Ok(List);
        }

        [HttpGet("{FromDate/ToDate}")]
        public async Task<ActionResult> GetbyDates([FromQuery] DateTime fromdate, DateTime toddate)
        {

            string query = "select * from  Cars c inner join Parking p on c.Pid = p.PID where c.Fromdate = @fromdate and c.Todate = @todate";
            using (var connection = new SqlConnection("Server=.;Database=ParkingManegment;Trusted_Connection=True;"))
            {
                return await connection.QueryFirstAsync(query);
            }
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Models.Parking parking)
        {

            Infrastracture.Entities.Parking parkingTable = new Infrastracture.Entities.Parking();
            parkingTable.Pid = Guid.NewGuid();
            parkingTable.Date = parking.Fromdate;
            parkingTable.NumberOfslots = 10 - parking.noOfSlots;
            parkingTable.BookedSlots = parkingTable.NumberOfslots;
            parkingTable.Cars.Add(new Infrastracture.Entities.Car()
            {
                Cid = Guid.NewGuid(),
                CarNumber = parking.CarNumber,
                Fromdate = DateTime.UtcNow,
                Todate = DateTime.UtcNow,
                Pid = parkingTable.Pid

            });

            try
            {
                var result = _parkingManegmentContext.Add(parkingTable);
                await _parkingManegmentContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
