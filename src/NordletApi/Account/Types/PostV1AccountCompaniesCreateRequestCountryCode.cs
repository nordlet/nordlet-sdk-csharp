using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AccountCompaniesCreateRequestCountryCode.PostV1AccountCompaniesCreateRequestCountryCodeSerializer)
)]
[Serializable]
public readonly record struct PostV1AccountCompaniesCreateRequestCountryCode : IStringEnum
{
    public static readonly PostV1AccountCompaniesCreateRequestCountryCode At = new(Values.At);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Be = new(Values.Be);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Bg = new(Values.Bg);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Cy = new(Values.Cy);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Cz = new(Values.Cz);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode De = new(Values.De);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Dk = new(Values.Dk);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Ee = new(Values.Ee);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Es = new(Values.Es);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Fi = new(Values.Fi);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Fr = new(Values.Fr);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Gr = new(Values.Gr);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Hr = new(Values.Hr);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Hu = new(Values.Hu);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Ie = new(Values.Ie);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode It = new(Values.It);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Lt = new(Values.Lt);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Lu = new(Values.Lu);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Lv = new(Values.Lv);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Mt = new(Values.Mt);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Nl = new(Values.Nl);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Pl = new(Values.Pl);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Pt = new(Values.Pt);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Ro = new(Values.Ro);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Se = new(Values.Se);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Si = new(Values.Si);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Sk = new(Values.Sk);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Is = new(Values.Is);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode Li = new(Values.Li);

    public static readonly PostV1AccountCompaniesCreateRequestCountryCode No = new(Values.No);

    public PostV1AccountCompaniesCreateRequestCountryCode(string value)
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
    public static PostV1AccountCompaniesCreateRequestCountryCode FromCustom(string value)
    {
        return new PostV1AccountCompaniesCreateRequestCountryCode(value);
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
        PostV1AccountCompaniesCreateRequestCountryCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AccountCompaniesCreateRequestCountryCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AccountCompaniesCreateRequestCountryCode value) =>
        value.Value;

    public static explicit operator PostV1AccountCompaniesCreateRequestCountryCode(string value) =>
        new(value);

    internal class PostV1AccountCompaniesCreateRequestCountryCodeSerializer
        : JsonConverter<PostV1AccountCompaniesCreateRequestCountryCode>
    {
        public override PostV1AccountCompaniesCreateRequestCountryCode Read(
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
            return new PostV1AccountCompaniesCreateRequestCountryCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AccountCompaniesCreateRequestCountryCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AccountCompaniesCreateRequestCountryCode ReadAsPropertyName(
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
            return new PostV1AccountCompaniesCreateRequestCountryCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AccountCompaniesCreateRequestCountryCode value,
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
