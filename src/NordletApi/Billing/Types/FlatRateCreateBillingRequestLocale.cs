using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FlatRateCreateBillingRequestLocale.FlatRateCreateBillingRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct FlatRateCreateBillingRequestLocale : IStringEnum
{
    public static readonly FlatRateCreateBillingRequestLocale En = new(Values.En);

    public static readonly FlatRateCreateBillingRequestLocale Lt = new(Values.Lt);

    public static readonly FlatRateCreateBillingRequestLocale De = new(Values.De);

    public static readonly FlatRateCreateBillingRequestLocale Fr = new(Values.Fr);

    public static readonly FlatRateCreateBillingRequestLocale Es = new(Values.Es);

    public static readonly FlatRateCreateBillingRequestLocale It = new(Values.It);

    public static readonly FlatRateCreateBillingRequestLocale Pt = new(Values.Pt);

    public static readonly FlatRateCreateBillingRequestLocale Nl = new(Values.Nl);

    public static readonly FlatRateCreateBillingRequestLocale Pl = new(Values.Pl);

    public static readonly FlatRateCreateBillingRequestLocale Sv = new(Values.Sv);

    public static readonly FlatRateCreateBillingRequestLocale Da = new(Values.Da);

    public static readonly FlatRateCreateBillingRequestLocale No = new(Values.No);

    public static readonly FlatRateCreateBillingRequestLocale Fi = new(Values.Fi);

    public static readonly FlatRateCreateBillingRequestLocale Et = new(Values.Et);

    public static readonly FlatRateCreateBillingRequestLocale Lv = new(Values.Lv);

    public static readonly FlatRateCreateBillingRequestLocale Cs = new(Values.Cs);

    public static readonly FlatRateCreateBillingRequestLocale Sk = new(Values.Sk);

    public static readonly FlatRateCreateBillingRequestLocale Hu = new(Values.Hu);

    public static readonly FlatRateCreateBillingRequestLocale Ro = new(Values.Ro);

    public static readonly FlatRateCreateBillingRequestLocale Bg = new(Values.Bg);

    public static readonly FlatRateCreateBillingRequestLocale Hr = new(Values.Hr);

    public static readonly FlatRateCreateBillingRequestLocale Sl = new(Values.Sl);

    public static readonly FlatRateCreateBillingRequestLocale El = new(Values.El);

    public static readonly FlatRateCreateBillingRequestLocale Mt = new(Values.Mt);

    public static readonly FlatRateCreateBillingRequestLocale Is = new(Values.Is);

    public static readonly FlatRateCreateBillingRequestLocale Ga = new(Values.Ga);

    public static readonly FlatRateCreateBillingRequestLocale Zh = new(Values.Zh);

    public static readonly FlatRateCreateBillingRequestLocale Ja = new(Values.Ja);

    public static readonly FlatRateCreateBillingRequestLocale Ar = new(Values.Ar);

    public static readonly FlatRateCreateBillingRequestLocale Hi = new(Values.Hi);

    public static readonly FlatRateCreateBillingRequestLocale Ru = new(Values.Ru);

    public static readonly FlatRateCreateBillingRequestLocale Tr = new(Values.Tr);

    public static readonly FlatRateCreateBillingRequestLocale Uk = new(Values.Uk);

    public FlatRateCreateBillingRequestLocale(string value)
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
    public static FlatRateCreateBillingRequestLocale FromCustom(string value)
    {
        return new FlatRateCreateBillingRequestLocale(value);
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

    public static bool operator ==(FlatRateCreateBillingRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FlatRateCreateBillingRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FlatRateCreateBillingRequestLocale value) => value.Value;

    public static explicit operator FlatRateCreateBillingRequestLocale(string value) => new(value);

    internal class FlatRateCreateBillingRequestLocaleSerializer
        : JsonConverter<FlatRateCreateBillingRequestLocale>
    {
        public override FlatRateCreateBillingRequestLocale Read(
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
            return new FlatRateCreateBillingRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FlatRateCreateBillingRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FlatRateCreateBillingRequestLocale ReadAsPropertyName(
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
            return new FlatRateCreateBillingRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FlatRateCreateBillingRequestLocale value,
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
