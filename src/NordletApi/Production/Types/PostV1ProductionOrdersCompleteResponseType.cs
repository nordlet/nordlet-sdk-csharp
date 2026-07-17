using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionOrdersCompleteResponseType.PostV1ProductionOrdersCompleteResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionOrdersCompleteResponseType : IStringEnum
{
    public static readonly PostV1ProductionOrdersCompleteResponseType Assembly = new(
        Values.Assembly
    );

    public static readonly PostV1ProductionOrdersCompleteResponseType Disassembly = new(
        Values.Disassembly
    );

    public PostV1ProductionOrdersCompleteResponseType(string value)
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
    public static PostV1ProductionOrdersCompleteResponseType FromCustom(string value)
    {
        return new PostV1ProductionOrdersCompleteResponseType(value);
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
        PostV1ProductionOrdersCompleteResponseType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionOrdersCompleteResponseType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProductionOrdersCompleteResponseType value) =>
        value.Value;

    public static explicit operator PostV1ProductionOrdersCompleteResponseType(string value) =>
        new(value);

    internal class PostV1ProductionOrdersCompleteResponseTypeSerializer
        : JsonConverter<PostV1ProductionOrdersCompleteResponseType>
    {
        public override PostV1ProductionOrdersCompleteResponseType Read(
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
            return new PostV1ProductionOrdersCompleteResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionOrdersCompleteResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionOrdersCompleteResponseType ReadAsPropertyName(
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
            return new PostV1ProductionOrdersCompleteResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionOrdersCompleteResponseType value,
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
