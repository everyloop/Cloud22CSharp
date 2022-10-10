using Events;

Publisher publisher = new Publisher();
Subscriber sub1 = new Subscriber("Fredrik");
Subscriber sub2 = new Subscriber("Anna");
Subscriber sub3 = new Subscriber("Erik");

publisher.MessageSent += sub1.OnMessageRecieved;
publisher.MessageSent += sub2.OnMessageRecieved;
publisher.MessageSent += sub3.OnMessageRecieved;

publisher.SendMessage("Hello world!");
Console.WriteLine();
publisher.SendMessage("Hello again!");


//Console.WriteLine();
//publisher.SendMessage();