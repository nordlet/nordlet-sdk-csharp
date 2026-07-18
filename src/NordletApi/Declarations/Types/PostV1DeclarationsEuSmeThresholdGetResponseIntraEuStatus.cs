using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus.PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus : IStringEnum
{
    public static readonly PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus Below = new(
        Values.Below
    );

    public static readonly PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus Approaching =
        new(Values.Approaching);

    public static readonly PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus Exceeded = new(
        Values.Exceeded
    );

    public PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus(string value)
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
    public static PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus FromCustom(string value)
    {
        return new PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus(value);
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
        PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus(
        string value
    ) => new(value);

    internal class PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatusSerializer
        : JsonConverter<PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus>
    {
        public override PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus Read(
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
            return new PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus ReadAsPropertyName(
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
            return new PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsEuSmeThresholdGetResponseIntraEuStatus value,
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
    }
}
