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
    }
}
