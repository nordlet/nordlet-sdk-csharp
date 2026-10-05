using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesProfileAccountResponseVatPeriod.CompaniesProfileAccountResponseVatPeriodSerializer)
)]
[Serializable]
public readonly record struct CompaniesProfileAccountResponseVatPeriod : IStringEnum
{
    public static readonly CompaniesProfileAccountResponseVatPeriod Monthly = new(Values.Monthly);

    public static readonly CompaniesProfileAccountResponseVatPeriod Bimonthly = new(
        Values.Bimonthly
    );

    public static readonly CompaniesProfileAccountResponseVatPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly CompaniesProfileAccountResponseVatPeriod Semiannual = new(
        Values.Semiannual
    );

    public static readonly CompaniesProfileAccountResponseVatPeriod Annual = new(Values.Annual);

    public CompaniesProfileAccountResponseVatPeriod(string value)
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
    public static CompaniesProfileAccountResponseVatPeriod FromCustom(string value)
    {
        return new CompaniesProfileAccountResponseVatPeriod(value);
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
        CompaniesProfileAccountResponseVatPeriod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesProfileAccountResponseVatPeriod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CompaniesProfileAccountResponseVatPeriod value) =>
        value.Value;

    public static explicit operator CompaniesProfileAccountResponseVatPeriod(string value) =>
        new(value);

    internal class CompaniesProfileAccountResponseVatPeriodSerializer
        : JsonConverter<CompaniesProfileAccountResponseVatPeriod>
    {
        public override CompaniesProfileAccountResponseVatPeriod Read(
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
            return new CompaniesProfileAccountResponseVatPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesProfileAccountResponseVatPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesProfileAccountResponseVatPeriod ReadAsPropertyName(
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
            return new CompaniesProfileAccountResponseVatPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesProfileAccountResponseVatPeriod value,
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

        public const string Bimonthly = "bimonthly";

        public const string Quarterly = "quarterly";

        public const string Semiannual = "semiannual";

        public const string Annual = "annual";
    }
}
