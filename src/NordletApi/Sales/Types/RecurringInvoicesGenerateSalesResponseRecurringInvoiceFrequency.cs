using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency.RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequencySerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency
    : IStringEnum
{
    public static readonly RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency Weekly =
        new(Values.Weekly);

    public static readonly RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency Monthly =
        new(Values.Monthly);

    public static readonly RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency Quarterly =
        new(Values.Quarterly);

    public static readonly RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency Annual =
        new(Values.Annual);

    public RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency(string value)
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
    public static RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency FromCustom(
        string value
    )
    {
        return new RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency(value);
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
        RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency value
    ) => value.Value;

    public static explicit operator RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency(
        string value
    ) => new(value);

    internal class RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequencySerializer
        : JsonConverter<RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency>
    {
        public override RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency Read(
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
            return new RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency ReadAsPropertyName(
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
            return new RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesGenerateSalesResponseRecurringInvoiceFrequency value,
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
