using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesListSalesResponseRowsItemStatus.RecurringInvoicesListSalesResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesListSalesResponseRowsItemStatus : IStringEnum
{
    public static readonly RecurringInvoicesListSalesResponseRowsItemStatus Active = new(
        Values.Active
    );

    public static readonly RecurringInvoicesListSalesResponseRowsItemStatus Paused = new(
        Values.Paused
    );

    public static readonly RecurringInvoicesListSalesResponseRowsItemStatus Finished = new(
        Values.Finished
    );

    public RecurringInvoicesListSalesResponseRowsItemStatus(string value)
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
    public static RecurringInvoicesListSalesResponseRowsItemStatus FromCustom(string value)
    {
        return new RecurringInvoicesListSalesResponseRowsItemStatus(value);
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
        RecurringInvoicesListSalesResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesListSalesResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RecurringInvoicesListSalesResponseRowsItemStatus value
    ) => value.Value;

    public static explicit operator RecurringInvoicesListSalesResponseRowsItemStatus(
        string value
    ) => new(value);

    internal class RecurringInvoicesListSalesResponseRowsItemStatusSerializer
        : JsonConverter<RecurringInvoicesListSalesResponseRowsItemStatus>
    {
        public override RecurringInvoicesListSalesResponseRowsItemStatus Read(
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
            return new RecurringInvoicesListSalesResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesListSalesResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesListSalesResponseRowsItemStatus ReadAsPropertyName(
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
            return new RecurringInvoicesListSalesResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesListSalesResponseRowsItemStatus value,
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
        public const string Active = "active";

        public const string Paused = "paused";

        public const string Finished = "finished";
    }
}
