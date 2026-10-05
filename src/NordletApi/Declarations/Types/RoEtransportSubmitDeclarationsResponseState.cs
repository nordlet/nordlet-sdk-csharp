using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RoEtransportSubmitDeclarationsResponseState.RoEtransportSubmitDeclarationsResponseStateSerializer)
)]
[Serializable]
public readonly record struct RoEtransportSubmitDeclarationsResponseState : IStringEnum
{
    public static readonly RoEtransportSubmitDeclarationsResponseState Submitted = new(
        Values.Submitted
    );

    public static readonly RoEtransportSubmitDeclarationsResponseState Accepted = new(
        Values.Accepted
    );

    public static readonly RoEtransportSubmitDeclarationsResponseState Rejected = new(
        Values.Rejected
    );

    public RoEtransportSubmitDeclarationsResponseState(string value)
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
    public static RoEtransportSubmitDeclarationsResponseState FromCustom(string value)
    {
        return new RoEtransportSubmitDeclarationsResponseState(value);
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
        RoEtransportSubmitDeclarationsResponseState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RoEtransportSubmitDeclarationsResponseState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RoEtransportSubmitDeclarationsResponseState value) =>
        value.Value;

    public static explicit operator RoEtransportSubmitDeclarationsResponseState(string value) =>
        new(value);

    internal class RoEtransportSubmitDeclarationsResponseStateSerializer
        : JsonConverter<RoEtransportSubmitDeclarationsResponseState>
    {
        public override RoEtransportSubmitDeclarationsResponseState Read(
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
            return new RoEtransportSubmitDeclarationsResponseState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RoEtransportSubmitDeclarationsResponseState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RoEtransportSubmitDeclarationsResponseState ReadAsPropertyName(
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
            return new RoEtransportSubmitDeclarationsResponseState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RoEtransportSubmitDeclarationsResponseState value,
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
