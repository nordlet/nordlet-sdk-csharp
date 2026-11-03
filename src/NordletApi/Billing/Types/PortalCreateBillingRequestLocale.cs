using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PortalCreateBillingRequestLocale.PortalCreateBillingRequestLocaleSerializer))]
[Serializable]
public readonly record struct PortalCreateBillingRequestLocale : IStringEnum
{
    public static readonly PortalCreateBillingRequestLocale En = new(Values.En);

    public static readonly PortalCreateBillingRequestLocale Lt = new(Values.Lt);

    public static readonly PortalCreateBillingRequestLocale De = new(Values.De);

    public static readonly PortalCreateBillingRequestLocale Fr = new(Values.Fr);

    public static readonly PortalCreateBillingRequestLocale Es = new(Values.Es);

    public static readonly PortalCreateBillingRequestLocale It = new(Values.It);

    public static readonly PortalCreateBillingRequestLocale Pt = new(Values.Pt);

    public static readonly PortalCreateBillingRequestLocale Nl = new(Values.Nl);

    public static readonly PortalCreateBillingRequestLocale Pl = new(Values.Pl);

    public static readonly PortalCreateBillingRequestLocale Sv = new(Values.Sv);

    public static readonly PortalCreateBillingRequestLocale Da = new(Values.Da);

    public static readonly PortalCreateBillingRequestLocale No = new(Values.No);

    public static readonly PortalCreateBillingRequestLocale Fi = new(Values.Fi);

    public static readonly PortalCreateBillingRequestLocale Et = new(Values.Et);

    public static readonly PortalCreateBillingRequestLocale Lv = new(Values.Lv);

    public static readonly PortalCreateBillingRequestLocale Cs = new(Values.Cs);

    public static readonly PortalCreateBillingRequestLocale Sk = new(Values.Sk);

    public static readonly PortalCreateBillingRequestLocale Hu = new(Values.Hu);

    public static readonly PortalCreateBillingRequestLocale Ro = new(Values.Ro);

    public static readonly PortalCreateBillingRequestLocale Bg = new(Values.Bg);

    public static readonly PortalCreateBillingRequestLocale Hr = new(Values.Hr);

    public static readonly PortalCreateBillingRequestLocale Sl = new(Values.Sl);

    public static readonly PortalCreateBillingRequestLocale El = new(Values.El);

    public static readonly PortalCreateBillingRequestLocale Mt = new(Values.Mt);

    public static readonly PortalCreateBillingRequestLocale Is = new(Values.Is);

    public static readonly PortalCreateBillingRequestLocale Ga = new(Values.Ga);

    public static readonly PortalCreateBillingRequestLocale Zh = new(Values.Zh);

    public static readonly PortalCreateBillingRequestLocale Ja = new(Values.Ja);

    public static readonly PortalCreateBillingRequestLocale Ar = new(Values.Ar);

    public static readonly PortalCreateBillingRequestLocale Hi = new(Values.Hi);

    public static readonly PortalCreateBillingRequestLocale Ru = new(Values.Ru);

    public static readonly PortalCreateBillingRequestLocale Tr = new(Values.Tr);

    public static readonly PortalCreateBillingRequestLocale Uk = new(Values.Uk);

    public PortalCreateBillingRequestLocale(string value)
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
    public static PortalCreateBillingRequestLocale FromCustom(string value)
    {
        return new PortalCreateBillingRequestLocale(value);
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

    public static bool operator ==(PortalCreateBillingRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PortalCreateBillingRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PortalCreateBillingRequestLocale value) => value.Value;

    public static explicit operator PortalCreateBillingRequestLocale(string value) => new(value);

    internal class PortalCreateBillingRequestLocaleSerializer
        : JsonConverter<PortalCreateBillingRequestLocale>
    {
        public override PortalCreateBillingRequestLocale Read(
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
            return new PortalCreateBillingRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PortalCreateBillingRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PortalCreateBillingRequestLocale ReadAsPropertyName(
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
            return new PortalCreateBillingRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PortalCreateBillingRequestLocale value,
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
