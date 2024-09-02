using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace FreeStreaming.Components.Class
{
    public class Series
    {
        public string? Name { get; set; }
        public byte[] Thumb { get; set; }
        public int Classification { get; set; }
    }
}
