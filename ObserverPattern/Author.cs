namespace ObserverPattern
{
    using Interfaces;
    using System.Collections.Generic;

    public class Author : ISubject
    {
        private List<IObserver> _observers { get; set; }

        private string BookName { get; set; }

        public Author() => this._observers = new List<IObserver>();
       
        public void Add(IObserver observer) => this._observers.Add(observer);

        public void Remove(IObserver observer) => this._observers.Remove(observer);

        public void Notify() => this._observers.ForEach(observer => observer.Update());

        public string GetState() => this.BookName;

        public string SetState(string newBookName) => this.BookName = newBookName;
    }
}

