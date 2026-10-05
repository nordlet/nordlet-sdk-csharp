using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesCreateAccountRequestCountryCode.CompaniesCreateAccountRequestCountryCodeSerializer)
)]
[Serializable]
public readonly record struct CompaniesCreateAccountRequestCountryCode : IStringEnum
{
    public static readonly CompaniesCreateAccountRequestCountryCode At = new(Values.At);

    public static readonly CompaniesCreateAccountRequestCountryCode Be = new(Values.Be);

    public static readonly CompaniesCreateAccountRequestCountryCode Bg = new(Values.Bg);

    public static readonly CompaniesCreateAccountRequestCountryCode Cy = new(Values.Cy);

    public static readonly CompaniesCreateAccountRequestCountryCode Cz = new(Values.Cz);

    public static readonly CompaniesCreateAccountRequestCountryCode De = new(Values.De);

    public static readonly CompaniesCreateAccountRequestCountryCode Dk = new(Values.Dk);

    public static readonly CompaniesCreateAccountRequestCountryCode Ee = new(Values.Ee);

    public static readonly CompaniesCreateAccountRequestCountryCode Es = new(Values.Es);

    public static readonly CompaniesCreateAccountRequestCountryCode Fi = new(Values.Fi);

    public static readonly CompaniesCreateAccountRequestCountryCode Fr = new(Values.Fr);

    public static readonly CompaniesCreateAccountRequestCountryCode Gr = new(Values.Gr);

    public static readonly CompaniesCreateAccountRequestCountryCode Hr = new(Values.Hr);

    public static readonly CompaniesCreateAccountRequestCountryCode Hu = new(Values.Hu);

    public static readonly CompaniesCreateAccountRequestCountryCode Ie = new(Values.Ie);

    public static readonly CompaniesCreateAccountRequestCountryCode It = new(Values.It);

    public static readonly CompaniesCreateAccountRequestCountryCode Lt = new(Values.Lt);

    public static readonly CompaniesCreateAccountRequestCountryCode Lu = new(Values.Lu);

    public static readonly CompaniesCreateAccountRequestCountryCode Lv = new(Values.Lv);

    public static readonly CompaniesCreateAccountRequestCountryCode Mt = new(Values.Mt);

    public static readonly CompaniesCreateAccountRequestCountryCode Nl = new(Values.Nl);

    public static readonly CompaniesCreateAccountRequestCountryCode Pl = new(Values.Pl);

    public static readonly CompaniesCreateAccountRequestCountryCode Pt = new(Values.Pt);

    public static readonly CompaniesCreateAccountRequestCountryCode Ro = new(Values.Ro);

    public static readonly CompaniesCreateAccountRequestCountryCode Se = new(Values.Se);

    public static readonly CompaniesCreateAccountRequestCountryCode Si = new(Values.Si);

    public static readonly CompaniesCreateAccountRequestCountryCode Sk = new(Values.Sk);

    public static readonly CompaniesCreateAccountRequestCountryCode Is = new(Values.Is);

    public static readonly CompaniesCreateAccountRequestCountryCode Li = new(Values.Li);

    public static readonly CompaniesCreateAccountRequestCountryCode No = new(Values.No);

    public CompaniesCreateAccountRequestCountryCode(string value)
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
    public static CompaniesCreateAccountRequestCountryCode FromCustom(string value)
    {
        return new CompaniesCreateAccountRequestCountryCode(value);
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
        CompaniesCreateAccountRequestCountryCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesCreateAccountRequestCountryCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CompaniesCreateAccountRequestCountryCode value) =>
        value.Value;

    public static explicit operator CompaniesCreateAccountRequestCountryCode(string value) =>
        new(value);

    internal class CompaniesCreateAccountRequestCountryCodeSerializer
        : JsonConverter<CompaniesCreateAccountRequestCountryCode>
    {
        public override CompaniesCreateAccountRequestCountryCode Read(
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
            return new CompaniesCreateAccountRequestCountryCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesCreateAccountRequestCountryCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesCreateAccountRequestCountryCode ReadAsPropertyName(
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
            return new CompaniesCreateAccountRequestCountryCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesCreateAccountRequestCountryCode value,
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
        public const string At = "AT";

        public const string Be = "BE";

        public const string Bg = "BG";

        public const string Cy = "CY";

        public const string Cz = "CZ";

        public const string De = "DE";

        public const string Dk = "DK";

        public const string Ee = "EE";

        public const string Es = "ES";

        public const string Fi = "FI";

        public const string Fr = "FR";

        public const string Gr = "GR";

        public const string Hr = "HR";

        public const string Hu = "HU";

        public const string Ie = "IE";

        public const string It = "IT";

        public const string Lt = "LT";

        public const string Lu = "LU";

        public const string Lv = "LV";

        public const string Mt = "MT";

        public const string Nl = "NL";

        public const string Pl = "PL";

        public const string Pt = "PT";

        public const string Ro = "RO";

        public const string Se = "SE";

        public const string Si = "SI";

        public const string Sk = "SK";

        public const string Is = "IS";

        public const string Li = "LI";

        public const string No = "NO";
    }
}
