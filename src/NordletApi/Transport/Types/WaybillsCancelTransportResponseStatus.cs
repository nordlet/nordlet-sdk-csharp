using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(WaybillsCancelTransportResponseStatus.WaybillsCancelTransportResponseStatusSerializer)
)]
[Serializable]
public readonly record struct WaybillsCancelTransportResponseStatus : IStringEnum
{
    public static readonly WaybillsCancelTransportResponseStatus Draft = new(Values.Draft);

    public static readonly WaybillsCancelTransportResponseStatus Issued = new(Values.Issued);

    public static readonly WaybillsCancelTransportResponseStatus Cancelled = new(Values.Cancelled);

    public WaybillsCancelTransportResponseStatus(string value)
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
    public static WaybillsCancelTransportResponseStatus FromCustom(string value)
    {
        return new WaybillsCancelTransportResponseStatus(value);
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

    public static bool operator ==(WaybillsCancelTransportResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WaybillsCancelTransportResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WaybillsCancelTransportResponseStatus value) =>
        value.Value;

    public static explicit operator WaybillsCancelTransportResponseStatus(string value) =>
        new(value);

    internal class WaybillsCancelTransportResponseStatusSerializer
        : JsonConverter<WaybillsCancelTransportResponseStatus>
    {
        public override WaybillsCancelTransportResponseStatus Read(
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
            return new WaybillsCancelTransportResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WaybillsCancelTransportResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WaybillsCancelTransportResponseStatus ReadAsPropertyName(
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
            return new WaybillsCancelTransportResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WaybillsCancelTransportResponseStatus value,
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
