using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(UnitsOptionsCatalogRequestLocale.UnitsOptionsCatalogRequestLocaleSerializer))]
[Serializable]
public readonly record struct UnitsOptionsCatalogRequestLocale : IStringEnum
{
    public static readonly UnitsOptionsCatalogRequestLocale En = new(Values.En);

    public static readonly UnitsOptionsCatalogRequestLocale Lt = new(Values.Lt);

    public static readonly UnitsOptionsCatalogRequestLocale De = new(Values.De);

    public static readonly UnitsOptionsCatalogRequestLocale Fr = new(Values.Fr);

    public static readonly UnitsOptionsCatalogRequestLocale Es = new(Values.Es);

    public static readonly UnitsOptionsCatalogRequestLocale It = new(Values.It);

    public static readonly UnitsOptionsCatalogRequestLocale Pt = new(Values.Pt);

    public static readonly UnitsOptionsCatalogRequestLocale Nl = new(Values.Nl);

    public static readonly UnitsOptionsCatalogRequestLocale Pl = new(Values.Pl);

    public static readonly UnitsOptionsCatalogRequestLocale Sv = new(Values.Sv);

    public static readonly UnitsOptionsCatalogRequestLocale Da = new(Values.Da);

    public static readonly UnitsOptionsCatalogRequestLocale No = new(Values.No);

    public static readonly UnitsOptionsCatalogRequestLocale Fi = new(Values.Fi);

    public static readonly UnitsOptionsCatalogRequestLocale Et = new(Values.Et);

    public static readonly UnitsOptionsCatalogRequestLocale Lv = new(Values.Lv);

    public static readonly UnitsOptionsCatalogRequestLocale Cs = new(Values.Cs);

    public static readonly UnitsOptionsCatalogRequestLocale Sk = new(Values.Sk);

    public static readonly UnitsOptionsCatalogRequestLocale Hu = new(Values.Hu);

    public static readonly UnitsOptionsCatalogRequestLocale Ro = new(Values.Ro);

    public static readonly UnitsOptionsCatalogRequestLocale Bg = new(Values.Bg);

    public static readonly UnitsOptionsCatalogRequestLocale Hr = new(Values.Hr);

    public static readonly UnitsOptionsCatalogRequestLocale Sl = new(Values.Sl);

    public static readonly UnitsOptionsCatalogRequestLocale El = new(Values.El);

    public static readonly UnitsOptionsCatalogRequestLocale Mt = new(Values.Mt);

    public static readonly UnitsOptionsCatalogRequestLocale Is = new(Values.Is);

    public static readonly UnitsOptionsCatalogRequestLocale Ga = new(Values.Ga);

    public static readonly UnitsOptionsCatalogRequestLocale Zh = new(Values.Zh);

    public static readonly UnitsOptionsCatalogRequestLocale Ja = new(Values.Ja);

    public static readonly UnitsOptionsCatalogRequestLocale Ar = new(Values.Ar);

    public static readonly UnitsOptionsCatalogRequestLocale Hi = new(Values.Hi);

    public static readonly UnitsOptionsCatalogRequestLocale Ru = new(Values.Ru);

    public static readonly UnitsOptionsCatalogRequestLocale Tr = new(Values.Tr);

    public static readonly UnitsOptionsCatalogRequestLocale Uk = new(Values.Uk);

    public UnitsOptionsCatalogRequestLocale(string value)
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
    public static UnitsOptionsCatalogRequestLocale FromCustom(string value)
    {
        return new UnitsOptionsCatalogRequestLocale(value);
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

    public static bool operator ==(UnitsOptionsCatalogRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UnitsOptionsCatalogRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UnitsOptionsCatalogRequestLocale value) => value.Value;

    public static explicit operator UnitsOptionsCatalogRequestLocale(string value) => new(value);

    internal class UnitsOptionsCatalogRequestLocaleSerializer
        : JsonConverter<UnitsOptionsCatalogRequestLocale>
    {
        public override UnitsOptionsCatalogRequestLocale Read(
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
            return new UnitsOptionsCatalogRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UnitsOptionsCatalogRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UnitsOptionsCatalogRequestLocale ReadAsPropertyName(
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
            return new UnitsOptionsCatalogRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UnitsOptionsCatalogRequestLocale value,
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
