using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(InvoicesCreateSalesRequestLocale.InvoicesCreateSalesRequestLocaleSerializer))]
[Serializable]
public readonly record struct InvoicesCreateSalesRequestLocale : IStringEnum
{
    public static readonly InvoicesCreateSalesRequestLocale En = new(Values.En);

    public static readonly InvoicesCreateSalesRequestLocale Lt = new(Values.Lt);

    public static readonly InvoicesCreateSalesRequestLocale De = new(Values.De);

    public static readonly InvoicesCreateSalesRequestLocale Fr = new(Values.Fr);

    public static readonly InvoicesCreateSalesRequestLocale Es = new(Values.Es);

    public static readonly InvoicesCreateSalesRequestLocale It = new(Values.It);

    public static readonly InvoicesCreateSalesRequestLocale Pt = new(Values.Pt);

    public static readonly InvoicesCreateSalesRequestLocale Nl = new(Values.Nl);

    public static readonly InvoicesCreateSalesRequestLocale Pl = new(Values.Pl);

    public static readonly InvoicesCreateSalesRequestLocale Sv = new(Values.Sv);

    public static readonly InvoicesCreateSalesRequestLocale Da = new(Values.Da);

    public static readonly InvoicesCreateSalesRequestLocale No = new(Values.No);

    public static readonly InvoicesCreateSalesRequestLocale Fi = new(Values.Fi);

    public static readonly InvoicesCreateSalesRequestLocale Et = new(Values.Et);

    public static readonly InvoicesCreateSalesRequestLocale Lv = new(Values.Lv);

    public static readonly InvoicesCreateSalesRequestLocale Cs = new(Values.Cs);

    public static readonly InvoicesCreateSalesRequestLocale Sk = new(Values.Sk);

    public static readonly InvoicesCreateSalesRequestLocale Hu = new(Values.Hu);

    public static readonly InvoicesCreateSalesRequestLocale Ro = new(Values.Ro);

    public static readonly InvoicesCreateSalesRequestLocale Bg = new(Values.Bg);

    public static readonly InvoicesCreateSalesRequestLocale Hr = new(Values.Hr);

    public static readonly InvoicesCreateSalesRequestLocale Sl = new(Values.Sl);

    public static readonly InvoicesCreateSalesRequestLocale El = new(Values.El);

    public static readonly InvoicesCreateSalesRequestLocale Mt = new(Values.Mt);

    public static readonly InvoicesCreateSalesRequestLocale Is = new(Values.Is);

    public static readonly InvoicesCreateSalesRequestLocale Ga = new(Values.Ga);

    public static readonly InvoicesCreateSalesRequestLocale Zh = new(Values.Zh);

    public static readonly InvoicesCreateSalesRequestLocale Ja = new(Values.Ja);

    public static readonly InvoicesCreateSalesRequestLocale Ar = new(Values.Ar);

    public static readonly InvoicesCreateSalesRequestLocale Hi = new(Values.Hi);

    public static readonly InvoicesCreateSalesRequestLocale Ru = new(Values.Ru);

    public static readonly InvoicesCreateSalesRequestLocale Tr = new(Values.Tr);

    public InvoicesCreateSalesRequestLocale(string value)
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
    public static InvoicesCreateSalesRequestLocale FromCustom(string value)
    {
        return new InvoicesCreateSalesRequestLocale(value);
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

    public static bool operator ==(InvoicesCreateSalesRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesCreateSalesRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesCreateSalesRequestLocale value) => value.Value;

    public static explicit operator InvoicesCreateSalesRequestLocale(string value) => new(value);

    internal class InvoicesCreateSalesRequestLocaleSerializer
        : JsonConverter<InvoicesCreateSalesRequestLocale>
    {
        public override InvoicesCreateSalesRequestLocale Read(
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
            return new InvoicesCreateSalesRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesCreateSalesRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesCreateSalesRequestLocale ReadAsPropertyName(
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
            return new InvoicesCreateSalesRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesCreateSalesRequestLocale value,
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
