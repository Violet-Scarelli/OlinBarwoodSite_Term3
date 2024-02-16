using OlinBarwoodSite_Term3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlinBarwoodSite_Term2.Repos
{
    public class FakeMessageRepository
    {
        List<Message> messages = new List<Message>();

        public IQueryable<Message> Messages
        {
            get { return messages.AsQueryable(); }
        }

        public void AddMessage(Message message)
        {
            message.MessageID = messages.Count;
            messages.Add(message); 
        }

        public Message RetrieveMessageById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
