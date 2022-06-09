namespace YouTubeDownloader.Command.SimpleCommands;

using System;
using System.Threading.Tasks;

public class WriteToConsoleCommand : ICommand
{
    private readonly CommandContext _context;

    public WriteToConsoleCommand(CommandContext context)
    {
        _context = context;
    }

    public Task Execute()
    {
        Console.WriteLine($"VideoCodec: {_context.Info.VideoCodec}");
        return Task.CompletedTask;
    }
}