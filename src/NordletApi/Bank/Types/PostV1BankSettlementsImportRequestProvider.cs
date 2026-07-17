using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankSettlementsImportRequestProvider.PostV1BankSettlementsImportRequestProviderSerializer)
)]
[Serializable]
public readonly record struct PostV1BankSettlementsImportRequestProvider : IStringEnum
{
    public static readonly PostV1BankSettlementsImportRequestProvider Stripe = new(Values.Stripe);

    public PostV1BankSettlementsImportRequestProvider(string value)
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
    public static PostV1BankSettlementsImportRequestProvider FromCustom(string value)
    {
        return new PostV1BankSettlementsImportRequestProvider(value);
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
        PostV1BankSettlementsImportRequestProvider value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankSettlementsImportRequestProvider value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankSettlementsImportRequestProvider value) =>
        value.Value;

    public static explicit operator PostV1BankSettlementsImportRequestProvider(string value) =>
        new(value);

    internal class PostV1BankSettlementsImportRequestProviderSerializer
        : JsonConverter<PostV1BankSettlementsImportRequestProvider>
    {
        public override PostV1BankSettlementsImportRequestProvider Read(
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
            return new PostV1BankSettlementsImportRequestProvider(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankSettlementsImportRequestProvider value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankSettlementsImportRequestProvider ReadAsPropertyName(
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
            return new PostV1BankSettlementsImportRequestProvider(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankSettlementsImportRequestProvider value,
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
        public const string Stripe = "stripe";
    }
}
