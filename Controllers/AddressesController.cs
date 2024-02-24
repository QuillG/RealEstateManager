using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateManager.Dao.SqlServer.Models;

namespace RealEstateManager.Controllers
{

    [ApiController]
    [Route("Addresses")]
    public class AddressesController :BaseContoller
    {
        public AddressesController(IConfiguration configuration) : base(configuration)
        {
        }

        // GET: AddressesController
        [HttpGet]
        public IEnumerable<Address> GetAll()
        {
            using var context = this.GetContext();
            return context.Addresses.ToArray();
        }
        [HttpGet("{id}")]
        public Address? GetById(int id)
        {
            using var context = this.GetContext();
            return context.Addresses.FirstOrDefault(x => x.Id.Equals(id));
        }

        //POST: AddressesController
        [HttpPost]
        public Address Create(Address address)
        {
            using var context = this.GetContext();
            context.Addresses.Add(address);
            context.SaveChanges();
            return address;
        }

        //// POST: AddressesController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: AddressesController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: AddressesController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: AddressesController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: AddressesController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
