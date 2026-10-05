using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OwnersCreateLedgerRequestPartnerLiability.OwnersCreateLedgerRequestPartnerLiabilitySerializer)
)]
[Serializable]
public readonly record struct OwnersCreateLedgerRequestPartnerLiability : IStringEnum
{
    public static readonly OwnersCreateLedgerRequestPartnerLiability General = new(Values.General);

    public static readonly OwnersCreateLedgerRequestPartnerLiability Limited = new(Values.Limited);

    public OwnersCreateLedgerRequestPartnerLiability(string value)
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
    public static OwnersCreateLedgerRequestPartnerLiability FromCustom(string value)
    {
        return new OwnersCreateLedgerRequestPartnerLiability(value);
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
        OwnersCreateLedgerRequestPartnerLiability value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        OwnersCreateLedgerRequestPartnerLiability value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(OwnersCreateLedgerRequestPartnerLiability value) =>
        value.Value;

    public static explicit operator OwnersCreateLedgerRequestPartnerLiability(string value) =>
        new(value);

    internal class OwnersCreateLedgerRequestPartnerLiabilitySerializer
        : JsonConverter<OwnersCreateLedgerRequestPartnerLiability>
    {
        public override OwnersCreateLedgerRequestPartnerLiability Read(
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
            return new OwnersCreateLedgerRequestPartnerLiability(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OwnersCreateLedgerRequestPartnerLiability value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OwnersCreateLedgerRequestPartnerLiability ReadAsPropertyName(
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
            return new OwnersCreateLedgerRequestPartnerLiability(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OwnersCreateLedgerRequestPartnerLiability value,
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
