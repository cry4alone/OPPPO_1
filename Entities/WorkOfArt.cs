// <copyright file="WorkOfArt.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace OPPPO1.Entities
{
    /// <summary>
    /// Абстрактный класс, представляющий произведение искусства.
    /// </summary>
    /// <param name="name">Название произведения искусства.</param>
    /// <param name="yearOfCreation">Год создания произведения искусства.</param>
    internal abstract class WorkOfArt(string name, int yearOfCreation)
    {
        /// <summary>
        /// Gets or sets название произведения искусства.
        /// </summary>
        required public string Name { get; set; } = name;

        /// <summary>
        /// Gets or sets год создания произведения искусства.
        /// </summary>
        public int YearOfCreation { get; set; } = yearOfCreation;

        /// <summary>
        /// Выводит информацию о произведении искусства в консоль.
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine(this.Name + " " + this.YearOfCreation);
        }
    }
}