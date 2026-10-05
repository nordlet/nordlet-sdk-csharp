using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtPln204ComputeDeclarationsResponseVariant.LtPln204ComputeDeclarationsResponseVariantSerializer)
)]
[Serializable]
public readonly record struct LtPln204ComputeDeclarationsResponseVariant : IStringEnum
{
    public static readonly LtPln204ComputeDeclarationsResponseVariant Pln204 = new(Values.Pln204);

    public static readonly LtPln204ComputeDeclarationsResponseVariant Pln204A = new(Values.Pln204A);

    public LtPln204ComputeDeclarationsResponseVariant(string value)
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
    public static LtPln204ComputeDeclarationsResponseVariant FromCustom(string value)
    {
        return new LtPln204ComputeDeclarationsResponseVariant(value);
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
        LtPln204ComputeDeclarationsResponseVariant value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LtPln204ComputeDeclarationsResponseVariant value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LtPln204ComputeDeclarationsResponseVariant value) =>
        value.Value;

    public static explicit operator LtPln204ComputeDeclarationsResponseVariant(string value) =>
        new(value);

    internal class LtPln204ComputeDeclarationsResponseVariantSerializer
        : JsonConverter<LtPln204ComputeDeclarationsResponseVariant>
    {
        public override LtPln204ComputeDeclarationsResponseVariant Read(
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
            return new LtPln204ComputeDeclarationsResponseVariant(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtPln204ComputeDeclarationsResponseVariant value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtPln204ComputeDeclarationsResponseVariant ReadAsPropertyName(
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
            return new LtPln204ComputeDeclarationsResponseVariant(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtPln204ComputeDeclarationsResponseVariant value,
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
        public const string Pln204 = "PLN204";

        public const string Pln204A = "PLN204A";
    }
}
