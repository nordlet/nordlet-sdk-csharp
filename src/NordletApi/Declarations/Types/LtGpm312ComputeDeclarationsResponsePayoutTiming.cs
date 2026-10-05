using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtGpm312ComputeDeclarationsResponsePayoutTiming.LtGpm312ComputeDeclarationsResponsePayoutTimingSerializer)
)]
[Serializable]
public readonly record struct LtGpm312ComputeDeclarationsResponsePayoutTiming : IStringEnum
{
    public static readonly LtGpm312ComputeDeclarationsResponsePayoutTiming SameMonth = new(
        Values.SameMonth
    );

    public static readonly LtGpm312ComputeDeclarationsResponsePayoutTiming NextMonth = new(
        Values.NextMonth
    );

    public LtGpm312ComputeDeclarationsResponsePayoutTiming(string value)
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
    public static LtGpm312ComputeDeclarationsResponsePayoutTiming FromCustom(string value)
    {
        return new LtGpm312ComputeDeclarationsResponsePayoutTiming(value);
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
        LtGpm312ComputeDeclarationsResponsePayoutTiming value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LtGpm312ComputeDeclarationsResponsePayoutTiming value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LtGpm312ComputeDeclarationsResponsePayoutTiming value) =>
        value.Value;

    public static explicit operator LtGpm312ComputeDeclarationsResponsePayoutTiming(string value) =>
        new(value);

    internal class LtGpm312ComputeDeclarationsResponsePayoutTimingSerializer
        : JsonConverter<LtGpm312ComputeDeclarationsResponsePayoutTiming>
    {
        public override LtGpm312ComputeDeclarationsResponsePayoutTiming Read(
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
            return new LtGpm312ComputeDeclarationsResponsePayoutTiming(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtGpm312ComputeDeclarationsResponsePayoutTiming value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtGpm312ComputeDeclarationsResponsePayoutTiming ReadAsPropertyName(
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
            return new LtGpm312ComputeDeclarationsResponsePayoutTiming(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtGpm312ComputeDeclarationsResponsePayoutTiming value,
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
        public const string SameMonth = "same-month";

        public const string NextMonth = "next-month";
    }
}
