using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SettlementsMatchBankResponseMatchStatus.SettlementsMatchBankResponseMatchStatusSerializer)
)]
[Serializable]
public readonly record struct SettlementsMatchBankResponseMatchStatus : IStringEnum
{
    public static readonly SettlementsMatchBankResponseMatchStatus Unmatched = new(
        Values.Unmatched
    );

    public static readonly SettlementsMatchBankResponseMatchStatus Matched = new(Values.Matched);

    public static readonly SettlementsMatchBankResponseMatchStatus Manual = new(Values.Manual);

    public SettlementsMatchBankResponseMatchStatus(string value)
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
    public static SettlementsMatchBankResponseMatchStatus FromCustom(string value)
    {
        return new SettlementsMatchBankResponseMatchStatus(value);
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

    public static bool operator ==(SettlementsMatchBankResponseMatchStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SettlementsMatchBankResponseMatchStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SettlementsMatchBankResponseMatchStatus value) =>
        value.Value;

    public static explicit operator SettlementsMatchBankResponseMatchStatus(string value) =>
        new(value);

    internal class SettlementsMatchBankResponseMatchStatusSerializer
        : JsonConverter<SettlementsMatchBankResponseMatchStatus>
    {
        public override SettlementsMatchBankResponseMatchStatus Read(
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
            return new SettlementsMatchBankResponseMatchStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SettlementsMatchBankResponseMatchStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SettlementsMatchBankResponseMatchStatus ReadAsPropertyName(
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
            return new SettlementsMatchBankResponseMatchStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SettlementsMatchBankResponseMatchStatus value,
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
        public const string Unmatched = "unmatched";

        public const string Matched = "matched";

        public const string Manual = "manual";
    }
}
