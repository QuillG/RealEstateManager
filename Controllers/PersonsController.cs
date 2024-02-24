using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateManager.Dao.SqlServer.Models;

namespace RealEstateManager.Controllers
{
    public class PersonsController : BaseContoller
    {
        public PersonsController(IConfiguration configuration) : base(configuration)
        {
        }

        //public Person? GetById(int id)
        //{
        //    using var context = this.GetContext();
        //    var query =  context.People
        //        .FirstOrDefault(x => x.Id.Equals(id));
        //}
    }
}
