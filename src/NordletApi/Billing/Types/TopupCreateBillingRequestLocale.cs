using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(TopupCreateBillingRequestLocale.TopupCreateBillingRequestLocaleSerializer))]
[Serializable]
public readonly record struct TopupCreateBillingRequestLocale : IStringEnum
{
    public static readonly TopupCreateBillingRequestLocale En = new(Values.En);

    public static readonly TopupCreateBillingRequestLocale Lt = new(Values.Lt);

    public static readonly TopupCreateBillingRequestLocale De = new(Values.De);

    public static readonly TopupCreateBillingRequestLocale Fr = new(Values.Fr);

    public static readonly TopupCreateBillingRequestLocale Es = new(Values.Es);

    public static readonly TopupCreateBillingRequestLocale It = new(Values.It);

    public static readonly TopupCreateBillingRequestLocale Pt = new(Values.Pt);

    public static readonly TopupCreateBillingRequestLocale Nl = new(Values.Nl);

    public static readonly TopupCreateBillingRequestLocale Pl = new(Values.Pl);

    public static readonly TopupCreateBillingRequestLocale Sv = new(Values.Sv);

    public static readonly TopupCreateBillingRequestLocale Da = new(Values.Da);

    public static readonly TopupCreateBillingRequestLocale No = new(Values.No);

    public static readonly TopupCreateBillingRequestLocale Fi = new(Values.Fi);

    public static readonly TopupCreateBillingRequestLocale Et = new(Values.Et);

    public static readonly TopupCreateBillingRequestLocale Lv = new(Values.Lv);

    public static readonly TopupCreateBillingRequestLocale Cs = new(Values.Cs);

    public static readonly TopupCreateBillingRequestLocale Sk = new(Values.Sk);

    public static readonly TopupCreateBillingRequestLocale Hu = new(Values.Hu);

    public static readonly TopupCreateBillingRequestLocale Ro = new(Values.Ro);

    public static readonly TopupCreateBillingRequestLocale Bg = new(Values.Bg);

    public static readonly TopupCreateBillingRequestLocale Hr = new(Values.Hr);

    public static readonly TopupCreateBillingRequestLocale Sl = new(Values.Sl);

    public static readonly TopupCreateBillingRequestLocale El = new(Values.El);

    public static readonly TopupCreateBillingRequestLocale Mt = new(Values.Mt);

    public static readonly TopupCreateBillingRequestLocale Is = new(Values.Is);

    public static readonly TopupCreateBillingRequestLocale Ga = new(Values.Ga);

    public static readonly TopupCreateBillingRequestLocale Zh = new(Values.Zh);

    public static readonly TopupCreateBillingRequestLocale Ja = new(Values.Ja);

    public static readonly TopupCreateBillingRequestLocale Ar = new(Values.Ar);

    public static readonly TopupCreateBillingRequestLocale Hi = new(Values.Hi);

    public static readonly TopupCreateBillingRequestLocale Ru = new(Values.Ru);

    public static readonly TopupCreateBillingRequestLocale Tr = new(Values.Tr);

    public static readonly TopupCreateBillingRequestLocale Uk = new(Values.Uk);

    public TopupCreateBillingRequestLocale(string value)
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
    public static TopupCreateBillingRequestLocale FromCustom(string value)
    {
        return new TopupCreateBillingRequestLocale(value);
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

    public static bool operator ==(TopupCreateBillingRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TopupCreateBillingRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TopupCreateBillingRequestLocale value) => value.Value;

    public static explicit operator TopupCreateBillingRequestLocale(string value) => new(value);

    internal class TopupCreateBillingRequestLocaleSerializer
        : JsonConverter<TopupCreateBillingRequestLocale>
    {
        public override TopupCreateBillingRequestLocale Read(
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
            return new TopupCreateBillingRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TopupCreateBillingRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TopupCreateBillingRequestLocale ReadAsPropertyName(
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
            return new TopupCreateBillingRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TopupCreateBillingRequestLocale value,
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
