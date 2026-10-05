using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtSaftSendDeclarationsResponseState.LtSaftSendDeclarationsResponseStateSerializer)
)]
[Serializable]
public readonly record struct LtSaftSendDeclarationsResponseState : IStringEnum
{
    public static readonly LtSaftSendDeclarationsResponseState Submitted = new(Values.Submitted);

    public static readonly LtSaftSendDeclarationsResponseState Accepted = new(Values.Accepted);

    public static readonly LtSaftSendDeclarationsResponseState Rejected = new(Values.Rejected);

    public LtSaftSendDeclarationsResponseState(string value)
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
    public static LtSaftSendDeclarationsResponseState FromCustom(string value)
    {
        return new LtSaftSendDeclarationsResponseState(value);
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

    public static bool operator ==(LtSaftSendDeclarationsResponseState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LtSaftSendDeclarationsResponseState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LtSaftSendDeclarationsResponseState value) =>
        value.Value;

    public static explicit operator LtSaftSendDeclarationsResponseState(string value) => new(value);

    internal class LtSaftSendDeclarationsResponseStateSerializer
        : JsonConverter<LtSaftSendDeclarationsResponseState>
    {
        public override LtSaftSendDeclarationsResponseState Read(
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
            return new LtSaftSendDeclarationsResponseState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtSaftSendDeclarationsResponseState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtSaftSendDeclarationsResponseState ReadAsPropertyName(
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
            return new LtSaftSendDeclarationsResponseState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtSaftSendDeclarationsResponseState value,
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
        public const string Submitted = "submitted";

        public const string Accepted = "accepted";

        public const string Rejected = "rejected";
    }
}
