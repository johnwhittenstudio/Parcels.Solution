using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelController : Controller
  {

    [HttpGet("/parcel")]
    public ActionResult Index()
    {
      List<Parcel> allItems = Parcel.GetAll();
      return View(allItems);
    }

    [HttpGet("/parcel/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcel")]
    public ActionResult Create(double weight, int height, int width, int length, int distance)
    {
      int[] dimensions = {length,height,width};
      Parcel myParcel = new Parcel(weight,dimensions,distance);
      return RedirectToAction("Index");
    }

  }
}