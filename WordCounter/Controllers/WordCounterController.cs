using Microsoft.AspNetCore.Mvc;
using WordCounter;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      return View("Index");
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult NewPost(string phrase, string word, int counter)
    {
      RepeatCounter myRepeatCounter = new RepeatCounter(phrase, word, counter);
      return View("Index", myRepeatCounter );
    }
  }
}
