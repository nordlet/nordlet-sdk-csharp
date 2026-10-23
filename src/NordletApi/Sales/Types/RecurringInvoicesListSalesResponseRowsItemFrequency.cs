using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesListSalesResponseRowsItemFrequency.RecurringInvoicesListSalesResponseRowsItemFrequencySerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesListSalesResponseRowsItemFrequency : IStringEnum
{
    public static readonly RecurringInvoicesListSalesResponseRowsItemFrequency Weekly = new(
        Values.Weekly
    );

    public static readonly RecurringInvoicesListSalesResponseRowsItemFrequency Monthly = new(
        Values.Monthly
    );

    public static readonly RecurringInvoicesListSalesResponseRowsItemFrequency Quarterly = new(
        Values.Quarterly
    );

    public static readonly RecurringInvoicesListSalesResponseRowsItemFrequency Annual = new(
        Values.Annual
    );

    public RecurringInvoicesListSalesResponseRowsItemFrequency(string value)
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
    public static RecurringInvoicesListSalesResponseRowsItemFrequency FromCustom(string value)
    {
        return new RecurringInvoicesListSalesResponseRowsItemFrequency(value);
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
        RecurringInvoicesListSalesResponseRowsItemFrequency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesListSalesResponseRowsItemFrequency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RecurringInvoicesListSalesResponseRowsItemFrequency value
    ) => value.Value;

    public static explicit operator RecurringInvoicesListSalesResponseRowsItemFrequency(
        string value
    ) => new(value);

    internal class RecurringInvoicesListSalesResponseRowsItemFrequencySerializer
        : JsonConverter<RecurringInvoicesListSalesResponseRowsItemFrequency>
    {
        public override RecurringInvoicesListSalesResponseRowsItemFrequency Read(
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
            return new RecurringInvoicesListSalesResponseRowsItemFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesListSalesResponseRowsItemFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesListSalesResponseRowsItemFrequency ReadAsPropertyName(
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
            return new RecurringInvoicesListSalesResponseRowsItemFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesListSalesResponseRowsItemFrequency value,
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
