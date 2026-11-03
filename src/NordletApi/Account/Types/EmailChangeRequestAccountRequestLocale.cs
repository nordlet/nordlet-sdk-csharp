using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EmailChangeRequestAccountRequestLocale.EmailChangeRequestAccountRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct EmailChangeRequestAccountRequestLocale : IStringEnum
{
    public static readonly EmailChangeRequestAccountRequestLocale En = new(Values.En);

    public static readonly EmailChangeRequestAccountRequestLocale Lt = new(Values.Lt);

    public static readonly EmailChangeRequestAccountRequestLocale De = new(Values.De);

    public static readonly EmailChangeRequestAccountRequestLocale Fr = new(Values.Fr);

    public static readonly EmailChangeRequestAccountRequestLocale Es = new(Values.Es);

    public static readonly EmailChangeRequestAccountRequestLocale It = new(Values.It);

    public static readonly EmailChangeRequestAccountRequestLocale Pt = new(Values.Pt);

    public static readonly EmailChangeRequestAccountRequestLocale Nl = new(Values.Nl);

    public static readonly EmailChangeRequestAccountRequestLocale Pl = new(Values.Pl);

    public static readonly EmailChangeRequestAccountRequestLocale Sv = new(Values.Sv);

    public static readonly EmailChangeRequestAccountRequestLocale Da = new(Values.Da);

    public static readonly EmailChangeRequestAccountRequestLocale No = new(Values.No);

    public static readonly EmailChangeRequestAccountRequestLocale Fi = new(Values.Fi);

    public static readonly EmailChangeRequestAccountRequestLocale Et = new(Values.Et);

    public static readonly EmailChangeRequestAccountRequestLocale Lv = new(Values.Lv);

    public static readonly EmailChangeRequestAccountRequestLocale Cs = new(Values.Cs);

    public static readonly EmailChangeRequestAccountRequestLocale Sk = new(Values.Sk);

    public static readonly EmailChangeRequestAccountRequestLocale Hu = new(Values.Hu);

    public static readonly EmailChangeRequestAccountRequestLocale Ro = new(Values.Ro);

    public static readonly EmailChangeRequestAccountRequestLocale Bg = new(Values.Bg);

    public static readonly EmailChangeRequestAccountRequestLocale Hr = new(Values.Hr);

    public static readonly EmailChangeRequestAccountRequestLocale Sl = new(Values.Sl);

    public static readonly EmailChangeRequestAccountRequestLocale El = new(Values.El);

    public static readonly EmailChangeRequestAccountRequestLocale Mt = new(Values.Mt);

    public static readonly EmailChangeRequestAccountRequestLocale Is = new(Values.Is);

    public static readonly EmailChangeRequestAccountRequestLocale Ga = new(Values.Ga);

    public static readonly EmailChangeRequestAccountRequestLocale Zh = new(Values.Zh);

    public static readonly EmailChangeRequestAccountRequestLocale Ja = new(Values.Ja);

    public static readonly EmailChangeRequestAccountRequestLocale Ar = new(Values.Ar);

    public static readonly EmailChangeRequestAccountRequestLocale Hi = new(Values.Hi);

    public static readonly EmailChangeRequestAccountRequestLocale Ru = new(Values.Ru);

    public static readonly EmailChangeRequestAccountRequestLocale Tr = new(Values.Tr);

    public static readonly EmailChangeRequestAccountRequestLocale Uk = new(Values.Uk);

    public EmailChangeRequestAccountRequestLocale(string value)
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
    public static EmailChangeRequestAccountRequestLocale FromCustom(string value)
    {
        return new EmailChangeRequestAccountRequestLocale(value);
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

    public static bool operator ==(EmailChangeRequestAccountRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmailChangeRequestAccountRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmailChangeRequestAccountRequestLocale value) =>
        value.Value;

    public static explicit operator EmailChangeRequestAccountRequestLocale(string value) =>
        new(value);

    internal class EmailChangeRequestAccountRequestLocaleSerializer
        : JsonConverter<EmailChangeRequestAccountRequestLocale>
    {
        public override EmailChangeRequestAccountRequestLocale Read(
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
            return new EmailChangeRequestAccountRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmailChangeRequestAccountRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmailChangeRequestAccountRequestLocale ReadAsPropertyName(
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
            return new EmailChangeRequestAccountRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmailChangeRequestAccountRequestLocale value,
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
