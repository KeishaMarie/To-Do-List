using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTests : IDisposable
  {
    public void Dispose()
    {
      Category.ClearAll();
    }

    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      Category newCategory = new Category("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      // ARRANGE
      string name = "Test Category";
      Category newCategory = new Category(name);
      // ACT
      string result = newCategory.Name;
      // ASSERT
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
    //Arrange
    string name = "Test Category";
    Category newCategory = new Category(name);
    //Act
    int result = newCategory.Id;
    //Assert
    Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllCategoryObjects_CategoryList()
    {
      // ARRANGE
      string name01 = "Work";
      string name02 = "School";
      Category newCategory1 = new Category(name01);
      Category newCategory2 = new Category(name02);
      List<Category> newList = new List<Category> {newCategory1, newCategory2};
      // ACT
      List<Category> result = Category.GetAll();
      //ASSERT
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectCategory_Category()
    {
    //Arrange
    string name01 = "Work";
    string name02 = "School";
    Category newCategory1 = new Category(name01);
    Category newCategory2 = new Category(name02);
    //ACT
    Category result = Category.Find(2);
    //ASSERT
    Assert.AreEqual(newCategory2, result);
     }

     [TestMethod]
     public void AddItem_AssociatesItemWithCategory_ItemList()
     {
      //ARRANGE
      string description = "Walk the dog";
      Item newItem = new Item(description);
      List<Item> newList = new List<Item> { newItem };
      string name = "Work";
      Category newCategory = new Category(name);
      newCategory.AddItem(newItem);
      //ACT
      List<Item> result = newCategory.Items;
      //ASSERT
      CollectionAssert.AreEqual(newList, result);
     }
  }
}