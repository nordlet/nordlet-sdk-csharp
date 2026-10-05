using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VatReviewsListPartnersResponseRowsItemReason.VatReviewsListPartnersResponseRowsItemReasonSerializer)
)]
[Serializable]
public readonly record struct VatReviewsListPartnersResponseRowsItemReason : IStringEnum
{
    public static readonly VatReviewsListPartnersResponseRowsItemReason Invalid = new(
        Values.Invalid
    );

    public static readonly VatReviewsListPartnersResponseRowsItemReason ServiceError = new(
        Values.ServiceError
    );

    public static readonly VatReviewsListPartnersResponseRowsItemReason NameMismatch = new(
        Values.NameMismatch
    );

    public VatReviewsListPartnersResponseRowsItemReason(string value)
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
    public static VatReviewsListPartnersResponseRowsItemReason FromCustom(string value)
    {
        return new VatReviewsListPartnersResponseRowsItemReason(value);
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
        VatReviewsListPartnersResponseRowsItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VatReviewsListPartnersResponseRowsItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VatReviewsListPartnersResponseRowsItemReason value) =>
        value.Value;

    public static explicit operator VatReviewsListPartnersResponseRowsItemReason(string value) =>
        new(value);

    internal class VatReviewsListPartnersResponseRowsItemReasonSerializer
        : JsonConverter<VatReviewsListPartnersResponseRowsItemReason>
    {
        public override VatReviewsListPartnersResponseRowsItemReason Read(
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
            return new VatReviewsListPartnersResponseRowsItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatReviewsListPartnersResponseRowsItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatReviewsListPartnersResponseRowsItemReason ReadAsPropertyName(
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
            return new VatReviewsListPartnersResponseRowsItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatReviewsListPartnersResponseRowsItemReason value,
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
