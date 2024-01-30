using Microsoft.EntityFrameworkCore;
using OlinBarwoodSite_Term2.Models;

namespace OlinBarwoodSite_Term2.Data;

public class MessageRepository : IMessageRepository
{
    private AppDbContext context;

    public MessageRepository(AppDbContext DbContext)
    {
        context = DbContext;
    }

    public IQueryable<Message> Messages
    {
        get
        {
            return context.Messages;
        }
    }

    public Message RetrieveMessageByID(int ID)
    {
        var score = context.Messages
            .Where(score => score.MessageID == ID)
            .SingleOrDefault();
        return score;
    }

    public void AddMessage(Message model)
    {
        model.SendDate = DateTime.Now;
        context.Messages.Add(model);
        context.SaveChanges();
    }
}
