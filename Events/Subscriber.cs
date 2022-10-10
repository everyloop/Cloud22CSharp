using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Subscriber
    {
        private string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void OnMessageRecieved(object sender, MessageEvents args)
        {
            Console.WriteLine($"{name} got the message: {args.Message}");
        }
    }
}
