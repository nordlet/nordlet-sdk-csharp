using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecognitionSchedulesListSalesRequestSortItemDir.RecognitionSchedulesListSalesRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct RecognitionSchedulesListSalesRequestSortItemDir : IStringEnum
{
    public static readonly RecognitionSchedulesListSalesRequestSortItemDir Asc = new(Values.Asc);

    public static readonly RecognitionSchedulesListSalesRequestSortItemDir Desc = new(Values.Desc);

    public RecognitionSchedulesListSalesRequestSortItemDir(string value)
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
    public static RecognitionSchedulesListSalesRequestSortItemDir FromCustom(string value)
    {
        return new RecognitionSchedulesListSalesRequestSortItemDir(value);
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
        RecognitionSchedulesListSalesRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecognitionSchedulesListSalesRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecognitionSchedulesListSalesRequestSortItemDir value) =>
        value.Value;

    public static explicit operator RecognitionSchedulesListSalesRequestSortItemDir(string value) =>
        new(value);

    internal class RecognitionSchedulesListSalesRequestSortItemDirSerializer
        : JsonConverter<RecognitionSchedulesListSalesRequestSortItemDir>
    {
        public override RecognitionSchedulesListSalesRequestSortItemDir Read(
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
            return new RecognitionSchedulesListSalesRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecognitionSchedulesListSalesRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecognitionSchedulesListSalesRequestSortItemDir ReadAsPropertyName(
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
            return new RecognitionSchedulesListSalesRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecognitionSchedulesListSalesRequestSortItemDir value,
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
        public const string Asc = "asc";

        public const string Desc = "desc";
    }
}
