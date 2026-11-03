using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvitesCreateAccountRequestLocale.InvitesCreateAccountRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct InvitesCreateAccountRequestLocale : IStringEnum
{
    public static readonly InvitesCreateAccountRequestLocale En = new(Values.En);

    public static readonly InvitesCreateAccountRequestLocale Lt = new(Values.Lt);

    public static readonly InvitesCreateAccountRequestLocale De = new(Values.De);

    public static readonly InvitesCreateAccountRequestLocale Fr = new(Values.Fr);

    public static readonly InvitesCreateAccountRequestLocale Es = new(Values.Es);

    public static readonly InvitesCreateAccountRequestLocale It = new(Values.It);

    public static readonly InvitesCreateAccountRequestLocale Pt = new(Values.Pt);

    public static readonly InvitesCreateAccountRequestLocale Nl = new(Values.Nl);

    public static readonly InvitesCreateAccountRequestLocale Pl = new(Values.Pl);

    public static readonly InvitesCreateAccountRequestLocale Sv = new(Values.Sv);

    public static readonly InvitesCreateAccountRequestLocale Da = new(Values.Da);

    public static readonly InvitesCreateAccountRequestLocale No = new(Values.No);

    public static readonly InvitesCreateAccountRequestLocale Fi = new(Values.Fi);

    public static readonly InvitesCreateAccountRequestLocale Et = new(Values.Et);

    public static readonly InvitesCreateAccountRequestLocale Lv = new(Values.Lv);

    public static readonly InvitesCreateAccountRequestLocale Cs = new(Values.Cs);

    public static readonly InvitesCreateAccountRequestLocale Sk = new(Values.Sk);

    public static readonly InvitesCreateAccountRequestLocale Hu = new(Values.Hu);

    public static readonly InvitesCreateAccountRequestLocale Ro = new(Values.Ro);

    public static readonly InvitesCreateAccountRequestLocale Bg = new(Values.Bg);

    public static readonly InvitesCreateAccountRequestLocale Hr = new(Values.Hr);

    public static readonly InvitesCreateAccountRequestLocale Sl = new(Values.Sl);

    public static readonly InvitesCreateAccountRequestLocale El = new(Values.El);

    public static readonly InvitesCreateAccountRequestLocale Mt = new(Values.Mt);

    public static readonly InvitesCreateAccountRequestLocale Is = new(Values.Is);

    public static readonly InvitesCreateAccountRequestLocale Ga = new(Values.Ga);

    public static readonly InvitesCreateAccountRequestLocale Zh = new(Values.Zh);

    public static readonly InvitesCreateAccountRequestLocale Ja = new(Values.Ja);

    public static readonly InvitesCreateAccountRequestLocale Ar = new(Values.Ar);

    public static readonly InvitesCreateAccountRequestLocale Hi = new(Values.Hi);

    public static readonly InvitesCreateAccountRequestLocale Ru = new(Values.Ru);

    public static readonly InvitesCreateAccountRequestLocale Tr = new(Values.Tr);

    public static readonly InvitesCreateAccountRequestLocale Uk = new(Values.Uk);

    public InvitesCreateAccountRequestLocale(string value)
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
    public static InvitesCreateAccountRequestLocale FromCustom(string value)
    {
        return new InvitesCreateAccountRequestLocale(value);
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

    public static bool operator ==(InvitesCreateAccountRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvitesCreateAccountRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvitesCreateAccountRequestLocale value) => value.Value;

    public static explicit operator InvitesCreateAccountRequestLocale(string value) => new(value);

    internal class InvitesCreateAccountRequestLocaleSerializer
        : JsonConverter<InvitesCreateAccountRequestLocale>
    {
        public override InvitesCreateAccountRequestLocale Read(
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
            return new InvitesCreateAccountRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvitesCreateAccountRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvitesCreateAccountRequestLocale ReadAsPropertyName(
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
            return new InvitesCreateAccountRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvitesCreateAccountRequestLocale value,
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
