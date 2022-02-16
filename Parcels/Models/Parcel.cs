using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public double Weight { get; set; }
    public int Distance { get; set; }
    public int[] Dimensions { get; set; }
    public int Volume { get; set; }
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel(double weight, int[] dimensions, int distance)
    {
      Weight = weight;
      Distance = distance;
      Dimensions = dimensions;
      Volume = Dimensions[0]*Dimensions[1]*Dimensions[2];
      _instances.Add(this);
    }

    public double CostToShip()
    {
      return (Weight * Volume * Distance) / 100000;
    }



    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
