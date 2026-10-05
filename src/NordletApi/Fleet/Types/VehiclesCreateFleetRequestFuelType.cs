using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VehiclesCreateFleetRequestFuelType.VehiclesCreateFleetRequestFuelTypeSerializer)
)]
[Serializable]
public readonly record struct VehiclesCreateFleetRequestFuelType : IStringEnum
{
    public static readonly VehiclesCreateFleetRequestFuelType Petrol = new(Values.Petrol);

    public static readonly VehiclesCreateFleetRequestFuelType Diesel = new(Values.Diesel);

    public static readonly VehiclesCreateFleetRequestFuelType Electric = new(Values.Electric);

    public static readonly VehiclesCreateFleetRequestFuelType Hybrid = new(Values.Hybrid);

    public static readonly VehiclesCreateFleetRequestFuelType Lpg = new(Values.Lpg);

    public static readonly VehiclesCreateFleetRequestFuelType Other = new(Values.Other);

    public VehiclesCreateFleetRequestFuelType(string value)
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
    public static VehiclesCreateFleetRequestFuelType FromCustom(string value)
    {
        return new VehiclesCreateFleetRequestFuelType(value);
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

    public static bool operator ==(VehiclesCreateFleetRequestFuelType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehiclesCreateFleetRequestFuelType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehiclesCreateFleetRequestFuelType value) => value.Value;

    public static explicit operator VehiclesCreateFleetRequestFuelType(string value) => new(value);

    internal class VehiclesCreateFleetRequestFuelTypeSerializer
        : JsonConverter<VehiclesCreateFleetRequestFuelType>
    {
        public override VehiclesCreateFleetRequestFuelType Read(
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
            return new VehiclesCreateFleetRequestFuelType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VehiclesCreateFleetRequestFuelType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VehiclesCreateFleetRequestFuelType ReadAsPropertyName(
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
            return new VehiclesCreateFleetRequestFuelType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VehiclesCreateFleetRequestFuelType value,
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
