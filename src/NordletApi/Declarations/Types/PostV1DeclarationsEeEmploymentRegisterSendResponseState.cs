using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsEeEmploymentRegisterSendResponseState.PostV1DeclarationsEeEmploymentRegisterSendResponseStateSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsEeEmploymentRegisterSendResponseState : IStringEnum
{
    public static readonly PostV1DeclarationsEeEmploymentRegisterSendResponseState Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1DeclarationsEeEmploymentRegisterSendResponseState Accepted = new(
        Values.Accepted
    );

    public static readonly PostV1DeclarationsEeEmploymentRegisterSendResponseState Rejected = new(
        Values.Rejected
    );

    public PostV1DeclarationsEeEmploymentRegisterSendResponseState(string value)
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
    public static PostV1DeclarationsEeEmploymentRegisterSendResponseState FromCustom(string value)
    {
        return new PostV1DeclarationsEeEmploymentRegisterSendResponseState(value);
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
        PostV1DeclarationsEeEmploymentRegisterSendResponseState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsEeEmploymentRegisterSendResponseState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsEeEmploymentRegisterSendResponseState value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsEeEmploymentRegisterSendResponseState(
        string value
    ) => new(value);

    internal class PostV1DeclarationsEeEmploymentRegisterSendResponseStateSerializer
        : JsonConverter<PostV1DeclarationsEeEmploymentRegisterSendResponseState>
    {
        public override PostV1DeclarationsEeEmploymentRegisterSendResponseState Read(
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
            return new PostV1DeclarationsEeEmploymentRegisterSendResponseState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsEeEmploymentRegisterSendResponseState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsEeEmploymentRegisterSendResponseState ReadAsPropertyName(
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
            return new PostV1DeclarationsEeEmploymentRegisterSendResponseState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsEeEmploymentRegisterSendResponseState value,
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
        public const string Submitted = "submitted";

        public const string Accepted = "accepted";

        public const string Rejected = "rejected";
    }
}
