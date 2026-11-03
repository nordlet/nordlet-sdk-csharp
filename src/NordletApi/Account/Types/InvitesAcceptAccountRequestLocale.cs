using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvitesAcceptAccountRequestLocale.InvitesAcceptAccountRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct InvitesAcceptAccountRequestLocale : IStringEnum
{
    public static readonly InvitesAcceptAccountRequestLocale En = new(Values.En);

    public static readonly InvitesAcceptAccountRequestLocale Lt = new(Values.Lt);

    public static readonly InvitesAcceptAccountRequestLocale De = new(Values.De);

    public static readonly InvitesAcceptAccountRequestLocale Fr = new(Values.Fr);

    public static readonly InvitesAcceptAccountRequestLocale Es = new(Values.Es);

    public static readonly InvitesAcceptAccountRequestLocale It = new(Values.It);

    public static readonly InvitesAcceptAccountRequestLocale Pt = new(Values.Pt);

    public static readonly InvitesAcceptAccountRequestLocale Nl = new(Values.Nl);

    public static readonly InvitesAcceptAccountRequestLocale Pl = new(Values.Pl);

    public static readonly InvitesAcceptAccountRequestLocale Sv = new(Values.Sv);

    public static readonly InvitesAcceptAccountRequestLocale Da = new(Values.Da);

    public static readonly InvitesAcceptAccountRequestLocale No = new(Values.No);

    public static readonly InvitesAcceptAccountRequestLocale Fi = new(Values.Fi);

    public static readonly InvitesAcceptAccountRequestLocale Et = new(Values.Et);

    public static readonly InvitesAcceptAccountRequestLocale Lv = new(Values.Lv);

    public static readonly InvitesAcceptAccountRequestLocale Cs = new(Values.Cs);

    public static readonly InvitesAcceptAccountRequestLocale Sk = new(Values.Sk);

    public static readonly InvitesAcceptAccountRequestLocale Hu = new(Values.Hu);

    public static readonly InvitesAcceptAccountRequestLocale Ro = new(Values.Ro);

    public static readonly InvitesAcceptAccountRequestLocale Bg = new(Values.Bg);

    public static readonly InvitesAcceptAccountRequestLocale Hr = new(Values.Hr);

    public static readonly InvitesAcceptAccountRequestLocale Sl = new(Values.Sl);

    public static readonly InvitesAcceptAccountRequestLocale El = new(Values.El);

    public static readonly InvitesAcceptAccountRequestLocale Mt = new(Values.Mt);

    public static readonly InvitesAcceptAccountRequestLocale Is = new(Values.Is);

    public static readonly InvitesAcceptAccountRequestLocale Ga = new(Values.Ga);

    public static readonly InvitesAcceptAccountRequestLocale Zh = new(Values.Zh);

    public static readonly InvitesAcceptAccountRequestLocale Ja = new(Values.Ja);

    public static readonly InvitesAcceptAccountRequestLocale Ar = new(Values.Ar);

    public static readonly InvitesAcceptAccountRequestLocale Hi = new(Values.Hi);

    public static readonly InvitesAcceptAccountRequestLocale Ru = new(Values.Ru);

    public static readonly InvitesAcceptAccountRequestLocale Tr = new(Values.Tr);

    public static readonly InvitesAcceptAccountRequestLocale Uk = new(Values.Uk);

    public InvitesAcceptAccountRequestLocale(string value)
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
    public static InvitesAcceptAccountRequestLocale FromCustom(string value)
    {
        return new InvitesAcceptAccountRequestLocale(value);
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

    public static bool operator ==(InvitesAcceptAccountRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvitesAcceptAccountRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvitesAcceptAccountRequestLocale value) => value.Value;

    public static explicit operator InvitesAcceptAccountRequestLocale(string value) => new(value);

    internal class InvitesAcceptAccountRequestLocaleSerializer
        : JsonConverter<InvitesAcceptAccountRequestLocale>
    {
        public override InvitesAcceptAccountRequestLocale Read(
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
            return new InvitesAcceptAccountRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvitesAcceptAccountRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvitesAcceptAccountRequestLocale ReadAsPropertyName(
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
            return new InvitesAcceptAccountRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvitesAcceptAccountRequestLocale value,
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
