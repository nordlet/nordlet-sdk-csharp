using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MeAccountResponseCompaniesItemVatPeriod.MeAccountResponseCompaniesItemVatPeriodSerializer)
)]
[Serializable]
public readonly record struct MeAccountResponseCompaniesItemVatPeriod : IStringEnum
{
    public static readonly MeAccountResponseCompaniesItemVatPeriod Monthly = new(Values.Monthly);

    public static readonly MeAccountResponseCompaniesItemVatPeriod Bimonthly = new(
        Values.Bimonthly
    );

    public static readonly MeAccountResponseCompaniesItemVatPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly MeAccountResponseCompaniesItemVatPeriod Semiannual = new(
        Values.Semiannual
    );

    public static readonly MeAccountResponseCompaniesItemVatPeriod Annual = new(Values.Annual);

    public MeAccountResponseCompaniesItemVatPeriod(string value)
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
    public static MeAccountResponseCompaniesItemVatPeriod FromCustom(string value)
    {
        return new MeAccountResponseCompaniesItemVatPeriod(value);
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

    public static bool operator ==(MeAccountResponseCompaniesItemVatPeriod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MeAccountResponseCompaniesItemVatPeriod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MeAccountResponseCompaniesItemVatPeriod value) =>
        value.Value;

    public static explicit operator MeAccountResponseCompaniesItemVatPeriod(string value) =>
        new(value);

    internal class MeAccountResponseCompaniesItemVatPeriodSerializer
        : JsonConverter<MeAccountResponseCompaniesItemVatPeriod>
    {
        public override MeAccountResponseCompaniesItemVatPeriod Read(
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
            return new MeAccountResponseCompaniesItemVatPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MeAccountResponseCompaniesItemVatPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MeAccountResponseCompaniesItemVatPeriod ReadAsPropertyName(
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
            return new MeAccountResponseCompaniesItemVatPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MeAccountResponseCompaniesItemVatPeriod value,
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
