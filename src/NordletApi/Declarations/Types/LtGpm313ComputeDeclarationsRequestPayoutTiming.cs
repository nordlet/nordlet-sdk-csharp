using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtGpm313ComputeDeclarationsRequestPayoutTiming.LtGpm313ComputeDeclarationsRequestPayoutTimingSerializer)
)]
[Serializable]
public readonly record struct LtGpm313ComputeDeclarationsRequestPayoutTiming : IStringEnum
{
    public static readonly LtGpm313ComputeDeclarationsRequestPayoutTiming SameMonth = new(
        Values.SameMonth
    );

    public static readonly LtGpm313ComputeDeclarationsRequestPayoutTiming NextMonth = new(
        Values.NextMonth
    );

    public LtGpm313ComputeDeclarationsRequestPayoutTiming(string value)
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
    public static LtGpm313ComputeDeclarationsRequestPayoutTiming FromCustom(string value)
    {
        return new LtGpm313ComputeDeclarationsRequestPayoutTiming(value);
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
        LtGpm313ComputeDeclarationsRequestPayoutTiming value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LtGpm313ComputeDeclarationsRequestPayoutTiming value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LtGpm313ComputeDeclarationsRequestPayoutTiming value) =>
        value.Value;

    public static explicit operator LtGpm313ComputeDeclarationsRequestPayoutTiming(string value) =>
        new(value);

    internal class LtGpm313ComputeDeclarationsRequestPayoutTimingSerializer
        : JsonConverter<LtGpm313ComputeDeclarationsRequestPayoutTiming>
    {
        public override LtGpm313ComputeDeclarationsRequestPayoutTiming Read(
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
            return new LtGpm313ComputeDeclarationsRequestPayoutTiming(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtGpm313ComputeDeclarationsRequestPayoutTiming value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtGpm313ComputeDeclarationsRequestPayoutTiming ReadAsPropertyName(
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
            return new LtGpm313ComputeDeclarationsRequestPayoutTiming(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtGpm313ComputeDeclarationsRequestPayoutTiming value,
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
