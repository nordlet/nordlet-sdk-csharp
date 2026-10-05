using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesUpdateAccountResponseVatPeriod.CompaniesUpdateAccountResponseVatPeriodSerializer)
)]
[Serializable]
public readonly record struct CompaniesUpdateAccountResponseVatPeriod : IStringEnum
{
    public static readonly CompaniesUpdateAccountResponseVatPeriod Monthly = new(Values.Monthly);

    public static readonly CompaniesUpdateAccountResponseVatPeriod Bimonthly = new(
        Values.Bimonthly
    );

    public static readonly CompaniesUpdateAccountResponseVatPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly CompaniesUpdateAccountResponseVatPeriod Semiannual = new(
        Values.Semiannual
    );

    public static readonly CompaniesUpdateAccountResponseVatPeriod Annual = new(Values.Annual);

    public CompaniesUpdateAccountResponseVatPeriod(string value)
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
    public static CompaniesUpdateAccountResponseVatPeriod FromCustom(string value)
    {
        return new CompaniesUpdateAccountResponseVatPeriod(value);
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

    public static bool operator ==(CompaniesUpdateAccountResponseVatPeriod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CompaniesUpdateAccountResponseVatPeriod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CompaniesUpdateAccountResponseVatPeriod value) =>
        value.Value;

    public static explicit operator CompaniesUpdateAccountResponseVatPeriod(string value) =>
        new(value);

    internal class CompaniesUpdateAccountResponseVatPeriodSerializer
        : JsonConverter<CompaniesUpdateAccountResponseVatPeriod>
    {
        public override CompaniesUpdateAccountResponseVatPeriod Read(
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
            return new CompaniesUpdateAccountResponseVatPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesUpdateAccountResponseVatPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesUpdateAccountResponseVatPeriod ReadAsPropertyName(
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
            return new CompaniesUpdateAccountResponseVatPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesUpdateAccountResponseVatPeriod value,
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
