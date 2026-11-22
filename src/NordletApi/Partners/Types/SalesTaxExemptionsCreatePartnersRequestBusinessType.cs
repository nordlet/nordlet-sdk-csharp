using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SalesTaxExemptionsCreatePartnersRequestBusinessType.SalesTaxExemptionsCreatePartnersRequestBusinessTypeSerializer)
)]
[Serializable]
public readonly record struct SalesTaxExemptionsCreatePartnersRequestBusinessType : IStringEnum
{
    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Ten = new(
        Values.Ten
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Eleven = new(
        Values.Eleven
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Twelve = new(
        Values.Twelve
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Thirteen = new(
        Values.Thirteen
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Fourteen = new(
        Values.Fourteen
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Fifteen = new(
        Values.Fifteen
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Sixteen = new(
        Values.Sixteen
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Seventeen = new(
        Values.Seventeen
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Eighteen = new(
        Values.Eighteen
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Nineteen = new(
        Values.Nineteen
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Twenty = new(
        Values.Twenty
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType One = new(
        Values.One
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Two = new(
        Values.Two
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Three = new(
        Values.Three
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Four = new(
        Values.Four
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Five = new(
        Values.Five
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Six = new(
        Values.Six
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Seven = new(
        Values.Seven
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Eight = new(
        Values.Eight
    );

    public static readonly SalesTaxExemptionsCreatePartnersRequestBusinessType Nine = new(
        Values.Nine
    );

    public SalesTaxExemptionsCreatePartnersRequestBusinessType(string value)
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
    public static SalesTaxExemptionsCreatePartnersRequestBusinessType FromCustom(string value)
    {
        return new SalesTaxExemptionsCreatePartnersRequestBusinessType(value);
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
        SalesTaxExemptionsCreatePartnersRequestBusinessType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SalesTaxExemptionsCreatePartnersRequestBusinessType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SalesTaxExemptionsCreatePartnersRequestBusinessType value
    ) => value.Value;

    public static explicit operator SalesTaxExemptionsCreatePartnersRequestBusinessType(
        string value
    ) => new(value);

    internal class SalesTaxExemptionsCreatePartnersRequestBusinessTypeSerializer
        : JsonConverter<SalesTaxExemptionsCreatePartnersRequestBusinessType>
    {
        public override SalesTaxExemptionsCreatePartnersRequestBusinessType Read(
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
            return new SalesTaxExemptionsCreatePartnersRequestBusinessType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SalesTaxExemptionsCreatePartnersRequestBusinessType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SalesTaxExemptionsCreatePartnersRequestBusinessType ReadAsPropertyName(
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
            return new SalesTaxExemptionsCreatePartnersRequestBusinessType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SalesTaxExemptionsCreatePartnersRequestBusinessType value,
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
        public const string Ten = "10";

        public const string Eleven = "11";

        public const string Twelve = "12";

        public const string Thirteen = "13";

        public const string Fourteen = "14";

        public const string Fifteen = "15";

        public const string Sixteen = "16";

        public const string Seventeen = "17";

        public const string Eighteen = "18";

        public const string Nineteen = "19";

        public const string Twenty = "20";

        public const string One = "01";

        public const string Two = "02";

        public const string Three = "03";

        public const string Four = "04";

        public const string Five = "05";

        public const string Six = "06";

        public const string Seven = "07";

        public const string Eight = "08";

        public const string Nine = "09";
    }
}
