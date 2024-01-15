using OlinBarwoodSite_Term2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlinBarwoodSite_Term2.Data
{
    public interface IMessageRepository
    {
        IQueryable<Message> Messages { get; }
        void AddMessage(Message message);
        Message RetrieveMessageByID(int id);
    }
}
