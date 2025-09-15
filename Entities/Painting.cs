namespace OPPPO1.Entities
{
    /// <summary>
    /// Представляет картину как произведение искусства.
    /// </summary>
    /// <param name="name">Название картины.</param>
    /// <param name="yearOfCreation">Год создания картины.</param>
    /// <param name="painterName">Имя автора картины.</param>
    internal class Painting(string name, int yearOfCreation, string painterName)
        : WorkOfArt(name, yearOfCreation)
    {
        /// <summary>
        /// Gets or sets имя автора картины.
        /// </summary>
        required public string PainterName { get; set; } = painterName;

        /// <summary>
        /// Выводит информацию о картине в консоль.
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("==================== Картина ====================");
            Console.WriteLine($"Название: {this.Name}");
            Console.WriteLine($"Год создания: {this.YearOfCreation}");
            Console.WriteLine($"Автор: {this.PainterName}");
            Console.WriteLine("=================================================");
            Console.WriteLine();
        }
    }
}
