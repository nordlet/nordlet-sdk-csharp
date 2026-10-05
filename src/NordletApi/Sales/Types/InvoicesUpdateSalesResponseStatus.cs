using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesUpdateSalesResponseStatus.InvoicesUpdateSalesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesUpdateSalesResponseStatus : IStringEnum
{
    public static readonly InvoicesUpdateSalesResponseStatus Draft = new(Values.Draft);

    public static readonly InvoicesUpdateSalesResponseStatus Issued = new(Values.Issued);

    public InvoicesUpdateSalesResponseStatus(string value)
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
    public static InvoicesUpdateSalesResponseStatus FromCustom(string value)
    {
        return new InvoicesUpdateSalesResponseStatus(value);
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

    public static bool operator ==(InvoicesUpdateSalesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesUpdateSalesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesUpdateSalesResponseStatus value) => value.Value;

    public static explicit operator InvoicesUpdateSalesResponseStatus(string value) => new(value);

    internal class InvoicesUpdateSalesResponseStatusSerializer
        : JsonConverter<InvoicesUpdateSalesResponseStatus>
    {
        public override InvoicesUpdateSalesResponseStatus Read(
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
            return new InvoicesUpdateSalesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesUpdateSalesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesUpdateSalesResponseStatus ReadAsPropertyName(
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
            return new InvoicesUpdateSalesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesUpdateSalesResponseStatus value,
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
    }
}
