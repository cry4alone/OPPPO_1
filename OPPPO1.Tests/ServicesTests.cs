namespace OPPPO1.Tests;

using Xunit;  
using OPPPO1.Services;
using OPPPO1.Entities;

public class ServicesTests
{
    [Fact]
    public void ExecuteCommands_ValidCommands_SuccessfullyAddsWorkOfArt()
    {
        // Arrange
        var validCommands = new List<string>
        {
            "add;painting;Starry Night;1889;Vincent van Gogh",
            "add;sculpture;David;1504;Marble"
        };
        var workOfArts = new List<WorkOfArt>();

        // Act
        CommandService.ExecuteCommands(validCommands, workOfArts);

        // Assert
        Assert.Equal(2, workOfArts.Count);

        var first = workOfArts[0] as Painting;
        Assert.Equal("Starry Night", first.Name); 
        Assert.Equal("Vincent van Gogh", first.PainterName);
        Assert.Equal(1889, first.YearOfCreation);

        var second = workOfArts[1] as Sculpture;
        Assert.Equal("David", second.Name);
        Assert.Equal("Marble", second.Material);
        Assert.Equal(1504, second.YearOfCreation);
    }

    [Fact]
    public void ExecuteCommands_RemoveOldArt_RemovesCorrectly()
    {
        // Arrange
        var commands = new List<string>
        {
            "Remove;YearOfCreation;<;1900"
        };
        var workOfArts = new List<WorkOfArt>
        {
            new Painting("Mona Lisa", 1503, "Leonardo da Vinci"),
            new Sculpture("The Thinker", 1902, "Bronze"),
            new Painting("The Persistence of Memory", 1931, "Salvador Dalí")
        };

        // Act
        CommandService.ExecuteCommands(commands, workOfArts);

        // Assert
        Assert.Equal(2, workOfArts.Count);
        Assert.Contains(workOfArts, art => art.Name == "The Thinker");
        Assert.Contains(workOfArts, art => art.Name == "The Persistence of Memory");
    }

    [Fact]
    public void ExecuteCommands_DisplayCommand_PrintsToConsole()
    {
        // Arrange
        var commands = new List<string>
        {
            "display"
        };
        var workOfArts = new List<WorkOfArt>
        {
            new Painting("The Starry Night", 1889, "Vincent van Gogh"),
            new Sculpture("David", 1504, "Marble")
        };

        using var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);

        // Act
        CommandService.ExecuteCommands(commands, workOfArts);

        // Assert
        var output = consoleOutput.ToString();
        Assert.Contains("The Starry Night", output);
        Assert.Contains("David", output);
    }

    [Fact]
    public void Executecommands_ProcessEmptyCommands_ThrowsEmptyCommandsError()
    {
        var commands = new List<string>
        {
            ";;;"
        };
        var workOfArts = new List<WorkOfArt>
        {
            new Painting("The Starry Night", 1889, "Vincent van Gogh"),
            new Sculpture("David", 1504, "Marble")
        };

        var exception = Assert.Throws<ArgumentException>(
            () => CommandService.ExecuteCommands(commands, workOfArts));

        Assert.Equal("Commands can't be empty", exception.Message);
    }

    [Fact]
    public void Executecommands_ProcessInvalidCommands_ThrowsInvalidCommandsError()
    {
        var commands = new List<string>
        {
            "invalid;"
        };
        var workOfArts = new List<WorkOfArt>
        {
            new Painting("The Starry Night", 1889, "Vincent van Gogh"),
            new Sculpture("David", 1504, "Marble")
        };

        var exception = Assert.Throws<ArgumentException>(
            () => CommandService.ExecuteCommands(commands, workOfArts));

        Assert.Equal("Invalid command", exception.Message);
    }
}