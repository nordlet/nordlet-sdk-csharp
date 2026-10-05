using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtIntrastatComputeDeclarationsRequestFlow.LtIntrastatComputeDeclarationsRequestFlowSerializer)
)]
[Serializable]
public readonly record struct LtIntrastatComputeDeclarationsRequestFlow : IStringEnum
{
    public static readonly LtIntrastatComputeDeclarationsRequestFlow Arrivals = new(
        Values.Arrivals
    );

    public static readonly LtIntrastatComputeDeclarationsRequestFlow Dispatches = new(
        Values.Dispatches
    );

    public LtIntrastatComputeDeclarationsRequestFlow(string value)
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
    public static LtIntrastatComputeDeclarationsRequestFlow FromCustom(string value)
    {
        return new LtIntrastatComputeDeclarationsRequestFlow(value);
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
        LtIntrastatComputeDeclarationsRequestFlow value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LtIntrastatComputeDeclarationsRequestFlow value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LtIntrastatComputeDeclarationsRequestFlow value) =>
        value.Value;

    public static explicit operator LtIntrastatComputeDeclarationsRequestFlow(string value) =>
        new(value);

    internal class LtIntrastatComputeDeclarationsRequestFlowSerializer
        : JsonConverter<LtIntrastatComputeDeclarationsRequestFlow>
    {
        public override LtIntrastatComputeDeclarationsRequestFlow Read(
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
            return new LtIntrastatComputeDeclarationsRequestFlow(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtIntrastatComputeDeclarationsRequestFlow value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtIntrastatComputeDeclarationsRequestFlow ReadAsPropertyName(
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
            return new LtIntrastatComputeDeclarationsRequestFlow(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtIntrastatComputeDeclarationsRequestFlow value,
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
