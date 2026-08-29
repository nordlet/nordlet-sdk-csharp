using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionMaintenanceCreateRequestType.PostV1ProductionMaintenanceCreateRequestTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionMaintenanceCreateRequestType : IStringEnum
{
    public static readonly PostV1ProductionMaintenanceCreateRequestType Preventive = new(
        Values.Preventive
    );

    public static readonly PostV1ProductionMaintenanceCreateRequestType Corrective = new(
        Values.Corrective
    );

    public PostV1ProductionMaintenanceCreateRequestType(string value)
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
    public static PostV1ProductionMaintenanceCreateRequestType FromCustom(string value)
    {
        return new PostV1ProductionMaintenanceCreateRequestType(value);
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
        PostV1ProductionMaintenanceCreateRequestType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionMaintenanceCreateRequestType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProductionMaintenanceCreateRequestType value) =>
        value.Value;

    public static explicit operator PostV1ProductionMaintenanceCreateRequestType(string value) =>
        new(value);

    internal class PostV1ProductionMaintenanceCreateRequestTypeSerializer
        : JsonConverter<PostV1ProductionMaintenanceCreateRequestType>
    {
        public override PostV1ProductionMaintenanceCreateRequestType Read(
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
            return new PostV1ProductionMaintenanceCreateRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionMaintenanceCreateRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionMaintenanceCreateRequestType ReadAsPropertyName(
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
            return new PostV1ProductionMaintenanceCreateRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionMaintenanceCreateRequestType value,
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
