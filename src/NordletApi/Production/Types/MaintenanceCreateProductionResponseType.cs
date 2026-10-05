using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MaintenanceCreateProductionResponseType.MaintenanceCreateProductionResponseTypeSerializer)
)]
[Serializable]
public readonly record struct MaintenanceCreateProductionResponseType : IStringEnum
{
    public static readonly MaintenanceCreateProductionResponseType Preventive = new(
        Values.Preventive
    );

    public static readonly MaintenanceCreateProductionResponseType Corrective = new(
        Values.Corrective
    );

    public MaintenanceCreateProductionResponseType(string value)
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
    public static MaintenanceCreateProductionResponseType FromCustom(string value)
    {
        return new MaintenanceCreateProductionResponseType(value);
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

    public static bool operator ==(MaintenanceCreateProductionResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MaintenanceCreateProductionResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MaintenanceCreateProductionResponseType value) =>
        value.Value;

    public static explicit operator MaintenanceCreateProductionResponseType(string value) =>
        new(value);

    internal class MaintenanceCreateProductionResponseTypeSerializer
        : JsonConverter<MaintenanceCreateProductionResponseType>
    {
        public override MaintenanceCreateProductionResponseType Read(
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
            return new MaintenanceCreateProductionResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MaintenanceCreateProductionResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MaintenanceCreateProductionResponseType ReadAsPropertyName(
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
            return new MaintenanceCreateProductionResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MaintenanceCreateProductionResponseType value,
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
        public const string Preventive = "preventive";

        public const string Corrective = "corrective";
    }
}
