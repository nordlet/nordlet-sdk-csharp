using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(InvoicesPdfSalesRequestLocale.InvoicesPdfSalesRequestLocaleSerializer))]
[Serializable]
public readonly record struct InvoicesPdfSalesRequestLocale : IStringEnum
{
    public static readonly InvoicesPdfSalesRequestLocale En = new(Values.En);

    public static readonly InvoicesPdfSalesRequestLocale Lt = new(Values.Lt);

    public static readonly InvoicesPdfSalesRequestLocale De = new(Values.De);

    public static readonly InvoicesPdfSalesRequestLocale Fr = new(Values.Fr);

    public static readonly InvoicesPdfSalesRequestLocale Es = new(Values.Es);

    public static readonly InvoicesPdfSalesRequestLocale It = new(Values.It);

    public static readonly InvoicesPdfSalesRequestLocale Pt = new(Values.Pt);

    public static readonly InvoicesPdfSalesRequestLocale Nl = new(Values.Nl);

    public static readonly InvoicesPdfSalesRequestLocale Pl = new(Values.Pl);

    public static readonly InvoicesPdfSalesRequestLocale Sv = new(Values.Sv);

    public static readonly InvoicesPdfSalesRequestLocale Da = new(Values.Da);

    public static readonly InvoicesPdfSalesRequestLocale No = new(Values.No);

    public static readonly InvoicesPdfSalesRequestLocale Fi = new(Values.Fi);

    public static readonly InvoicesPdfSalesRequestLocale Et = new(Values.Et);

    public static readonly InvoicesPdfSalesRequestLocale Lv = new(Values.Lv);

    public static readonly InvoicesPdfSalesRequestLocale Cs = new(Values.Cs);

    public static readonly InvoicesPdfSalesRequestLocale Sk = new(Values.Sk);

    public static readonly InvoicesPdfSalesRequestLocale Hu = new(Values.Hu);

    public static readonly InvoicesPdfSalesRequestLocale Ro = new(Values.Ro);

    public static readonly InvoicesPdfSalesRequestLocale Bg = new(Values.Bg);

    public static readonly InvoicesPdfSalesRequestLocale Hr = new(Values.Hr);

    public static readonly InvoicesPdfSalesRequestLocale Sl = new(Values.Sl);

    public static readonly InvoicesPdfSalesRequestLocale El = new(Values.El);

    public static readonly InvoicesPdfSalesRequestLocale Mt = new(Values.Mt);

    public static readonly InvoicesPdfSalesRequestLocale Is = new(Values.Is);

    public static readonly InvoicesPdfSalesRequestLocale Ga = new(Values.Ga);

    public static readonly InvoicesPdfSalesRequestLocale Zh = new(Values.Zh);

    public static readonly InvoicesPdfSalesRequestLocale Ja = new(Values.Ja);

    public static readonly InvoicesPdfSalesRequestLocale Ar = new(Values.Ar);

    public static readonly InvoicesPdfSalesRequestLocale Hi = new(Values.Hi);

    public static readonly InvoicesPdfSalesRequestLocale Ru = new(Values.Ru);

    public static readonly InvoicesPdfSalesRequestLocale Tr = new(Values.Tr);

    public InvoicesPdfSalesRequestLocale(string value)
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
    public static InvoicesPdfSalesRequestLocale FromCustom(string value)
    {
        return new InvoicesPdfSalesRequestLocale(value);
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

    public static bool operator ==(InvoicesPdfSalesRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesPdfSalesRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesPdfSalesRequestLocale value) => value.Value;

    public static explicit operator InvoicesPdfSalesRequestLocale(string value) => new(value);

    internal class InvoicesPdfSalesRequestLocaleSerializer
        : JsonConverter<InvoicesPdfSalesRequestLocale>
    {
        public override InvoicesPdfSalesRequestLocale Read(
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
            return new InvoicesPdfSalesRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesPdfSalesRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesPdfSalesRequestLocale ReadAsPropertyName(
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
            return new InvoicesPdfSalesRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesPdfSalesRequestLocale value,
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
