using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox_Console_App.DemoFiles
{
    public class EventDemo
    {
        /// Events in C# are a way for a class to provide notifications to clients of that class when something of interest happens.
        /// This is done using delegates and event handlers.
        /// 
        /// Here's a simple example:
        /// 1. Define a delegate.
        /// 2. Define an event based on that delegate.
        /// 3. Raise the event at the appropriate time. 

        public EventDemo()
        {
            ShowEventResults();
            Console.WriteLine("EventDemo class instantiated. Ready to raise events.");
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string TypeDescription { get; set; }
        public string TypeName { get; set; }
        public string TypeDescriptionDescription { get; set; } = string.Empty;
        public string TypeNameDescription { get; set; } = string.Empty;

        // Define a delegate that represents the method signature for the event handler
        public delegate void EventHandler(string message);
        public event EventHandler<EventArgs> EventReceived;
        public event EventHandler<EventArgs> EventSent;
        public event EventHandler<EventArgs> EventCancelled;
        public event EventHandler<EventArgs> EventCompleted;
        public event EventHandler<EventArgs> EventError;

        // Method to raise the event
        public void RaiseEvent(string message)
        {
            EventReceived?.Invoke(this, EventArgs.Empty);
        }

        // show results of the event
        public void ShowEventResults()
        {
            EventReceived += (sender, e) => Console.WriteLine("Event Received");
            EventSent += (sender, e) => Console.WriteLine("Event Sent");
            EventCancelled += (sender, e) => Console.WriteLine("Event Cancelled");
            EventCompleted += (sender, e) => Console.WriteLine("Event Completed");
            EventError += (sender, e) => Console.WriteLine("Event Error");

            //This is usually where you would trigger the event based on some condition or action in your application.
            //For demonstration purposes, we will just trigger the EventReceived event here.
            EventReceived?.Invoke(this, EventArgs.Empty);                
        }

    }
}
