using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(LocaleSetAccountRequestLocale.LocaleSetAccountRequestLocaleSerializer))]
[Serializable]
public readonly record struct LocaleSetAccountRequestLocale : IStringEnum
{
    public static readonly LocaleSetAccountRequestLocale En = new(Values.En);

    public static readonly LocaleSetAccountRequestLocale Lt = new(Values.Lt);

    public static readonly LocaleSetAccountRequestLocale De = new(Values.De);

    public LocaleSetAccountRequestLocale(string value)
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
    public static LocaleSetAccountRequestLocale FromCustom(string value)
    {
        return new LocaleSetAccountRequestLocale(value);
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

    public static bool operator ==(LocaleSetAccountRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LocaleSetAccountRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LocaleSetAccountRequestLocale value) => value.Value;

    public static explicit operator LocaleSetAccountRequestLocale(string value) => new(value);

    internal class LocaleSetAccountRequestLocaleSerializer
        : JsonConverter<LocaleSetAccountRequestLocale>
    {
        public override LocaleSetAccountRequestLocale Read(
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
            return new LocaleSetAccountRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LocaleSetAccountRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LocaleSetAccountRequestLocale ReadAsPropertyName(
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
            return new LocaleSetAccountRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LocaleSetAccountRequestLocale value,
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
