using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SettlementsCommissionBankResponseMatchStatus.SettlementsCommissionBankResponseMatchStatusSerializer)
)]
[Serializable]
public readonly record struct SettlementsCommissionBankResponseMatchStatus : IStringEnum
{
    public static readonly SettlementsCommissionBankResponseMatchStatus Unmatched = new(
        Values.Unmatched
    );

    public static readonly SettlementsCommissionBankResponseMatchStatus Matched = new(
        Values.Matched
    );

    public static readonly SettlementsCommissionBankResponseMatchStatus Manual = new(Values.Manual);

    public SettlementsCommissionBankResponseMatchStatus(string value)
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
    public static SettlementsCommissionBankResponseMatchStatus FromCustom(string value)
    {
        return new SettlementsCommissionBankResponseMatchStatus(value);
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
        SettlementsCommissionBankResponseMatchStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SettlementsCommissionBankResponseMatchStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SettlementsCommissionBankResponseMatchStatus value) =>
        value.Value;

    public static explicit operator SettlementsCommissionBankResponseMatchStatus(string value) =>
        new(value);

    internal class SettlementsCommissionBankResponseMatchStatusSerializer
        : JsonConverter<SettlementsCommissionBankResponseMatchStatus>
    {
        public override SettlementsCommissionBankResponseMatchStatus Read(
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
            return new SettlementsCommissionBankResponseMatchStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SettlementsCommissionBankResponseMatchStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SettlementsCommissionBankResponseMatchStatus ReadAsPropertyName(
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
            return new SettlementsCommissionBankResponseMatchStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SettlementsCommissionBankResponseMatchStatus value,
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
