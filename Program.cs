using OPPPO1.Entities;
using OPPPO1.Services;

List<WorkOfArt> workOfArts = [];
var fileService = new FileService("commands.txt");
var commands = fileService.ReadCommands();
CommandService.ExecuteCommands(commands, workOfArts);
