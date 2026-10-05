using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VatReviewsResolvePartnersResponseResolution.VatReviewsResolvePartnersResponseResolutionSerializer)
)]
[Serializable]
public readonly record struct VatReviewsResolvePartnersResponseResolution : IStringEnum
{
    public static readonly VatReviewsResolvePartnersResponseResolution ConfirmedValid = new(
        Values.ConfirmedValid
    );

    public static readonly VatReviewsResolvePartnersResponseResolution ConfirmedInvalid = new(
        Values.ConfirmedInvalid
    );

    public static readonly VatReviewsResolvePartnersResponseResolution Dismissed = new(
        Values.Dismissed
    );

    public static readonly VatReviewsResolvePartnersResponseResolution Revalidated = new(
        Values.Revalidated
    );

    public static readonly VatReviewsResolvePartnersResponseResolution Superseded = new(
        Values.Superseded
    );

    public VatReviewsResolvePartnersResponseResolution(string value)
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
    public static VatReviewsResolvePartnersResponseResolution FromCustom(string value)
    {
        return new VatReviewsResolvePartnersResponseResolution(value);
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
        VatReviewsResolvePartnersResponseResolution value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VatReviewsResolvePartnersResponseResolution value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VatReviewsResolvePartnersResponseResolution value) =>
        value.Value;

    public static explicit operator VatReviewsResolvePartnersResponseResolution(string value) =>
        new(value);

    internal class VatReviewsResolvePartnersResponseResolutionSerializer
        : JsonConverter<VatReviewsResolvePartnersResponseResolution>
    {
        public override VatReviewsResolvePartnersResponseResolution Read(
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
            return new VatReviewsResolvePartnersResponseResolution(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatReviewsResolvePartnersResponseResolution value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatReviewsResolvePartnersResponseResolution ReadAsPropertyName(
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
            return new VatReviewsResolvePartnersResponseResolution(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatReviewsResolvePartnersResponseResolution value,
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
