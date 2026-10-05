using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VatReviewsResolvePartnersResponseReason.VatReviewsResolvePartnersResponseReasonSerializer)
)]
[Serializable]
public readonly record struct VatReviewsResolvePartnersResponseReason : IStringEnum
{
    public static readonly VatReviewsResolvePartnersResponseReason Invalid = new(Values.Invalid);

    public static readonly VatReviewsResolvePartnersResponseReason ServiceError = new(
        Values.ServiceError
    );

    public static readonly VatReviewsResolvePartnersResponseReason NameMismatch = new(
        Values.NameMismatch
    );

    public VatReviewsResolvePartnersResponseReason(string value)
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
    public static VatReviewsResolvePartnersResponseReason FromCustom(string value)
    {
        return new VatReviewsResolvePartnersResponseReason(value);
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

    public static bool operator ==(VatReviewsResolvePartnersResponseReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VatReviewsResolvePartnersResponseReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VatReviewsResolvePartnersResponseReason value) =>
        value.Value;

    public static explicit operator VatReviewsResolvePartnersResponseReason(string value) =>
        new(value);

    internal class VatReviewsResolvePartnersResponseReasonSerializer
        : JsonConverter<VatReviewsResolvePartnersResponseReason>
    {
        public override VatReviewsResolvePartnersResponseReason Read(
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
            return new VatReviewsResolvePartnersResponseReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatReviewsResolvePartnersResponseReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatReviewsResolvePartnersResponseReason ReadAsPropertyName(
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
            return new VatReviewsResolvePartnersResponseReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatReviewsResolvePartnersResponseReason value,
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
