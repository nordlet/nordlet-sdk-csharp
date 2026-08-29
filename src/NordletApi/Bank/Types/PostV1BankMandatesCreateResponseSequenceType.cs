using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankMandatesCreateResponseSequenceType.PostV1BankMandatesCreateResponseSequenceTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankMandatesCreateResponseSequenceType : IStringEnum
{
    public static readonly PostV1BankMandatesCreateResponseSequenceType Recurrent = new(
        Values.Recurrent
    );

    public static readonly PostV1BankMandatesCreateResponseSequenceType OneOff = new(Values.OneOff);

    public PostV1BankMandatesCreateResponseSequenceType(string value)
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
    public static PostV1BankMandatesCreateResponseSequenceType FromCustom(string value)
    {
        return new PostV1BankMandatesCreateResponseSequenceType(value);
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
        PostV1BankMandatesCreateResponseSequenceType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankMandatesCreateResponseSequenceType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankMandatesCreateResponseSequenceType value) =>
        value.Value;

    public static explicit operator PostV1BankMandatesCreateResponseSequenceType(string value) =>
        new(value);

    internal class PostV1BankMandatesCreateResponseSequenceTypeSerializer
        : JsonConverter<PostV1BankMandatesCreateResponseSequenceType>
    {
        public override PostV1BankMandatesCreateResponseSequenceType Read(
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
            return new PostV1BankMandatesCreateResponseSequenceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankMandatesCreateResponseSequenceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankMandatesCreateResponseSequenceType ReadAsPropertyName(
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
            return new PostV1BankMandatesCreateResponseSequenceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankMandatesCreateResponseSequenceType value,
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
