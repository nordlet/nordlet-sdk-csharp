using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesCreateSalesResponseFrequency.RecurringInvoicesCreateSalesResponseFrequencySerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesCreateSalesResponseFrequency : IStringEnum
{
    public static readonly RecurringInvoicesCreateSalesResponseFrequency Weekly = new(
        Values.Weekly
    );

    public static readonly RecurringInvoicesCreateSalesResponseFrequency Monthly = new(
        Values.Monthly
    );

    public static readonly RecurringInvoicesCreateSalesResponseFrequency Quarterly = new(
        Values.Quarterly
    );

    public static readonly RecurringInvoicesCreateSalesResponseFrequency Annual = new(
        Values.Annual
    );

    public RecurringInvoicesCreateSalesResponseFrequency(string value)
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
    public static RecurringInvoicesCreateSalesResponseFrequency FromCustom(string value)
    {
        return new RecurringInvoicesCreateSalesResponseFrequency(value);
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
        RecurringInvoicesCreateSalesResponseFrequency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesCreateSalesResponseFrequency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecurringInvoicesCreateSalesResponseFrequency value) =>
        value.Value;

    public static explicit operator RecurringInvoicesCreateSalesResponseFrequency(string value) =>
        new(value);

    internal class RecurringInvoicesCreateSalesResponseFrequencySerializer
        : JsonConverter<RecurringInvoicesCreateSalesResponseFrequency>
    {
        public override RecurringInvoicesCreateSalesResponseFrequency Read(
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
            return new RecurringInvoicesCreateSalesResponseFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesCreateSalesResponseFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesCreateSalesResponseFrequency ReadAsPropertyName(
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
            return new RecurringInvoicesCreateSalesResponseFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesCreateSalesResponseFrequency value,
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
