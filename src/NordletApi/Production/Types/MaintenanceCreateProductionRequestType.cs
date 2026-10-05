using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MaintenanceCreateProductionRequestType.MaintenanceCreateProductionRequestTypeSerializer)
)]
[Serializable]
public readonly record struct MaintenanceCreateProductionRequestType : IStringEnum
{
    public static readonly MaintenanceCreateProductionRequestType Preventive = new(
        Values.Preventive
    );

    public static readonly MaintenanceCreateProductionRequestType Corrective = new(
        Values.Corrective
    );

    public MaintenanceCreateProductionRequestType(string value)
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
    public static MaintenanceCreateProductionRequestType FromCustom(string value)
    {
        return new MaintenanceCreateProductionRequestType(value);
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

    public static bool operator ==(MaintenanceCreateProductionRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MaintenanceCreateProductionRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MaintenanceCreateProductionRequestType value) =>
        value.Value;

    public static explicit operator MaintenanceCreateProductionRequestType(string value) =>
        new(value);

    internal class MaintenanceCreateProductionRequestTypeSerializer
        : JsonConverter<MaintenanceCreateProductionRequestType>
    {
        public override MaintenanceCreateProductionRequestType Read(
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
            return new MaintenanceCreateProductionRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MaintenanceCreateProductionRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MaintenanceCreateProductionRequestType ReadAsPropertyName(
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
            return new MaintenanceCreateProductionRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MaintenanceCreateProductionRequestType value,
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
