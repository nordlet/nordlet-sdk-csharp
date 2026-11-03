using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DebtRemindersPreviewPartnersResponseRowsItemLocale.DebtRemindersPreviewPartnersResponseRowsItemLocaleSerializer)
)]
[Serializable]
public readonly record struct DebtRemindersPreviewPartnersResponseRowsItemLocale : IStringEnum
{
    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale En = new(Values.En);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Lt = new(Values.Lt);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale De = new(Values.De);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Fr = new(Values.Fr);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Es = new(Values.Es);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale It = new(Values.It);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Pt = new(Values.Pt);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Nl = new(Values.Nl);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Pl = new(Values.Pl);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Sv = new(Values.Sv);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Da = new(Values.Da);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale No = new(Values.No);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Fi = new(Values.Fi);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Et = new(Values.Et);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Lv = new(Values.Lv);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Cs = new(Values.Cs);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Sk = new(Values.Sk);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Hu = new(Values.Hu);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Ro = new(Values.Ro);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Bg = new(Values.Bg);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Hr = new(Values.Hr);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Sl = new(Values.Sl);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale El = new(Values.El);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Mt = new(Values.Mt);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Is = new(Values.Is);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Ga = new(Values.Ga);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Zh = new(Values.Zh);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Ja = new(Values.Ja);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Ar = new(Values.Ar);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Hi = new(Values.Hi);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Ru = new(Values.Ru);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Tr = new(Values.Tr);

    public static readonly DebtRemindersPreviewPartnersResponseRowsItemLocale Uk = new(Values.Uk);

    public DebtRemindersPreviewPartnersResponseRowsItemLocale(string value)
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
    public static DebtRemindersPreviewPartnersResponseRowsItemLocale FromCustom(string value)
    {
        return new DebtRemindersPreviewPartnersResponseRowsItemLocale(value);
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
        DebtRemindersPreviewPartnersResponseRowsItemLocale value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DebtRemindersPreviewPartnersResponseRowsItemLocale value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DebtRemindersPreviewPartnersResponseRowsItemLocale value
    ) => value.Value;

    public static explicit operator DebtRemindersPreviewPartnersResponseRowsItemLocale(
        string value
    ) => new(value);

    internal class DebtRemindersPreviewPartnersResponseRowsItemLocaleSerializer
        : JsonConverter<DebtRemindersPreviewPartnersResponseRowsItemLocale>
    {
        public override DebtRemindersPreviewPartnersResponseRowsItemLocale Read(
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
            return new DebtRemindersPreviewPartnersResponseRowsItemLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DebtRemindersPreviewPartnersResponseRowsItemLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DebtRemindersPreviewPartnersResponseRowsItemLocale ReadAsPropertyName(
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
            return new DebtRemindersPreviewPartnersResponseRowsItemLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DebtRemindersPreviewPartnersResponseRowsItemLocale value,
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
