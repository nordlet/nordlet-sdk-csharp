using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesReverseSalesResponseStatus.InvoicesReverseSalesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesReverseSalesResponseStatus : IStringEnum
{
    public static readonly InvoicesReverseSalesResponseStatus Draft = new(Values.Draft);

    public static readonly InvoicesReverseSalesResponseStatus Issued = new(Values.Issued);

    public static readonly InvoicesReverseSalesResponseStatus Reversed = new(Values.Reversed);

    public InvoicesReverseSalesResponseStatus(string value)
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
    public static InvoicesReverseSalesResponseStatus FromCustom(string value)
    {
        return new InvoicesReverseSalesResponseStatus(value);
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

    public static bool operator ==(InvoicesReverseSalesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesReverseSalesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesReverseSalesResponseStatus value) => value.Value;

    public static explicit operator InvoicesReverseSalesResponseStatus(string value) => new(value);

    internal class InvoicesReverseSalesResponseStatusSerializer
        : JsonConverter<InvoicesReverseSalesResponseStatus>
    {
        public override InvoicesReverseSalesResponseStatus Read(
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
            return new InvoicesReverseSalesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesReverseSalesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesReverseSalesResponseStatus ReadAsPropertyName(
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
            return new InvoicesReverseSalesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesReverseSalesResponseStatus value,
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

        public const string Reversed = "reversed";
    }
}
