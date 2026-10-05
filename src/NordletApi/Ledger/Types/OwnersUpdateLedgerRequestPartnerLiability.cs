using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OwnersUpdateLedgerRequestPartnerLiability.OwnersUpdateLedgerRequestPartnerLiabilitySerializer)
)]
[Serializable]
public readonly record struct OwnersUpdateLedgerRequestPartnerLiability : IStringEnum
{
    public static readonly OwnersUpdateLedgerRequestPartnerLiability General = new(Values.General);

    public static readonly OwnersUpdateLedgerRequestPartnerLiability Limited = new(Values.Limited);

    public OwnersUpdateLedgerRequestPartnerLiability(string value)
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
    public static OwnersUpdateLedgerRequestPartnerLiability FromCustom(string value)
    {
        return new OwnersUpdateLedgerRequestPartnerLiability(value);
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
        OwnersUpdateLedgerRequestPartnerLiability value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        OwnersUpdateLedgerRequestPartnerLiability value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(OwnersUpdateLedgerRequestPartnerLiability value) =>
        value.Value;

    public static explicit operator OwnersUpdateLedgerRequestPartnerLiability(string value) =>
        new(value);

    internal class OwnersUpdateLedgerRequestPartnerLiabilitySerializer
        : JsonConverter<OwnersUpdateLedgerRequestPartnerLiability>
    {
        public override OwnersUpdateLedgerRequestPartnerLiability Read(
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
            return new OwnersUpdateLedgerRequestPartnerLiability(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OwnersUpdateLedgerRequestPartnerLiability value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OwnersUpdateLedgerRequestPartnerLiability ReadAsPropertyName(
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
            return new OwnersUpdateLedgerRequestPartnerLiability(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OwnersUpdateLedgerRequestPartnerLiability value,
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
