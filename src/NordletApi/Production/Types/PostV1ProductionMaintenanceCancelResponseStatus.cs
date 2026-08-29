using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionMaintenanceCancelResponseStatus.PostV1ProductionMaintenanceCancelResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionMaintenanceCancelResponseStatus : IStringEnum
{
    public static readonly PostV1ProductionMaintenanceCancelResponseStatus Planned = new(
        Values.Planned
    );

    public static readonly PostV1ProductionMaintenanceCancelResponseStatus Completed = new(
        Values.Completed
    );

    public static readonly PostV1ProductionMaintenanceCancelResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1ProductionMaintenanceCancelResponseStatus(string value)
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
    public static PostV1ProductionMaintenanceCancelResponseStatus FromCustom(string value)
    {
        return new PostV1ProductionMaintenanceCancelResponseStatus(value);
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
        PostV1ProductionMaintenanceCancelResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionMaintenanceCancelResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProductionMaintenanceCancelResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1ProductionMaintenanceCancelResponseStatus(string value) =>
        new(value);

    internal class PostV1ProductionMaintenanceCancelResponseStatusSerializer
        : JsonConverter<PostV1ProductionMaintenanceCancelResponseStatus>
    {
        public override PostV1ProductionMaintenanceCancelResponseStatus Read(
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
            return new PostV1ProductionMaintenanceCancelResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionMaintenanceCancelResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionMaintenanceCancelResponseStatus ReadAsPropertyName(
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
            return new PostV1ProductionMaintenanceCancelResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionMaintenanceCancelResponseStatus value,
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
