namespace ObserverPattern
{
    public class Startup
    {
        public static void Main()
        {
            var author = new Author();

            var firstReader = new Reader(author);
            var secondReader = new Reader(author);
            var thirdReader = new Reader(author);

            author.Add(firstReader);
            author.Add(secondReader);
            author.Add(thirdReader);

            author.SetState("C# via CLR 4th edition");
            author.Notify();
        }
    }
}


