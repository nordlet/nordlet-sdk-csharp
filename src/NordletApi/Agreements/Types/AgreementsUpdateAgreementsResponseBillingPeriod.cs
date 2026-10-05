using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsUpdateAgreementsResponseBillingPeriod.AgreementsUpdateAgreementsResponseBillingPeriodSerializer)
)]
[Serializable]
public readonly record struct AgreementsUpdateAgreementsResponseBillingPeriod : IStringEnum
{
    public static readonly AgreementsUpdateAgreementsResponseBillingPeriod Monthly = new(
        Values.Monthly
    );

    public static readonly AgreementsUpdateAgreementsResponseBillingPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly AgreementsUpdateAgreementsResponseBillingPeriod Annual = new(
        Values.Annual
    );

    public AgreementsUpdateAgreementsResponseBillingPeriod(string value)
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
    public static AgreementsUpdateAgreementsResponseBillingPeriod FromCustom(string value)
    {
        return new AgreementsUpdateAgreementsResponseBillingPeriod(value);
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
        AgreementsUpdateAgreementsResponseBillingPeriod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AgreementsUpdateAgreementsResponseBillingPeriod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsUpdateAgreementsResponseBillingPeriod value) =>
        value.Value;

    public static explicit operator AgreementsUpdateAgreementsResponseBillingPeriod(string value) =>
        new(value);

    internal class AgreementsUpdateAgreementsResponseBillingPeriodSerializer
        : JsonConverter<AgreementsUpdateAgreementsResponseBillingPeriod>
    {
        public override AgreementsUpdateAgreementsResponseBillingPeriod Read(
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
            return new AgreementsUpdateAgreementsResponseBillingPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsUpdateAgreementsResponseBillingPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsUpdateAgreementsResponseBillingPeriod ReadAsPropertyName(
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
            return new AgreementsUpdateAgreementsResponseBillingPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsUpdateAgreementsResponseBillingPeriod value,
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
