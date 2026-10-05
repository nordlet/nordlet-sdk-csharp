using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VehiclesUpdateFleetRequestFuelType.VehiclesUpdateFleetRequestFuelTypeSerializer)
)]
[Serializable]
public readonly record struct VehiclesUpdateFleetRequestFuelType : IStringEnum
{
    public static readonly VehiclesUpdateFleetRequestFuelType Petrol = new(Values.Petrol);

    public static readonly VehiclesUpdateFleetRequestFuelType Diesel = new(Values.Diesel);

    public static readonly VehiclesUpdateFleetRequestFuelType Electric = new(Values.Electric);

    public static readonly VehiclesUpdateFleetRequestFuelType Hybrid = new(Values.Hybrid);

    public static readonly VehiclesUpdateFleetRequestFuelType Lpg = new(Values.Lpg);

    public static readonly VehiclesUpdateFleetRequestFuelType Other = new(Values.Other);

    public VehiclesUpdateFleetRequestFuelType(string value)
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
    public static VehiclesUpdateFleetRequestFuelType FromCustom(string value)
    {
        return new VehiclesUpdateFleetRequestFuelType(value);
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

    public static bool operator ==(VehiclesUpdateFleetRequestFuelType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehiclesUpdateFleetRequestFuelType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehiclesUpdateFleetRequestFuelType value) => value.Value;

    public static explicit operator VehiclesUpdateFleetRequestFuelType(string value) => new(value);

    internal class VehiclesUpdateFleetRequestFuelTypeSerializer
        : JsonConverter<VehiclesUpdateFleetRequestFuelType>
    {
        public override VehiclesUpdateFleetRequestFuelType Read(
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
            return new VehiclesUpdateFleetRequestFuelType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VehiclesUpdateFleetRequestFuelType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VehiclesUpdateFleetRequestFuelType ReadAsPropertyName(
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
            return new VehiclesUpdateFleetRequestFuelType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VehiclesUpdateFleetRequestFuelType value,
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
