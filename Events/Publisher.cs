using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class MessageEvents : EventArgs
    {
        public string Message { get; set; }
        public MessageEvents(string message)
        {
            Message = message;
        }
    }

    internal class Publisher
    {
        //public delegate void Message(object sender, EventArgs args);
        //public delegate void Message(object sender, MessageEvents message);

        public event EventHandler<MessageEvents> MessageSent;

        public void SendMessage(string text)
        {
            MessageSent?.Invoke(this, new MessageEvents(text));
        }
    }
}
