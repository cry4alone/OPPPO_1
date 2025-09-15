// <copyright file="WorkOfArt.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace OPPPO1.Entities
{
    /// <summary>
    /// ����������� �����, �������������� ������������ ���������.
    /// </summary>
    /// <param name="name">�������� ������������ ���������.</param>
    /// <param name="yearOfCreation">��� �������� ������������ ���������.</param>
    internal abstract class WorkOfArt(string name, int yearOfCreation)
    {
        /// <summary>
        /// Gets or sets �������� ������������ ���������.
        /// </summary>
        required public string Name { get; set; } = name;

        /// <summary>
        /// Gets or sets ��� �������� ������������ ���������.
        /// </summary>
        public int YearOfCreation { get; set; } = yearOfCreation;

        /// <summary>
        /// ������� ���������� � ������������ ��������� � �������.
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine(this.Name + " " + this.YearOfCreation);
        }
    }
}