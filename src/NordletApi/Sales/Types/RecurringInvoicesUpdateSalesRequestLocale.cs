using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesUpdateSalesRequestLocale.RecurringInvoicesUpdateSalesRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesUpdateSalesRequestLocale : IStringEnum
{
    public static readonly RecurringInvoicesUpdateSalesRequestLocale En = new(Values.En);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Lt = new(Values.Lt);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale De = new(Values.De);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Fr = new(Values.Fr);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Es = new(Values.Es);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale It = new(Values.It);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Pt = new(Values.Pt);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Nl = new(Values.Nl);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Pl = new(Values.Pl);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Sv = new(Values.Sv);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Da = new(Values.Da);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale No = new(Values.No);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Fi = new(Values.Fi);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Et = new(Values.Et);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Lv = new(Values.Lv);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Cs = new(Values.Cs);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Sk = new(Values.Sk);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Hu = new(Values.Hu);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Ro = new(Values.Ro);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Bg = new(Values.Bg);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Hr = new(Values.Hr);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Sl = new(Values.Sl);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale El = new(Values.El);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Mt = new(Values.Mt);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Is = new(Values.Is);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Ga = new(Values.Ga);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Zh = new(Values.Zh);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Ja = new(Values.Ja);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Ar = new(Values.Ar);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Hi = new(Values.Hi);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Ru = new(Values.Ru);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Tr = new(Values.Tr);

    public RecurringInvoicesUpdateSalesRequestLocale(string value)
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
    public static RecurringInvoicesUpdateSalesRequestLocale FromCustom(string value)
    {
        return new RecurringInvoicesUpdateSalesRequestLocale(value);
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
        RecurringInvoicesUpdateSalesRequestLocale value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesUpdateSalesRequestLocale value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecurringInvoicesUpdateSalesRequestLocale value) =>
        value.Value;

    public static explicit operator RecurringInvoicesUpdateSalesRequestLocale(string value) =>
        new(value);

    internal class RecurringInvoicesUpdateSalesRequestLocaleSerializer
        : JsonConverter<RecurringInvoicesUpdateSalesRequestLocale>
    {
        public override RecurringInvoicesUpdateSalesRequestLocale Read(
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
            return new RecurringInvoicesUpdateSalesRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesUpdateSalesRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesUpdateSalesRequestLocale ReadAsPropertyName(
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
            return new RecurringInvoicesUpdateSalesRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesUpdateSalesRequestLocale value,
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
