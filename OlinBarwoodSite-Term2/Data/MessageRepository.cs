using Microsoft.EntityFrameworkCore;
using OlinBarwoodSite_Term3.Models;

namespace OlinBarwoodSite_Term3.Data;

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
            return context.Messages
                .Include(message => message.Sender)
                .Include(message => message.Recipient)
                .Include(message => message.Subject)
                .Include(message => message.MsgBody);
        }
    }

    public Message RetrieveMessageByID(int ID)
    {
        var message = context.Messages
            .Include(message => message.Sender)
            .Include(message => message.Recipient)
            .Include(message => message.Subject)
            .Include(message => message.MsgBody)
            .Where(message => message.MessageID == ID)
            .SingleOrDefault();
        return message;
    }

    public int AddMessage(Message model)
    {
        model.SendDate = DateTime.Now;
        context.Messages.Add(model);
        return context.SaveChanges();
    }
}
