using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuOssNonUnionComputeDeclarationsResponseRowsItemRateType.EuOssNonUnionComputeDeclarationsResponseRowsItemRateTypeSerializer)
)]
[Serializable]
public readonly record struct EuOssNonUnionComputeDeclarationsResponseRowsItemRateType : IStringEnum
{
    public static readonly EuOssNonUnionComputeDeclarationsResponseRowsItemRateType Standard = new(
        Values.Standard
    );

    public static readonly EuOssNonUnionComputeDeclarationsResponseRowsItemRateType Reduced = new(
        Values.Reduced
    );

    public EuOssNonUnionComputeDeclarationsResponseRowsItemRateType(string value)
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
    public static EuOssNonUnionComputeDeclarationsResponseRowsItemRateType FromCustom(string value)
    {
        return new EuOssNonUnionComputeDeclarationsResponseRowsItemRateType(value);
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
        EuOssNonUnionComputeDeclarationsResponseRowsItemRateType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuOssNonUnionComputeDeclarationsResponseRowsItemRateType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EuOssNonUnionComputeDeclarationsResponseRowsItemRateType value
    ) => value.Value;

    public static explicit operator EuOssNonUnionComputeDeclarationsResponseRowsItemRateType(
        string value
    ) => new(value);

    internal class EuOssNonUnionComputeDeclarationsResponseRowsItemRateTypeSerializer
        : JsonConverter<EuOssNonUnionComputeDeclarationsResponseRowsItemRateType>
    {
        public override EuOssNonUnionComputeDeclarationsResponseRowsItemRateType Read(
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
            return new EuOssNonUnionComputeDeclarationsResponseRowsItemRateType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuOssNonUnionComputeDeclarationsResponseRowsItemRateType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuOssNonUnionComputeDeclarationsResponseRowsItemRateType ReadAsPropertyName(
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
            return new EuOssNonUnionComputeDeclarationsResponseRowsItemRateType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuOssNonUnionComputeDeclarationsResponseRowsItemRateType value,
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
