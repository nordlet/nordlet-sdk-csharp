using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersVatReviewsResolveResponseStatus.PostV1PartnersVatReviewsResolveResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersVatReviewsResolveResponseStatus : IStringEnum
{
    public static readonly PostV1PartnersVatReviewsResolveResponseStatus Open = new(Values.Open);

    public static readonly PostV1PartnersVatReviewsResolveResponseStatus Resolved = new(
        Values.Resolved
    );

    public PostV1PartnersVatReviewsResolveResponseStatus(string value)
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
    public static PostV1PartnersVatReviewsResolveResponseStatus FromCustom(string value)
    {
        return new PostV1PartnersVatReviewsResolveResponseStatus(value);
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
        PostV1PartnersVatReviewsResolveResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersVatReviewsResolveResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersVatReviewsResolveResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1PartnersVatReviewsResolveResponseStatus(string value) =>
        new(value);

    internal class PostV1PartnersVatReviewsResolveResponseStatusSerializer
        : JsonConverter<PostV1PartnersVatReviewsResolveResponseStatus>
    {
        public override PostV1PartnersVatReviewsResolveResponseStatus Read(
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
            return new PostV1PartnersVatReviewsResolveResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersVatReviewsResolveResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersVatReviewsResolveResponseStatus ReadAsPropertyName(
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
            return new PostV1PartnersVatReviewsResolveResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersVatReviewsResolveResponseStatus value,
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
        public const string Open = "open";

        public const string Resolved = "resolved";
    }
}
