using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsLtSaftSendResponseState.PostV1DeclarationsLtSaftSendResponseStateSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsLtSaftSendResponseState : IStringEnum
{
    public static readonly PostV1DeclarationsLtSaftSendResponseState Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1DeclarationsLtSaftSendResponseState Accepted = new(
        Values.Accepted
    );

    public static readonly PostV1DeclarationsLtSaftSendResponseState Rejected = new(
        Values.Rejected
    );

    public PostV1DeclarationsLtSaftSendResponseState(string value)
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
    public static PostV1DeclarationsLtSaftSendResponseState FromCustom(string value)
    {
        return new PostV1DeclarationsLtSaftSendResponseState(value);
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
        PostV1DeclarationsLtSaftSendResponseState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsLtSaftSendResponseState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DeclarationsLtSaftSendResponseState value) =>
        value.Value;

    public static explicit operator PostV1DeclarationsLtSaftSendResponseState(string value) =>
        new(value);

    internal class PostV1DeclarationsLtSaftSendResponseStateSerializer
        : JsonConverter<PostV1DeclarationsLtSaftSendResponseState>
    {
        public override PostV1DeclarationsLtSaftSendResponseState Read(
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
            return new PostV1DeclarationsLtSaftSendResponseState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtSaftSendResponseState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsLtSaftSendResponseState ReadAsPropertyName(
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
            return new PostV1DeclarationsLtSaftSendResponseState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtSaftSendResponseState value,
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
