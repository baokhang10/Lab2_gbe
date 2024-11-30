using lab2.data;
using lab2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        
        private readonly ApplicationDbContext _context;
        public GameController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Gamelevel> gameLevels = _context.Gamelevels.ToList();
            return View(gameLevels);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Gamelevel gameLevel)
        {
            if (ModelState.IsValid)
            {
                _context.Gamelevels.Add(gameLevel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameLevel);
        }
        public IActionResult Edit(int id)
        {
            var gameLevel = _context.Gamelevels.Find(id);
            return View(gameLevel);
        }
        [HttpPost]
        public IActionResult Edit(Gamelevel gameLevel)
        {
            if (ModelState.IsValid)
            {
                _context.Gamelevels.Update(gameLevel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameLevel);
        }
        public IActionResult Delete(int id)
        {
            var gameLevel = _context.Gamelevels.Find(id);
            _context.Gamelevels.Remove(gameLevel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var gameLevel = _context.Gamelevels.Find(id);
            ViewBag.GameLevelTitle = gameLevel.title;
            ViewBag.GameLevelId = gameLevel.LevelId;
            var quesstion = _context.Questions.Where(q => q.levelId == id).ToList();
            return View(quesstion);
        }
        public IActionResult CreateQuestion(int levelid)
        {
            Question question = new()
            {
                levelId = levelid

            };
            return View(question);
        }
        [HttpPost]
        public IActionResult CreateQuestion(Question question)
        {
            if (ModelState.IsValid)
            {
                _context.Questions.Add(question);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = question.levelId });
            }
            return View(question);
        }
        public IActionResult EditQuestion(int QuestionId)
        {
            var question = _context.Questions.Find(QuestionId);
            return View(question);
        }


        [HttpPost]
        public IActionResult EditQuestion(Question question)
        {
            if (ModelState.IsValid)
            {
                _context.Questions.Update(question);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = question.levelId });
            }
            return View(question);
        }
        public IActionResult DeleteQuestion(int QuestionId)
        {
            var question = _context.Questions.Find(QuestionId);
            _context.Questions.Remove(question);
            _context.SaveChanges();
            return RedirectToAction("Details", new { id = question.levelId });
        }
    }
}
