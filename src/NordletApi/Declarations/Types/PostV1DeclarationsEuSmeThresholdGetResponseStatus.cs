using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsEuSmeThresholdGetResponseStatus.PostV1DeclarationsEuSmeThresholdGetResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsEuSmeThresholdGetResponseStatus : IStringEnum
{
    public static readonly PostV1DeclarationsEuSmeThresholdGetResponseStatus NotApplicable = new(
        Values.NotApplicable
    );

    public static readonly PostV1DeclarationsEuSmeThresholdGetResponseStatus Below = new(
        Values.Below
    );

    public static readonly PostV1DeclarationsEuSmeThresholdGetResponseStatus Approaching = new(
        Values.Approaching
    );

    public static readonly PostV1DeclarationsEuSmeThresholdGetResponseStatus Exceeded = new(
        Values.Exceeded
    );

    public static readonly PostV1DeclarationsEuSmeThresholdGetResponseStatus Unknown = new(
        Values.Unknown
    );

    public PostV1DeclarationsEuSmeThresholdGetResponseStatus(string value)
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
    public static PostV1DeclarationsEuSmeThresholdGetResponseStatus FromCustom(string value)
    {
        return new PostV1DeclarationsEuSmeThresholdGetResponseStatus(value);
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
        PostV1DeclarationsEuSmeThresholdGetResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsEuSmeThresholdGetResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsEuSmeThresholdGetResponseStatus value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsEuSmeThresholdGetResponseStatus(
        string value
    ) => new(value);

    internal class PostV1DeclarationsEuSmeThresholdGetResponseStatusSerializer
        : JsonConverter<PostV1DeclarationsEuSmeThresholdGetResponseStatus>
    {
        public override PostV1DeclarationsEuSmeThresholdGetResponseStatus Read(
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
            return new PostV1DeclarationsEuSmeThresholdGetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsEuSmeThresholdGetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsEuSmeThresholdGetResponseStatus ReadAsPropertyName(
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
            return new PostV1DeclarationsEuSmeThresholdGetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsEuSmeThresholdGetResponseStatus value,
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
        public const string NotApplicable = "not_applicable";

        public const string Below = "below";

        public const string Approaching = "approaching";

        public const string Exceeded = "exceeded";

        public const string Unknown = "unknown";
    }
}
