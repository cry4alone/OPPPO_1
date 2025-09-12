namespace OPPPO_1.Entities
{
    public abstract class WorkOfArt
    {
        public required string Name { get; set; }
        public int YearOfCreation { get; set; }

        public WorkOfArt(string name, int yearOfCreation)
        {
            Name = name;
            YearOfCreation = yearOfCreation;
        }

        public virtual void Print()
        {
            Console.WriteLine(Name + " " + YearOfCreation);
        }
    }
}