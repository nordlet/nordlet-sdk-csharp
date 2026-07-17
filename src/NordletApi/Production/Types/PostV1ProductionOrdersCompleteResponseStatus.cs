using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionOrdersCompleteResponseStatus.PostV1ProductionOrdersCompleteResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionOrdersCompleteResponseStatus : IStringEnum
{
    public static readonly PostV1ProductionOrdersCompleteResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1ProductionOrdersCompleteResponseStatus Completed = new(
        Values.Completed
    );

    public PostV1ProductionOrdersCompleteResponseStatus(string value)
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
    public static PostV1ProductionOrdersCompleteResponseStatus FromCustom(string value)
    {
        return new PostV1ProductionOrdersCompleteResponseStatus(value);
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
        PostV1ProductionOrdersCompleteResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionOrdersCompleteResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProductionOrdersCompleteResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1ProductionOrdersCompleteResponseStatus(string value) =>
        new(value);

    internal class PostV1ProductionOrdersCompleteResponseStatusSerializer
        : JsonConverter<PostV1ProductionOrdersCompleteResponseStatus>
    {
        public override PostV1ProductionOrdersCompleteResponseStatus Read(
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
            return new PostV1ProductionOrdersCompleteResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionOrdersCompleteResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionOrdersCompleteResponseStatus ReadAsPropertyName(
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
            return new PostV1ProductionOrdersCompleteResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionOrdersCompleteResponseStatus value,
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
        public const string Draft = "draft";

        public const string Completed = "completed";
    }
}
