using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersVatReviewsResolveResponseReason.PostV1PartnersVatReviewsResolveResponseReasonSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersVatReviewsResolveResponseReason : IStringEnum
{
    public static readonly PostV1PartnersVatReviewsResolveResponseReason Invalid = new(
        Values.Invalid
    );

    public static readonly PostV1PartnersVatReviewsResolveResponseReason ServiceError = new(
        Values.ServiceError
    );

    public static readonly PostV1PartnersVatReviewsResolveResponseReason NameMismatch = new(
        Values.NameMismatch
    );

    public PostV1PartnersVatReviewsResolveResponseReason(string value)
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
    public static PostV1PartnersVatReviewsResolveResponseReason FromCustom(string value)
    {
        return new PostV1PartnersVatReviewsResolveResponseReason(value);
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
        PostV1PartnersVatReviewsResolveResponseReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersVatReviewsResolveResponseReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersVatReviewsResolveResponseReason value) =>
        value.Value;

    public static explicit operator PostV1PartnersVatReviewsResolveResponseReason(string value) =>
        new(value);

    internal class PostV1PartnersVatReviewsResolveResponseReasonSerializer
        : JsonConverter<PostV1PartnersVatReviewsResolveResponseReason>
    {
        public override PostV1PartnersVatReviewsResolveResponseReason Read(
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
            return new PostV1PartnersVatReviewsResolveResponseReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersVatReviewsResolveResponseReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersVatReviewsResolveResponseReason ReadAsPropertyName(
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
            return new PostV1PartnersVatReviewsResolveResponseReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersVatReviewsResolveResponseReason value,
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
        public const string Invalid = "invalid";

        public const string ServiceError = "service_error";

        public const string NameMismatch = "name_mismatch";
    }
}
