using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VatReviewsListPartnersResponseRowsItemResolution.VatReviewsListPartnersResponseRowsItemResolutionSerializer)
)]
[Serializable]
public readonly record struct VatReviewsListPartnersResponseRowsItemResolution : IStringEnum
{
    public static readonly VatReviewsListPartnersResponseRowsItemResolution ConfirmedValid = new(
        Values.ConfirmedValid
    );

    public static readonly VatReviewsListPartnersResponseRowsItemResolution ConfirmedInvalid = new(
        Values.ConfirmedInvalid
    );

    public static readonly VatReviewsListPartnersResponseRowsItemResolution Dismissed = new(
        Values.Dismissed
    );

    public static readonly VatReviewsListPartnersResponseRowsItemResolution Revalidated = new(
        Values.Revalidated
    );

    public static readonly VatReviewsListPartnersResponseRowsItemResolution Superseded = new(
        Values.Superseded
    );

    public VatReviewsListPartnersResponseRowsItemResolution(string value)
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
    public static VatReviewsListPartnersResponseRowsItemResolution FromCustom(string value)
    {
        return new VatReviewsListPartnersResponseRowsItemResolution(value);
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
        VatReviewsListPartnersResponseRowsItemResolution value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VatReviewsListPartnersResponseRowsItemResolution value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VatReviewsListPartnersResponseRowsItemResolution value
    ) => value.Value;

    public static explicit operator VatReviewsListPartnersResponseRowsItemResolution(
        string value
    ) => new(value);

    internal class VatReviewsListPartnersResponseRowsItemResolutionSerializer
        : JsonConverter<VatReviewsListPartnersResponseRowsItemResolution>
    {
        public override VatReviewsListPartnersResponseRowsItemResolution Read(
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
            return new VatReviewsListPartnersResponseRowsItemResolution(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatReviewsListPartnersResponseRowsItemResolution value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatReviewsListPartnersResponseRowsItemResolution ReadAsPropertyName(
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
            return new VatReviewsListPartnersResponseRowsItemResolution(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatReviewsListPartnersResponseRowsItemResolution value,
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
