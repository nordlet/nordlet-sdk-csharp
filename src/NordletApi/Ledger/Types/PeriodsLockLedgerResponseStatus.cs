using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PeriodsLockLedgerResponseStatus.PeriodsLockLedgerResponseStatusSerializer))]
[Serializable]
public readonly record struct PeriodsLockLedgerResponseStatus : IStringEnum
{
    public static readonly PeriodsLockLedgerResponseStatus Open = new(Values.Open);

    public static readonly PeriodsLockLedgerResponseStatus Locked = new(Values.Locked);

    public PeriodsLockLedgerResponseStatus(string value)
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
    public static PeriodsLockLedgerResponseStatus FromCustom(string value)
    {
        return new PeriodsLockLedgerResponseStatus(value);
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

    public static bool operator ==(PeriodsLockLedgerResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PeriodsLockLedgerResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PeriodsLockLedgerResponseStatus value) => value.Value;

    public static explicit operator PeriodsLockLedgerResponseStatus(string value) => new(value);

    internal class PeriodsLockLedgerResponseStatusSerializer
        : JsonConverter<PeriodsLockLedgerResponseStatus>
    {
        public override PeriodsLockLedgerResponseStatus Read(
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
            return new PeriodsLockLedgerResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PeriodsLockLedgerResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PeriodsLockLedgerResponseStatus ReadAsPropertyName(
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
            return new PeriodsLockLedgerResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PeriodsLockLedgerResponseStatus value,
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
