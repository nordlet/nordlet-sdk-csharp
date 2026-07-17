using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersInquiriesListResponseRowsItemStatus.PostV1PartnersInquiriesListResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersInquiriesListResponseRowsItemStatus : IStringEnum
{
    public static readonly PostV1PartnersInquiriesListResponseRowsItemStatus New = new(Values.New);

    public static readonly PostV1PartnersInquiriesListResponseRowsItemStatus InProgress = new(
        Values.InProgress
    );

    public static readonly PostV1PartnersInquiriesListResponseRowsItemStatus Closed = new(
        Values.Closed
    );

    public PostV1PartnersInquiriesListResponseRowsItemStatus(string value)
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
    public static PostV1PartnersInquiriesListResponseRowsItemStatus FromCustom(string value)
    {
        return new PostV1PartnersInquiriesListResponseRowsItemStatus(value);
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
        PostV1PartnersInquiriesListResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersInquiriesListResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PartnersInquiriesListResponseRowsItemStatus value
    ) => value.Value;

    public static explicit operator PostV1PartnersInquiriesListResponseRowsItemStatus(
        string value
    ) => new(value);

    internal class PostV1PartnersInquiriesListResponseRowsItemStatusSerializer
        : JsonConverter<PostV1PartnersInquiriesListResponseRowsItemStatus>
    {
        public override PostV1PartnersInquiriesListResponseRowsItemStatus Read(
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
            return new PostV1PartnersInquiriesListResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersInquiriesListResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersInquiriesListResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1PartnersInquiriesListResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersInquiriesListResponseRowsItemStatus value,
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
