using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PlIntrastatGenerateDeclarationsRequestFlow.PlIntrastatGenerateDeclarationsRequestFlowSerializer)
)]
[Serializable]
public readonly record struct PlIntrastatGenerateDeclarationsRequestFlow : IStringEnum
{
    public static readonly PlIntrastatGenerateDeclarationsRequestFlow Arrivals = new(
        Values.Arrivals
    );

    public static readonly PlIntrastatGenerateDeclarationsRequestFlow Dispatches = new(
        Values.Dispatches
    );

    public PlIntrastatGenerateDeclarationsRequestFlow(string value)
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
    public static PlIntrastatGenerateDeclarationsRequestFlow FromCustom(string value)
    {
        return new PlIntrastatGenerateDeclarationsRequestFlow(value);
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
        PlIntrastatGenerateDeclarationsRequestFlow value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PlIntrastatGenerateDeclarationsRequestFlow value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PlIntrastatGenerateDeclarationsRequestFlow value) =>
        value.Value;

    public static explicit operator PlIntrastatGenerateDeclarationsRequestFlow(string value) =>
        new(value);

    internal class PlIntrastatGenerateDeclarationsRequestFlowSerializer
        : JsonConverter<PlIntrastatGenerateDeclarationsRequestFlow>
    {
        public override PlIntrastatGenerateDeclarationsRequestFlow Read(
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
            return new PlIntrastatGenerateDeclarationsRequestFlow(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PlIntrastatGenerateDeclarationsRequestFlow value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PlIntrastatGenerateDeclarationsRequestFlow ReadAsPropertyName(
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
            return new PlIntrastatGenerateDeclarationsRequestFlow(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PlIntrastatGenerateDeclarationsRequestFlow value,
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
        public const string Arrivals = "arrivals";

        public const string Dispatches = "dispatches";
    }
}
