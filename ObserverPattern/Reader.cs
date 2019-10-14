namespace ObserverPattern
{
    using Interfaces;
    using System;

    public class Reader : IObserver
    {
        private Author _author;

        public Reader(Author author) => this._author = author;

        public void Update() => Console.WriteLine(this._author.GetState());
    }
}

