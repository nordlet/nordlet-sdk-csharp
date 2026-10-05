using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EeEmploymentRegisterSendDeclarationsResponseState.EeEmploymentRegisterSendDeclarationsResponseStateSerializer)
)]
[Serializable]
public readonly record struct EeEmploymentRegisterSendDeclarationsResponseState : IStringEnum
{
    public static readonly EeEmploymentRegisterSendDeclarationsResponseState Submitted = new(
        Values.Submitted
    );

    public static readonly EeEmploymentRegisterSendDeclarationsResponseState Accepted = new(
        Values.Accepted
    );

    public static readonly EeEmploymentRegisterSendDeclarationsResponseState Rejected = new(
        Values.Rejected
    );

    public EeEmploymentRegisterSendDeclarationsResponseState(string value)
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
    public static EeEmploymentRegisterSendDeclarationsResponseState FromCustom(string value)
    {
        return new EeEmploymentRegisterSendDeclarationsResponseState(value);
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
        EeEmploymentRegisterSendDeclarationsResponseState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EeEmploymentRegisterSendDeclarationsResponseState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EeEmploymentRegisterSendDeclarationsResponseState value
    ) => value.Value;

    public static explicit operator EeEmploymentRegisterSendDeclarationsResponseState(
        string value
    ) => new(value);

    internal class EeEmploymentRegisterSendDeclarationsResponseStateSerializer
        : JsonConverter<EeEmploymentRegisterSendDeclarationsResponseState>
    {
        public override EeEmploymentRegisterSendDeclarationsResponseState Read(
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
            return new EeEmploymentRegisterSendDeclarationsResponseState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EeEmploymentRegisterSendDeclarationsResponseState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EeEmploymentRegisterSendDeclarationsResponseState ReadAsPropertyName(
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
            return new EeEmploymentRegisterSendDeclarationsResponseState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EeEmploymentRegisterSendDeclarationsResponseState value,
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
