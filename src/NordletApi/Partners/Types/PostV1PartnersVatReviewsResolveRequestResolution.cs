using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersVatReviewsResolveRequestResolution.PostV1PartnersVatReviewsResolveRequestResolutionSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersVatReviewsResolveRequestResolution : IStringEnum
{
    public static readonly PostV1PartnersVatReviewsResolveRequestResolution ConfirmedValid = new(
        Values.ConfirmedValid
    );

    public static readonly PostV1PartnersVatReviewsResolveRequestResolution ConfirmedInvalid = new(
        Values.ConfirmedInvalid
    );

    public static readonly PostV1PartnersVatReviewsResolveRequestResolution Dismissed = new(
        Values.Dismissed
    );

    public PostV1PartnersVatReviewsResolveRequestResolution(string value)
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
    public static PostV1PartnersVatReviewsResolveRequestResolution FromCustom(string value)
    {
        return new PostV1PartnersVatReviewsResolveRequestResolution(value);
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
        PostV1PartnersVatReviewsResolveRequestResolution value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersVatReviewsResolveRequestResolution value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PartnersVatReviewsResolveRequestResolution value
    ) => value.Value;

    public static explicit operator PostV1PartnersVatReviewsResolveRequestResolution(
        string value
    ) => new(value);

    internal class PostV1PartnersVatReviewsResolveRequestResolutionSerializer
        : JsonConverter<PostV1PartnersVatReviewsResolveRequestResolution>
    {
        public override PostV1PartnersVatReviewsResolveRequestResolution Read(
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
            return new PostV1PartnersVatReviewsResolveRequestResolution(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersVatReviewsResolveRequestResolution value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersVatReviewsResolveRequestResolution ReadAsPropertyName(
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
            return new PostV1PartnersVatReviewsResolveRequestResolution(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersVatReviewsResolveRequestResolution value,
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
        public const string ConfirmedValid = "confirmed_valid";

        public const string ConfirmedInvalid = "confirmed_invalid";

        public const string Dismissed = "dismissed";
    }
}
