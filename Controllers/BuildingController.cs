using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateManager.Dao.SqlServer.Models;

namespace RealEstateManager.Controllers
{
    [ApiController]
    [Route("Building")]
    public class BuildingController : BaseContoller
    {
        public BuildingController(IConfiguration configuration) : base(configuration)
        {
        }
        //// GET: AddressesController
        //[HttpGet("{id}")]
        //public Building GetByID(int id)
        //{
        //    using var context = this.GetContext();
        //    var result = context.Buildings
        //        .Include(x => x.Address)
        //        .Include(x => x.Apartements)
        //        .ThenInclude(x => x.Tenants)
        //        .FirstOrDefault(x => x.Id.Equals(id));

        //    return result;

        //}
    }
}
