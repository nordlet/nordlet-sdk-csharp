using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VatReviewsListPartnersResponseRowsItemStatus.VatReviewsListPartnersResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct VatReviewsListPartnersResponseRowsItemStatus : IStringEnum
{
    public static readonly VatReviewsListPartnersResponseRowsItemStatus Open = new(Values.Open);

    public static readonly VatReviewsListPartnersResponseRowsItemStatus Resolved = new(
        Values.Resolved
    );

    public VatReviewsListPartnersResponseRowsItemStatus(string value)
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
    public static VatReviewsListPartnersResponseRowsItemStatus FromCustom(string value)
    {
        return new VatReviewsListPartnersResponseRowsItemStatus(value);
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
        VatReviewsListPartnersResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VatReviewsListPartnersResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VatReviewsListPartnersResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator VatReviewsListPartnersResponseRowsItemStatus(string value) =>
        new(value);

    internal class VatReviewsListPartnersResponseRowsItemStatusSerializer
        : JsonConverter<VatReviewsListPartnersResponseRowsItemStatus>
    {
        public override VatReviewsListPartnersResponseRowsItemStatus Read(
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
            return new VatReviewsListPartnersResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatReviewsListPartnersResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatReviewsListPartnersResponseRowsItemStatus ReadAsPropertyName(
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
            return new VatReviewsListPartnersResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatReviewsListPartnersResponseRowsItemStatus value,
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
