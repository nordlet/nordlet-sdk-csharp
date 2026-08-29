using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1FleetVehiclesUpdateRequestStatus.PostV1FleetVehiclesUpdateRequestStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1FleetVehiclesUpdateRequestStatus : IStringEnum
{
    public static readonly PostV1FleetVehiclesUpdateRequestStatus Active = new(Values.Active);

    public static readonly PostV1FleetVehiclesUpdateRequestStatus Sold = new(Values.Sold);

    public static readonly PostV1FleetVehiclesUpdateRequestStatus Scrapped = new(Values.Scrapped);

    public PostV1FleetVehiclesUpdateRequestStatus(string value)
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
    public static PostV1FleetVehiclesUpdateRequestStatus FromCustom(string value)
    {
        return new PostV1FleetVehiclesUpdateRequestStatus(value);
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

    public static bool operator ==(PostV1FleetVehiclesUpdateRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1FleetVehiclesUpdateRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1FleetVehiclesUpdateRequestStatus value) =>
        value.Value;

    public static explicit operator PostV1FleetVehiclesUpdateRequestStatus(string value) =>
        new(value);

    internal class PostV1FleetVehiclesUpdateRequestStatusSerializer
        : JsonConverter<PostV1FleetVehiclesUpdateRequestStatus>
    {
        public override PostV1FleetVehiclesUpdateRequestStatus Read(
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
            return new PostV1FleetVehiclesUpdateRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1FleetVehiclesUpdateRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1FleetVehiclesUpdateRequestStatus ReadAsPropertyName(
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
            return new PostV1FleetVehiclesUpdateRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1FleetVehiclesUpdateRequestStatus value,
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
        public const string Active = "active";

        public const string Sold = "sold";

        public const string Scrapped = "scrapped";
    }
}
