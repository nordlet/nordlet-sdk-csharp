using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LoginLinkRequestAccountRequestLocale.LoginLinkRequestAccountRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct LoginLinkRequestAccountRequestLocale : IStringEnum
{
    public static readonly LoginLinkRequestAccountRequestLocale En = new(Values.En);

    public static readonly LoginLinkRequestAccountRequestLocale Lt = new(Values.Lt);

    public static readonly LoginLinkRequestAccountRequestLocale De = new(Values.De);

    public static readonly LoginLinkRequestAccountRequestLocale Fr = new(Values.Fr);

    public static readonly LoginLinkRequestAccountRequestLocale Es = new(Values.Es);

    public static readonly LoginLinkRequestAccountRequestLocale It = new(Values.It);

    public static readonly LoginLinkRequestAccountRequestLocale Pt = new(Values.Pt);

    public static readonly LoginLinkRequestAccountRequestLocale Nl = new(Values.Nl);

    public static readonly LoginLinkRequestAccountRequestLocale Pl = new(Values.Pl);

    public static readonly LoginLinkRequestAccountRequestLocale Sv = new(Values.Sv);

    public static readonly LoginLinkRequestAccountRequestLocale Da = new(Values.Da);

    public static readonly LoginLinkRequestAccountRequestLocale No = new(Values.No);

    public static readonly LoginLinkRequestAccountRequestLocale Fi = new(Values.Fi);

    public static readonly LoginLinkRequestAccountRequestLocale Et = new(Values.Et);

    public static readonly LoginLinkRequestAccountRequestLocale Lv = new(Values.Lv);

    public static readonly LoginLinkRequestAccountRequestLocale Cs = new(Values.Cs);

    public static readonly LoginLinkRequestAccountRequestLocale Sk = new(Values.Sk);

    public static readonly LoginLinkRequestAccountRequestLocale Hu = new(Values.Hu);

    public static readonly LoginLinkRequestAccountRequestLocale Ro = new(Values.Ro);

    public static readonly LoginLinkRequestAccountRequestLocale Bg = new(Values.Bg);

    public static readonly LoginLinkRequestAccountRequestLocale Hr = new(Values.Hr);

    public static readonly LoginLinkRequestAccountRequestLocale Sl = new(Values.Sl);

    public static readonly LoginLinkRequestAccountRequestLocale El = new(Values.El);

    public static readonly LoginLinkRequestAccountRequestLocale Mt = new(Values.Mt);

    public static readonly LoginLinkRequestAccountRequestLocale Is = new(Values.Is);

    public static readonly LoginLinkRequestAccountRequestLocale Ga = new(Values.Ga);

    public static readonly LoginLinkRequestAccountRequestLocale Zh = new(Values.Zh);

    public static readonly LoginLinkRequestAccountRequestLocale Ja = new(Values.Ja);

    public static readonly LoginLinkRequestAccountRequestLocale Ar = new(Values.Ar);

    public static readonly LoginLinkRequestAccountRequestLocale Hi = new(Values.Hi);

    public static readonly LoginLinkRequestAccountRequestLocale Ru = new(Values.Ru);

    public static readonly LoginLinkRequestAccountRequestLocale Tr = new(Values.Tr);

    public static readonly LoginLinkRequestAccountRequestLocale Uk = new(Values.Uk);

    public LoginLinkRequestAccountRequestLocale(string value)
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
    public static LoginLinkRequestAccountRequestLocale FromCustom(string value)
    {
        return new LoginLinkRequestAccountRequestLocale(value);
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

    public static bool operator ==(LoginLinkRequestAccountRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LoginLinkRequestAccountRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LoginLinkRequestAccountRequestLocale value) =>
        value.Value;

    public static explicit operator LoginLinkRequestAccountRequestLocale(string value) =>
        new(value);

    internal class LoginLinkRequestAccountRequestLocaleSerializer
        : JsonConverter<LoginLinkRequestAccountRequestLocale>
    {
        public override LoginLinkRequestAccountRequestLocale Read(
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
            return new LoginLinkRequestAccountRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LoginLinkRequestAccountRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LoginLinkRequestAccountRequestLocale ReadAsPropertyName(
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
            return new LoginLinkRequestAccountRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LoginLinkRequestAccountRequestLocale value,
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
