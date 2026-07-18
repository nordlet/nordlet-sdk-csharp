using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AgreementsAgreementsUpdateRequestBillingPeriod.PostV1AgreementsAgreementsUpdateRequestBillingPeriodSerializer)
)]
[Serializable]
public readonly record struct PostV1AgreementsAgreementsUpdateRequestBillingPeriod : IStringEnum
{
    public static readonly PostV1AgreementsAgreementsUpdateRequestBillingPeriod Monthly = new(
        Values.Monthly
    );

    public static readonly PostV1AgreementsAgreementsUpdateRequestBillingPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly PostV1AgreementsAgreementsUpdateRequestBillingPeriod Annual = new(
        Values.Annual
    );

    public PostV1AgreementsAgreementsUpdateRequestBillingPeriod(string value)
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
    public static PostV1AgreementsAgreementsUpdateRequestBillingPeriod FromCustom(string value)
    {
        return new PostV1AgreementsAgreementsUpdateRequestBillingPeriod(value);
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
        PostV1AgreementsAgreementsUpdateRequestBillingPeriod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AgreementsAgreementsUpdateRequestBillingPeriod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1AgreementsAgreementsUpdateRequestBillingPeriod value
    ) => value.Value;

    public static explicit operator PostV1AgreementsAgreementsUpdateRequestBillingPeriod(
        string value
    ) => new(value);

    internal class PostV1AgreementsAgreementsUpdateRequestBillingPeriodSerializer
        : JsonConverter<PostV1AgreementsAgreementsUpdateRequestBillingPeriod>
    {
        public override PostV1AgreementsAgreementsUpdateRequestBillingPeriod Read(
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
            return new PostV1AgreementsAgreementsUpdateRequestBillingPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsUpdateRequestBillingPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AgreementsAgreementsUpdateRequestBillingPeriod ReadAsPropertyName(
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
            return new PostV1AgreementsAgreementsUpdateRequestBillingPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsUpdateRequestBillingPeriod value,
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
