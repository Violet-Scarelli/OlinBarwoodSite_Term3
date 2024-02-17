using OlinBarwoodSite_Term3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlinBarwoodSite_Term3.Data
{
    public interface IMessageRepository
    {
        IQueryable<Message> Messages { get; }
        int AddMessage(Message message);
        Message RetrieveMessageByID(int id);
    }
}
