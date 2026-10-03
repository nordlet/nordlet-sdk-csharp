using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsEeEmploymentRegisterSendRequestEvent.PostV1DeclarationsEeEmploymentRegisterSendRequestEventSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsEeEmploymentRegisterSendRequestEvent : IStringEnum
{
    public static readonly PostV1DeclarationsEeEmploymentRegisterSendRequestEvent Start = new(
        Values.Start
    );

    public static readonly PostV1DeclarationsEeEmploymentRegisterSendRequestEvent End = new(
        Values.End
    );

    public PostV1DeclarationsEeEmploymentRegisterSendRequestEvent(string value)
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
    public static PostV1DeclarationsEeEmploymentRegisterSendRequestEvent FromCustom(string value)
    {
        return new PostV1DeclarationsEeEmploymentRegisterSendRequestEvent(value);
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
        PostV1DeclarationsEeEmploymentRegisterSendRequestEvent value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsEeEmploymentRegisterSendRequestEvent value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsEeEmploymentRegisterSendRequestEvent value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsEeEmploymentRegisterSendRequestEvent(
        string value
    ) => new(value);

    internal class PostV1DeclarationsEeEmploymentRegisterSendRequestEventSerializer
        : JsonConverter<PostV1DeclarationsEeEmploymentRegisterSendRequestEvent>
    {
        public override PostV1DeclarationsEeEmploymentRegisterSendRequestEvent Read(
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
            return new PostV1DeclarationsEeEmploymentRegisterSendRequestEvent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsEeEmploymentRegisterSendRequestEvent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsEeEmploymentRegisterSendRequestEvent ReadAsPropertyName(
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
            return new PostV1DeclarationsEeEmploymentRegisterSendRequestEvent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsEeEmploymentRegisterSendRequestEvent value,
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
        public const string Start = "start";

        public const string End = "end";
    }
}
