namespace OPPPO1.Entities
{
    internal abstract class WorkOfArt(string name, int yearOfCreation)
    {
        public required string Name { get; set; } = name;
        public int YearOfCreation { get; set; } = yearOfCreation;

        public virtual void Print()
        {
            Console.WriteLine(Name + " " + YearOfCreation);
        }
    }
}