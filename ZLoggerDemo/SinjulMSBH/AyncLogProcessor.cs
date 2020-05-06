using System;
using System.Buffers;
using System.Text.Json;
using System.Threading.Tasks;

using ZLogger;

namespace ZLoggerDemo.SinjulMSBH
{
    public interface IAsyncLogProcessor : IAsyncDisposable
    {
        void Post(IZLoggerEntry log);

        //? DisposeAsync is called when LoggerFactory is disposed(application stopped).
        new ValueTask DisposeAsync();
    }

    public interface IZLoggerEntry
    {
        LogInfo LogInfo { get; }
        void FormatUtf8(IBufferWriter<byte> writer, ZLoggerOptions options, Utf8JsonWriter? jsonWriter);
        void SwitchCasePayload<TPayload>(Action<IZLoggerEntry, TPayload, object?> payloadCallback, object? state);
        object? GetPayload();
        void Return();

        //? Extension Methods
        string FormatToString(ZLoggerOptions options, Utf8JsonWriter? jsonWriter);
    }
}
