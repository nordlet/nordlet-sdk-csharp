using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(LocaleSetAccountRequestLocale.LocaleSetAccountRequestLocaleSerializer))]
[Serializable]
public readonly record struct LocaleSetAccountRequestLocale : IStringEnum
{
    public static readonly LocaleSetAccountRequestLocale En = new(Values.En);

    public static readonly LocaleSetAccountRequestLocale Lt = new(Values.Lt);

    public static readonly LocaleSetAccountRequestLocale De = new(Values.De);

    public static readonly LocaleSetAccountRequestLocale Fr = new(Values.Fr);

    public static readonly LocaleSetAccountRequestLocale Es = new(Values.Es);

    public static readonly LocaleSetAccountRequestLocale It = new(Values.It);

    public static readonly LocaleSetAccountRequestLocale Pt = new(Values.Pt);

    public static readonly LocaleSetAccountRequestLocale Nl = new(Values.Nl);

    public static readonly LocaleSetAccountRequestLocale Pl = new(Values.Pl);

    public static readonly LocaleSetAccountRequestLocale Sv = new(Values.Sv);

    public static readonly LocaleSetAccountRequestLocale Da = new(Values.Da);

    public static readonly LocaleSetAccountRequestLocale No = new(Values.No);

    public static readonly LocaleSetAccountRequestLocale Fi = new(Values.Fi);

    public static readonly LocaleSetAccountRequestLocale Et = new(Values.Et);

    public static readonly LocaleSetAccountRequestLocale Lv = new(Values.Lv);

    public static readonly LocaleSetAccountRequestLocale Cs = new(Values.Cs);

    public static readonly LocaleSetAccountRequestLocale Sk = new(Values.Sk);

    public static readonly LocaleSetAccountRequestLocale Hu = new(Values.Hu);

    public static readonly LocaleSetAccountRequestLocale Ro = new(Values.Ro);

    public static readonly LocaleSetAccountRequestLocale Bg = new(Values.Bg);

    public static readonly LocaleSetAccountRequestLocale Hr = new(Values.Hr);

    public static readonly LocaleSetAccountRequestLocale Sl = new(Values.Sl);

    public static readonly LocaleSetAccountRequestLocale El = new(Values.El);

    public static readonly LocaleSetAccountRequestLocale Mt = new(Values.Mt);

    public static readonly LocaleSetAccountRequestLocale Is = new(Values.Is);

    public static readonly LocaleSetAccountRequestLocale Ga = new(Values.Ga);

    public static readonly LocaleSetAccountRequestLocale Zh = new(Values.Zh);

    public static readonly LocaleSetAccountRequestLocale Ja = new(Values.Ja);

    public static readonly LocaleSetAccountRequestLocale Ar = new(Values.Ar);

    public static readonly LocaleSetAccountRequestLocale Hi = new(Values.Hi);

    public static readonly LocaleSetAccountRequestLocale Ru = new(Values.Ru);

    public static readonly LocaleSetAccountRequestLocale Tr = new(Values.Tr);

    public static readonly LocaleSetAccountRequestLocale Uk = new(Values.Uk);

    public LocaleSetAccountRequestLocale(string value)
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
    public static LocaleSetAccountRequestLocale FromCustom(string value)
    {
        return new LocaleSetAccountRequestLocale(value);
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

    public static bool operator ==(LocaleSetAccountRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LocaleSetAccountRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LocaleSetAccountRequestLocale value) => value.Value;

    public static explicit operator LocaleSetAccountRequestLocale(string value) => new(value);

    internal class LocaleSetAccountRequestLocaleSerializer
        : JsonConverter<LocaleSetAccountRequestLocale>
    {
        public override LocaleSetAccountRequestLocale Read(
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
            return new LocaleSetAccountRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LocaleSetAccountRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LocaleSetAccountRequestLocale ReadAsPropertyName(
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
            return new LocaleSetAccountRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LocaleSetAccountRequestLocale value,
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
