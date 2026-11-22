using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SalesTaxExemptionsCreatePartnersRequestReasonsItem.SalesTaxExemptionsCreatePartnersRequestReasonsItemSerializer)
)]
[Serializable]
public readonly record struct SalesTaxExemptionsCreatePartnersRequestReasonsItem : IStringEnum
{
    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem A = new(Values.A);

    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem B = new(Values.B);

    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem C = new(Values.C);

    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem D = new(Values.D);

    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem E = new(Values.E);

    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem F = new(Values.F);

    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem G = new(Values.G);

    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem H = new(Values.H);

    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem I = new(Values.I);

    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem J = new(Values.J);

    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem K = new(Values.K);

    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem L = new(Values.L);

    public static readonly SalesTaxExemptionsCreatePartnersRequestReasonsItem M = new(Values.M);

    public SalesTaxExemptionsCreatePartnersRequestReasonsItem(string value)
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
    public static SalesTaxExemptionsCreatePartnersRequestReasonsItem FromCustom(string value)
    {
        return new SalesTaxExemptionsCreatePartnersRequestReasonsItem(value);
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
        SalesTaxExemptionsCreatePartnersRequestReasonsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SalesTaxExemptionsCreatePartnersRequestReasonsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SalesTaxExemptionsCreatePartnersRequestReasonsItem value
    ) => value.Value;

    public static explicit operator SalesTaxExemptionsCreatePartnersRequestReasonsItem(
        string value
    ) => new(value);

    internal class SalesTaxExemptionsCreatePartnersRequestReasonsItemSerializer
        : JsonConverter<SalesTaxExemptionsCreatePartnersRequestReasonsItem>
    {
        public override SalesTaxExemptionsCreatePartnersRequestReasonsItem Read(
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
            return new SalesTaxExemptionsCreatePartnersRequestReasonsItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SalesTaxExemptionsCreatePartnersRequestReasonsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SalesTaxExemptionsCreatePartnersRequestReasonsItem ReadAsPropertyName(
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
            return new SalesTaxExemptionsCreatePartnersRequestReasonsItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SalesTaxExemptionsCreatePartnersRequestReasonsItem value,
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
        public const string A = "A";

        public const string B = "B";

        public const string C = "C";

        public const string D = "D";

        public const string E = "E";

        public const string F = "F";

        public const string G = "G";

        public const string H = "H";

        public const string I = "I";

        public const string J = "J";

        public const string K = "K";

        public const string L = "L";

        public const string M = "M";
    }
}
