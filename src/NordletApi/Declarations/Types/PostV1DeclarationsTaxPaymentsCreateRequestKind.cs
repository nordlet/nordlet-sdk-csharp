using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsTaxPaymentsCreateRequestKind.PostV1DeclarationsTaxPaymentsCreateRequestKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsTaxPaymentsCreateRequestKind : IStringEnum
{
    public static readonly PostV1DeclarationsTaxPaymentsCreateRequestKind Advance = new(
        Values.Advance
    );

    public static readonly PostV1DeclarationsTaxPaymentsCreateRequestKind Withholding = new(
        Values.Withholding
    );

    public static readonly PostV1DeclarationsTaxPaymentsCreateRequestKind Final = new(Values.Final);

    public static readonly PostV1DeclarationsTaxPaymentsCreateRequestKind Refund = new(
        Values.Refund
    );

    public PostV1DeclarationsTaxPaymentsCreateRequestKind(string value)
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
    public static PostV1DeclarationsTaxPaymentsCreateRequestKind FromCustom(string value)
    {
        return new PostV1DeclarationsTaxPaymentsCreateRequestKind(value);
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
        PostV1DeclarationsTaxPaymentsCreateRequestKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsTaxPaymentsCreateRequestKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DeclarationsTaxPaymentsCreateRequestKind value) =>
        value.Value;

    public static explicit operator PostV1DeclarationsTaxPaymentsCreateRequestKind(string value) =>
        new(value);

    internal class PostV1DeclarationsTaxPaymentsCreateRequestKindSerializer
        : JsonConverter<PostV1DeclarationsTaxPaymentsCreateRequestKind>
    {
        public override PostV1DeclarationsTaxPaymentsCreateRequestKind Read(
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
            return new PostV1DeclarationsTaxPaymentsCreateRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxPaymentsCreateRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsTaxPaymentsCreateRequestKind ReadAsPropertyName(
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
            return new PostV1DeclarationsTaxPaymentsCreateRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxPaymentsCreateRequestKind value,
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
