namespace OPPPO_1.Entities
{
    public class Sculpture : WorkOfArt
    {
        public required string Material { get; set; }

        public Sculpture(string name, int yearOfCreation, string material) : base(name, yearOfCreation)
        {
            Material = material;
        }

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