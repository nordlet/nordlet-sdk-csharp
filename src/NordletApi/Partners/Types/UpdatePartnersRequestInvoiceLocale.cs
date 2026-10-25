using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UpdatePartnersRequestInvoiceLocale.UpdatePartnersRequestInvoiceLocaleSerializer)
)]
[Serializable]
public readonly record struct UpdatePartnersRequestInvoiceLocale : IStringEnum
{
    public static readonly UpdatePartnersRequestInvoiceLocale En = new(Values.En);

    public static readonly UpdatePartnersRequestInvoiceLocale Lt = new(Values.Lt);

    public static readonly UpdatePartnersRequestInvoiceLocale De = new(Values.De);

    public static readonly UpdatePartnersRequestInvoiceLocale Fr = new(Values.Fr);

    public static readonly UpdatePartnersRequestInvoiceLocale Es = new(Values.Es);

    public static readonly UpdatePartnersRequestInvoiceLocale It = new(Values.It);

    public static readonly UpdatePartnersRequestInvoiceLocale Pt = new(Values.Pt);

    public static readonly UpdatePartnersRequestInvoiceLocale Nl = new(Values.Nl);

    public static readonly UpdatePartnersRequestInvoiceLocale Pl = new(Values.Pl);

    public static readonly UpdatePartnersRequestInvoiceLocale Sv = new(Values.Sv);

    public static readonly UpdatePartnersRequestInvoiceLocale Da = new(Values.Da);

    public static readonly UpdatePartnersRequestInvoiceLocale No = new(Values.No);

    public static readonly UpdatePartnersRequestInvoiceLocale Fi = new(Values.Fi);

    public static readonly UpdatePartnersRequestInvoiceLocale Et = new(Values.Et);

    public static readonly UpdatePartnersRequestInvoiceLocale Lv = new(Values.Lv);

    public static readonly UpdatePartnersRequestInvoiceLocale Cs = new(Values.Cs);

    public static readonly UpdatePartnersRequestInvoiceLocale Sk = new(Values.Sk);

    public static readonly UpdatePartnersRequestInvoiceLocale Hu = new(Values.Hu);

    public static readonly UpdatePartnersRequestInvoiceLocale Ro = new(Values.Ro);

    public static readonly UpdatePartnersRequestInvoiceLocale Bg = new(Values.Bg);

    public static readonly UpdatePartnersRequestInvoiceLocale Hr = new(Values.Hr);

    public static readonly UpdatePartnersRequestInvoiceLocale Sl = new(Values.Sl);

    public static readonly UpdatePartnersRequestInvoiceLocale El = new(Values.El);

    public static readonly UpdatePartnersRequestInvoiceLocale Mt = new(Values.Mt);

    public static readonly UpdatePartnersRequestInvoiceLocale Is = new(Values.Is);

    public static readonly UpdatePartnersRequestInvoiceLocale Ga = new(Values.Ga);

    public static readonly UpdatePartnersRequestInvoiceLocale Zh = new(Values.Zh);

    public static readonly UpdatePartnersRequestInvoiceLocale Ja = new(Values.Ja);

    public static readonly UpdatePartnersRequestInvoiceLocale Ar = new(Values.Ar);

    public static readonly UpdatePartnersRequestInvoiceLocale Hi = new(Values.Hi);

    public static readonly UpdatePartnersRequestInvoiceLocale Ru = new(Values.Ru);

    public static readonly UpdatePartnersRequestInvoiceLocale Tr = new(Values.Tr);

    public UpdatePartnersRequestInvoiceLocale(string value)
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
    public static UpdatePartnersRequestInvoiceLocale FromCustom(string value)
    {
        return new UpdatePartnersRequestInvoiceLocale(value);
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

    public static bool operator ==(UpdatePartnersRequestInvoiceLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdatePartnersRequestInvoiceLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdatePartnersRequestInvoiceLocale value) => value.Value;

    public static explicit operator UpdatePartnersRequestInvoiceLocale(string value) => new(value);

    internal class UpdatePartnersRequestInvoiceLocaleSerializer
        : JsonConverter<UpdatePartnersRequestInvoiceLocale>
    {
        public override UpdatePartnersRequestInvoiceLocale Read(
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
            return new UpdatePartnersRequestInvoiceLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdatePartnersRequestInvoiceLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdatePartnersRequestInvoiceLocale ReadAsPropertyName(
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
            return new UpdatePartnersRequestInvoiceLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdatePartnersRequestInvoiceLocale value,
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
