using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsTaxPaymentsCreateResponseKind.PostV1DeclarationsTaxPaymentsCreateResponseKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsTaxPaymentsCreateResponseKind : IStringEnum
{
    public static readonly PostV1DeclarationsTaxPaymentsCreateResponseKind Advance = new(
        Values.Advance
    );

    public static readonly PostV1DeclarationsTaxPaymentsCreateResponseKind Withholding = new(
        Values.Withholding
    );

    public static readonly PostV1DeclarationsTaxPaymentsCreateResponseKind Final = new(
        Values.Final
    );

    public static readonly PostV1DeclarationsTaxPaymentsCreateResponseKind Refund = new(
        Values.Refund
    );

    public PostV1DeclarationsTaxPaymentsCreateResponseKind(string value)
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
    public static PostV1DeclarationsTaxPaymentsCreateResponseKind FromCustom(string value)
    {
        return new PostV1DeclarationsTaxPaymentsCreateResponseKind(value);
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
        PostV1DeclarationsTaxPaymentsCreateResponseKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsTaxPaymentsCreateResponseKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DeclarationsTaxPaymentsCreateResponseKind value) =>
        value.Value;

    public static explicit operator PostV1DeclarationsTaxPaymentsCreateResponseKind(string value) =>
        new(value);

    internal class PostV1DeclarationsTaxPaymentsCreateResponseKindSerializer
        : JsonConverter<PostV1DeclarationsTaxPaymentsCreateResponseKind>
    {
        public override PostV1DeclarationsTaxPaymentsCreateResponseKind Read(
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
            return new PostV1DeclarationsTaxPaymentsCreateResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxPaymentsCreateResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsTaxPaymentsCreateResponseKind ReadAsPropertyName(
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
            return new PostV1DeclarationsTaxPaymentsCreateResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxPaymentsCreateResponseKind value,
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
        public const string Advance = "advance";

        public const string Withholding = "withholding";

        public const string Final = "final";

        public const string Refund = "refund";
    }
}
