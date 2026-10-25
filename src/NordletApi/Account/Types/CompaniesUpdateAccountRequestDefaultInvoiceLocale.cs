using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesUpdateAccountRequestDefaultInvoiceLocale.CompaniesUpdateAccountRequestDefaultInvoiceLocaleSerializer)
)]
[Serializable]
public readonly record struct CompaniesUpdateAccountRequestDefaultInvoiceLocale : IStringEnum
{
    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale En = new(Values.En);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Lt = new(Values.Lt);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale De = new(Values.De);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Fr = new(Values.Fr);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Es = new(Values.Es);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale It = new(Values.It);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Pt = new(Values.Pt);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Nl = new(Values.Nl);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Pl = new(Values.Pl);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Sv = new(Values.Sv);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Da = new(Values.Da);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale No = new(Values.No);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Fi = new(Values.Fi);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Et = new(Values.Et);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Lv = new(Values.Lv);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Cs = new(Values.Cs);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Sk = new(Values.Sk);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Hu = new(Values.Hu);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Ro = new(Values.Ro);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Bg = new(Values.Bg);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Hr = new(Values.Hr);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Sl = new(Values.Sl);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale El = new(Values.El);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Mt = new(Values.Mt);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Is = new(Values.Is);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Ga = new(Values.Ga);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Zh = new(Values.Zh);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Ja = new(Values.Ja);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Ar = new(Values.Ar);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Hi = new(Values.Hi);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Ru = new(Values.Ru);

    public static readonly CompaniesUpdateAccountRequestDefaultInvoiceLocale Tr = new(Values.Tr);

    public CompaniesUpdateAccountRequestDefaultInvoiceLocale(string value)
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
    public static CompaniesUpdateAccountRequestDefaultInvoiceLocale FromCustom(string value)
    {
        return new CompaniesUpdateAccountRequestDefaultInvoiceLocale(value);
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
        CompaniesUpdateAccountRequestDefaultInvoiceLocale value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesUpdateAccountRequestDefaultInvoiceLocale value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CompaniesUpdateAccountRequestDefaultInvoiceLocale value
    ) => value.Value;

    public static explicit operator CompaniesUpdateAccountRequestDefaultInvoiceLocale(
        string value
    ) => new(value);

    internal class CompaniesUpdateAccountRequestDefaultInvoiceLocaleSerializer
        : JsonConverter<CompaniesUpdateAccountRequestDefaultInvoiceLocale>
    {
        public override CompaniesUpdateAccountRequestDefaultInvoiceLocale Read(
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
            return new CompaniesUpdateAccountRequestDefaultInvoiceLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesUpdateAccountRequestDefaultInvoiceLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesUpdateAccountRequestDefaultInvoiceLocale ReadAsPropertyName(
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
            return new CompaniesUpdateAccountRequestDefaultInvoiceLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesUpdateAccountRequestDefaultInvoiceLocale value,
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
