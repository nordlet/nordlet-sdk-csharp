using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtFr0600ComputeDeclarationsResponseBreakdownItemDirection.LtFr0600ComputeDeclarationsResponseBreakdownItemDirectionSerializer)
)]
[Serializable]
public readonly record struct LtFr0600ComputeDeclarationsResponseBreakdownItemDirection
    : IStringEnum
{
    public static readonly LtFr0600ComputeDeclarationsResponseBreakdownItemDirection Sales = new(
        Values.Sales
    );

    public static readonly LtFr0600ComputeDeclarationsResponseBreakdownItemDirection Purchases =
        new(Values.Purchases);

    public LtFr0600ComputeDeclarationsResponseBreakdownItemDirection(string value)
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
    public static LtFr0600ComputeDeclarationsResponseBreakdownItemDirection FromCustom(string value)
    {
        return new LtFr0600ComputeDeclarationsResponseBreakdownItemDirection(value);
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
        LtFr0600ComputeDeclarationsResponseBreakdownItemDirection value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LtFr0600ComputeDeclarationsResponseBreakdownItemDirection value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        LtFr0600ComputeDeclarationsResponseBreakdownItemDirection value
    ) => value.Value;

    public static explicit operator LtFr0600ComputeDeclarationsResponseBreakdownItemDirection(
        string value
    ) => new(value);

    internal class LtFr0600ComputeDeclarationsResponseBreakdownItemDirectionSerializer
        : JsonConverter<LtFr0600ComputeDeclarationsResponseBreakdownItemDirection>
    {
        public override LtFr0600ComputeDeclarationsResponseBreakdownItemDirection Read(
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
            return new LtFr0600ComputeDeclarationsResponseBreakdownItemDirection(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtFr0600ComputeDeclarationsResponseBreakdownItemDirection value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtFr0600ComputeDeclarationsResponseBreakdownItemDirection ReadAsPropertyName(
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
            return new LtFr0600ComputeDeclarationsResponseBreakdownItemDirection(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtFr0600ComputeDeclarationsResponseBreakdownItemDirection value,
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
        public const string Sales = "sales";

        public const string Purchases = "purchases";
    }
}
