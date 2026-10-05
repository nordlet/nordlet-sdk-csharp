using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OwnersCreateLedgerResponsePartnerLiability.OwnersCreateLedgerResponsePartnerLiabilitySerializer)
)]
[Serializable]
public readonly record struct OwnersCreateLedgerResponsePartnerLiability : IStringEnum
{
    public static readonly OwnersCreateLedgerResponsePartnerLiability General = new(Values.General);

    public static readonly OwnersCreateLedgerResponsePartnerLiability Limited = new(Values.Limited);

    public OwnersCreateLedgerResponsePartnerLiability(string value)
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
    public static OwnersCreateLedgerResponsePartnerLiability FromCustom(string value)
    {
        return new OwnersCreateLedgerResponsePartnerLiability(value);
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
        OwnersCreateLedgerResponsePartnerLiability value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        OwnersCreateLedgerResponsePartnerLiability value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(OwnersCreateLedgerResponsePartnerLiability value) =>
        value.Value;

    public static explicit operator OwnersCreateLedgerResponsePartnerLiability(string value) =>
        new(value);

    internal class OwnersCreateLedgerResponsePartnerLiabilitySerializer
        : JsonConverter<OwnersCreateLedgerResponsePartnerLiability>
    {
        public override OwnersCreateLedgerResponsePartnerLiability Read(
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
            return new OwnersCreateLedgerResponsePartnerLiability(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OwnersCreateLedgerResponsePartnerLiability value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OwnersCreateLedgerResponsePartnerLiability ReadAsPropertyName(
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
            return new OwnersCreateLedgerResponsePartnerLiability(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OwnersCreateLedgerResponsePartnerLiability value,
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
        public const string General = "general";

        public const string Limited = "limited";
    }
}
