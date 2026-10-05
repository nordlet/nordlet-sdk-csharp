using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuIossComputeDeclarationsResponseRowsItemRateType.EuIossComputeDeclarationsResponseRowsItemRateTypeSerializer)
)]
[Serializable]
public readonly record struct EuIossComputeDeclarationsResponseRowsItemRateType : IStringEnum
{
    public static readonly EuIossComputeDeclarationsResponseRowsItemRateType Standard = new(
        Values.Standard
    );

    public static readonly EuIossComputeDeclarationsResponseRowsItemRateType Reduced = new(
        Values.Reduced
    );

    public EuIossComputeDeclarationsResponseRowsItemRateType(string value)
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
    public static EuIossComputeDeclarationsResponseRowsItemRateType FromCustom(string value)
    {
        return new EuIossComputeDeclarationsResponseRowsItemRateType(value);
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
        EuIossComputeDeclarationsResponseRowsItemRateType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuIossComputeDeclarationsResponseRowsItemRateType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EuIossComputeDeclarationsResponseRowsItemRateType value
    ) => value.Value;

    public static explicit operator EuIossComputeDeclarationsResponseRowsItemRateType(
        string value
    ) => new(value);

    internal class EuIossComputeDeclarationsResponseRowsItemRateTypeSerializer
        : JsonConverter<EuIossComputeDeclarationsResponseRowsItemRateType>
    {
        public override EuIossComputeDeclarationsResponseRowsItemRateType Read(
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
            return new EuIossComputeDeclarationsResponseRowsItemRateType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuIossComputeDeclarationsResponseRowsItemRateType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuIossComputeDeclarationsResponseRowsItemRateType ReadAsPropertyName(
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
            return new EuIossComputeDeclarationsResponseRowsItemRateType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuIossComputeDeclarationsResponseRowsItemRateType value,
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
