using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesUpdateSalesResponseFrequency.RecurringInvoicesUpdateSalesResponseFrequencySerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesUpdateSalesResponseFrequency : IStringEnum
{
    public static readonly RecurringInvoicesUpdateSalesResponseFrequency Weekly = new(
        Values.Weekly
    );

    public static readonly RecurringInvoicesUpdateSalesResponseFrequency Monthly = new(
        Values.Monthly
    );

    public static readonly RecurringInvoicesUpdateSalesResponseFrequency Quarterly = new(
        Values.Quarterly
    );

    public static readonly RecurringInvoicesUpdateSalesResponseFrequency Annual = new(
        Values.Annual
    );

    public RecurringInvoicesUpdateSalesResponseFrequency(string value)
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
    public static RecurringInvoicesUpdateSalesResponseFrequency FromCustom(string value)
    {
        return new RecurringInvoicesUpdateSalesResponseFrequency(value);
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
        RecurringInvoicesUpdateSalesResponseFrequency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesUpdateSalesResponseFrequency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecurringInvoicesUpdateSalesResponseFrequency value) =>
        value.Value;

    public static explicit operator RecurringInvoicesUpdateSalesResponseFrequency(string value) =>
        new(value);

    internal class RecurringInvoicesUpdateSalesResponseFrequencySerializer
        : JsonConverter<RecurringInvoicesUpdateSalesResponseFrequency>
    {
        public override RecurringInvoicesUpdateSalesResponseFrequency Read(
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
            return new RecurringInvoicesUpdateSalesResponseFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesUpdateSalesResponseFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesUpdateSalesResponseFrequency ReadAsPropertyName(
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
            return new RecurringInvoicesUpdateSalesResponseFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesUpdateSalesResponseFrequency value,
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
