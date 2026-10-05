using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsGetAgreementsResponseBillingPeriod.AgreementsGetAgreementsResponseBillingPeriodSerializer)
)]
[Serializable]
public readonly record struct AgreementsGetAgreementsResponseBillingPeriod : IStringEnum
{
    public static readonly AgreementsGetAgreementsResponseBillingPeriod Monthly = new(
        Values.Monthly
    );

    public static readonly AgreementsGetAgreementsResponseBillingPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly AgreementsGetAgreementsResponseBillingPeriod Annual = new(Values.Annual);

    public AgreementsGetAgreementsResponseBillingPeriod(string value)
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
    public static AgreementsGetAgreementsResponseBillingPeriod FromCustom(string value)
    {
        return new AgreementsGetAgreementsResponseBillingPeriod(value);
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
        AgreementsGetAgreementsResponseBillingPeriod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AgreementsGetAgreementsResponseBillingPeriod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsGetAgreementsResponseBillingPeriod value) =>
        value.Value;

    public static explicit operator AgreementsGetAgreementsResponseBillingPeriod(string value) =>
        new(value);

    internal class AgreementsGetAgreementsResponseBillingPeriodSerializer
        : JsonConverter<AgreementsGetAgreementsResponseBillingPeriod>
    {
        public override AgreementsGetAgreementsResponseBillingPeriod Read(
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
            return new AgreementsGetAgreementsResponseBillingPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsGetAgreementsResponseBillingPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsGetAgreementsResponseBillingPeriod ReadAsPropertyName(
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
            return new AgreementsGetAgreementsResponseBillingPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsGetAgreementsResponseBillingPeriod value,
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
