using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ActsCancelSalesResponseStatus.ActsCancelSalesResponseStatusSerializer))]
[Serializable]
public readonly record struct ActsCancelSalesResponseStatus : IStringEnum
{
    public static readonly ActsCancelSalesResponseStatus Draft = new(Values.Draft);

    public static readonly ActsCancelSalesResponseStatus Issued = new(Values.Issued);

    public static readonly ActsCancelSalesResponseStatus Cancelled = new(Values.Cancelled);

    public ActsCancelSalesResponseStatus(string value)
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
    public static ActsCancelSalesResponseStatus FromCustom(string value)
    {
        return new ActsCancelSalesResponseStatus(value);
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

    public static bool operator ==(ActsCancelSalesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ActsCancelSalesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ActsCancelSalesResponseStatus value) => value.Value;

    public static explicit operator ActsCancelSalesResponseStatus(string value) => new(value);

    internal class ActsCancelSalesResponseStatusSerializer
        : JsonConverter<ActsCancelSalesResponseStatus>
    {
        public override ActsCancelSalesResponseStatus Read(
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
            return new ActsCancelSalesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ActsCancelSalesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ActsCancelSalesResponseStatus ReadAsPropertyName(
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
            return new ActsCancelSalesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ActsCancelSalesResponseStatus value,
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
        public const string Draft = "draft";

        public const string Issued = "issued";

        public const string Cancelled = "cancelled";
    }
}
