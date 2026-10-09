using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(BusinessTripsCreateHrResponseStatus.BusinessTripsCreateHrResponseStatusSerializer)
)]
[Serializable]
public readonly record struct BusinessTripsCreateHrResponseStatus : IStringEnum
{
    public static readonly BusinessTripsCreateHrResponseStatus Draft = new(Values.Draft);

    public static readonly BusinessTripsCreateHrResponseStatus Approved = new(Values.Approved);

    public BusinessTripsCreateHrResponseStatus(string value)
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
    public static BusinessTripsCreateHrResponseStatus FromCustom(string value)
    {
        return new BusinessTripsCreateHrResponseStatus(value);
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

    public static bool operator ==(BusinessTripsCreateHrResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BusinessTripsCreateHrResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BusinessTripsCreateHrResponseStatus value) =>
        value.Value;

    public static explicit operator BusinessTripsCreateHrResponseStatus(string value) => new(value);

    internal class BusinessTripsCreateHrResponseStatusSerializer
        : JsonConverter<BusinessTripsCreateHrResponseStatus>
    {
        public override BusinessTripsCreateHrResponseStatus Read(
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
            return new BusinessTripsCreateHrResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BusinessTripsCreateHrResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BusinessTripsCreateHrResponseStatus ReadAsPropertyName(
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
            return new BusinessTripsCreateHrResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BusinessTripsCreateHrResponseStatus value,
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
        public const string Draft = "draft";

        public const string Approved = "approved";
    }
}
