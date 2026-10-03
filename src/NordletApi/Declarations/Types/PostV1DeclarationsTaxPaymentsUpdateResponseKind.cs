using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsTaxPaymentsUpdateResponseKind.PostV1DeclarationsTaxPaymentsUpdateResponseKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsTaxPaymentsUpdateResponseKind : IStringEnum
{
    public static readonly PostV1DeclarationsTaxPaymentsUpdateResponseKind Advance = new(
        Values.Advance
    );

    public static readonly PostV1DeclarationsTaxPaymentsUpdateResponseKind Withholding = new(
        Values.Withholding
    );

    public static readonly PostV1DeclarationsTaxPaymentsUpdateResponseKind Final = new(
        Values.Final
    );

    public static readonly PostV1DeclarationsTaxPaymentsUpdateResponseKind Refund = new(
        Values.Refund
    );

    public PostV1DeclarationsTaxPaymentsUpdateResponseKind(string value)
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
    public static PostV1DeclarationsTaxPaymentsUpdateResponseKind FromCustom(string value)
    {
        return new PostV1DeclarationsTaxPaymentsUpdateResponseKind(value);
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
        PostV1DeclarationsTaxPaymentsUpdateResponseKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsTaxPaymentsUpdateResponseKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DeclarationsTaxPaymentsUpdateResponseKind value) =>
        value.Value;

    public static explicit operator PostV1DeclarationsTaxPaymentsUpdateResponseKind(string value) =>
        new(value);

    internal class PostV1DeclarationsTaxPaymentsUpdateResponseKindSerializer
        : JsonConverter<PostV1DeclarationsTaxPaymentsUpdateResponseKind>
    {
        public override PostV1DeclarationsTaxPaymentsUpdateResponseKind Read(
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
            return new PostV1DeclarationsTaxPaymentsUpdateResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxPaymentsUpdateResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsTaxPaymentsUpdateResponseKind ReadAsPropertyName(
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
            return new PostV1DeclarationsTaxPaymentsUpdateResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxPaymentsUpdateResponseKind value,
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
