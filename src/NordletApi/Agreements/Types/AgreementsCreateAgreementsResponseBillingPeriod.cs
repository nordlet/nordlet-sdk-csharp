using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsCreateAgreementsResponseBillingPeriod.AgreementsCreateAgreementsResponseBillingPeriodSerializer)
)]
[Serializable]
public readonly record struct AgreementsCreateAgreementsResponseBillingPeriod : IStringEnum
{
    public static readonly AgreementsCreateAgreementsResponseBillingPeriod Monthly = new(
        Values.Monthly
    );

    public static readonly AgreementsCreateAgreementsResponseBillingPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly AgreementsCreateAgreementsResponseBillingPeriod Annual = new(
        Values.Annual
    );

    public AgreementsCreateAgreementsResponseBillingPeriod(string value)
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
    public static AgreementsCreateAgreementsResponseBillingPeriod FromCustom(string value)
    {
        return new AgreementsCreateAgreementsResponseBillingPeriod(value);
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
        AgreementsCreateAgreementsResponseBillingPeriod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AgreementsCreateAgreementsResponseBillingPeriod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsCreateAgreementsResponseBillingPeriod value) =>
        value.Value;

    public static explicit operator AgreementsCreateAgreementsResponseBillingPeriod(string value) =>
        new(value);

    internal class AgreementsCreateAgreementsResponseBillingPeriodSerializer
        : JsonConverter<AgreementsCreateAgreementsResponseBillingPeriod>
    {
        public override AgreementsCreateAgreementsResponseBillingPeriod Read(
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
            return new AgreementsCreateAgreementsResponseBillingPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsCreateAgreementsResponseBillingPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsCreateAgreementsResponseBillingPeriod ReadAsPropertyName(
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
            return new AgreementsCreateAgreementsResponseBillingPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsCreateAgreementsResponseBillingPeriod value,
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
