namespace OPPPO1.Entities
{
    internal class Sculpture(string name, int yearOfCreation, string material) : WorkOfArt(name, yearOfCreation)
    {
        public required string Material { get; set; } = material;

        public override void Print()
        {
            Console.WriteLine("================== Скульптура ===================");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Год создания: {YearOfCreation}");
            Console.WriteLine($"Материал: {Material}");
            Console.WriteLine("=================================================");
            Console.WriteLine();
        }
    }

}