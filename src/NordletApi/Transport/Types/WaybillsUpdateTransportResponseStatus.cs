using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(WaybillsUpdateTransportResponseStatus.WaybillsUpdateTransportResponseStatusSerializer)
)]
[Serializable]
public readonly record struct WaybillsUpdateTransportResponseStatus : IStringEnum
{
    public static readonly WaybillsUpdateTransportResponseStatus Draft = new(Values.Draft);

    public static readonly WaybillsUpdateTransportResponseStatus Issued = new(Values.Issued);

    public static readonly WaybillsUpdateTransportResponseStatus Cancelled = new(Values.Cancelled);

    public WaybillsUpdateTransportResponseStatus(string value)
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
    public static WaybillsUpdateTransportResponseStatus FromCustom(string value)
    {
        return new WaybillsUpdateTransportResponseStatus(value);
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

    public static bool operator ==(WaybillsUpdateTransportResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WaybillsUpdateTransportResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WaybillsUpdateTransportResponseStatus value) =>
        value.Value;

    public static explicit operator WaybillsUpdateTransportResponseStatus(string value) =>
        new(value);

    internal class WaybillsUpdateTransportResponseStatusSerializer
        : JsonConverter<WaybillsUpdateTransportResponseStatus>
    {
        public override WaybillsUpdateTransportResponseStatus Read(
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
            return new WaybillsUpdateTransportResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WaybillsUpdateTransportResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WaybillsUpdateTransportResponseStatus ReadAsPropertyName(
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
            return new WaybillsUpdateTransportResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WaybillsUpdateTransportResponseStatus value,
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
