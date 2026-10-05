using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecognitionModifySalesResponseApproach.RecognitionModifySalesResponseApproachSerializer)
)]
[Serializable]
public readonly record struct RecognitionModifySalesResponseApproach : IStringEnum
{
    public static readonly RecognitionModifySalesResponseApproach Prospective = new(
        Values.Prospective
    );

    public static readonly RecognitionModifySalesResponseApproach CumulativeCatchUp = new(
        Values.CumulativeCatchUp
    );

    public RecognitionModifySalesResponseApproach(string value)
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
    public static RecognitionModifySalesResponseApproach FromCustom(string value)
    {
        return new RecognitionModifySalesResponseApproach(value);
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

    public static bool operator ==(RecognitionModifySalesResponseApproach value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RecognitionModifySalesResponseApproach value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RecognitionModifySalesResponseApproach value) =>
        value.Value;

    public static explicit operator RecognitionModifySalesResponseApproach(string value) =>
        new(value);

    internal class RecognitionModifySalesResponseApproachSerializer
        : JsonConverter<RecognitionModifySalesResponseApproach>
    {
        public override RecognitionModifySalesResponseApproach Read(
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
            return new RecognitionModifySalesResponseApproach(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecognitionModifySalesResponseApproach value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecognitionModifySalesResponseApproach ReadAsPropertyName(
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
            return new RecognitionModifySalesResponseApproach(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecognitionModifySalesResponseApproach value,
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
        public const string Prospective = "prospective";

        public const string CumulativeCatchUp = "cumulative_catch_up";
    }
}
