using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionOrdersCreateRequestType.PostV1ProductionOrdersCreateRequestTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionOrdersCreateRequestType : IStringEnum
{
    public static readonly PostV1ProductionOrdersCreateRequestType Assembly = new(Values.Assembly);

    public static readonly PostV1ProductionOrdersCreateRequestType Disassembly = new(
        Values.Disassembly
    );

    public PostV1ProductionOrdersCreateRequestType(string value)
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
    public static PostV1ProductionOrdersCreateRequestType FromCustom(string value)
    {
        return new PostV1ProductionOrdersCreateRequestType(value);
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

    public static bool operator ==(PostV1ProductionOrdersCreateRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1ProductionOrdersCreateRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProductionOrdersCreateRequestType value) =>
        value.Value;

    public static explicit operator PostV1ProductionOrdersCreateRequestType(string value) =>
        new(value);

    internal class PostV1ProductionOrdersCreateRequestTypeSerializer
        : JsonConverter<PostV1ProductionOrdersCreateRequestType>
    {
        public override PostV1ProductionOrdersCreateRequestType Read(
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
            return new PostV1ProductionOrdersCreateRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionOrdersCreateRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionOrdersCreateRequestType ReadAsPropertyName(
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
            return new PostV1ProductionOrdersCreateRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionOrdersCreateRequestType value,
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
        public const string Assembly = "assembly";

        public const string Disassembly = "disassembly";
    }
}
