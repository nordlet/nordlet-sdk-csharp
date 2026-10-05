using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsCreateAgreementsRequestBillingPeriod.AgreementsCreateAgreementsRequestBillingPeriodSerializer)
)]
[Serializable]
public readonly record struct AgreementsCreateAgreementsRequestBillingPeriod : IStringEnum
{
    public static readonly AgreementsCreateAgreementsRequestBillingPeriod Monthly = new(
        Values.Monthly
    );

    public static readonly AgreementsCreateAgreementsRequestBillingPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly AgreementsCreateAgreementsRequestBillingPeriod Annual = new(
        Values.Annual
    );

    public AgreementsCreateAgreementsRequestBillingPeriod(string value)
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
    public static AgreementsCreateAgreementsRequestBillingPeriod FromCustom(string value)
    {
        return new AgreementsCreateAgreementsRequestBillingPeriod(value);
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
        AgreementsCreateAgreementsRequestBillingPeriod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AgreementsCreateAgreementsRequestBillingPeriod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsCreateAgreementsRequestBillingPeriod value) =>
        value.Value;

    public static explicit operator AgreementsCreateAgreementsRequestBillingPeriod(string value) =>
        new(value);

    internal class AgreementsCreateAgreementsRequestBillingPeriodSerializer
        : JsonConverter<AgreementsCreateAgreementsRequestBillingPeriod>
    {
        public override AgreementsCreateAgreementsRequestBillingPeriod Read(
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
            return new AgreementsCreateAgreementsRequestBillingPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsCreateAgreementsRequestBillingPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsCreateAgreementsRequestBillingPeriod ReadAsPropertyName(
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
            return new AgreementsCreateAgreementsRequestBillingPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsCreateAgreementsRequestBillingPeriod value,
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
