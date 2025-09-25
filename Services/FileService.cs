namespace OPPPO1.Services
{
    /// <summary>
    /// Сервис для работы с файлами команд.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="FileService"/> class.
    /// </remarks>
    /// <param name="filePath">Путь к файлу команд.</param>
    internal class FileService(string filePath)
    {
        private readonly string filePath = filePath;

        /// <summary>
        /// Считывает команды из файла.
        /// </summary>
        /// <returns>Список команд, считанных из файла.</returns>
        /// <exception cref="FileNotFoundException">Выбрасывается, если файл не найден.</exception>
        public List<string> ReadCommands()
        {
            if (!File.Exists(this.filePath))
            {
                throw new FileNotFoundException($"Файл не найден: {this.filePath}");
            }

            var commands = new List<string>();
            foreach (var line in File.ReadLines(this.filePath))
            {
                var trimmed = line.Trim();
                if (!string.IsNullOrEmpty(trimmed))
                {
                    commands.Add(trimmed);
                }
            }

            return commands;
        }
    }
}
