using System.Collections.Generic;
using System.Diagnostics;

namespace OOPS.Console.Patterns.Observer
{
    // The subject interface that defines methods for attaching, detaching, and notifying observers.

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

// The subject class that maintains a list of observers and sends notifications to them.
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Notify(); // Notify observers when the state changes
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(state); // Pass the updated state to each observer
            }
        }
    }

// The observer interface that defines the update method.
    public interface IObserver
    {
        void Update(string state);
    }

// The concrete observer class that implements the update method.
    public class ConcreteObserver : IObserver
    {
        private string name;

        public ConcreteObserver(string name)
        {
            this.name = name;
        }

        public void Update(string state)
        {
            Debug.WriteLine("Observer {0} received update. New state: {1}", name, state);
        }
    }
}
