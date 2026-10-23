using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecurringInvoicesCreateSalesResponseStatus.RecurringInvoicesCreateSalesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct RecurringInvoicesCreateSalesResponseStatus : IStringEnum
{
    public static readonly RecurringInvoicesCreateSalesResponseStatus Active = new(Values.Active);

    public static readonly RecurringInvoicesCreateSalesResponseStatus Paused = new(Values.Paused);

    public static readonly RecurringInvoicesCreateSalesResponseStatus Finished = new(
        Values.Finished
    );

    public RecurringInvoicesCreateSalesResponseStatus(string value)
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
    public static RecurringInvoicesCreateSalesResponseStatus FromCustom(string value)
    {
        return new RecurringInvoicesCreateSalesResponseStatus(value);
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
        RecurringInvoicesCreateSalesResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecurringInvoicesCreateSalesResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecurringInvoicesCreateSalesResponseStatus value) =>
        value.Value;

    public static explicit operator RecurringInvoicesCreateSalesResponseStatus(string value) =>
        new(value);

    internal class RecurringInvoicesCreateSalesResponseStatusSerializer
        : JsonConverter<RecurringInvoicesCreateSalesResponseStatus>
    {
        public override RecurringInvoicesCreateSalesResponseStatus Read(
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
            return new RecurringInvoicesCreateSalesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecurringInvoicesCreateSalesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecurringInvoicesCreateSalesResponseStatus ReadAsPropertyName(
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
            return new RecurringInvoicesCreateSalesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecurringInvoicesCreateSalesResponseStatus value,
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
