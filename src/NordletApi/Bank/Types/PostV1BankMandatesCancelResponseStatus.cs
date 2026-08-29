using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankMandatesCancelResponseStatus.PostV1BankMandatesCancelResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1BankMandatesCancelResponseStatus : IStringEnum
{
    public static readonly PostV1BankMandatesCancelResponseStatus Active = new(Values.Active);

    public static readonly PostV1BankMandatesCancelResponseStatus Cancelled = new(Values.Cancelled);

    public static readonly PostV1BankMandatesCancelResponseStatus Completed = new(Values.Completed);

    public PostV1BankMandatesCancelResponseStatus(string value)
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
    public static PostV1BankMandatesCancelResponseStatus FromCustom(string value)
    {
        return new PostV1BankMandatesCancelResponseStatus(value);
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

    public static bool operator ==(PostV1BankMandatesCancelResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BankMandatesCancelResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankMandatesCancelResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1BankMandatesCancelResponseStatus(string value) =>
        new(value);

    internal class PostV1BankMandatesCancelResponseStatusSerializer
        : JsonConverter<PostV1BankMandatesCancelResponseStatus>
    {
        public override PostV1BankMandatesCancelResponseStatus Read(
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
            return new PostV1BankMandatesCancelResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankMandatesCancelResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankMandatesCancelResponseStatus ReadAsPropertyName(
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
            return new PostV1BankMandatesCancelResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankMandatesCancelResponseStatus value,
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
