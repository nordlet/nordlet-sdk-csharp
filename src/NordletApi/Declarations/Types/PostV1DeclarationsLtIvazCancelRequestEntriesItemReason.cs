using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsLtIvazCancelRequestEntriesItemReason.PostV1DeclarationsLtIvazCancelRequestEntriesItemReasonSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsLtIvazCancelRequestEntriesItemReason : IStringEnum
{
    public static readonly PostV1DeclarationsLtIvazCancelRequestEntriesItemReason One = new(
        Values.One
    );

    public static readonly PostV1DeclarationsLtIvazCancelRequestEntriesItemReason Two = new(
        Values.Two
    );

    public static readonly PostV1DeclarationsLtIvazCancelRequestEntriesItemReason Three = new(
        Values.Three
    );

    public static readonly PostV1DeclarationsLtIvazCancelRequestEntriesItemReason Four = new(
        Values.Four
    );

    public static readonly PostV1DeclarationsLtIvazCancelRequestEntriesItemReason Five = new(
        Values.Five
    );

    public static readonly PostV1DeclarationsLtIvazCancelRequestEntriesItemReason Six = new(
        Values.Six
    );

    public PostV1DeclarationsLtIvazCancelRequestEntriesItemReason(string value)
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
    public static PostV1DeclarationsLtIvazCancelRequestEntriesItemReason FromCustom(string value)
    {
        return new PostV1DeclarationsLtIvazCancelRequestEntriesItemReason(value);
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
        PostV1DeclarationsLtIvazCancelRequestEntriesItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsLtIvazCancelRequestEntriesItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsLtIvazCancelRequestEntriesItemReason value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsLtIvazCancelRequestEntriesItemReason(
        string value
    ) => new(value);

    internal class PostV1DeclarationsLtIvazCancelRequestEntriesItemReasonSerializer
        : JsonConverter<PostV1DeclarationsLtIvazCancelRequestEntriesItemReason>
    {
        public override PostV1DeclarationsLtIvazCancelRequestEntriesItemReason Read(
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
            return new PostV1DeclarationsLtIvazCancelRequestEntriesItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtIvazCancelRequestEntriesItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsLtIvazCancelRequestEntriesItemReason ReadAsPropertyName(
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
            return new PostV1DeclarationsLtIvazCancelRequestEntriesItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtIvazCancelRequestEntriesItemReason value,
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
        public const string One = "1";

        public const string Two = "2";

        public const string Three = "3";

        public const string Four = "4";

        public const string Five = "5";

        public const string Six = "6";
    }
}
