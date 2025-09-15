namespace OPPPO1.Entities
{
    internal class Painting(string name, int yearOfCreation, string painterName) : WorkOfArt(name, yearOfCreation)
    {
        public required string PainterName { get; set; } = painterName;

        public override void Print()
        {
            Console.WriteLine("==================== Картина ====================");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Год создания: {YearOfCreation}");
            Console.WriteLine($"Автор: {PainterName}");
            Console.WriteLine("=================================================");
            Console.WriteLine();
        }
    }
}
