using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankMandatesCancelResponseSequenceType.PostV1BankMandatesCancelResponseSequenceTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankMandatesCancelResponseSequenceType : IStringEnum
{
    public static readonly PostV1BankMandatesCancelResponseSequenceType Recurrent = new(
        Values.Recurrent
    );

    public static readonly PostV1BankMandatesCancelResponseSequenceType OneOff = new(Values.OneOff);

    public PostV1BankMandatesCancelResponseSequenceType(string value)
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
    public static PostV1BankMandatesCancelResponseSequenceType FromCustom(string value)
    {
        return new PostV1BankMandatesCancelResponseSequenceType(value);
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
        PostV1BankMandatesCancelResponseSequenceType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankMandatesCancelResponseSequenceType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankMandatesCancelResponseSequenceType value) =>
        value.Value;

    public static explicit operator PostV1BankMandatesCancelResponseSequenceType(string value) =>
        new(value);

    internal class PostV1BankMandatesCancelResponseSequenceTypeSerializer
        : JsonConverter<PostV1BankMandatesCancelResponseSequenceType>
    {
        public override PostV1BankMandatesCancelResponseSequenceType Read(
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
            return new PostV1BankMandatesCancelResponseSequenceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankMandatesCancelResponseSequenceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankMandatesCancelResponseSequenceType ReadAsPropertyName(
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
            return new PostV1BankMandatesCancelResponseSequenceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankMandatesCancelResponseSequenceType value,
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
        public const string Recurrent = "recurrent";

        public const string OneOff = "one_off";
    }
}
