using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuOssComputeDeclarationsResponseRowsItemRateType.EuOssComputeDeclarationsResponseRowsItemRateTypeSerializer)
)]
[Serializable]
public readonly record struct EuOssComputeDeclarationsResponseRowsItemRateType : IStringEnum
{
    public static readonly EuOssComputeDeclarationsResponseRowsItemRateType Standard = new(
        Values.Standard
    );

    public static readonly EuOssComputeDeclarationsResponseRowsItemRateType Reduced = new(
        Values.Reduced
    );

    public EuOssComputeDeclarationsResponseRowsItemRateType(string value)
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
    public static EuOssComputeDeclarationsResponseRowsItemRateType FromCustom(string value)
    {
        return new EuOssComputeDeclarationsResponseRowsItemRateType(value);
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
        EuOssComputeDeclarationsResponseRowsItemRateType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuOssComputeDeclarationsResponseRowsItemRateType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EuOssComputeDeclarationsResponseRowsItemRateType value
    ) => value.Value;

    public static explicit operator EuOssComputeDeclarationsResponseRowsItemRateType(
        string value
    ) => new(value);

    internal class EuOssComputeDeclarationsResponseRowsItemRateTypeSerializer
        : JsonConverter<EuOssComputeDeclarationsResponseRowsItemRateType>
    {
        public override EuOssComputeDeclarationsResponseRowsItemRateType Read(
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
            return new EuOssComputeDeclarationsResponseRowsItemRateType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuOssComputeDeclarationsResponseRowsItemRateType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuOssComputeDeclarationsResponseRowsItemRateType ReadAsPropertyName(
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
            return new EuOssComputeDeclarationsResponseRowsItemRateType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuOssComputeDeclarationsResponseRowsItemRateType value,
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
        public const string Standard = "STANDARD";

        public const string Reduced = "REDUCED";
    }
}
