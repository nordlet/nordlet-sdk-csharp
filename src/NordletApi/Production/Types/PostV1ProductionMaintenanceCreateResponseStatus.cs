using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionMaintenanceCreateResponseStatus.PostV1ProductionMaintenanceCreateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionMaintenanceCreateResponseStatus : IStringEnum
{
    public static readonly PostV1ProductionMaintenanceCreateResponseStatus Planned = new(
        Values.Planned
    );

    public static readonly PostV1ProductionMaintenanceCreateResponseStatus Completed = new(
        Values.Completed
    );

    public static readonly PostV1ProductionMaintenanceCreateResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1ProductionMaintenanceCreateResponseStatus(string value)
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
    public static PostV1ProductionMaintenanceCreateResponseStatus FromCustom(string value)
    {
        return new PostV1ProductionMaintenanceCreateResponseStatus(value);
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
        PostV1ProductionMaintenanceCreateResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionMaintenanceCreateResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProductionMaintenanceCreateResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1ProductionMaintenanceCreateResponseStatus(string value) =>
        new(value);

    internal class PostV1ProductionMaintenanceCreateResponseStatusSerializer
        : JsonConverter<PostV1ProductionMaintenanceCreateResponseStatus>
    {
        public override PostV1ProductionMaintenanceCreateResponseStatus Read(
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
            return new PostV1ProductionMaintenanceCreateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionMaintenanceCreateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionMaintenanceCreateResponseStatus ReadAsPropertyName(
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
            return new PostV1ProductionMaintenanceCreateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionMaintenanceCreateResponseStatus value,
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
