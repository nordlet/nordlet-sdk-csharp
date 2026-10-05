using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FeedsConnectionsStartBankRequestPsuType.FeedsConnectionsStartBankRequestPsuTypeSerializer)
)]
[Serializable]
public readonly record struct FeedsConnectionsStartBankRequestPsuType : IStringEnum
{
    public static readonly FeedsConnectionsStartBankRequestPsuType Business = new(Values.Business);

    public static readonly FeedsConnectionsStartBankRequestPsuType Personal = new(Values.Personal);

    public FeedsConnectionsStartBankRequestPsuType(string value)
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
    public static FeedsConnectionsStartBankRequestPsuType FromCustom(string value)
    {
        return new FeedsConnectionsStartBankRequestPsuType(value);
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

    public static bool operator ==(FeedsConnectionsStartBankRequestPsuType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FeedsConnectionsStartBankRequestPsuType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FeedsConnectionsStartBankRequestPsuType value) =>
        value.Value;

    public static explicit operator FeedsConnectionsStartBankRequestPsuType(string value) =>
        new(value);

    internal class FeedsConnectionsStartBankRequestPsuTypeSerializer
        : JsonConverter<FeedsConnectionsStartBankRequestPsuType>
    {
        public override FeedsConnectionsStartBankRequestPsuType Read(
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
            return new FeedsConnectionsStartBankRequestPsuType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FeedsConnectionsStartBankRequestPsuType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FeedsConnectionsStartBankRequestPsuType ReadAsPropertyName(
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
            return new FeedsConnectionsStartBankRequestPsuType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FeedsConnectionsStartBankRequestPsuType value,
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
