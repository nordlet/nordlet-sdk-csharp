using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsPlIntrastatGenerateResponseFlow.PostV1DeclarationsPlIntrastatGenerateResponseFlowSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsPlIntrastatGenerateResponseFlow : IStringEnum
{
    public static readonly PostV1DeclarationsPlIntrastatGenerateResponseFlow Arrivals = new(
        Values.Arrivals
    );

    public static readonly PostV1DeclarationsPlIntrastatGenerateResponseFlow Dispatches = new(
        Values.Dispatches
    );

    public PostV1DeclarationsPlIntrastatGenerateResponseFlow(string value)
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
    public static PostV1DeclarationsPlIntrastatGenerateResponseFlow FromCustom(string value)
    {
        return new PostV1DeclarationsPlIntrastatGenerateResponseFlow(value);
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
        PostV1DeclarationsPlIntrastatGenerateResponseFlow value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsPlIntrastatGenerateResponseFlow value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsPlIntrastatGenerateResponseFlow value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsPlIntrastatGenerateResponseFlow(
        string value
    ) => new(value);

    internal class PostV1DeclarationsPlIntrastatGenerateResponseFlowSerializer
        : JsonConverter<PostV1DeclarationsPlIntrastatGenerateResponseFlow>
    {
        public override PostV1DeclarationsPlIntrastatGenerateResponseFlow Read(
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
            return new PostV1DeclarationsPlIntrastatGenerateResponseFlow(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsPlIntrastatGenerateResponseFlow value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsPlIntrastatGenerateResponseFlow ReadAsPropertyName(
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
            return new PostV1DeclarationsPlIntrastatGenerateResponseFlow(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsPlIntrastatGenerateResponseFlow value,
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
        public const string Arrivals = "arrivals";

        public const string Dispatches = "dispatches";
    }
}
