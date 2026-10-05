using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MaintenanceCompleteProductionResponseStatus.MaintenanceCompleteProductionResponseStatusSerializer)
)]
[Serializable]
public readonly record struct MaintenanceCompleteProductionResponseStatus : IStringEnum
{
    public static readonly MaintenanceCompleteProductionResponseStatus Planned = new(
        Values.Planned
    );

    public static readonly MaintenanceCompleteProductionResponseStatus Completed = new(
        Values.Completed
    );

    public static readonly MaintenanceCompleteProductionResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public MaintenanceCompleteProductionResponseStatus(string value)
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
    public static MaintenanceCompleteProductionResponseStatus FromCustom(string value)
    {
        return new MaintenanceCompleteProductionResponseStatus(value);
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
        MaintenanceCompleteProductionResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceCompleteProductionResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(MaintenanceCompleteProductionResponseStatus value) =>
        value.Value;

    public static explicit operator MaintenanceCompleteProductionResponseStatus(string value) =>
        new(value);

    internal class MaintenanceCompleteProductionResponseStatusSerializer
        : JsonConverter<MaintenanceCompleteProductionResponseStatus>
    {
        public override MaintenanceCompleteProductionResponseStatus Read(
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
            return new MaintenanceCompleteProductionResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MaintenanceCompleteProductionResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MaintenanceCompleteProductionResponseStatus ReadAsPropertyName(
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
            return new MaintenanceCompleteProductionResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MaintenanceCompleteProductionResponseStatus value,
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
