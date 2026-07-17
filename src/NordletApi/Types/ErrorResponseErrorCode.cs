using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ErrorResponseErrorCode.ErrorResponseErrorCodeSerializer))]
[Serializable]
public readonly record struct ErrorResponseErrorCode : IStringEnum
{
    public static readonly ErrorResponseErrorCode Validation = new(Values.Validation);

    public static readonly ErrorResponseErrorCode Unauthorized = new(Values.Unauthorized);

    public static readonly ErrorResponseErrorCode Forbidden = new(Values.Forbidden);

    public static readonly ErrorResponseErrorCode NotFound = new(Values.NotFound);

    public static readonly ErrorResponseErrorCode Conflict = new(Values.Conflict);

    public static readonly ErrorResponseErrorCode IdempotencyKeyReuse = new(
        Values.IdempotencyKeyReuse
    );

    public static readonly ErrorResponseErrorCode IdempotencyInProgress = new(
        Values.IdempotencyInProgress
    );

    public static readonly ErrorResponseErrorCode RateLimited = new(Values.RateLimited);

    public static readonly ErrorResponseErrorCode Internal = new(Values.Internal);

    public ErrorResponseErrorCode(string value)
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
    public static ErrorResponseErrorCode FromCustom(string value)
    {
        return new ErrorResponseErrorCode(value);
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

    public static bool operator ==(ErrorResponseErrorCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ErrorResponseErrorCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ErrorResponseErrorCode value) => value.Value;

    public static explicit operator ErrorResponseErrorCode(string value) => new(value);

    internal class ErrorResponseErrorCodeSerializer : JsonConverter<ErrorResponseErrorCode>
    {
        public override ErrorResponseErrorCode Read(
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
            return new ErrorResponseErrorCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ErrorResponseErrorCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ErrorResponseErrorCode ReadAsPropertyName(
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
            return new ErrorResponseErrorCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ErrorResponseErrorCode value,
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
        public const string Validation = "validation";

        public const string Unauthorized = "unauthorized";

        public const string Forbidden = "forbidden";

        public const string NotFound = "not_found";

        public const string Conflict = "conflict";

        public const string IdempotencyKeyReuse = "idempotency_key_reuse";

        public const string IdempotencyInProgress = "idempotency_in_progress";

        public const string RateLimited = "rate_limited";

        public const string Internal = "internal";
    }
}
