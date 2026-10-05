using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MaintenanceCreateProductionResponseStatus.MaintenanceCreateProductionResponseStatusSerializer)
)]
[Serializable]
public readonly record struct MaintenanceCreateProductionResponseStatus : IStringEnum
{
    public static readonly MaintenanceCreateProductionResponseStatus Planned = new(Values.Planned);

    public static readonly MaintenanceCreateProductionResponseStatus Completed = new(
        Values.Completed
    );

    public static readonly MaintenanceCreateProductionResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public MaintenanceCreateProductionResponseStatus(string value)
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
    public static MaintenanceCreateProductionResponseStatus FromCustom(string value)
    {
        return new MaintenanceCreateProductionResponseStatus(value);
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
        MaintenanceCreateProductionResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceCreateProductionResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(MaintenanceCreateProductionResponseStatus value) =>
        value.Value;

    public static explicit operator MaintenanceCreateProductionResponseStatus(string value) =>
        new(value);

    internal class MaintenanceCreateProductionResponseStatusSerializer
        : JsonConverter<MaintenanceCreateProductionResponseStatus>
    {
        public override MaintenanceCreateProductionResponseStatus Read(
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
            return new MaintenanceCreateProductionResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MaintenanceCreateProductionResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MaintenanceCreateProductionResponseStatus ReadAsPropertyName(
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
            return new MaintenanceCreateProductionResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MaintenanceCreateProductionResponseStatus value,
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
        public const string Planned = "planned";

        public const string Completed = "completed";

        public const string Cancelled = "cancelled";
    }
}
