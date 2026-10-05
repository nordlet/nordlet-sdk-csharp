using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(WaybillsListTransportResponseRowsItemStatus.WaybillsListTransportResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct WaybillsListTransportResponseRowsItemStatus : IStringEnum
{
    public static readonly WaybillsListTransportResponseRowsItemStatus Draft = new(Values.Draft);

    public static readonly WaybillsListTransportResponseRowsItemStatus Issued = new(Values.Issued);

    public static readonly WaybillsListTransportResponseRowsItemStatus Cancelled = new(
        Values.Cancelled
    );

    public WaybillsListTransportResponseRowsItemStatus(string value)
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
    public static WaybillsListTransportResponseRowsItemStatus FromCustom(string value)
    {
        return new WaybillsListTransportResponseRowsItemStatus(value);
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

    public static bool operator ==(
        WaybillsListTransportResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WaybillsListTransportResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WaybillsListTransportResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator WaybillsListTransportResponseRowsItemStatus(string value) =>
        new(value);

    internal class WaybillsListTransportResponseRowsItemStatusSerializer
        : JsonConverter<WaybillsListTransportResponseRowsItemStatus>
    {
        public override WaybillsListTransportResponseRowsItemStatus Read(
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
            return new WaybillsListTransportResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WaybillsListTransportResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WaybillsListTransportResponseRowsItemStatus ReadAsPropertyName(
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
            return new WaybillsListTransportResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WaybillsListTransportResponseRowsItemStatus value,
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
