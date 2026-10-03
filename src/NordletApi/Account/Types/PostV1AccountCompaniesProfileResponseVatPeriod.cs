using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AccountCompaniesProfileResponseVatPeriod.PostV1AccountCompaniesProfileResponseVatPeriodSerializer)
)]
[Serializable]
public readonly record struct PostV1AccountCompaniesProfileResponseVatPeriod : IStringEnum
{
    public static readonly PostV1AccountCompaniesProfileResponseVatPeriod Monthly = new(
        Values.Monthly
    );

    public static readonly PostV1AccountCompaniesProfileResponseVatPeriod Bimonthly = new(
        Values.Bimonthly
    );

    public static readonly PostV1AccountCompaniesProfileResponseVatPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly PostV1AccountCompaniesProfileResponseVatPeriod Semiannual = new(
        Values.Semiannual
    );

    public static readonly PostV1AccountCompaniesProfileResponseVatPeriod Annual = new(
        Values.Annual
    );

    public PostV1AccountCompaniesProfileResponseVatPeriod(string value)
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
    public static PostV1AccountCompaniesProfileResponseVatPeriod FromCustom(string value)
    {
        return new PostV1AccountCompaniesProfileResponseVatPeriod(value);
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
        PostV1AccountCompaniesProfileResponseVatPeriod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AccountCompaniesProfileResponseVatPeriod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AccountCompaniesProfileResponseVatPeriod value) =>
        value.Value;

    public static explicit operator PostV1AccountCompaniesProfileResponseVatPeriod(string value) =>
        new(value);

    internal class PostV1AccountCompaniesProfileResponseVatPeriodSerializer
        : JsonConverter<PostV1AccountCompaniesProfileResponseVatPeriod>
    {
        public override PostV1AccountCompaniesProfileResponseVatPeriod Read(
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
            return new PostV1AccountCompaniesProfileResponseVatPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AccountCompaniesProfileResponseVatPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AccountCompaniesProfileResponseVatPeriod ReadAsPropertyName(
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
            return new PostV1AccountCompaniesProfileResponseVatPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AccountCompaniesProfileResponseVatPeriod value,
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
