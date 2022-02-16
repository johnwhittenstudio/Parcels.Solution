using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;

namespace Parcels.Tests
{
  [TestClass]
  public class ParcelsTests
  {
    [TestMethod]
    public void ParcelConstructor_CreateInstanceOfParcel_Parcel()
    {
      //Arrange
      double weight = 5;
      int[] dimensions = {12,12,12};
      int distance = 100;
      //Act
      Parcel myParcel = new Parcel(weight,dimensions,distance);
      //Assert
      Assert.AreEqual(typeof(Parcel),myParcel.GetType());
    }

    [TestMethod]
    public void ParcelConstructor_AssignWeight_5()
    {
      //Arrange
      double weight = 5;
      int[] dimensions = {12,12,12};
      int distance = 100;
      //Act
      Parcel myParcel = new Parcel(weight,dimensions,distance);
      //Assert
      Assert.AreEqual(myParcel.Weight,5);
    }

    [TestMethod]
    public void ParcelConstructor_CalculateShipping_864()
    {
      //Arrange
      double weight = 5;
      int[] dimensions = {12,12,12};
      int distance = 100;
      //Act
      Parcel myParcel = new Parcel(weight,dimensions,distance);
      //Assert
      Assert.AreEqual(myParcel.CostToShip(),8.64);
    }

  }
}