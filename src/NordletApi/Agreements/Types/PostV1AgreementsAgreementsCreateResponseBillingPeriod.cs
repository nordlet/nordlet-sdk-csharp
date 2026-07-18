using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AgreementsAgreementsCreateResponseBillingPeriod.PostV1AgreementsAgreementsCreateResponseBillingPeriodSerializer)
)]
[Serializable]
public readonly record struct PostV1AgreementsAgreementsCreateResponseBillingPeriod : IStringEnum
{
    public static readonly PostV1AgreementsAgreementsCreateResponseBillingPeriod Monthly = new(
        Values.Monthly
    );

    public static readonly PostV1AgreementsAgreementsCreateResponseBillingPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly PostV1AgreementsAgreementsCreateResponseBillingPeriod Annual = new(
        Values.Annual
    );

    public PostV1AgreementsAgreementsCreateResponseBillingPeriod(string value)
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
    public static PostV1AgreementsAgreementsCreateResponseBillingPeriod FromCustom(string value)
    {
        return new PostV1AgreementsAgreementsCreateResponseBillingPeriod(value);
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
        PostV1AgreementsAgreementsCreateResponseBillingPeriod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AgreementsAgreementsCreateResponseBillingPeriod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1AgreementsAgreementsCreateResponseBillingPeriod value
    ) => value.Value;

    public static explicit operator PostV1AgreementsAgreementsCreateResponseBillingPeriod(
        string value
    ) => new(value);

    internal class PostV1AgreementsAgreementsCreateResponseBillingPeriodSerializer
        : JsonConverter<PostV1AgreementsAgreementsCreateResponseBillingPeriod>
    {
        public override PostV1AgreementsAgreementsCreateResponseBillingPeriod Read(
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
            return new PostV1AgreementsAgreementsCreateResponseBillingPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsCreateResponseBillingPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AgreementsAgreementsCreateResponseBillingPeriod ReadAsPropertyName(
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
            return new PostV1AgreementsAgreementsCreateResponseBillingPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsCreateResponseBillingPeriod value,
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
        public const string Monthly = "monthly";

        public const string Quarterly = "quarterly";

        public const string Annual = "annual";
    }
}
