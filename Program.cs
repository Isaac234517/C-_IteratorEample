using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Message> msgs = new List<Message>();
            msgs.Add(new Message("Tom", "Susan", "Hello"));
            msgs.Add(new Message("Micky", "Mary", "HI"));
            msgs.Add(new Message("Daenerys", "Jon", "您好"));
            msgs.Add(new Message("Vincent", "Cherry", "Good morning"));
            MessageBox msBox = new MessageBox(msgs);
            foreach(Message msg in msBox)
            {
                Console.WriteLine(msg.ToString());
            }
            Console.Read();
        }
    }
}
