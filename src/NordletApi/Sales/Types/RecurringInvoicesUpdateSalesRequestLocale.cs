using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesUpdateSalesRequestLocale.RecurringInvoicesUpdateSalesRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesUpdateSalesRequestLocale : IStringEnum
{
    public static readonly RecurringInvoicesUpdateSalesRequestLocale En = new(Values.En);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale Lt = new(Values.Lt);

    public static readonly RecurringInvoicesUpdateSalesRequestLocale De = new(Values.De);

    public RecurringInvoicesUpdateSalesRequestLocale(string value)
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
    public static RecurringInvoicesUpdateSalesRequestLocale FromCustom(string value)
    {
        return new RecurringInvoicesUpdateSalesRequestLocale(value);
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
        RecurringInvoicesUpdateSalesRequestLocale value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesUpdateSalesRequestLocale value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecurringInvoicesUpdateSalesRequestLocale value) =>
        value.Value;

    public static explicit operator RecurringInvoicesUpdateSalesRequestLocale(string value) =>
        new(value);

    internal class RecurringInvoicesUpdateSalesRequestLocaleSerializer
        : JsonConverter<RecurringInvoicesUpdateSalesRequestLocale>
    {
        public override RecurringInvoicesUpdateSalesRequestLocale Read(
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
            return new RecurringInvoicesUpdateSalesRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesUpdateSalesRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesUpdateSalesRequestLocale ReadAsPropertyName(
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
            return new RecurringInvoicesUpdateSalesRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesUpdateSalesRequestLocale value,
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
