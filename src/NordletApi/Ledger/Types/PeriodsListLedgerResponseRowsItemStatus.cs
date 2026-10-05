using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PeriodsListLedgerResponseRowsItemStatus.PeriodsListLedgerResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PeriodsListLedgerResponseRowsItemStatus : IStringEnum
{
    public static readonly PeriodsListLedgerResponseRowsItemStatus Open = new(Values.Open);

    public static readonly PeriodsListLedgerResponseRowsItemStatus Locked = new(Values.Locked);

    public PeriodsListLedgerResponseRowsItemStatus(string value)
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
    public static PeriodsListLedgerResponseRowsItemStatus FromCustom(string value)
    {
        return new PeriodsListLedgerResponseRowsItemStatus(value);
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

    public static bool operator ==(PeriodsListLedgerResponseRowsItemStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PeriodsListLedgerResponseRowsItemStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PeriodsListLedgerResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator PeriodsListLedgerResponseRowsItemStatus(string value) =>
        new(value);

    internal class PeriodsListLedgerResponseRowsItemStatusSerializer
        : JsonConverter<PeriodsListLedgerResponseRowsItemStatus>
    {
        public override PeriodsListLedgerResponseRowsItemStatus Read(
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
            return new PeriodsListLedgerResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PeriodsListLedgerResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PeriodsListLedgerResponseRowsItemStatus ReadAsPropertyName(
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
            return new PeriodsListLedgerResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PeriodsListLedgerResponseRowsItemStatus value,
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
        public const string Open = "open";

        public const string Locked = "locked";
    }
}
