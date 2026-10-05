using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OwnersUpdateLedgerRequestSharesType.OwnersUpdateLedgerRequestSharesTypeSerializer)
)]
[Serializable]
public readonly record struct OwnersUpdateLedgerRequestSharesType : IStringEnum
{
    public static readonly OwnersUpdateLedgerRequestSharesType V = new(Values.V);

    public static readonly OwnersUpdateLedgerRequestSharesType Pr = new(Values.Pr);

    public static readonly OwnersUpdateLedgerRequestSharesType Pp = new(Values.Pp);

    public static readonly OwnersUpdateLedgerRequestSharesType Prv = new(Values.Prv);

    public OwnersUpdateLedgerRequestSharesType(string value)
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
    public static OwnersUpdateLedgerRequestSharesType FromCustom(string value)
    {
        return new OwnersUpdateLedgerRequestSharesType(value);
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

    public static bool operator ==(OwnersUpdateLedgerRequestSharesType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OwnersUpdateLedgerRequestSharesType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OwnersUpdateLedgerRequestSharesType value) =>
        value.Value;

    public static explicit operator OwnersUpdateLedgerRequestSharesType(string value) => new(value);

    internal class OwnersUpdateLedgerRequestSharesTypeSerializer
        : JsonConverter<OwnersUpdateLedgerRequestSharesType>
    {
        public override OwnersUpdateLedgerRequestSharesType Read(
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
            return new OwnersUpdateLedgerRequestSharesType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OwnersUpdateLedgerRequestSharesType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OwnersUpdateLedgerRequestSharesType ReadAsPropertyName(
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
            return new OwnersUpdateLedgerRequestSharesType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OwnersUpdateLedgerRequestSharesType value,
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
        public const string V = "V";

        public const string Pr = "PR";

        public const string Pp = "PP";

        public const string Prv = "PRV";
    }
}
