using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(WaybillsGetTransportResponseStatus.WaybillsGetTransportResponseStatusSerializer)
)]
[Serializable]
public readonly record struct WaybillsGetTransportResponseStatus : IStringEnum
{
    public static readonly WaybillsGetTransportResponseStatus Draft = new(Values.Draft);

    public static readonly WaybillsGetTransportResponseStatus Issued = new(Values.Issued);

    public static readonly WaybillsGetTransportResponseStatus Cancelled = new(Values.Cancelled);

    public WaybillsGetTransportResponseStatus(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static WaybillsGetTransportResponseStatus FromCustom(string value)
    {
        return new WaybillsGetTransportResponseStatus(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(WaybillsGetTransportResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WaybillsGetTransportResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WaybillsGetTransportResponseStatus value) => value.Value;

    public static explicit operator WaybillsGetTransportResponseStatus(string value) => new(value);

    internal class WaybillsGetTransportResponseStatusSerializer
        : JsonConverter<WaybillsGetTransportResponseStatus>
    {
        public override WaybillsGetTransportResponseStatus Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new WaybillsGetTransportResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WaybillsGetTransportResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WaybillsGetTransportResponseStatus ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new WaybillsGetTransportResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WaybillsGetTransportResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Draft = "draft";

        public const string Issued = "issued";

        public const string Cancelled = "cancelled";
    }
}
