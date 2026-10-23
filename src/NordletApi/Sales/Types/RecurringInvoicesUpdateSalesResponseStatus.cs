using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesUpdateSalesResponseStatus.RecurringInvoicesUpdateSalesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesUpdateSalesResponseStatus : IStringEnum
{
    public static readonly RecurringInvoicesUpdateSalesResponseStatus Active = new(Values.Active);

    public static readonly RecurringInvoicesUpdateSalesResponseStatus Paused = new(Values.Paused);

    public static readonly RecurringInvoicesUpdateSalesResponseStatus Finished = new(
        Values.Finished
    );

    public RecurringInvoicesUpdateSalesResponseStatus(string value)
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
    public static RecurringInvoicesUpdateSalesResponseStatus FromCustom(string value)
    {
        return new RecurringInvoicesUpdateSalesResponseStatus(value);
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
        RecurringInvoicesUpdateSalesResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesUpdateSalesResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecurringInvoicesUpdateSalesResponseStatus value) =>
        value.Value;

    public static explicit operator RecurringInvoicesUpdateSalesResponseStatus(string value) =>
        new(value);

    internal class RecurringInvoicesUpdateSalesResponseStatusSerializer
        : JsonConverter<RecurringInvoicesUpdateSalesResponseStatus>
    {
        public override RecurringInvoicesUpdateSalesResponseStatus Read(
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
            return new RecurringInvoicesUpdateSalesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesUpdateSalesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesUpdateSalesResponseStatus ReadAsPropertyName(
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
            return new RecurringInvoicesUpdateSalesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesUpdateSalesResponseStatus value,
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
