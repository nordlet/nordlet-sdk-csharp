using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(InvoicesUpdateSalesRequestLocale.InvoicesUpdateSalesRequestLocaleSerializer))]
[Serializable]
public readonly record struct InvoicesUpdateSalesRequestLocale : IStringEnum
{
    public static readonly InvoicesUpdateSalesRequestLocale En = new(Values.En);

    public static readonly InvoicesUpdateSalesRequestLocale Lt = new(Values.Lt);

    public static readonly InvoicesUpdateSalesRequestLocale De = new(Values.De);

    public static readonly InvoicesUpdateSalesRequestLocale Fr = new(Values.Fr);

    public static readonly InvoicesUpdateSalesRequestLocale Es = new(Values.Es);

    public static readonly InvoicesUpdateSalesRequestLocale It = new(Values.It);

    public static readonly InvoicesUpdateSalesRequestLocale Pt = new(Values.Pt);

    public static readonly InvoicesUpdateSalesRequestLocale Nl = new(Values.Nl);

    public static readonly InvoicesUpdateSalesRequestLocale Pl = new(Values.Pl);

    public static readonly InvoicesUpdateSalesRequestLocale Sv = new(Values.Sv);

    public static readonly InvoicesUpdateSalesRequestLocale Da = new(Values.Da);

    public static readonly InvoicesUpdateSalesRequestLocale No = new(Values.No);

    public static readonly InvoicesUpdateSalesRequestLocale Fi = new(Values.Fi);

    public static readonly InvoicesUpdateSalesRequestLocale Et = new(Values.Et);

    public static readonly InvoicesUpdateSalesRequestLocale Lv = new(Values.Lv);

    public static readonly InvoicesUpdateSalesRequestLocale Cs = new(Values.Cs);

    public static readonly InvoicesUpdateSalesRequestLocale Sk = new(Values.Sk);

    public static readonly InvoicesUpdateSalesRequestLocale Hu = new(Values.Hu);

    public static readonly InvoicesUpdateSalesRequestLocale Ro = new(Values.Ro);

    public static readonly InvoicesUpdateSalesRequestLocale Bg = new(Values.Bg);

    public static readonly InvoicesUpdateSalesRequestLocale Hr = new(Values.Hr);

    public static readonly InvoicesUpdateSalesRequestLocale Sl = new(Values.Sl);

    public static readonly InvoicesUpdateSalesRequestLocale El = new(Values.El);

    public static readonly InvoicesUpdateSalesRequestLocale Mt = new(Values.Mt);

    public static readonly InvoicesUpdateSalesRequestLocale Is = new(Values.Is);

    public static readonly InvoicesUpdateSalesRequestLocale Ga = new(Values.Ga);

    public static readonly InvoicesUpdateSalesRequestLocale Zh = new(Values.Zh);

    public static readonly InvoicesUpdateSalesRequestLocale Ja = new(Values.Ja);

    public static readonly InvoicesUpdateSalesRequestLocale Ar = new(Values.Ar);

    public static readonly InvoicesUpdateSalesRequestLocale Hi = new(Values.Hi);

    public static readonly InvoicesUpdateSalesRequestLocale Ru = new(Values.Ru);

    public static readonly InvoicesUpdateSalesRequestLocale Tr = new(Values.Tr);

    public InvoicesUpdateSalesRequestLocale(string value)
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
    public static InvoicesUpdateSalesRequestLocale FromCustom(string value)
    {
        return new InvoicesUpdateSalesRequestLocale(value);
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

    public static bool operator ==(InvoicesUpdateSalesRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesUpdateSalesRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesUpdateSalesRequestLocale value) => value.Value;

    public static explicit operator InvoicesUpdateSalesRequestLocale(string value) => new(value);

    internal class InvoicesUpdateSalesRequestLocaleSerializer
        : JsonConverter<InvoicesUpdateSalesRequestLocale>
    {
        public override InvoicesUpdateSalesRequestLocale Read(
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
            return new InvoicesUpdateSalesRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesUpdateSalesRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesUpdateSalesRequestLocale ReadAsPropertyName(
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
            return new InvoicesUpdateSalesRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesUpdateSalesRequestLocale value,
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
