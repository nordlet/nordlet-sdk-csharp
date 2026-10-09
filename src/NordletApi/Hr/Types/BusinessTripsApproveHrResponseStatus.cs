using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(BusinessTripsApproveHrResponseStatus.BusinessTripsApproveHrResponseStatusSerializer)
)]
[Serializable]
public readonly record struct BusinessTripsApproveHrResponseStatus : IStringEnum
{
    public static readonly BusinessTripsApproveHrResponseStatus Draft = new(Values.Draft);

    public static readonly BusinessTripsApproveHrResponseStatus Approved = new(Values.Approved);

    public BusinessTripsApproveHrResponseStatus(string value)
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
    public static BusinessTripsApproveHrResponseStatus FromCustom(string value)
    {
        return new BusinessTripsApproveHrResponseStatus(value);
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

    public static bool operator ==(BusinessTripsApproveHrResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BusinessTripsApproveHrResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BusinessTripsApproveHrResponseStatus value) =>
        value.Value;

    public static explicit operator BusinessTripsApproveHrResponseStatus(string value) =>
        new(value);

    internal class BusinessTripsApproveHrResponseStatusSerializer
        : JsonConverter<BusinessTripsApproveHrResponseStatus>
    {
        public override BusinessTripsApproveHrResponseStatus Read(
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
            return new BusinessTripsApproveHrResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BusinessTripsApproveHrResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BusinessTripsApproveHrResponseStatus ReadAsPropertyName(
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
            return new BusinessTripsApproveHrResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BusinessTripsApproveHrResponseStatus value,
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
