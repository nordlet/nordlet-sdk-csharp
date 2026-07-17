using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionOrdersGetResponseType.PostV1ProductionOrdersGetResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionOrdersGetResponseType : IStringEnum
{
    public static readonly PostV1ProductionOrdersGetResponseType Assembly = new(Values.Assembly);

    public static readonly PostV1ProductionOrdersGetResponseType Disassembly = new(
        Values.Disassembly
    );

    public PostV1ProductionOrdersGetResponseType(string value)
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
    public static PostV1ProductionOrdersGetResponseType FromCustom(string value)
    {
        return new PostV1ProductionOrdersGetResponseType(value);
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

    public static bool operator ==(PostV1ProductionOrdersGetResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1ProductionOrdersGetResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProductionOrdersGetResponseType value) =>
        value.Value;

    public static explicit operator PostV1ProductionOrdersGetResponseType(string value) =>
        new(value);

    internal class PostV1ProductionOrdersGetResponseTypeSerializer
        : JsonConverter<PostV1ProductionOrdersGetResponseType>
    {
        public override PostV1ProductionOrdersGetResponseType Read(
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
            return new PostV1ProductionOrdersGetResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionOrdersGetResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionOrdersGetResponseType ReadAsPropertyName(
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
            return new PostV1ProductionOrdersGetResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionOrdersGetResponseType value,
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
