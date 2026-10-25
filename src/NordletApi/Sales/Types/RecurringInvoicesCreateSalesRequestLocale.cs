using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesCreateSalesRequestLocale.RecurringInvoicesCreateSalesRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesCreateSalesRequestLocale : IStringEnum
{
    public static readonly RecurringInvoicesCreateSalesRequestLocale En = new(Values.En);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Lt = new(Values.Lt);

    public static readonly RecurringInvoicesCreateSalesRequestLocale De = new(Values.De);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Fr = new(Values.Fr);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Es = new(Values.Es);

    public static readonly RecurringInvoicesCreateSalesRequestLocale It = new(Values.It);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Pt = new(Values.Pt);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Nl = new(Values.Nl);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Pl = new(Values.Pl);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Sv = new(Values.Sv);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Da = new(Values.Da);

    public static readonly RecurringInvoicesCreateSalesRequestLocale No = new(Values.No);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Fi = new(Values.Fi);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Et = new(Values.Et);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Lv = new(Values.Lv);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Cs = new(Values.Cs);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Sk = new(Values.Sk);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Hu = new(Values.Hu);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Ro = new(Values.Ro);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Bg = new(Values.Bg);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Hr = new(Values.Hr);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Sl = new(Values.Sl);

    public static readonly RecurringInvoicesCreateSalesRequestLocale El = new(Values.El);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Mt = new(Values.Mt);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Is = new(Values.Is);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Ga = new(Values.Ga);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Zh = new(Values.Zh);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Ja = new(Values.Ja);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Ar = new(Values.Ar);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Hi = new(Values.Hi);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Ru = new(Values.Ru);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Tr = new(Values.Tr);

    public RecurringInvoicesCreateSalesRequestLocale(string value)
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
    public static RecurringInvoicesCreateSalesRequestLocale FromCustom(string value)
    {
        return new RecurringInvoicesCreateSalesRequestLocale(value);
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
        RecurringInvoicesCreateSalesRequestLocale value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesCreateSalesRequestLocale value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecurringInvoicesCreateSalesRequestLocale value) =>
        value.Value;

    public static explicit operator RecurringInvoicesCreateSalesRequestLocale(string value) =>
        new(value);

    internal class RecurringInvoicesCreateSalesRequestLocaleSerializer
        : JsonConverter<RecurringInvoicesCreateSalesRequestLocale>
    {
        public override RecurringInvoicesCreateSalesRequestLocale Read(
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
            return new RecurringInvoicesCreateSalesRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesCreateSalesRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesCreateSalesRequestLocale ReadAsPropertyName(
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
            return new RecurringInvoicesCreateSalesRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesCreateSalesRequestLocale value,
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
