using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecognitionSchedulesListSalesResponseRowsItemMethod.RecognitionSchedulesListSalesResponseRowsItemMethodSerializer)
)]
[Serializable]
public readonly record struct RecognitionSchedulesListSalesResponseRowsItemMethod : IStringEnum
{
    public static readonly RecognitionSchedulesListSalesResponseRowsItemMethod PointInTime = new(
        Values.PointInTime
    );

    public static readonly RecognitionSchedulesListSalesResponseRowsItemMethod Ratable = new(
        Values.Ratable
    );

    public static readonly RecognitionSchedulesListSalesResponseRowsItemMethod Milestone = new(
        Values.Milestone
    );

    public static readonly RecognitionSchedulesListSalesResponseRowsItemMethod PercentComplete =
        new(Values.PercentComplete);

    public RecognitionSchedulesListSalesResponseRowsItemMethod(string value)
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
    public static RecognitionSchedulesListSalesResponseRowsItemMethod FromCustom(string value)
    {
        return new RecognitionSchedulesListSalesResponseRowsItemMethod(value);
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
        RecognitionSchedulesListSalesResponseRowsItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecognitionSchedulesListSalesResponseRowsItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RecognitionSchedulesListSalesResponseRowsItemMethod value
    ) => value.Value;

    public static explicit operator RecognitionSchedulesListSalesResponseRowsItemMethod(
        string value
    ) => new(value);

    internal class RecognitionSchedulesListSalesResponseRowsItemMethodSerializer
        : JsonConverter<RecognitionSchedulesListSalesResponseRowsItemMethod>
    {
        public override RecognitionSchedulesListSalesResponseRowsItemMethod Read(
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
            return new RecognitionSchedulesListSalesResponseRowsItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecognitionSchedulesListSalesResponseRowsItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecognitionSchedulesListSalesResponseRowsItemMethod ReadAsPropertyName(
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
            return new RecognitionSchedulesListSalesResponseRowsItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecognitionSchedulesListSalesResponseRowsItemMethod value,
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
        public const string PointInTime = "point_in_time";

        public const string Ratable = "ratable";

        public const string Milestone = "milestone";

        public const string PercentComplete = "percent_complete";
    }
}
