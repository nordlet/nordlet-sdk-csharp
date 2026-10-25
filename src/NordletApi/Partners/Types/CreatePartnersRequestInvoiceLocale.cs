using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CreatePartnersRequestInvoiceLocale.CreatePartnersRequestInvoiceLocaleSerializer)
)]
[Serializable]
public readonly record struct CreatePartnersRequestInvoiceLocale : IStringEnum
{
    public static readonly CreatePartnersRequestInvoiceLocale En = new(Values.En);

    public static readonly CreatePartnersRequestInvoiceLocale Lt = new(Values.Lt);

    public static readonly CreatePartnersRequestInvoiceLocale De = new(Values.De);

    public static readonly CreatePartnersRequestInvoiceLocale Fr = new(Values.Fr);

    public static readonly CreatePartnersRequestInvoiceLocale Es = new(Values.Es);

    public static readonly CreatePartnersRequestInvoiceLocale It = new(Values.It);

    public static readonly CreatePartnersRequestInvoiceLocale Pt = new(Values.Pt);

    public static readonly CreatePartnersRequestInvoiceLocale Nl = new(Values.Nl);

    public static readonly CreatePartnersRequestInvoiceLocale Pl = new(Values.Pl);

    public static readonly CreatePartnersRequestInvoiceLocale Sv = new(Values.Sv);

    public static readonly CreatePartnersRequestInvoiceLocale Da = new(Values.Da);

    public static readonly CreatePartnersRequestInvoiceLocale No = new(Values.No);

    public static readonly CreatePartnersRequestInvoiceLocale Fi = new(Values.Fi);

    public static readonly CreatePartnersRequestInvoiceLocale Et = new(Values.Et);

    public static readonly CreatePartnersRequestInvoiceLocale Lv = new(Values.Lv);

    public static readonly CreatePartnersRequestInvoiceLocale Cs = new(Values.Cs);

    public static readonly CreatePartnersRequestInvoiceLocale Sk = new(Values.Sk);

    public static readonly CreatePartnersRequestInvoiceLocale Hu = new(Values.Hu);

    public static readonly CreatePartnersRequestInvoiceLocale Ro = new(Values.Ro);

    public static readonly CreatePartnersRequestInvoiceLocale Bg = new(Values.Bg);

    public static readonly CreatePartnersRequestInvoiceLocale Hr = new(Values.Hr);

    public static readonly CreatePartnersRequestInvoiceLocale Sl = new(Values.Sl);

    public static readonly CreatePartnersRequestInvoiceLocale El = new(Values.El);

    public static readonly CreatePartnersRequestInvoiceLocale Mt = new(Values.Mt);

    public static readonly CreatePartnersRequestInvoiceLocale Is = new(Values.Is);

    public static readonly CreatePartnersRequestInvoiceLocale Ga = new(Values.Ga);

    public static readonly CreatePartnersRequestInvoiceLocale Zh = new(Values.Zh);

    public static readonly CreatePartnersRequestInvoiceLocale Ja = new(Values.Ja);

    public static readonly CreatePartnersRequestInvoiceLocale Ar = new(Values.Ar);

    public static readonly CreatePartnersRequestInvoiceLocale Hi = new(Values.Hi);

    public static readonly CreatePartnersRequestInvoiceLocale Ru = new(Values.Ru);

    public static readonly CreatePartnersRequestInvoiceLocale Tr = new(Values.Tr);

    public CreatePartnersRequestInvoiceLocale(string value)
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
    public static CreatePartnersRequestInvoiceLocale FromCustom(string value)
    {
        return new CreatePartnersRequestInvoiceLocale(value);
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

    public static bool operator ==(CreatePartnersRequestInvoiceLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreatePartnersRequestInvoiceLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreatePartnersRequestInvoiceLocale value) => value.Value;

    public static explicit operator CreatePartnersRequestInvoiceLocale(string value) => new(value);

    internal class CreatePartnersRequestInvoiceLocaleSerializer
        : JsonConverter<CreatePartnersRequestInvoiceLocale>
    {
        public override CreatePartnersRequestInvoiceLocale Read(
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
            return new CreatePartnersRequestInvoiceLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreatePartnersRequestInvoiceLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreatePartnersRequestInvoiceLocale ReadAsPropertyName(
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
            return new CreatePartnersRequestInvoiceLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreatePartnersRequestInvoiceLocale value,
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
