using MimeTypes;
using Xunit;

namespace MimeTypeMapTest
{
    public class BaseTests 
    {
        [Fact] public void TxtTest() => Assert.Equal("text/plain", MimeTypeMap.GetMimeType("txt"));
        [Fact] public void AudioWavTest() => Assert.Equal("application/octet-stream", MimeTypeMap.GetMimeType("audio/wav"));
    }
}
