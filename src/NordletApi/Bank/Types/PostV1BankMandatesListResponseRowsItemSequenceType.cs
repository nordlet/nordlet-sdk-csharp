using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankMandatesListResponseRowsItemSequenceType.PostV1BankMandatesListResponseRowsItemSequenceTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankMandatesListResponseRowsItemSequenceType : IStringEnum
{
    public static readonly PostV1BankMandatesListResponseRowsItemSequenceType Recurrent = new(
        Values.Recurrent
    );

    public static readonly PostV1BankMandatesListResponseRowsItemSequenceType OneOff = new(
        Values.OneOff
    );

    public PostV1BankMandatesListResponseRowsItemSequenceType(string value)
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
    public static PostV1BankMandatesListResponseRowsItemSequenceType FromCustom(string value)
    {
        return new PostV1BankMandatesListResponseRowsItemSequenceType(value);
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
        PostV1BankMandatesListResponseRowsItemSequenceType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankMandatesListResponseRowsItemSequenceType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankMandatesListResponseRowsItemSequenceType value
    ) => value.Value;

    public static explicit operator PostV1BankMandatesListResponseRowsItemSequenceType(
        string value
    ) => new(value);

    internal class PostV1BankMandatesListResponseRowsItemSequenceTypeSerializer
        : JsonConverter<PostV1BankMandatesListResponseRowsItemSequenceType>
    {
        public override PostV1BankMandatesListResponseRowsItemSequenceType Read(
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
            return new PostV1BankMandatesListResponseRowsItemSequenceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankMandatesListResponseRowsItemSequenceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankMandatesListResponseRowsItemSequenceType ReadAsPropertyName(
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
            return new PostV1BankMandatesListResponseRowsItemSequenceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankMandatesListResponseRowsItemSequenceType value,
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
