using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AgreementsAgreementsCreateResponseKind.PostV1AgreementsAgreementsCreateResponseKindSerializer)
)]
[Serializable]
public readonly record struct PostV1AgreementsAgreementsCreateResponseKind : IStringEnum
{
    public static readonly PostV1AgreementsAgreementsCreateResponseKind Customer = new(
        Values.Customer
    );

    public static readonly PostV1AgreementsAgreementsCreateResponseKind Supplier = new(
        Values.Supplier
    );

    public static readonly PostV1AgreementsAgreementsCreateResponseKind Employment = new(
        Values.Employment
    );

    public static readonly PostV1AgreementsAgreementsCreateResponseKind Bank = new(Values.Bank);

    public static readonly PostV1AgreementsAgreementsCreateResponseKind Lease = new(Values.Lease);

    public static readonly PostV1AgreementsAgreementsCreateResponseKind Insurance = new(
        Values.Insurance
    );

    public static readonly PostV1AgreementsAgreementsCreateResponseKind Other = new(Values.Other);

    public PostV1AgreementsAgreementsCreateResponseKind(string value)
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
    public static PostV1AgreementsAgreementsCreateResponseKind FromCustom(string value)
    {
        return new PostV1AgreementsAgreementsCreateResponseKind(value);
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
        PostV1AgreementsAgreementsCreateResponseKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AgreementsAgreementsCreateResponseKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AgreementsAgreementsCreateResponseKind value) =>
        value.Value;

    public static explicit operator PostV1AgreementsAgreementsCreateResponseKind(string value) =>
        new(value);

    internal class PostV1AgreementsAgreementsCreateResponseKindSerializer
        : JsonConverter<PostV1AgreementsAgreementsCreateResponseKind>
    {
        public override PostV1AgreementsAgreementsCreateResponseKind Read(
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
            return new PostV1AgreementsAgreementsCreateResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsCreateResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AgreementsAgreementsCreateResponseKind ReadAsPropertyName(
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
            return new PostV1AgreementsAgreementsCreateResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsCreateResponseKind value,
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
        public const string Customer = "customer";

        public const string Supplier = "supplier";

        public const string Employment = "employment";

        public const string Bank = "bank";

        public const string Lease = "lease";

        public const string Insurance = "insurance";

        public const string Other = "other";
    }
}
