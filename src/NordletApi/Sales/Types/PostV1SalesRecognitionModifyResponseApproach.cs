using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesRecognitionModifyResponseApproach.PostV1SalesRecognitionModifyResponseApproachSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesRecognitionModifyResponseApproach : IStringEnum
{
    public static readonly PostV1SalesRecognitionModifyResponseApproach Prospective = new(
        Values.Prospective
    );

    public static readonly PostV1SalesRecognitionModifyResponseApproach CumulativeCatchUp = new(
        Values.CumulativeCatchUp
    );

    public PostV1SalesRecognitionModifyResponseApproach(string value)
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
    public static PostV1SalesRecognitionModifyResponseApproach FromCustom(string value)
    {
        return new PostV1SalesRecognitionModifyResponseApproach(value);
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
        PostV1SalesRecognitionModifyResponseApproach value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesRecognitionModifyResponseApproach value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesRecognitionModifyResponseApproach value) =>
        value.Value;

    public static explicit operator PostV1SalesRecognitionModifyResponseApproach(string value) =>
        new(value);

    internal class PostV1SalesRecognitionModifyResponseApproachSerializer
        : JsonConverter<PostV1SalesRecognitionModifyResponseApproach>
    {
        public override PostV1SalesRecognitionModifyResponseApproach Read(
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
            return new PostV1SalesRecognitionModifyResponseApproach(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesRecognitionModifyResponseApproach value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesRecognitionModifyResponseApproach ReadAsPropertyName(
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
            return new PostV1SalesRecognitionModifyResponseApproach(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesRecognitionModifyResponseApproach value,
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
