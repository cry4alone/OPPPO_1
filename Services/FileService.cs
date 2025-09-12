using System;
using System.Collections.Generic;
using System.IO;

namespace OPPPO_1.Services
{
    public class FileService(string filePath)
    {
        private readonly string _filePath = filePath;

        public List<string> ReadCommands()
        {
            if (!File.Exists(_filePath))
                throw new FileNotFoundException($"Файл не найден: {_filePath}");

            var commands = new List<string>();
            foreach (var line in File.ReadLines(_filePath))
            {
                var trimmed = line.Trim();
                if (!string.IsNullOrEmpty(trimmed))
                    commands.Add(trimmed);
            }
            return commands;
        }
    }
}
