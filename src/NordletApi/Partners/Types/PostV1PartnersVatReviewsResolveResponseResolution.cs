using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersVatReviewsResolveResponseResolution.PostV1PartnersVatReviewsResolveResponseResolutionSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersVatReviewsResolveResponseResolution : IStringEnum
{
    public static readonly PostV1PartnersVatReviewsResolveResponseResolution ConfirmedValid = new(
        Values.ConfirmedValid
    );

    public static readonly PostV1PartnersVatReviewsResolveResponseResolution ConfirmedInvalid = new(
        Values.ConfirmedInvalid
    );

    public static readonly PostV1PartnersVatReviewsResolveResponseResolution Dismissed = new(
        Values.Dismissed
    );

    public static readonly PostV1PartnersVatReviewsResolveResponseResolution Revalidated = new(
        Values.Revalidated
    );

    public static readonly PostV1PartnersVatReviewsResolveResponseResolution Superseded = new(
        Values.Superseded
    );

    public PostV1PartnersVatReviewsResolveResponseResolution(string value)
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
    public static PostV1PartnersVatReviewsResolveResponseResolution FromCustom(string value)
    {
        return new PostV1PartnersVatReviewsResolveResponseResolution(value);
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
        PostV1PartnersVatReviewsResolveResponseResolution value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersVatReviewsResolveResponseResolution value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PartnersVatReviewsResolveResponseResolution value
    ) => value.Value;

    public static explicit operator PostV1PartnersVatReviewsResolveResponseResolution(
        string value
    ) => new(value);

    internal class PostV1PartnersVatReviewsResolveResponseResolutionSerializer
        : JsonConverter<PostV1PartnersVatReviewsResolveResponseResolution>
    {
        public override PostV1PartnersVatReviewsResolveResponseResolution Read(
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
            return new PostV1PartnersVatReviewsResolveResponseResolution(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersVatReviewsResolveResponseResolution value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersVatReviewsResolveResponseResolution ReadAsPropertyName(
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
            return new PostV1PartnersVatReviewsResolveResponseResolution(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersVatReviewsResolveResponseResolution value,
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

        public const string Revalidated = "revalidated";

        public const string Superseded = "superseded";
    }
}
