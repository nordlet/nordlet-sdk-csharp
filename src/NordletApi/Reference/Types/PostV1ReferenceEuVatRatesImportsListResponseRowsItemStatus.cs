using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus.PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus
    : IStringEnum
{
    public static readonly PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus Running = new(
        Values.Running
    );

    public static readonly PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus Succeeded =
        new(Values.Succeeded);

    public static readonly PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus Failed = new(
        Values.Failed
    );

    public PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus(string value)
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
    public static PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus FromCustom(
        string value
    )
    {
        return new PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus(value);
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
        PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus value
    ) => value.Value;

    public static explicit operator PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus(
        string value
    ) => new(value);

    internal class PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatusSerializer
        : JsonConverter<PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus>
    {
        public override PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus Read(
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
            return new PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesImportsListResponseRowsItemStatus value,
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
        public const string Running = "running";

        public const string Succeeded = "succeeded";

        public const string Failed = "failed";
    }
}
