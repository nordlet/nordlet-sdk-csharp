using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VehiclesUpdateFleetResponseStatus.VehiclesUpdateFleetResponseStatusSerializer)
)]
[Serializable]
public readonly record struct VehiclesUpdateFleetResponseStatus : IStringEnum
{
    public static readonly VehiclesUpdateFleetResponseStatus Active = new(Values.Active);

    public static readonly VehiclesUpdateFleetResponseStatus Sold = new(Values.Sold);

    public static readonly VehiclesUpdateFleetResponseStatus Scrapped = new(Values.Scrapped);

    public VehiclesUpdateFleetResponseStatus(string value)
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
    public static VehiclesUpdateFleetResponseStatus FromCustom(string value)
    {
        return new VehiclesUpdateFleetResponseStatus(value);
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

    public static bool operator ==(VehiclesUpdateFleetResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehiclesUpdateFleetResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehiclesUpdateFleetResponseStatus value) => value.Value;

    public static explicit operator VehiclesUpdateFleetResponseStatus(string value) => new(value);

    internal class VehiclesUpdateFleetResponseStatusSerializer
        : JsonConverter<VehiclesUpdateFleetResponseStatus>
    {
        public override VehiclesUpdateFleetResponseStatus Read(
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
            return new VehiclesUpdateFleetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VehiclesUpdateFleetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VehiclesUpdateFleetResponseStatus ReadAsPropertyName(
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
            return new VehiclesUpdateFleetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VehiclesUpdateFleetResponseStatus value,
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
