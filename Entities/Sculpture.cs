namespace OPPPO1.Entities
{
    /// <summary>
    /// Представляет скульптуру как произведение искусства.
    /// </summary>
    internal class Sculpture(string name, int yearOfCreation, string material)
        : WorkOfArt(name, yearOfCreation)
    {
        /// <summary>
        /// Gets or sets материал скульптуры.
        /// </summary>
        public string Material { get; set; } = material;

        /// <summary>
        /// Выводит информацию о скульптуре в консоль.
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("================== Скульптура ===================");
            Console.WriteLine($"Название: {this.Name}");
            Console.WriteLine($"Год создания: {this.YearOfCreation}");
            Console.WriteLine($"Материал: {this.Material}");
            Console.WriteLine("=================================================");
            Console.WriteLine();
        }
    }
}