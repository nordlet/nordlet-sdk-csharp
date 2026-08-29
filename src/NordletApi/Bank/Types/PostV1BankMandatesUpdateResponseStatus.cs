using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankMandatesUpdateResponseStatus.PostV1BankMandatesUpdateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1BankMandatesUpdateResponseStatus : IStringEnum
{
    public static readonly PostV1BankMandatesUpdateResponseStatus Active = new(Values.Active);

    public static readonly PostV1BankMandatesUpdateResponseStatus Cancelled = new(Values.Cancelled);

    public static readonly PostV1BankMandatesUpdateResponseStatus Completed = new(Values.Completed);

    public PostV1BankMandatesUpdateResponseStatus(string value)
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
    public static PostV1BankMandatesUpdateResponseStatus FromCustom(string value)
    {
        return new PostV1BankMandatesUpdateResponseStatus(value);
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

    public static bool operator ==(PostV1BankMandatesUpdateResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BankMandatesUpdateResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankMandatesUpdateResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1BankMandatesUpdateResponseStatus(string value) =>
        new(value);

    internal class PostV1BankMandatesUpdateResponseStatusSerializer
        : JsonConverter<PostV1BankMandatesUpdateResponseStatus>
    {
        public override PostV1BankMandatesUpdateResponseStatus Read(
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
            return new PostV1BankMandatesUpdateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankMandatesUpdateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankMandatesUpdateResponseStatus ReadAsPropertyName(
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
            return new PostV1BankMandatesUpdateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankMandatesUpdateResponseStatus value,
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
        public const string Active = "active";

        public const string Cancelled = "cancelled";

        public const string Completed = "completed";
    }
}
