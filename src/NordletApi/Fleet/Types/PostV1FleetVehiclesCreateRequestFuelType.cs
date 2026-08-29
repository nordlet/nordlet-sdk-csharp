using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1FleetVehiclesCreateRequestFuelType.PostV1FleetVehiclesCreateRequestFuelTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1FleetVehiclesCreateRequestFuelType : IStringEnum
{
    public static readonly PostV1FleetVehiclesCreateRequestFuelType Petrol = new(Values.Petrol);

    public static readonly PostV1FleetVehiclesCreateRequestFuelType Diesel = new(Values.Diesel);

    public static readonly PostV1FleetVehiclesCreateRequestFuelType Electric = new(Values.Electric);

    public static readonly PostV1FleetVehiclesCreateRequestFuelType Hybrid = new(Values.Hybrid);

    public static readonly PostV1FleetVehiclesCreateRequestFuelType Lpg = new(Values.Lpg);

    public static readonly PostV1FleetVehiclesCreateRequestFuelType Other = new(Values.Other);

    public PostV1FleetVehiclesCreateRequestFuelType(string value)
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
    public static PostV1FleetVehiclesCreateRequestFuelType FromCustom(string value)
    {
        return new PostV1FleetVehiclesCreateRequestFuelType(value);
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
        PostV1FleetVehiclesCreateRequestFuelType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1FleetVehiclesCreateRequestFuelType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1FleetVehiclesCreateRequestFuelType value) =>
        value.Value;

    public static explicit operator PostV1FleetVehiclesCreateRequestFuelType(string value) =>
        new(value);

    internal class PostV1FleetVehiclesCreateRequestFuelTypeSerializer
        : JsonConverter<PostV1FleetVehiclesCreateRequestFuelType>
    {
        public override PostV1FleetVehiclesCreateRequestFuelType Read(
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
            return new PostV1FleetVehiclesCreateRequestFuelType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1FleetVehiclesCreateRequestFuelType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1FleetVehiclesCreateRequestFuelType ReadAsPropertyName(
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
            return new PostV1FleetVehiclesCreateRequestFuelType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1FleetVehiclesCreateRequestFuelType value,
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
