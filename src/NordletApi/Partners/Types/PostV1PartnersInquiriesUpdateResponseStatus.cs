using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersInquiriesUpdateResponseStatus.PostV1PartnersInquiriesUpdateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersInquiriesUpdateResponseStatus : IStringEnum
{
    public static readonly PostV1PartnersInquiriesUpdateResponseStatus New = new(Values.New);

    public static readonly PostV1PartnersInquiriesUpdateResponseStatus InProgress = new(
        Values.InProgress
    );

    public static readonly PostV1PartnersInquiriesUpdateResponseStatus Closed = new(Values.Closed);

    public PostV1PartnersInquiriesUpdateResponseStatus(string value)
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
    public static PostV1PartnersInquiriesUpdateResponseStatus FromCustom(string value)
    {
        return new PostV1PartnersInquiriesUpdateResponseStatus(value);
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
        PostV1PartnersInquiriesUpdateResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersInquiriesUpdateResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersInquiriesUpdateResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1PartnersInquiriesUpdateResponseStatus(string value) =>
        new(value);

    internal class PostV1PartnersInquiriesUpdateResponseStatusSerializer
        : JsonConverter<PostV1PartnersInquiriesUpdateResponseStatus>
    {
        public override PostV1PartnersInquiriesUpdateResponseStatus Read(
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
            return new PostV1PartnersInquiriesUpdateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersInquiriesUpdateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersInquiriesUpdateResponseStatus ReadAsPropertyName(
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
            return new PostV1PartnersInquiriesUpdateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersInquiriesUpdateResponseStatus value,
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
