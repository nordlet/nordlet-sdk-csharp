using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VehiclesListFleetResponseRowsItemStatus.VehiclesListFleetResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct VehiclesListFleetResponseRowsItemStatus : IStringEnum
{
    public static readonly VehiclesListFleetResponseRowsItemStatus Active = new(Values.Active);

    public static readonly VehiclesListFleetResponseRowsItemStatus Sold = new(Values.Sold);

    public static readonly VehiclesListFleetResponseRowsItemStatus Scrapped = new(Values.Scrapped);

    public VehiclesListFleetResponseRowsItemStatus(string value)
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
    public static VehiclesListFleetResponseRowsItemStatus FromCustom(string value)
    {
        return new VehiclesListFleetResponseRowsItemStatus(value);
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

    public static bool operator ==(VehiclesListFleetResponseRowsItemStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehiclesListFleetResponseRowsItemStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehiclesListFleetResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator VehiclesListFleetResponseRowsItemStatus(string value) =>
        new(value);

    internal class VehiclesListFleetResponseRowsItemStatusSerializer
        : JsonConverter<VehiclesListFleetResponseRowsItemStatus>
    {
        public override VehiclesListFleetResponseRowsItemStatus Read(
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
            return new VehiclesListFleetResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VehiclesListFleetResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VehiclesListFleetResponseRowsItemStatus ReadAsPropertyName(
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
            return new VehiclesListFleetResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VehiclesListFleetResponseRowsItemStatus value,
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
