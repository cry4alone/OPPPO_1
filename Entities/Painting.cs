namespace OPPPO_1.Entities
{
    public class Painting : WorkOfArt
    {
        public required string PainterName { get; set; }

        public Painting(string name, int yearOfCreation, string painterName) : base(name, yearOfCreation)
        {
            PainterName = painterName;
        }

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
