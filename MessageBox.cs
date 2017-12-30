using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    public class Message
    {
        public string sender;
        public string receiver;
        public string content;
        public bool sent;
        public Message(string sender, string receiver, string content) {
            this.sender = sender;
            this.receiver = receiver;
            this.content = content;
        }

        public override string ToString()
        {
            return string.Format("{0} give {1} a message. Content is {2}.  {3}", 
                this.sender, this.receiver, this.content, (this.sent ? "It sent":"It has not sent yet"));
        }
    }
    public class MessageBox:IEnumerable
    {
        public List<Message> messages;
        public MessageBox() { }
        public MessageBox(List<Message> msgs)
        {
            this.messages = msgs;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Message msg in messages)
            {
                Console.WriteLine("Before Yield");
                yield return msg;
                Console.WriteLine("After Yield");
            }
        }
    }
}
