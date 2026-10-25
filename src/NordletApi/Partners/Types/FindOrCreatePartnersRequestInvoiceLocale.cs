using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FindOrCreatePartnersRequestInvoiceLocale.FindOrCreatePartnersRequestInvoiceLocaleSerializer)
)]
[Serializable]
public readonly record struct FindOrCreatePartnersRequestInvoiceLocale : IStringEnum
{
    public static readonly FindOrCreatePartnersRequestInvoiceLocale En = new(Values.En);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Lt = new(Values.Lt);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale De = new(Values.De);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Fr = new(Values.Fr);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Es = new(Values.Es);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale It = new(Values.It);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Pt = new(Values.Pt);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Nl = new(Values.Nl);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Pl = new(Values.Pl);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Sv = new(Values.Sv);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Da = new(Values.Da);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale No = new(Values.No);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Fi = new(Values.Fi);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Et = new(Values.Et);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Lv = new(Values.Lv);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Cs = new(Values.Cs);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Sk = new(Values.Sk);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Hu = new(Values.Hu);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Ro = new(Values.Ro);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Bg = new(Values.Bg);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Hr = new(Values.Hr);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Sl = new(Values.Sl);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale El = new(Values.El);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Mt = new(Values.Mt);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Is = new(Values.Is);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Ga = new(Values.Ga);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Zh = new(Values.Zh);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Ja = new(Values.Ja);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Ar = new(Values.Ar);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Hi = new(Values.Hi);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Ru = new(Values.Ru);

    public static readonly FindOrCreatePartnersRequestInvoiceLocale Tr = new(Values.Tr);

    public FindOrCreatePartnersRequestInvoiceLocale(string value)
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
    public static FindOrCreatePartnersRequestInvoiceLocale FromCustom(string value)
    {
        return new FindOrCreatePartnersRequestInvoiceLocale(value);
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

    public static bool operator ==(
        FindOrCreatePartnersRequestInvoiceLocale value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FindOrCreatePartnersRequestInvoiceLocale value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FindOrCreatePartnersRequestInvoiceLocale value) =>
        value.Value;

    public static explicit operator FindOrCreatePartnersRequestInvoiceLocale(string value) =>
        new(value);

    internal class FindOrCreatePartnersRequestInvoiceLocaleSerializer
        : JsonConverter<FindOrCreatePartnersRequestInvoiceLocale>
    {
        public override FindOrCreatePartnersRequestInvoiceLocale Read(
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
            return new FindOrCreatePartnersRequestInvoiceLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FindOrCreatePartnersRequestInvoiceLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FindOrCreatePartnersRequestInvoiceLocale ReadAsPropertyName(
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
            return new FindOrCreatePartnersRequestInvoiceLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FindOrCreatePartnersRequestInvoiceLocale value,
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
    }
}
