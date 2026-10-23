using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesCreateSalesRequestLocale.RecurringInvoicesCreateSalesRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesCreateSalesRequestLocale : IStringEnum
{
    public static readonly RecurringInvoicesCreateSalesRequestLocale En = new(Values.En);

    public static readonly RecurringInvoicesCreateSalesRequestLocale Lt = new(Values.Lt);

    public static readonly RecurringInvoicesCreateSalesRequestLocale De = new(Values.De);

    public RecurringInvoicesCreateSalesRequestLocale(string value)
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
    public static RecurringInvoicesCreateSalesRequestLocale FromCustom(string value)
    {
        return new RecurringInvoicesCreateSalesRequestLocale(value);
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
        RecurringInvoicesCreateSalesRequestLocale value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesCreateSalesRequestLocale value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecurringInvoicesCreateSalesRequestLocale value) =>
        value.Value;

    public static explicit operator RecurringInvoicesCreateSalesRequestLocale(string value) =>
        new(value);

    internal class RecurringInvoicesCreateSalesRequestLocaleSerializer
        : JsonConverter<RecurringInvoicesCreateSalesRequestLocale>
    {
        public override RecurringInvoicesCreateSalesRequestLocale Read(
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
            return new RecurringInvoicesCreateSalesRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesCreateSalesRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesCreateSalesRequestLocale ReadAsPropertyName(
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
            return new RecurringInvoicesCreateSalesRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesCreateSalesRequestLocale value,
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
