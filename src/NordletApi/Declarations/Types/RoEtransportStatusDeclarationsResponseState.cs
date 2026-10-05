using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RoEtransportStatusDeclarationsResponseState.RoEtransportStatusDeclarationsResponseStateSerializer)
)]
[Serializable]
public readonly record struct RoEtransportStatusDeclarationsResponseState : IStringEnum
{
    public static readonly RoEtransportStatusDeclarationsResponseState Submitted = new(
        Values.Submitted
    );

    public static readonly RoEtransportStatusDeclarationsResponseState Accepted = new(
        Values.Accepted
    );

    public static readonly RoEtransportStatusDeclarationsResponseState Rejected = new(
        Values.Rejected
    );

    public RoEtransportStatusDeclarationsResponseState(string value)
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
    public static RoEtransportStatusDeclarationsResponseState FromCustom(string value)
    {
        return new RoEtransportStatusDeclarationsResponseState(value);
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
        RoEtransportStatusDeclarationsResponseState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RoEtransportStatusDeclarationsResponseState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RoEtransportStatusDeclarationsResponseState value) =>
        value.Value;

    public static explicit operator RoEtransportStatusDeclarationsResponseState(string value) =>
        new(value);

    internal class RoEtransportStatusDeclarationsResponseStateSerializer
        : JsonConverter<RoEtransportStatusDeclarationsResponseState>
    {
        public override RoEtransportStatusDeclarationsResponseState Read(
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
            return new RoEtransportStatusDeclarationsResponseState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RoEtransportStatusDeclarationsResponseState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RoEtransportStatusDeclarationsResponseState ReadAsPropertyName(
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
            return new RoEtransportStatusDeclarationsResponseState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RoEtransportStatusDeclarationsResponseState value,
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
