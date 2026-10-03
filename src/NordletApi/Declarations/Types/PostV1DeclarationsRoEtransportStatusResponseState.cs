using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsRoEtransportStatusResponseState.PostV1DeclarationsRoEtransportStatusResponseStateSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsRoEtransportStatusResponseState : IStringEnum
{
    public static readonly PostV1DeclarationsRoEtransportStatusResponseState Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1DeclarationsRoEtransportStatusResponseState Accepted = new(
        Values.Accepted
    );

    public static readonly PostV1DeclarationsRoEtransportStatusResponseState Rejected = new(
        Values.Rejected
    );

    public PostV1DeclarationsRoEtransportStatusResponseState(string value)
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
    public static PostV1DeclarationsRoEtransportStatusResponseState FromCustom(string value)
    {
        return new PostV1DeclarationsRoEtransportStatusResponseState(value);
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
        PostV1DeclarationsRoEtransportStatusResponseState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsRoEtransportStatusResponseState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsRoEtransportStatusResponseState value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsRoEtransportStatusResponseState(
        string value
    ) => new(value);

    internal class PostV1DeclarationsRoEtransportStatusResponseStateSerializer
        : JsonConverter<PostV1DeclarationsRoEtransportStatusResponseState>
    {
        public override PostV1DeclarationsRoEtransportStatusResponseState Read(
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
            return new PostV1DeclarationsRoEtransportStatusResponseState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsRoEtransportStatusResponseState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsRoEtransportStatusResponseState ReadAsPropertyName(
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
            return new PostV1DeclarationsRoEtransportStatusResponseState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsRoEtransportStatusResponseState value,
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
