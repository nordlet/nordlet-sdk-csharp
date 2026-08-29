using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1FleetVehiclesUpdateRequestFuelType.PostV1FleetVehiclesUpdateRequestFuelTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1FleetVehiclesUpdateRequestFuelType : IStringEnum
{
    public static readonly PostV1FleetVehiclesUpdateRequestFuelType Petrol = new(Values.Petrol);

    public static readonly PostV1FleetVehiclesUpdateRequestFuelType Diesel = new(Values.Diesel);

    public static readonly PostV1FleetVehiclesUpdateRequestFuelType Electric = new(Values.Electric);

    public static readonly PostV1FleetVehiclesUpdateRequestFuelType Hybrid = new(Values.Hybrid);

    public static readonly PostV1FleetVehiclesUpdateRequestFuelType Lpg = new(Values.Lpg);

    public static readonly PostV1FleetVehiclesUpdateRequestFuelType Other = new(Values.Other);

    public PostV1FleetVehiclesUpdateRequestFuelType(string value)
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
    public static PostV1FleetVehiclesUpdateRequestFuelType FromCustom(string value)
    {
        return new PostV1FleetVehiclesUpdateRequestFuelType(value);
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
        PostV1FleetVehiclesUpdateRequestFuelType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1FleetVehiclesUpdateRequestFuelType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1FleetVehiclesUpdateRequestFuelType value) =>
        value.Value;

    public static explicit operator PostV1FleetVehiclesUpdateRequestFuelType(string value) =>
        new(value);

    internal class PostV1FleetVehiclesUpdateRequestFuelTypeSerializer
        : JsonConverter<PostV1FleetVehiclesUpdateRequestFuelType>
    {
        public override PostV1FleetVehiclesUpdateRequestFuelType Read(
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
            return new PostV1FleetVehiclesUpdateRequestFuelType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1FleetVehiclesUpdateRequestFuelType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1FleetVehiclesUpdateRequestFuelType ReadAsPropertyName(
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
            return new PostV1FleetVehiclesUpdateRequestFuelType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1FleetVehiclesUpdateRequestFuelType value,
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
        public const string Petrol = "petrol";

        public const string Diesel = "diesel";

        public const string Electric = "electric";

        public const string Hybrid = "hybrid";

        public const string Lpg = "lpg";

        public const string Other = "other";
    }
}
