using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionOrdersGetResponseStatus.PostV1ProductionOrdersGetResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionOrdersGetResponseStatus : IStringEnum
{
    public static readonly PostV1ProductionOrdersGetResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1ProductionOrdersGetResponseStatus Completed = new(
        Values.Completed
    );

    public PostV1ProductionOrdersGetResponseStatus(string value)
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
    public static PostV1ProductionOrdersGetResponseStatus FromCustom(string value)
    {
        return new PostV1ProductionOrdersGetResponseStatus(value);
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

    public static bool operator ==(PostV1ProductionOrdersGetResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1ProductionOrdersGetResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProductionOrdersGetResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1ProductionOrdersGetResponseStatus(string value) =>
        new(value);

    internal class PostV1ProductionOrdersGetResponseStatusSerializer
        : JsonConverter<PostV1ProductionOrdersGetResponseStatus>
    {
        public override PostV1ProductionOrdersGetResponseStatus Read(
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
            return new PostV1ProductionOrdersGetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionOrdersGetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionOrdersGetResponseStatus ReadAsPropertyName(
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
            return new PostV1ProductionOrdersGetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionOrdersGetResponseStatus value,
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
