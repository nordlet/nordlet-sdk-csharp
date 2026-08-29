using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesInvoicesMatchResponseStatus.PostV1PurchasesInvoicesMatchResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesInvoicesMatchResponseStatus : IStringEnum
{
    public static readonly PostV1PurchasesInvoicesMatchResponseStatus Matched = new(Values.Matched);

    public static readonly PostV1PurchasesInvoicesMatchResponseStatus Mismatched = new(
        Values.Mismatched
    );

    public PostV1PurchasesInvoicesMatchResponseStatus(string value)
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
    public static PostV1PurchasesInvoicesMatchResponseStatus FromCustom(string value)
    {
        return new PostV1PurchasesInvoicesMatchResponseStatus(value);
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
        PostV1PurchasesInvoicesMatchResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PurchasesInvoicesMatchResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PurchasesInvoicesMatchResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1PurchasesInvoicesMatchResponseStatus(string value) =>
        new(value);

    internal class PostV1PurchasesInvoicesMatchResponseStatusSerializer
        : JsonConverter<PostV1PurchasesInvoicesMatchResponseStatus>
    {
        public override PostV1PurchasesInvoicesMatchResponseStatus Read(
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
            return new PostV1PurchasesInvoicesMatchResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesMatchResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesInvoicesMatchResponseStatus ReadAsPropertyName(
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
            return new PostV1PurchasesInvoicesMatchResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesMatchResponseStatus value,
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
        public const string Matched = "matched";

        public const string Mismatched = "mismatched";
    }
}
