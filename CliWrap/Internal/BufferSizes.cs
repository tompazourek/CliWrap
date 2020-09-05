namespace CliWrap.Internal
{
    internal static class BufferSizes
    {
        public const int Stream = 4096; // made the buffer size smaller to reproduce the issue more easily (note: to reproduce the issue, we need a number not divisible by 3)
        public const int StreamReader = 1024;
    }
}