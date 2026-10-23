using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesUpdateSalesRequestFrequency.RecurringInvoicesUpdateSalesRequestFrequencySerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesUpdateSalesRequestFrequency : IStringEnum
{
    public static readonly RecurringInvoicesUpdateSalesRequestFrequency Weekly = new(Values.Weekly);

    public static readonly RecurringInvoicesUpdateSalesRequestFrequency Monthly = new(
        Values.Monthly
    );

    public static readonly RecurringInvoicesUpdateSalesRequestFrequency Quarterly = new(
        Values.Quarterly
    );

    public static readonly RecurringInvoicesUpdateSalesRequestFrequency Annual = new(Values.Annual);

    public RecurringInvoicesUpdateSalesRequestFrequency(string value)
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
    public static RecurringInvoicesUpdateSalesRequestFrequency FromCustom(string value)
    {
        return new RecurringInvoicesUpdateSalesRequestFrequency(value);
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
        RecurringInvoicesUpdateSalesRequestFrequency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesUpdateSalesRequestFrequency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecurringInvoicesUpdateSalesRequestFrequency value) =>
        value.Value;

    public static explicit operator RecurringInvoicesUpdateSalesRequestFrequency(string value) =>
        new(value);

    internal class RecurringInvoicesUpdateSalesRequestFrequencySerializer
        : JsonConverter<RecurringInvoicesUpdateSalesRequestFrequency>
    {
        public override RecurringInvoicesUpdateSalesRequestFrequency Read(
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
            return new RecurringInvoicesUpdateSalesRequestFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesUpdateSalesRequestFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesUpdateSalesRequestFrequency ReadAsPropertyName(
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
            return new RecurringInvoicesUpdateSalesRequestFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesUpdateSalesRequestFrequency value,
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
        public const string Weekly = "weekly";

        public const string Monthly = "monthly";

        public const string Quarterly = "quarterly";

        public const string Annual = "annual";
    }
}
