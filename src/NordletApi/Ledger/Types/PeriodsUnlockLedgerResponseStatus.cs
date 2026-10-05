using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PeriodsUnlockLedgerResponseStatus.PeriodsUnlockLedgerResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PeriodsUnlockLedgerResponseStatus : IStringEnum
{
    public static readonly PeriodsUnlockLedgerResponseStatus Open = new(Values.Open);

    public static readonly PeriodsUnlockLedgerResponseStatus Locked = new(Values.Locked);

    public PeriodsUnlockLedgerResponseStatus(string value)
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
    public static PeriodsUnlockLedgerResponseStatus FromCustom(string value)
    {
        return new PeriodsUnlockLedgerResponseStatus(value);
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

    public static bool operator ==(PeriodsUnlockLedgerResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PeriodsUnlockLedgerResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PeriodsUnlockLedgerResponseStatus value) => value.Value;

    public static explicit operator PeriodsUnlockLedgerResponseStatus(string value) => new(value);

    internal class PeriodsUnlockLedgerResponseStatusSerializer
        : JsonConverter<PeriodsUnlockLedgerResponseStatus>
    {
        public override PeriodsUnlockLedgerResponseStatus Read(
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
            return new PeriodsUnlockLedgerResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PeriodsUnlockLedgerResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PeriodsUnlockLedgerResponseStatus ReadAsPropertyName(
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
            return new PeriodsUnlockLedgerResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PeriodsUnlockLedgerResponseStatus value,
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
