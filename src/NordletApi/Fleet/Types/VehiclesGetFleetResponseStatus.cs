using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(VehiclesGetFleetResponseStatus.VehiclesGetFleetResponseStatusSerializer))]
[Serializable]
public readonly record struct VehiclesGetFleetResponseStatus : IStringEnum
{
    public static readonly VehiclesGetFleetResponseStatus Active = new(Values.Active);

    public static readonly VehiclesGetFleetResponseStatus Sold = new(Values.Sold);

    public static readonly VehiclesGetFleetResponseStatus Scrapped = new(Values.Scrapped);

    public VehiclesGetFleetResponseStatus(string value)
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
    public static VehiclesGetFleetResponseStatus FromCustom(string value)
    {
        return new VehiclesGetFleetResponseStatus(value);
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

    public static bool operator ==(VehiclesGetFleetResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehiclesGetFleetResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehiclesGetFleetResponseStatus value) => value.Value;

    public static explicit operator VehiclesGetFleetResponseStatus(string value) => new(value);

    internal class VehiclesGetFleetResponseStatusSerializer
        : JsonConverter<VehiclesGetFleetResponseStatus>
    {
        public override VehiclesGetFleetResponseStatus Read(
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
            return new VehiclesGetFleetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VehiclesGetFleetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VehiclesGetFleetResponseStatus ReadAsPropertyName(
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
            return new VehiclesGetFleetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VehiclesGetFleetResponseStatus value,
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
