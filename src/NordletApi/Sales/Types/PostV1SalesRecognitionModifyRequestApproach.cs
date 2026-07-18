using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesRecognitionModifyRequestApproach.PostV1SalesRecognitionModifyRequestApproachSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesRecognitionModifyRequestApproach : IStringEnum
{
    public static readonly PostV1SalesRecognitionModifyRequestApproach Prospective = new(
        Values.Prospective
    );

    public static readonly PostV1SalesRecognitionModifyRequestApproach CumulativeCatchUp = new(
        Values.CumulativeCatchUp
    );

    public PostV1SalesRecognitionModifyRequestApproach(string value)
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
    public static PostV1SalesRecognitionModifyRequestApproach FromCustom(string value)
    {
        return new PostV1SalesRecognitionModifyRequestApproach(value);
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
        PostV1SalesRecognitionModifyRequestApproach value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesRecognitionModifyRequestApproach value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesRecognitionModifyRequestApproach value) =>
        value.Value;

    public static explicit operator PostV1SalesRecognitionModifyRequestApproach(string value) =>
        new(value);

    internal class PostV1SalesRecognitionModifyRequestApproachSerializer
        : JsonConverter<PostV1SalesRecognitionModifyRequestApproach>
    {
        public override PostV1SalesRecognitionModifyRequestApproach Read(
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
            return new PostV1SalesRecognitionModifyRequestApproach(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesRecognitionModifyRequestApproach value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesRecognitionModifyRequestApproach ReadAsPropertyName(
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
            return new PostV1SalesRecognitionModifyRequestApproach(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesRecognitionModifyRequestApproach value,
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
