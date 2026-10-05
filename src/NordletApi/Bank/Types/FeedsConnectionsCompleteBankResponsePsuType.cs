using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FeedsConnectionsCompleteBankResponsePsuType.FeedsConnectionsCompleteBankResponsePsuTypeSerializer)
)]
[Serializable]
public readonly record struct FeedsConnectionsCompleteBankResponsePsuType : IStringEnum
{
    public static readonly FeedsConnectionsCompleteBankResponsePsuType Business = new(
        Values.Business
    );

    public static readonly FeedsConnectionsCompleteBankResponsePsuType Personal = new(
        Values.Personal
    );

    public FeedsConnectionsCompleteBankResponsePsuType(string value)
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
    public static FeedsConnectionsCompleteBankResponsePsuType FromCustom(string value)
    {
        return new FeedsConnectionsCompleteBankResponsePsuType(value);
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
        FeedsConnectionsCompleteBankResponsePsuType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FeedsConnectionsCompleteBankResponsePsuType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FeedsConnectionsCompleteBankResponsePsuType value) =>
        value.Value;

    public static explicit operator FeedsConnectionsCompleteBankResponsePsuType(string value) =>
        new(value);

    internal class FeedsConnectionsCompleteBankResponsePsuTypeSerializer
        : JsonConverter<FeedsConnectionsCompleteBankResponsePsuType>
    {
        public override FeedsConnectionsCompleteBankResponsePsuType Read(
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
            return new FeedsConnectionsCompleteBankResponsePsuType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FeedsConnectionsCompleteBankResponsePsuType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FeedsConnectionsCompleteBankResponsePsuType ReadAsPropertyName(
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
            return new FeedsConnectionsCompleteBankResponsePsuType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FeedsConnectionsCompleteBankResponsePsuType value,
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
