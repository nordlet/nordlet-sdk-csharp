using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(VehiclesUpdateFleetRequestStatus.VehiclesUpdateFleetRequestStatusSerializer))]
[Serializable]
public readonly record struct VehiclesUpdateFleetRequestStatus : IStringEnum
{
    public static readonly VehiclesUpdateFleetRequestStatus Active = new(Values.Active);

    public static readonly VehiclesUpdateFleetRequestStatus Sold = new(Values.Sold);

    public static readonly VehiclesUpdateFleetRequestStatus Scrapped = new(Values.Scrapped);

    public VehiclesUpdateFleetRequestStatus(string value)
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
    public static VehiclesUpdateFleetRequestStatus FromCustom(string value)
    {
        return new VehiclesUpdateFleetRequestStatus(value);
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

    public static bool operator ==(VehiclesUpdateFleetRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehiclesUpdateFleetRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehiclesUpdateFleetRequestStatus value) => value.Value;

    public static explicit operator VehiclesUpdateFleetRequestStatus(string value) => new(value);

    internal class VehiclesUpdateFleetRequestStatusSerializer
        : JsonConverter<VehiclesUpdateFleetRequestStatus>
    {
        public override VehiclesUpdateFleetRequestStatus Read(
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
            return new VehiclesUpdateFleetRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VehiclesUpdateFleetRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VehiclesUpdateFleetRequestStatus ReadAsPropertyName(
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
            return new VehiclesUpdateFleetRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VehiclesUpdateFleetRequestStatus value,
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
