using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {
    [TestMethod]
    public void Index_ReturnAccurateView_True()
    {
			WordCounterController controller = new WordCounterController();
      ActionResult indexView = controller.Index();
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
		}

    [TestMethod]
    public void New_ReturnAccurateView_True()
    {
			WordCounterController controller = new WordCounterController();
      ActionResult indexNew = controller.New();
      Assert.IsInstanceOfType(indexNew, typeof(ViewResult));
		}

    [TestMethod]
    public void Action_ReturnAccurateAction_RedirectToActionResult()
    {
		  WordCounterController controller = new WordCounterController();
      IActionResult view = controller.Action("I have three types of bananas", "bananas");
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Action_RedirectToAccurateAction_Index()
    {
      WordCounterController controller = new WordCounterController();
      RedirectToActionResult actionResult = controller.Action("I have three types of bananas", "bananas") as RedirectToActionResult;
      string counter = actionResult.ActionName;
      Assert.AreEqual(counter, "Index");
    }
  }
}
