using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersInquiriesCreateResponseStatus.PostV1PartnersInquiriesCreateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersInquiriesCreateResponseStatus : IStringEnum
{
    public static readonly PostV1PartnersInquiriesCreateResponseStatus New = new(Values.New);

    public static readonly PostV1PartnersInquiriesCreateResponseStatus InProgress = new(
        Values.InProgress
    );

    public static readonly PostV1PartnersInquiriesCreateResponseStatus Closed = new(Values.Closed);

    public PostV1PartnersInquiriesCreateResponseStatus(string value)
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
    public static PostV1PartnersInquiriesCreateResponseStatus FromCustom(string value)
    {
        return new PostV1PartnersInquiriesCreateResponseStatus(value);
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
        PostV1PartnersInquiriesCreateResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersInquiriesCreateResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersInquiriesCreateResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1PartnersInquiriesCreateResponseStatus(string value) =>
        new(value);

    internal class PostV1PartnersInquiriesCreateResponseStatusSerializer
        : JsonConverter<PostV1PartnersInquiriesCreateResponseStatus>
    {
        public override PostV1PartnersInquiriesCreateResponseStatus Read(
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
            return new PostV1PartnersInquiriesCreateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersInquiriesCreateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersInquiriesCreateResponseStatus ReadAsPropertyName(
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
            return new PostV1PartnersInquiriesCreateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersInquiriesCreateResponseStatus value,
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
        public const string New = "new";

        public const string InProgress = "in_progress";

        public const string Closed = "closed";
    }
}
