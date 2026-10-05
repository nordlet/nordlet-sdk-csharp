using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VatReviewsResolvePartnersResponseStatus.VatReviewsResolvePartnersResponseStatusSerializer)
)]
[Serializable]
public readonly record struct VatReviewsResolvePartnersResponseStatus : IStringEnum
{
    public static readonly VatReviewsResolvePartnersResponseStatus Open = new(Values.Open);

    public static readonly VatReviewsResolvePartnersResponseStatus Resolved = new(Values.Resolved);

    public VatReviewsResolvePartnersResponseStatus(string value)
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
    public static VatReviewsResolvePartnersResponseStatus FromCustom(string value)
    {
        return new VatReviewsResolvePartnersResponseStatus(value);
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

    public static bool operator ==(VatReviewsResolvePartnersResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VatReviewsResolvePartnersResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VatReviewsResolvePartnersResponseStatus value) =>
        value.Value;

    public static explicit operator VatReviewsResolvePartnersResponseStatus(string value) =>
        new(value);

    internal class VatReviewsResolvePartnersResponseStatusSerializer
        : JsonConverter<VatReviewsResolvePartnersResponseStatus>
    {
        public override VatReviewsResolvePartnersResponseStatus Read(
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
            return new VatReviewsResolvePartnersResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatReviewsResolvePartnersResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatReviewsResolvePartnersResponseStatus ReadAsPropertyName(
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
            return new VatReviewsResolvePartnersResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatReviewsResolvePartnersResponseStatus value,
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
