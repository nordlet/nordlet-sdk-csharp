using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtIntrastatComputeDeclarationsResponseFlow.LtIntrastatComputeDeclarationsResponseFlowSerializer)
)]
[Serializable]
public readonly record struct LtIntrastatComputeDeclarationsResponseFlow : IStringEnum
{
    public static readonly LtIntrastatComputeDeclarationsResponseFlow Arrivals = new(
        Values.Arrivals
    );

    public static readonly LtIntrastatComputeDeclarationsResponseFlow Dispatches = new(
        Values.Dispatches
    );

    public LtIntrastatComputeDeclarationsResponseFlow(string value)
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
    public static LtIntrastatComputeDeclarationsResponseFlow FromCustom(string value)
    {
        return new LtIntrastatComputeDeclarationsResponseFlow(value);
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
        LtIntrastatComputeDeclarationsResponseFlow value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LtIntrastatComputeDeclarationsResponseFlow value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LtIntrastatComputeDeclarationsResponseFlow value) =>
        value.Value;

    public static explicit operator LtIntrastatComputeDeclarationsResponseFlow(string value) =>
        new(value);

    internal class LtIntrastatComputeDeclarationsResponseFlowSerializer
        : JsonConverter<LtIntrastatComputeDeclarationsResponseFlow>
    {
        public override LtIntrastatComputeDeclarationsResponseFlow Read(
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
            return new LtIntrastatComputeDeclarationsResponseFlow(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtIntrastatComputeDeclarationsResponseFlow value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtIntrastatComputeDeclarationsResponseFlow ReadAsPropertyName(
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
            return new LtIntrastatComputeDeclarationsResponseFlow(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtIntrastatComputeDeclarationsResponseFlow value,
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
