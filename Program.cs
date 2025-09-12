using OPPPO_1.Entities;
using OPPPO_1.Services;

List<WorkOfArt> workOfArts = [];
var fileService = new FileService("commands.txt");
var commands = fileService.ReadCommands();
var commandService = new CommandService();
commandService.ExecuteCommands(commands, workOfArts);
