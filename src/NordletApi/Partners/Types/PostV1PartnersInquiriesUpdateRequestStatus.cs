using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersInquiriesUpdateRequestStatus.PostV1PartnersInquiriesUpdateRequestStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersInquiriesUpdateRequestStatus : IStringEnum
{
    public static readonly PostV1PartnersInquiriesUpdateRequestStatus New = new(Values.New);

    public static readonly PostV1PartnersInquiriesUpdateRequestStatus InProgress = new(
        Values.InProgress
    );

    public static readonly PostV1PartnersInquiriesUpdateRequestStatus Closed = new(Values.Closed);

    public PostV1PartnersInquiriesUpdateRequestStatus(string value)
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
    public static PostV1PartnersInquiriesUpdateRequestStatus FromCustom(string value)
    {
        return new PostV1PartnersInquiriesUpdateRequestStatus(value);
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
        PostV1PartnersInquiriesUpdateRequestStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersInquiriesUpdateRequestStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersInquiriesUpdateRequestStatus value) =>
        value.Value;

    public static explicit operator PostV1PartnersInquiriesUpdateRequestStatus(string value) =>
        new(value);

    internal class PostV1PartnersInquiriesUpdateRequestStatusSerializer
        : JsonConverter<PostV1PartnersInquiriesUpdateRequestStatus>
    {
        public override PostV1PartnersInquiriesUpdateRequestStatus Read(
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
            return new PostV1PartnersInquiriesUpdateRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersInquiriesUpdateRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersInquiriesUpdateRequestStatus ReadAsPropertyName(
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
            return new PostV1PartnersInquiriesUpdateRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersInquiriesUpdateRequestStatus value,
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
