using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PaymentsExportPayrollRequestLocale.PaymentsExportPayrollRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct PaymentsExportPayrollRequestLocale : IStringEnum
{
    public static readonly PaymentsExportPayrollRequestLocale En = new(Values.En);

    public static readonly PaymentsExportPayrollRequestLocale Lt = new(Values.Lt);

    public static readonly PaymentsExportPayrollRequestLocale De = new(Values.De);

    public static readonly PaymentsExportPayrollRequestLocale Fr = new(Values.Fr);

    public static readonly PaymentsExportPayrollRequestLocale Es = new(Values.Es);

    public static readonly PaymentsExportPayrollRequestLocale It = new(Values.It);

    public static readonly PaymentsExportPayrollRequestLocale Pt = new(Values.Pt);

    public static readonly PaymentsExportPayrollRequestLocale Nl = new(Values.Nl);

    public static readonly PaymentsExportPayrollRequestLocale Pl = new(Values.Pl);

    public static readonly PaymentsExportPayrollRequestLocale Sv = new(Values.Sv);

    public static readonly PaymentsExportPayrollRequestLocale Da = new(Values.Da);

    public static readonly PaymentsExportPayrollRequestLocale No = new(Values.No);

    public static readonly PaymentsExportPayrollRequestLocale Fi = new(Values.Fi);

    public static readonly PaymentsExportPayrollRequestLocale Et = new(Values.Et);

    public static readonly PaymentsExportPayrollRequestLocale Lv = new(Values.Lv);

    public static readonly PaymentsExportPayrollRequestLocale Cs = new(Values.Cs);

    public static readonly PaymentsExportPayrollRequestLocale Sk = new(Values.Sk);

    public static readonly PaymentsExportPayrollRequestLocale Hu = new(Values.Hu);

    public static readonly PaymentsExportPayrollRequestLocale Ro = new(Values.Ro);

    public static readonly PaymentsExportPayrollRequestLocale Bg = new(Values.Bg);

    public static readonly PaymentsExportPayrollRequestLocale Hr = new(Values.Hr);

    public static readonly PaymentsExportPayrollRequestLocale Sl = new(Values.Sl);

    public static readonly PaymentsExportPayrollRequestLocale El = new(Values.El);

    public static readonly PaymentsExportPayrollRequestLocale Mt = new(Values.Mt);

    public static readonly PaymentsExportPayrollRequestLocale Is = new(Values.Is);

    public static readonly PaymentsExportPayrollRequestLocale Ga = new(Values.Ga);

    public static readonly PaymentsExportPayrollRequestLocale Zh = new(Values.Zh);

    public static readonly PaymentsExportPayrollRequestLocale Ja = new(Values.Ja);

    public static readonly PaymentsExportPayrollRequestLocale Ar = new(Values.Ar);

    public static readonly PaymentsExportPayrollRequestLocale Hi = new(Values.Hi);

    public static readonly PaymentsExportPayrollRequestLocale Ru = new(Values.Ru);

    public static readonly PaymentsExportPayrollRequestLocale Tr = new(Values.Tr);

    public static readonly PaymentsExportPayrollRequestLocale Uk = new(Values.Uk);

    public PaymentsExportPayrollRequestLocale(string value)
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
    public static PaymentsExportPayrollRequestLocale FromCustom(string value)
    {
        return new PaymentsExportPayrollRequestLocale(value);
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

    public static bool operator ==(PaymentsExportPayrollRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PaymentsExportPayrollRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PaymentsExportPayrollRequestLocale value) => value.Value;

    public static explicit operator PaymentsExportPayrollRequestLocale(string value) => new(value);

    internal class PaymentsExportPayrollRequestLocaleSerializer
        : JsonConverter<PaymentsExportPayrollRequestLocale>
    {
        public override PaymentsExportPayrollRequestLocale Read(
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
            return new PaymentsExportPayrollRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PaymentsExportPayrollRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PaymentsExportPayrollRequestLocale ReadAsPropertyName(
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
            return new PaymentsExportPayrollRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PaymentsExportPayrollRequestLocale value,
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
