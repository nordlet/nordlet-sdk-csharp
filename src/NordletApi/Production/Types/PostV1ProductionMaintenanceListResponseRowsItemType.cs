using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionMaintenanceListResponseRowsItemType.PostV1ProductionMaintenanceListResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionMaintenanceListResponseRowsItemType : IStringEnum
{
    public static readonly PostV1ProductionMaintenanceListResponseRowsItemType Preventive = new(
        Values.Preventive
    );

    public static readonly PostV1ProductionMaintenanceListResponseRowsItemType Corrective = new(
        Values.Corrective
    );

    public PostV1ProductionMaintenanceListResponseRowsItemType(string value)
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
    public static PostV1ProductionMaintenanceListResponseRowsItemType FromCustom(string value)
    {
        return new PostV1ProductionMaintenanceListResponseRowsItemType(value);
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
        PostV1ProductionMaintenanceListResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionMaintenanceListResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ProductionMaintenanceListResponseRowsItemType value
    ) => value.Value;

    public static explicit operator PostV1ProductionMaintenanceListResponseRowsItemType(
        string value
    ) => new(value);

    internal class PostV1ProductionMaintenanceListResponseRowsItemTypeSerializer
        : JsonConverter<PostV1ProductionMaintenanceListResponseRowsItemType>
    {
        public override PostV1ProductionMaintenanceListResponseRowsItemType Read(
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
            return new PostV1ProductionMaintenanceListResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionMaintenanceListResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionMaintenanceListResponseRowsItemType ReadAsPropertyName(
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
            return new PostV1ProductionMaintenanceListResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionMaintenanceListResponseRowsItemType value,
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
