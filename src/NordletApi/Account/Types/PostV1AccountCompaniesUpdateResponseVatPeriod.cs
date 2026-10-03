using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AccountCompaniesUpdateResponseVatPeriod.PostV1AccountCompaniesUpdateResponseVatPeriodSerializer)
)]
[Serializable]
public readonly record struct PostV1AccountCompaniesUpdateResponseVatPeriod : IStringEnum
{
    public static readonly PostV1AccountCompaniesUpdateResponseVatPeriod Monthly = new(
        Values.Monthly
    );

    public static readonly PostV1AccountCompaniesUpdateResponseVatPeriod Bimonthly = new(
        Values.Bimonthly
    );

    public static readonly PostV1AccountCompaniesUpdateResponseVatPeriod Quarterly = new(
        Values.Quarterly
    );

    public static readonly PostV1AccountCompaniesUpdateResponseVatPeriod Semiannual = new(
        Values.Semiannual
    );

    public static readonly PostV1AccountCompaniesUpdateResponseVatPeriod Annual = new(
        Values.Annual
    );

    public PostV1AccountCompaniesUpdateResponseVatPeriod(string value)
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
    public static PostV1AccountCompaniesUpdateResponseVatPeriod FromCustom(string value)
    {
        return new PostV1AccountCompaniesUpdateResponseVatPeriod(value);
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
        PostV1AccountCompaniesUpdateResponseVatPeriod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AccountCompaniesUpdateResponseVatPeriod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AccountCompaniesUpdateResponseVatPeriod value) =>
        value.Value;

    public static explicit operator PostV1AccountCompaniesUpdateResponseVatPeriod(string value) =>
        new(value);

    internal class PostV1AccountCompaniesUpdateResponseVatPeriodSerializer
        : JsonConverter<PostV1AccountCompaniesUpdateResponseVatPeriod>
    {
        public override PostV1AccountCompaniesUpdateResponseVatPeriod Read(
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
            return new PostV1AccountCompaniesUpdateResponseVatPeriod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AccountCompaniesUpdateResponseVatPeriod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AccountCompaniesUpdateResponseVatPeriod ReadAsPropertyName(
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
            return new PostV1AccountCompaniesUpdateResponseVatPeriod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AccountCompaniesUpdateResponseVatPeriod value,
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
