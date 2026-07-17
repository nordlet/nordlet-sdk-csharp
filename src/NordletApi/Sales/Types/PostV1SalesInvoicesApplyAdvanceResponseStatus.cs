using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesInvoicesApplyAdvanceResponseStatus.PostV1SalesInvoicesApplyAdvanceResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesInvoicesApplyAdvanceResponseStatus : IStringEnum
{
    public static readonly PostV1SalesInvoicesApplyAdvanceResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1SalesInvoicesApplyAdvanceResponseStatus Issued = new(
        Values.Issued
    );

    public PostV1SalesInvoicesApplyAdvanceResponseStatus(string value)
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
    public static PostV1SalesInvoicesApplyAdvanceResponseStatus FromCustom(string value)
    {
        return new PostV1SalesInvoicesApplyAdvanceResponseStatus(value);
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
        PostV1SalesInvoicesApplyAdvanceResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesInvoicesApplyAdvanceResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesInvoicesApplyAdvanceResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1SalesInvoicesApplyAdvanceResponseStatus(string value) =>
        new(value);

    internal class PostV1SalesInvoicesApplyAdvanceResponseStatusSerializer
        : JsonConverter<PostV1SalesInvoicesApplyAdvanceResponseStatus>
    {
        public override PostV1SalesInvoicesApplyAdvanceResponseStatus Read(
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
            return new PostV1SalesInvoicesApplyAdvanceResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesApplyAdvanceResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesInvoicesApplyAdvanceResponseStatus ReadAsPropertyName(
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
            return new PostV1SalesInvoicesApplyAdvanceResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesApplyAdvanceResponseStatus value,
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
