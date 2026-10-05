using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecognitionModifySalesRequestApproach.RecognitionModifySalesRequestApproachSerializer)
)]
[Serializable]
public readonly record struct RecognitionModifySalesRequestApproach : IStringEnum
{
    public static readonly RecognitionModifySalesRequestApproach Prospective = new(
        Values.Prospective
    );

    public static readonly RecognitionModifySalesRequestApproach CumulativeCatchUp = new(
        Values.CumulativeCatchUp
    );

    public RecognitionModifySalesRequestApproach(string value)
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
    public static RecognitionModifySalesRequestApproach FromCustom(string value)
    {
        return new RecognitionModifySalesRequestApproach(value);
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

    public static bool operator ==(RecognitionModifySalesRequestApproach value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RecognitionModifySalesRequestApproach value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RecognitionModifySalesRequestApproach value) =>
        value.Value;

    public static explicit operator RecognitionModifySalesRequestApproach(string value) =>
        new(value);

    internal class RecognitionModifySalesRequestApproachSerializer
        : JsonConverter<RecognitionModifySalesRequestApproach>
    {
        public override RecognitionModifySalesRequestApproach Read(
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
            return new RecognitionModifySalesRequestApproach(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecognitionModifySalesRequestApproach value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecognitionModifySalesRequestApproach ReadAsPropertyName(
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
            return new RecognitionModifySalesRequestApproach(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecognitionModifySalesRequestApproach value,
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
