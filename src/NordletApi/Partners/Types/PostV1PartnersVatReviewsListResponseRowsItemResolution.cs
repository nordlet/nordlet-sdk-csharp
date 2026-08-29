using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersVatReviewsListResponseRowsItemResolution.PostV1PartnersVatReviewsListResponseRowsItemResolutionSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersVatReviewsListResponseRowsItemResolution : IStringEnum
{
    public static readonly PostV1PartnersVatReviewsListResponseRowsItemResolution ConfirmedValid =
        new(Values.ConfirmedValid);

    public static readonly PostV1PartnersVatReviewsListResponseRowsItemResolution ConfirmedInvalid =
        new(Values.ConfirmedInvalid);

    public static readonly PostV1PartnersVatReviewsListResponseRowsItemResolution Dismissed = new(
        Values.Dismissed
    );

    public static readonly PostV1PartnersVatReviewsListResponseRowsItemResolution Revalidated = new(
        Values.Revalidated
    );

    public static readonly PostV1PartnersVatReviewsListResponseRowsItemResolution Superseded = new(
        Values.Superseded
    );

    public PostV1PartnersVatReviewsListResponseRowsItemResolution(string value)
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
    public static PostV1PartnersVatReviewsListResponseRowsItemResolution FromCustom(string value)
    {
        return new PostV1PartnersVatReviewsListResponseRowsItemResolution(value);
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
        PostV1PartnersVatReviewsListResponseRowsItemResolution value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersVatReviewsListResponseRowsItemResolution value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PartnersVatReviewsListResponseRowsItemResolution value
    ) => value.Value;

    public static explicit operator PostV1PartnersVatReviewsListResponseRowsItemResolution(
        string value
    ) => new(value);

    internal class PostV1PartnersVatReviewsListResponseRowsItemResolutionSerializer
        : JsonConverter<PostV1PartnersVatReviewsListResponseRowsItemResolution>
    {
        public override PostV1PartnersVatReviewsListResponseRowsItemResolution Read(
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
            return new PostV1PartnersVatReviewsListResponseRowsItemResolution(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersVatReviewsListResponseRowsItemResolution value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersVatReviewsListResponseRowsItemResolution ReadAsPropertyName(
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
            return new PostV1PartnersVatReviewsListResponseRowsItemResolution(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersVatReviewsListResponseRowsItemResolution value,
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
