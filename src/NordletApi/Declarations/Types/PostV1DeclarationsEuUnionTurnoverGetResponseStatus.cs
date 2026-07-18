using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsEuUnionTurnoverGetResponseStatus.PostV1DeclarationsEuUnionTurnoverGetResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsEuUnionTurnoverGetResponseStatus : IStringEnum
{
    public static readonly PostV1DeclarationsEuUnionTurnoverGetResponseStatus Below = new(
        Values.Below
    );

    public static readonly PostV1DeclarationsEuUnionTurnoverGetResponseStatus Approaching = new(
        Values.Approaching
    );

    public static readonly PostV1DeclarationsEuUnionTurnoverGetResponseStatus Exceeded = new(
        Values.Exceeded
    );

    public static readonly PostV1DeclarationsEuUnionTurnoverGetResponseStatus NotApplicable = new(
        Values.NotApplicable
    );

    public PostV1DeclarationsEuUnionTurnoverGetResponseStatus(string value)
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
    public static PostV1DeclarationsEuUnionTurnoverGetResponseStatus FromCustom(string value)
    {
        return new PostV1DeclarationsEuUnionTurnoverGetResponseStatus(value);
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
        PostV1DeclarationsEuUnionTurnoverGetResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsEuUnionTurnoverGetResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsEuUnionTurnoverGetResponseStatus value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsEuUnionTurnoverGetResponseStatus(
        string value
    ) => new(value);

    internal class PostV1DeclarationsEuUnionTurnoverGetResponseStatusSerializer
        : JsonConverter<PostV1DeclarationsEuUnionTurnoverGetResponseStatus>
    {
        public override PostV1DeclarationsEuUnionTurnoverGetResponseStatus Read(
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
            return new PostV1DeclarationsEuUnionTurnoverGetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsEuUnionTurnoverGetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsEuUnionTurnoverGetResponseStatus ReadAsPropertyName(
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
            return new PostV1DeclarationsEuUnionTurnoverGetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsEuUnionTurnoverGetResponseStatus value,
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
        public const string Below = "below";

        public const string Approaching = "approaching";

        public const string Exceeded = "exceeded";

        public const string NotApplicable = "not_applicable";
    }
}
