using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MaintenanceListProductionResponseRowsItemType.MaintenanceListProductionResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct MaintenanceListProductionResponseRowsItemType : IStringEnum
{
    public static readonly MaintenanceListProductionResponseRowsItemType Preventive = new(
        Values.Preventive
    );

    public static readonly MaintenanceListProductionResponseRowsItemType Corrective = new(
        Values.Corrective
    );

    public MaintenanceListProductionResponseRowsItemType(string value)
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
    public static MaintenanceListProductionResponseRowsItemType FromCustom(string value)
    {
        return new MaintenanceListProductionResponseRowsItemType(value);
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
        MaintenanceListProductionResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceListProductionResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(MaintenanceListProductionResponseRowsItemType value) =>
        value.Value;

    public static explicit operator MaintenanceListProductionResponseRowsItemType(string value) =>
        new(value);

    internal class MaintenanceListProductionResponseRowsItemTypeSerializer
        : JsonConverter<MaintenanceListProductionResponseRowsItemType>
    {
        public override MaintenanceListProductionResponseRowsItemType Read(
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
            return new MaintenanceListProductionResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MaintenanceListProductionResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MaintenanceListProductionResponseRowsItemType ReadAsPropertyName(
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
            return new MaintenanceListProductionResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MaintenanceListProductionResponseRowsItemType value,
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
