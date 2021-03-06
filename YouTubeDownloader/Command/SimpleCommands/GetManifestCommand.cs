namespace YouTubeDownloader.Command.SimpleCommands;

using System.Threading.Tasks;
using YoutubeExplode.Videos.Streams;

public class GetManifestCommand : ICommand
{
    private readonly CommandContext _commandContext;

    public GetManifestCommand(CommandContext commandContext)
    {
        _commandContext = commandContext;
    }

    public async Task Execute()
    {
        var client = _commandContext.Client;
        var video = _commandContext.VideoId;
        var manifest = await client.Videos.Streams.GetManifestAsync(video);
        _commandContext.Manifest = manifest; 
        var videoInfo = manifest.GetMuxedStreams().GetWithHighestVideoQuality();
        _commandContext.Info = videoInfo;
    }
}