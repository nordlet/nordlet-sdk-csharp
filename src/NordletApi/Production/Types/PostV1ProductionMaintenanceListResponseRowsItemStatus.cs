using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionMaintenanceListResponseRowsItemStatus.PostV1ProductionMaintenanceListResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionMaintenanceListResponseRowsItemStatus : IStringEnum
{
    public static readonly PostV1ProductionMaintenanceListResponseRowsItemStatus Planned = new(
        Values.Planned
    );

    public static readonly PostV1ProductionMaintenanceListResponseRowsItemStatus Completed = new(
        Values.Completed
    );

    public static readonly PostV1ProductionMaintenanceListResponseRowsItemStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1ProductionMaintenanceListResponseRowsItemStatus(string value)
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
    public static PostV1ProductionMaintenanceListResponseRowsItemStatus FromCustom(string value)
    {
        return new PostV1ProductionMaintenanceListResponseRowsItemStatus(value);
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
        PostV1ProductionMaintenanceListResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionMaintenanceListResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ProductionMaintenanceListResponseRowsItemStatus value
    ) => value.Value;

    public static explicit operator PostV1ProductionMaintenanceListResponseRowsItemStatus(
        string value
    ) => new(value);

    internal class PostV1ProductionMaintenanceListResponseRowsItemStatusSerializer
        : JsonConverter<PostV1ProductionMaintenanceListResponseRowsItemStatus>
    {
        public override PostV1ProductionMaintenanceListResponseRowsItemStatus Read(
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
            return new PostV1ProductionMaintenanceListResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionMaintenanceListResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionMaintenanceListResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1ProductionMaintenanceListResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionMaintenanceListResponseRowsItemStatus value,
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
