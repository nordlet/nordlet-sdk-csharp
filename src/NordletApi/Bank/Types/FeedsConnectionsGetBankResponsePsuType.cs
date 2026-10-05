using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FeedsConnectionsGetBankResponsePsuType.FeedsConnectionsGetBankResponsePsuTypeSerializer)
)]
[Serializable]
public readonly record struct FeedsConnectionsGetBankResponsePsuType : IStringEnum
{
    public static readonly FeedsConnectionsGetBankResponsePsuType Business = new(Values.Business);

    public static readonly FeedsConnectionsGetBankResponsePsuType Personal = new(Values.Personal);

    public FeedsConnectionsGetBankResponsePsuType(string value)
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
    public static FeedsConnectionsGetBankResponsePsuType FromCustom(string value)
    {
        return new FeedsConnectionsGetBankResponsePsuType(value);
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

    public static bool operator ==(FeedsConnectionsGetBankResponsePsuType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FeedsConnectionsGetBankResponsePsuType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FeedsConnectionsGetBankResponsePsuType value) =>
        value.Value;

    public static explicit operator FeedsConnectionsGetBankResponsePsuType(string value) =>
        new(value);

    internal class FeedsConnectionsGetBankResponsePsuTypeSerializer
        : JsonConverter<FeedsConnectionsGetBankResponsePsuType>
    {
        public override FeedsConnectionsGetBankResponsePsuType Read(
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
            return new FeedsConnectionsGetBankResponsePsuType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FeedsConnectionsGetBankResponsePsuType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FeedsConnectionsGetBankResponsePsuType ReadAsPropertyName(
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
            return new FeedsConnectionsGetBankResponsePsuType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FeedsConnectionsGetBankResponsePsuType value,
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
        public const string Business = "business";

        public const string Personal = "personal";
    }
}
