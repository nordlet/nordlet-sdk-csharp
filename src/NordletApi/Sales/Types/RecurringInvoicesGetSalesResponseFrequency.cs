using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesGetSalesResponseFrequency.RecurringInvoicesGetSalesResponseFrequencySerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesGetSalesResponseFrequency : IStringEnum
{
    public static readonly RecurringInvoicesGetSalesResponseFrequency Weekly = new(Values.Weekly);

    public static readonly RecurringInvoicesGetSalesResponseFrequency Monthly = new(Values.Monthly);

    public static readonly RecurringInvoicesGetSalesResponseFrequency Quarterly = new(
        Values.Quarterly
    );

    public static readonly RecurringInvoicesGetSalesResponseFrequency Annual = new(Values.Annual);

    public RecurringInvoicesGetSalesResponseFrequency(string value)
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
    public static RecurringInvoicesGetSalesResponseFrequency FromCustom(string value)
    {
        return new RecurringInvoicesGetSalesResponseFrequency(value);
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
        RecurringInvoicesGetSalesResponseFrequency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesGetSalesResponseFrequency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecurringInvoicesGetSalesResponseFrequency value) =>
        value.Value;

    public static explicit operator RecurringInvoicesGetSalesResponseFrequency(string value) =>
        new(value);

    internal class RecurringInvoicesGetSalesResponseFrequencySerializer
        : JsonConverter<RecurringInvoicesGetSalesResponseFrequency>
    {
        public override RecurringInvoicesGetSalesResponseFrequency Read(
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
            return new RecurringInvoicesGetSalesResponseFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesGetSalesResponseFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesGetSalesResponseFrequency ReadAsPropertyName(
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
            return new RecurringInvoicesGetSalesResponseFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesGetSalesResponseFrequency value,
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
