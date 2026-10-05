using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VehiclesCreateFleetResponseStatus.VehiclesCreateFleetResponseStatusSerializer)
)]
[Serializable]
public readonly record struct VehiclesCreateFleetResponseStatus : IStringEnum
{
    public static readonly VehiclesCreateFleetResponseStatus Active = new(Values.Active);

    public static readonly VehiclesCreateFleetResponseStatus Sold = new(Values.Sold);

    public static readonly VehiclesCreateFleetResponseStatus Scrapped = new(Values.Scrapped);

    public VehiclesCreateFleetResponseStatus(string value)
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
    public static VehiclesCreateFleetResponseStatus FromCustom(string value)
    {
        return new VehiclesCreateFleetResponseStatus(value);
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

    public static bool operator ==(VehiclesCreateFleetResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehiclesCreateFleetResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehiclesCreateFleetResponseStatus value) => value.Value;

    public static explicit operator VehiclesCreateFleetResponseStatus(string value) => new(value);

    internal class VehiclesCreateFleetResponseStatusSerializer
        : JsonConverter<VehiclesCreateFleetResponseStatus>
    {
        public override VehiclesCreateFleetResponseStatus Read(
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
            return new VehiclesCreateFleetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VehiclesCreateFleetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VehiclesCreateFleetResponseStatus ReadAsPropertyName(
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
            return new VehiclesCreateFleetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VehiclesCreateFleetResponseStatus value,
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
