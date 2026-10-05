using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecognitionSchedulesListSalesResponseRowsItemStatus.RecognitionSchedulesListSalesResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct RecognitionSchedulesListSalesResponseRowsItemStatus : IStringEnum
{
    public static readonly RecognitionSchedulesListSalesResponseRowsItemStatus Pending = new(
        Values.Pending
    );

    public static readonly RecognitionSchedulesListSalesResponseRowsItemStatus Recognized = new(
        Values.Recognized
    );

    public static readonly RecognitionSchedulesListSalesResponseRowsItemStatus Cancelled = new(
        Values.Cancelled
    );

    public RecognitionSchedulesListSalesResponseRowsItemStatus(string value)
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
    public static RecognitionSchedulesListSalesResponseRowsItemStatus FromCustom(string value)
    {
        return new RecognitionSchedulesListSalesResponseRowsItemStatus(value);
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
        RecognitionSchedulesListSalesResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecognitionSchedulesListSalesResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RecognitionSchedulesListSalesResponseRowsItemStatus value
    ) => value.Value;

    public static explicit operator RecognitionSchedulesListSalesResponseRowsItemStatus(
        string value
    ) => new(value);

    internal class RecognitionSchedulesListSalesResponseRowsItemStatusSerializer
        : JsonConverter<RecognitionSchedulesListSalesResponseRowsItemStatus>
    {
        public override RecognitionSchedulesListSalesResponseRowsItemStatus Read(
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
            return new RecognitionSchedulesListSalesResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecognitionSchedulesListSalesResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecognitionSchedulesListSalesResponseRowsItemStatus ReadAsPropertyName(
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
            return new RecognitionSchedulesListSalesResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecognitionSchedulesListSalesResponseRowsItemStatus value,
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
        public const string Pending = "pending";

        public const string Recognized = "recognized";

        public const string Cancelled = "cancelled";
    }
}
