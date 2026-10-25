using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(InvoicesSendSalesRequestLocale.InvoicesSendSalesRequestLocaleSerializer))]
[Serializable]
public readonly record struct InvoicesSendSalesRequestLocale : IStringEnum
{
    public static readonly InvoicesSendSalesRequestLocale En = new(Values.En);

    public static readonly InvoicesSendSalesRequestLocale Lt = new(Values.Lt);

    public static readonly InvoicesSendSalesRequestLocale De = new(Values.De);

    public static readonly InvoicesSendSalesRequestLocale Fr = new(Values.Fr);

    public static readonly InvoicesSendSalesRequestLocale Es = new(Values.Es);

    public static readonly InvoicesSendSalesRequestLocale It = new(Values.It);

    public static readonly InvoicesSendSalesRequestLocale Pt = new(Values.Pt);

    public static readonly InvoicesSendSalesRequestLocale Nl = new(Values.Nl);

    public static readonly InvoicesSendSalesRequestLocale Pl = new(Values.Pl);

    public static readonly InvoicesSendSalesRequestLocale Sv = new(Values.Sv);

    public static readonly InvoicesSendSalesRequestLocale Da = new(Values.Da);

    public static readonly InvoicesSendSalesRequestLocale No = new(Values.No);

    public static readonly InvoicesSendSalesRequestLocale Fi = new(Values.Fi);

    public static readonly InvoicesSendSalesRequestLocale Et = new(Values.Et);

    public static readonly InvoicesSendSalesRequestLocale Lv = new(Values.Lv);

    public static readonly InvoicesSendSalesRequestLocale Cs = new(Values.Cs);

    public static readonly InvoicesSendSalesRequestLocale Sk = new(Values.Sk);

    public static readonly InvoicesSendSalesRequestLocale Hu = new(Values.Hu);

    public static readonly InvoicesSendSalesRequestLocale Ro = new(Values.Ro);

    public static readonly InvoicesSendSalesRequestLocale Bg = new(Values.Bg);

    public static readonly InvoicesSendSalesRequestLocale Hr = new(Values.Hr);

    public static readonly InvoicesSendSalesRequestLocale Sl = new(Values.Sl);

    public static readonly InvoicesSendSalesRequestLocale El = new(Values.El);

    public static readonly InvoicesSendSalesRequestLocale Mt = new(Values.Mt);

    public static readonly InvoicesSendSalesRequestLocale Is = new(Values.Is);

    public static readonly InvoicesSendSalesRequestLocale Ga = new(Values.Ga);

    public static readonly InvoicesSendSalesRequestLocale Zh = new(Values.Zh);

    public static readonly InvoicesSendSalesRequestLocale Ja = new(Values.Ja);

    public static readonly InvoicesSendSalesRequestLocale Ar = new(Values.Ar);

    public static readonly InvoicesSendSalesRequestLocale Hi = new(Values.Hi);

    public static readonly InvoicesSendSalesRequestLocale Ru = new(Values.Ru);

    public static readonly InvoicesSendSalesRequestLocale Tr = new(Values.Tr);

    public InvoicesSendSalesRequestLocale(string value)
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
    public static InvoicesSendSalesRequestLocale FromCustom(string value)
    {
        return new InvoicesSendSalesRequestLocale(value);
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

    public static bool operator ==(InvoicesSendSalesRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesSendSalesRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesSendSalesRequestLocale value) => value.Value;

    public static explicit operator InvoicesSendSalesRequestLocale(string value) => new(value);

    internal class InvoicesSendSalesRequestLocaleSerializer
        : JsonConverter<InvoicesSendSalesRequestLocale>
    {
        public override InvoicesSendSalesRequestLocale Read(
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
            return new InvoicesSendSalesRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesSendSalesRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesSendSalesRequestLocale ReadAsPropertyName(
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
            return new InvoicesSendSalesRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesSendSalesRequestLocale value,
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
