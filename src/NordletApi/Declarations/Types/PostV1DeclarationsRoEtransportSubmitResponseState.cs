using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsRoEtransportSubmitResponseState.PostV1DeclarationsRoEtransportSubmitResponseStateSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsRoEtransportSubmitResponseState : IStringEnum
{
    public static readonly PostV1DeclarationsRoEtransportSubmitResponseState Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1DeclarationsRoEtransportSubmitResponseState Accepted = new(
        Values.Accepted
    );

    public static readonly PostV1DeclarationsRoEtransportSubmitResponseState Rejected = new(
        Values.Rejected
    );

    public PostV1DeclarationsRoEtransportSubmitResponseState(string value)
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
    public static PostV1DeclarationsRoEtransportSubmitResponseState FromCustom(string value)
    {
        return new PostV1DeclarationsRoEtransportSubmitResponseState(value);
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
        PostV1DeclarationsRoEtransportSubmitResponseState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsRoEtransportSubmitResponseState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsRoEtransportSubmitResponseState value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsRoEtransportSubmitResponseState(
        string value
    ) => new(value);

    internal class PostV1DeclarationsRoEtransportSubmitResponseStateSerializer
        : JsonConverter<PostV1DeclarationsRoEtransportSubmitResponseState>
    {
        public override PostV1DeclarationsRoEtransportSubmitResponseState Read(
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
            return new PostV1DeclarationsRoEtransportSubmitResponseState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsRoEtransportSubmitResponseState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsRoEtransportSubmitResponseState ReadAsPropertyName(
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
            return new PostV1DeclarationsRoEtransportSubmitResponseState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsRoEtransportSubmitResponseState value,
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
