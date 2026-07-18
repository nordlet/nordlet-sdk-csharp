using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AgreementsAgreementsGetResponseBillingPeriod.PostV1AgreementsAgreementsGetResponseBillingPeriodSerializer)
)]
[Serializable]
public readonly record struct PostV1AgreementsAgreementsGetResponseBillingPeriod : IStringEnum
{
    public static readonly PostV1AgreementsAgreementsGetResponseBillingPeriod Monthly = new(
        Values.Monthly
    );

    public static readonly PostV1AgreementsAgreementsGetResponseBillingPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly PostV1AgreementsAgreementsGetResponseBillingPeriod Annual = new(
        Values.Annual
    );

    public PostV1AgreementsAgreementsGetResponseBillingPeriod(string value)
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
    public static PostV1AgreementsAgreementsGetResponseBillingPeriod FromCustom(string value)
    {
        return new PostV1AgreementsAgreementsGetResponseBillingPeriod(value);
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
        PostV1AgreementsAgreementsGetResponseBillingPeriod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AgreementsAgreementsGetResponseBillingPeriod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1AgreementsAgreementsGetResponseBillingPeriod value
    ) => value.Value;

    public static explicit operator PostV1AgreementsAgreementsGetResponseBillingPeriod(
        string value
    ) => new(value);

    internal class PostV1AgreementsAgreementsGetResponseBillingPeriodSerializer
        : JsonConverter<PostV1AgreementsAgreementsGetResponseBillingPeriod>
    {
        public override PostV1AgreementsAgreementsGetResponseBillingPeriod Read(
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
            return new PostV1AgreementsAgreementsGetResponseBillingPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsGetResponseBillingPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AgreementsAgreementsGetResponseBillingPeriod ReadAsPropertyName(
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
            return new PostV1AgreementsAgreementsGetResponseBillingPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsGetResponseBillingPeriod value,
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
