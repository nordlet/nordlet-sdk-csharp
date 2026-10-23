using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesCreateSalesRequestFrequency.RecurringInvoicesCreateSalesRequestFrequencySerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesCreateSalesRequestFrequency : IStringEnum
{
    public static readonly RecurringInvoicesCreateSalesRequestFrequency Weekly = new(Values.Weekly);

    public static readonly RecurringInvoicesCreateSalesRequestFrequency Monthly = new(
        Values.Monthly
    );

    public static readonly RecurringInvoicesCreateSalesRequestFrequency Quarterly = new(
        Values.Quarterly
    );

    public static readonly RecurringInvoicesCreateSalesRequestFrequency Annual = new(Values.Annual);

    public RecurringInvoicesCreateSalesRequestFrequency(string value)
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
    public static RecurringInvoicesCreateSalesRequestFrequency FromCustom(string value)
    {
        return new RecurringInvoicesCreateSalesRequestFrequency(value);
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
        RecurringInvoicesCreateSalesRequestFrequency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesCreateSalesRequestFrequency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecurringInvoicesCreateSalesRequestFrequency value) =>
        value.Value;

    public static explicit operator RecurringInvoicesCreateSalesRequestFrequency(string value) =>
        new(value);

    internal class RecurringInvoicesCreateSalesRequestFrequencySerializer
        : JsonConverter<RecurringInvoicesCreateSalesRequestFrequency>
    {
        public override RecurringInvoicesCreateSalesRequestFrequency Read(
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
            return new RecurringInvoicesCreateSalesRequestFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesCreateSalesRequestFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesCreateSalesRequestFrequency ReadAsPropertyName(
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
            return new RecurringInvoicesCreateSalesRequestFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesCreateSalesRequestFrequency value,
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
