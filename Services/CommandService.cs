using System;
using System.Collections.Generic;
using OPPPO_1.Entities;

namespace OPPPO_1.Services
{
    public class CommandService
    {
        public void ExecuteCommands(List<string> commands, List<WorkOfArt> workOfArts)
        {
            foreach (var command in commands)
            {
                var parts = command.Split(';');
                if (parts.Length == 0 || string.IsNullOrWhiteSpace(parts[0])) continue;
                switch (parts[0].ToLower())
                {
                    case "add":
                        if (parts.Length < 3) break;
                        if (parts[1].Equals("painting", StringComparison.CurrentCultureIgnoreCase) && parts.Length >= 5)
                        {
                            var painting = new Painting(parts[2], int.Parse(parts[3]), parts[4])
                            {
                                Name = parts[2],
                                PainterName = parts[4]
                            };
                            workOfArts.Add(painting);
                        }
                        else if (parts[1].Equals("sculpture", StringComparison.CurrentCultureIgnoreCase) && parts.Length >= 5)
                        {
                            var sculpture = new Sculpture(parts[2], int.Parse(parts[3]), parts[4])
                            {
                                Name = parts[2],
                                Material = parts[4]
                            };
                            workOfArts.Add(sculpture);
                        }
                        break;
                    case "remove":
                        if (parts.Length == 4 && parts[1] == "YearOfCreation" && parts[2] == "<")
                        {
                            if (int.TryParse(parts[3], out int year))
                            {
                                workOfArts.RemoveAll(art => art.YearOfCreation < year);
                            }
                        }
                        break;
                    case "display":
                        Console.WriteLine("Текущий список объектов:");
                        foreach (var art in workOfArts)
                        {
                            art.Print();
                        }
                        break;
                }
            }
        }
    }
}
