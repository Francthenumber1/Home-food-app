using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFood._588286
{
    public class Message
    {
        public string AuthorName { get; set; }
        public string MessageText { get; set; }

        public Message(string authorName, string messageText)
        {
            AuthorName = authorName;
            MessageText = messageText;
        }
    }

}
