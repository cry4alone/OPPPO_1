namespace OPPPO1
{
    using OPPPO1.Entities;
    using OPPPO1.Services;

    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в приложение.
        /// </summary>
        private static void Main()
        {
            List<WorkOfArt> workOfArts = [];
            var fileService = new FileService("commands.txt");
            var commands = fileService.ReadCommands();
            CommandService.ExecuteCommands(commands, workOfArts);
        }
    }
}
