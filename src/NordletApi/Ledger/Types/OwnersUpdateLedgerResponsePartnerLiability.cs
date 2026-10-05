using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OwnersUpdateLedgerResponsePartnerLiability.OwnersUpdateLedgerResponsePartnerLiabilitySerializer)
)]
[Serializable]
public readonly record struct OwnersUpdateLedgerResponsePartnerLiability : IStringEnum
{
    public static readonly OwnersUpdateLedgerResponsePartnerLiability General = new(Values.General);

    public static readonly OwnersUpdateLedgerResponsePartnerLiability Limited = new(Values.Limited);

    public OwnersUpdateLedgerResponsePartnerLiability(string value)
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
    public static OwnersUpdateLedgerResponsePartnerLiability FromCustom(string value)
    {
        return new OwnersUpdateLedgerResponsePartnerLiability(value);
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
        OwnersUpdateLedgerResponsePartnerLiability value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        OwnersUpdateLedgerResponsePartnerLiability value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(OwnersUpdateLedgerResponsePartnerLiability value) =>
        value.Value;

    public static explicit operator OwnersUpdateLedgerResponsePartnerLiability(string value) =>
        new(value);

    internal class OwnersUpdateLedgerResponsePartnerLiabilitySerializer
        : JsonConverter<OwnersUpdateLedgerResponsePartnerLiability>
    {
        public override OwnersUpdateLedgerResponsePartnerLiability Read(
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
            return new OwnersUpdateLedgerResponsePartnerLiability(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OwnersUpdateLedgerResponsePartnerLiability value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OwnersUpdateLedgerResponsePartnerLiability ReadAsPropertyName(
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
            return new OwnersUpdateLedgerResponsePartnerLiability(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OwnersUpdateLedgerResponsePartnerLiability value,
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
