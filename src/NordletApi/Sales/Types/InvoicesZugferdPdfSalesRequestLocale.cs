using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesZugferdPdfSalesRequestLocale.InvoicesZugferdPdfSalesRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct InvoicesZugferdPdfSalesRequestLocale : IStringEnum
{
    public static readonly InvoicesZugferdPdfSalesRequestLocale En = new(Values.En);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Lt = new(Values.Lt);

    public static readonly InvoicesZugferdPdfSalesRequestLocale De = new(Values.De);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Fr = new(Values.Fr);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Es = new(Values.Es);

    public static readonly InvoicesZugferdPdfSalesRequestLocale It = new(Values.It);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Pt = new(Values.Pt);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Nl = new(Values.Nl);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Pl = new(Values.Pl);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Sv = new(Values.Sv);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Da = new(Values.Da);

    public static readonly InvoicesZugferdPdfSalesRequestLocale No = new(Values.No);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Fi = new(Values.Fi);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Et = new(Values.Et);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Lv = new(Values.Lv);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Cs = new(Values.Cs);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Sk = new(Values.Sk);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Hu = new(Values.Hu);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Ro = new(Values.Ro);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Bg = new(Values.Bg);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Hr = new(Values.Hr);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Sl = new(Values.Sl);

    public static readonly InvoicesZugferdPdfSalesRequestLocale El = new(Values.El);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Mt = new(Values.Mt);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Is = new(Values.Is);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Ga = new(Values.Ga);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Zh = new(Values.Zh);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Ja = new(Values.Ja);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Ar = new(Values.Ar);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Hi = new(Values.Hi);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Ru = new(Values.Ru);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Tr = new(Values.Tr);

    public static readonly InvoicesZugferdPdfSalesRequestLocale Uk = new(Values.Uk);

    public InvoicesZugferdPdfSalesRequestLocale(string value)
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
    public static InvoicesZugferdPdfSalesRequestLocale FromCustom(string value)
    {
        return new InvoicesZugferdPdfSalesRequestLocale(value);
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

    public static bool operator ==(InvoicesZugferdPdfSalesRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesZugferdPdfSalesRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesZugferdPdfSalesRequestLocale value) =>
        value.Value;

    public static explicit operator InvoicesZugferdPdfSalesRequestLocale(string value) =>
        new(value);

    internal class InvoicesZugferdPdfSalesRequestLocaleSerializer
        : JsonConverter<InvoicesZugferdPdfSalesRequestLocale>
    {
        public override InvoicesZugferdPdfSalesRequestLocale Read(
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
            return new InvoicesZugferdPdfSalesRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesZugferdPdfSalesRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesZugferdPdfSalesRequestLocale ReadAsPropertyName(
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
            return new InvoicesZugferdPdfSalesRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesZugferdPdfSalesRequestLocale value,
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

        public const string Uk = "uk";
    }
}
