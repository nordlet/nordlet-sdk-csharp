using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesContextAccountResponseProfileVatPeriod.CompaniesContextAccountResponseProfileVatPeriodSerializer)
)]
[Serializable]
public readonly record struct CompaniesContextAccountResponseProfileVatPeriod : IStringEnum
{
    public static readonly CompaniesContextAccountResponseProfileVatPeriod Monthly = new(
        Values.Monthly
    );

    public static readonly CompaniesContextAccountResponseProfileVatPeriod Bimonthly = new(
        Values.Bimonthly
    );

    public static readonly CompaniesContextAccountResponseProfileVatPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly CompaniesContextAccountResponseProfileVatPeriod Semiannual = new(
        Values.Semiannual
    );

    public static readonly CompaniesContextAccountResponseProfileVatPeriod Annual = new(
        Values.Annual
    );

    public CompaniesContextAccountResponseProfileVatPeriod(string value)
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
    public static CompaniesContextAccountResponseProfileVatPeriod FromCustom(string value)
    {
        return new CompaniesContextAccountResponseProfileVatPeriod(value);
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
        CompaniesContextAccountResponseProfileVatPeriod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesContextAccountResponseProfileVatPeriod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CompaniesContextAccountResponseProfileVatPeriod value) =>
        value.Value;

    public static explicit operator CompaniesContextAccountResponseProfileVatPeriod(string value) =>
        new(value);

    internal class CompaniesContextAccountResponseProfileVatPeriodSerializer
        : JsonConverter<CompaniesContextAccountResponseProfileVatPeriod>
    {
        public override CompaniesContextAccountResponseProfileVatPeriod Read(
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
            return new CompaniesContextAccountResponseProfileVatPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesContextAccountResponseProfileVatPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesContextAccountResponseProfileVatPeriod ReadAsPropertyName(
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
            return new CompaniesContextAccountResponseProfileVatPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesContextAccountResponseProfileVatPeriod value,
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
