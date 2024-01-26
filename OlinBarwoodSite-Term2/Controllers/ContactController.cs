using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OlinBarwoodSite_Term2.Models;
using OlinBarwoodSite_Term2.Data;
using System;
using System.Linq;

namespace OlinBarwoodSite_Term2.Controllers
{
    public class ContactController : Controller
    {
        AppDbContext context;
        IMessageRepository repo;
        public ContactController(AppDbContext c, IMessageRepository m)
        {
            context = c;
            repo = m;
        }
        public IActionResult Index(int Id)
        {
            var message = context.Messages
                .Where(message => message.MessageID == Id)
                .SingleOrDefault();
            return View(message);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Message model)
        {
            model.SendDate = DateTime.Now;
            context.Messages.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index", new {Id = model.MessageID});
        }
    }
}
