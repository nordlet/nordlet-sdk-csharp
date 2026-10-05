using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(OwnersCreateLedgerRequestSharesType.OwnersCreateLedgerRequestSharesTypeSerializer)
)]
[Serializable]
public readonly record struct OwnersCreateLedgerRequestSharesType : IStringEnum
{
    public static readonly OwnersCreateLedgerRequestSharesType V = new(Values.V);

    public static readonly OwnersCreateLedgerRequestSharesType Pr = new(Values.Pr);

    public static readonly OwnersCreateLedgerRequestSharesType Pp = new(Values.Pp);

    public static readonly OwnersCreateLedgerRequestSharesType Prv = new(Values.Prv);

    public OwnersCreateLedgerRequestSharesType(string value)
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
    public static OwnersCreateLedgerRequestSharesType FromCustom(string value)
    {
        return new OwnersCreateLedgerRequestSharesType(value);
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

    public static bool operator ==(OwnersCreateLedgerRequestSharesType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OwnersCreateLedgerRequestSharesType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OwnersCreateLedgerRequestSharesType value) =>
        value.Value;

    public static explicit operator OwnersCreateLedgerRequestSharesType(string value) => new(value);

    internal class OwnersCreateLedgerRequestSharesTypeSerializer
        : JsonConverter<OwnersCreateLedgerRequestSharesType>
    {
        public override OwnersCreateLedgerRequestSharesType Read(
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
            return new OwnersCreateLedgerRequestSharesType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OwnersCreateLedgerRequestSharesType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OwnersCreateLedgerRequestSharesType ReadAsPropertyName(
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
            return new OwnersCreateLedgerRequestSharesType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OwnersCreateLedgerRequestSharesType value,
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
