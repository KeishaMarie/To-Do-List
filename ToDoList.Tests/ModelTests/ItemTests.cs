using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

    // Test Methods will go here
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      // ARRANGE
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      // ACT
      string result = newItem.Description;
      // ASSERT
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      // ARRANGE
      string description = "Walk the dog";
      Item newItem = new Item(description);
      // ACT
      string updatedDescription = "Do the dishes";
      newItem.Description = updatedDescription;
      string result = newItem.Description;
      //ASSERT
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // ARRANGE
      List<Item> newList = new List<Item> { };
      // ACT
      List<Item> result = Item.GetAll();
      // ASSERT
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      // ARRANGE
      string description = "Walk the dog";
      Item newItem = new Item(description);
      // ACT
      int result = newItem.Id;
      // ASSERT
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
    // Arrange
    string description01 = "Walk the dog";
    string description02 = "Wash the dishes";
    Item newItem1 = new Item(description01);
    Item newItem2 = new Item(description02);
    // ACT
    Item result = Item.Find(2);
    // ASSERT
    Assert.AreEqual(newItem2, result);
    }
  }
}