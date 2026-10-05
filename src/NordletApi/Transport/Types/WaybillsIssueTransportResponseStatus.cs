using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(WaybillsIssueTransportResponseStatus.WaybillsIssueTransportResponseStatusSerializer)
)]
[Serializable]
public readonly record struct WaybillsIssueTransportResponseStatus : IStringEnum
{
    public static readonly WaybillsIssueTransportResponseStatus Draft = new(Values.Draft);

    public static readonly WaybillsIssueTransportResponseStatus Issued = new(Values.Issued);

    public static readonly WaybillsIssueTransportResponseStatus Cancelled = new(Values.Cancelled);

    public WaybillsIssueTransportResponseStatus(string value)
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
    public static WaybillsIssueTransportResponseStatus FromCustom(string value)
    {
        return new WaybillsIssueTransportResponseStatus(value);
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

    public static bool operator ==(WaybillsIssueTransportResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WaybillsIssueTransportResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WaybillsIssueTransportResponseStatus value) =>
        value.Value;

    public static explicit operator WaybillsIssueTransportResponseStatus(string value) =>
        new(value);

    internal class WaybillsIssueTransportResponseStatusSerializer
        : JsonConverter<WaybillsIssueTransportResponseStatus>
    {
        public override WaybillsIssueTransportResponseStatus Read(
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
            return new WaybillsIssueTransportResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WaybillsIssueTransportResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WaybillsIssueTransportResponseStatus ReadAsPropertyName(
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
            return new WaybillsIssueTransportResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WaybillsIssueTransportResponseStatus value,
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
