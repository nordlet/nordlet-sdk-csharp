using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesCreateAccountRequestDefaultInvoiceLocale.CompaniesCreateAccountRequestDefaultInvoiceLocaleSerializer)
)]
[Serializable]
public readonly record struct CompaniesCreateAccountRequestDefaultInvoiceLocale : IStringEnum
{
    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale En = new(Values.En);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Lt = new(Values.Lt);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale De = new(Values.De);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Fr = new(Values.Fr);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Es = new(Values.Es);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale It = new(Values.It);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Pt = new(Values.Pt);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Nl = new(Values.Nl);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Pl = new(Values.Pl);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Sv = new(Values.Sv);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Da = new(Values.Da);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale No = new(Values.No);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Fi = new(Values.Fi);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Et = new(Values.Et);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Lv = new(Values.Lv);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Cs = new(Values.Cs);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Sk = new(Values.Sk);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Hu = new(Values.Hu);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Ro = new(Values.Ro);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Bg = new(Values.Bg);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Hr = new(Values.Hr);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Sl = new(Values.Sl);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale El = new(Values.El);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Mt = new(Values.Mt);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Is = new(Values.Is);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Ga = new(Values.Ga);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Zh = new(Values.Zh);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Ja = new(Values.Ja);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Ar = new(Values.Ar);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Hi = new(Values.Hi);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Ru = new(Values.Ru);

    public static readonly CompaniesCreateAccountRequestDefaultInvoiceLocale Tr = new(Values.Tr);

    public CompaniesCreateAccountRequestDefaultInvoiceLocale(string value)
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
    public static CompaniesCreateAccountRequestDefaultInvoiceLocale FromCustom(string value)
    {
        return new CompaniesCreateAccountRequestDefaultInvoiceLocale(value);
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
        CompaniesCreateAccountRequestDefaultInvoiceLocale value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesCreateAccountRequestDefaultInvoiceLocale value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CompaniesCreateAccountRequestDefaultInvoiceLocale value
    ) => value.Value;

    public static explicit operator CompaniesCreateAccountRequestDefaultInvoiceLocale(
        string value
    ) => new(value);

    internal class CompaniesCreateAccountRequestDefaultInvoiceLocaleSerializer
        : JsonConverter<CompaniesCreateAccountRequestDefaultInvoiceLocale>
    {
        public override CompaniesCreateAccountRequestDefaultInvoiceLocale Read(
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
            return new CompaniesCreateAccountRequestDefaultInvoiceLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesCreateAccountRequestDefaultInvoiceLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesCreateAccountRequestDefaultInvoiceLocale ReadAsPropertyName(
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
            return new CompaniesCreateAccountRequestDefaultInvoiceLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesCreateAccountRequestDefaultInvoiceLocale value,
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
        public const string En = "en";

        public const string Lt = "lt";

        public const string De = "de";

        public const string Fr = "fr";

        public const string Es = "es";

        public const string It = "it";

        public const string Pt = "pt";

        public const string Nl = "nl";

        public const string Pl = "pl";

        public const string Sv = "sv";

        public const string Da = "da";

        public const string No = "no";

        public const string Fi = "fi";

        public const string Et = "et";

        public const string Lv = "lv";

        public const string Cs = "cs";

        public const string Sk = "sk";

        public const string Hu = "hu";

        public const string Ro = "ro";

        public const string Bg = "bg";

        public const string Hr = "hr";

        public const string Sl = "sl";

        public const string El = "el";

        public const string Mt = "mt";

        public const string Is = "is";

        public const string Ga = "ga";

        public const string Zh = "zh";

        public const string Ja = "ja";

        public const string Ar = "ar";

        public const string Hi = "hi";

        public const string Ru = "ru";

        public const string Tr = "tr";
    }
}
