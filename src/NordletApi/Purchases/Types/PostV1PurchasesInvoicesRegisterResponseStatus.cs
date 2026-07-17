using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesInvoicesRegisterResponseStatus.PostV1PurchasesInvoicesRegisterResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesInvoicesRegisterResponseStatus : IStringEnum
{
    public static readonly PostV1PurchasesInvoicesRegisterResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1PurchasesInvoicesRegisterResponseStatus Registered = new(
        Values.Registered
    );

    public PostV1PurchasesInvoicesRegisterResponseStatus(string value)
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
    public static PostV1PurchasesInvoicesRegisterResponseStatus FromCustom(string value)
    {
        return new PostV1PurchasesInvoicesRegisterResponseStatus(value);
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
        PostV1PurchasesInvoicesRegisterResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PurchasesInvoicesRegisterResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PurchasesInvoicesRegisterResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1PurchasesInvoicesRegisterResponseStatus(string value) =>
        new(value);

    internal class PostV1PurchasesInvoicesRegisterResponseStatusSerializer
        : JsonConverter<PostV1PurchasesInvoicesRegisterResponseStatus>
    {
        public override PostV1PurchasesInvoicesRegisterResponseStatus Read(
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
            return new PostV1PurchasesInvoicesRegisterResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesRegisterResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesInvoicesRegisterResponseStatus ReadAsPropertyName(
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
            return new PostV1PurchasesInvoicesRegisterResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesRegisterResponseStatus value,
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

        public const string Registered = "registered";
    }
}
