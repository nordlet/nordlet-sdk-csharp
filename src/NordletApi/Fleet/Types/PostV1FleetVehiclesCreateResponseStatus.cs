using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1FleetVehiclesCreateResponseStatus.PostV1FleetVehiclesCreateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1FleetVehiclesCreateResponseStatus : IStringEnum
{
    public static readonly PostV1FleetVehiclesCreateResponseStatus Active = new(Values.Active);

    public static readonly PostV1FleetVehiclesCreateResponseStatus Sold = new(Values.Sold);

    public static readonly PostV1FleetVehiclesCreateResponseStatus Scrapped = new(Values.Scrapped);

    public PostV1FleetVehiclesCreateResponseStatus(string value)
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
    public static PostV1FleetVehiclesCreateResponseStatus FromCustom(string value)
    {
        return new PostV1FleetVehiclesCreateResponseStatus(value);
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

    public static bool operator ==(PostV1FleetVehiclesCreateResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1FleetVehiclesCreateResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1FleetVehiclesCreateResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1FleetVehiclesCreateResponseStatus(string value) =>
        new(value);

    internal class PostV1FleetVehiclesCreateResponseStatusSerializer
        : JsonConverter<PostV1FleetVehiclesCreateResponseStatus>
    {
        public override PostV1FleetVehiclesCreateResponseStatus Read(
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
            return new PostV1FleetVehiclesCreateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1FleetVehiclesCreateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1FleetVehiclesCreateResponseStatus ReadAsPropertyName(
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
            return new PostV1FleetVehiclesCreateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1FleetVehiclesCreateResponseStatus value,
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
