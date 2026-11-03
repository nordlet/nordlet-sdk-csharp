using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ActsPdfSalesRequestLocale.ActsPdfSalesRequestLocaleSerializer))]
[Serializable]
public readonly record struct ActsPdfSalesRequestLocale : IStringEnum
{
    public static readonly ActsPdfSalesRequestLocale En = new(Values.En);

    public static readonly ActsPdfSalesRequestLocale Lt = new(Values.Lt);

    public static readonly ActsPdfSalesRequestLocale De = new(Values.De);

    public static readonly ActsPdfSalesRequestLocale Fr = new(Values.Fr);

    public static readonly ActsPdfSalesRequestLocale Es = new(Values.Es);

    public static readonly ActsPdfSalesRequestLocale It = new(Values.It);

    public static readonly ActsPdfSalesRequestLocale Pt = new(Values.Pt);

    public static readonly ActsPdfSalesRequestLocale Nl = new(Values.Nl);

    public static readonly ActsPdfSalesRequestLocale Pl = new(Values.Pl);

    public static readonly ActsPdfSalesRequestLocale Sv = new(Values.Sv);

    public static readonly ActsPdfSalesRequestLocale Da = new(Values.Da);

    public static readonly ActsPdfSalesRequestLocale No = new(Values.No);

    public static readonly ActsPdfSalesRequestLocale Fi = new(Values.Fi);

    public static readonly ActsPdfSalesRequestLocale Et = new(Values.Et);

    public static readonly ActsPdfSalesRequestLocale Lv = new(Values.Lv);

    public static readonly ActsPdfSalesRequestLocale Cs = new(Values.Cs);

    public static readonly ActsPdfSalesRequestLocale Sk = new(Values.Sk);

    public static readonly ActsPdfSalesRequestLocale Hu = new(Values.Hu);

    public static readonly ActsPdfSalesRequestLocale Ro = new(Values.Ro);

    public static readonly ActsPdfSalesRequestLocale Bg = new(Values.Bg);

    public static readonly ActsPdfSalesRequestLocale Hr = new(Values.Hr);

    public static readonly ActsPdfSalesRequestLocale Sl = new(Values.Sl);

    public static readonly ActsPdfSalesRequestLocale El = new(Values.El);

    public static readonly ActsPdfSalesRequestLocale Mt = new(Values.Mt);

    public static readonly ActsPdfSalesRequestLocale Is = new(Values.Is);

    public static readonly ActsPdfSalesRequestLocale Ga = new(Values.Ga);

    public static readonly ActsPdfSalesRequestLocale Zh = new(Values.Zh);

    public static readonly ActsPdfSalesRequestLocale Ja = new(Values.Ja);

    public static readonly ActsPdfSalesRequestLocale Ar = new(Values.Ar);

    public static readonly ActsPdfSalesRequestLocale Hi = new(Values.Hi);

    public static readonly ActsPdfSalesRequestLocale Ru = new(Values.Ru);

    public static readonly ActsPdfSalesRequestLocale Tr = new(Values.Tr);

    public static readonly ActsPdfSalesRequestLocale Uk = new(Values.Uk);

    public ActsPdfSalesRequestLocale(string value)
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
    public static ActsPdfSalesRequestLocale FromCustom(string value)
    {
        return new ActsPdfSalesRequestLocale(value);
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

    public static bool operator ==(ActsPdfSalesRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ActsPdfSalesRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ActsPdfSalesRequestLocale value) => value.Value;

    public static explicit operator ActsPdfSalesRequestLocale(string value) => new(value);

    internal class ActsPdfSalesRequestLocaleSerializer : JsonConverter<ActsPdfSalesRequestLocale>
    {
        public override ActsPdfSalesRequestLocale Read(
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
            return new ActsPdfSalesRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ActsPdfSalesRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ActsPdfSalesRequestLocale ReadAsPropertyName(
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
            return new ActsPdfSalesRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ActsPdfSalesRequestLocale value,
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
