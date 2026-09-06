using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AgreementsAgreementsUpdateRequestKind.PostV1AgreementsAgreementsUpdateRequestKindSerializer)
)]
[Serializable]
public readonly record struct PostV1AgreementsAgreementsUpdateRequestKind : IStringEnum
{
    public static readonly PostV1AgreementsAgreementsUpdateRequestKind Customer = new(
        Values.Customer
    );

    public static readonly PostV1AgreementsAgreementsUpdateRequestKind Supplier = new(
        Values.Supplier
    );

    public static readonly PostV1AgreementsAgreementsUpdateRequestKind Employment = new(
        Values.Employment
    );

    public static readonly PostV1AgreementsAgreementsUpdateRequestKind Bank = new(Values.Bank);

    public static readonly PostV1AgreementsAgreementsUpdateRequestKind Lease = new(Values.Lease);

    public static readonly PostV1AgreementsAgreementsUpdateRequestKind Insurance = new(
        Values.Insurance
    );

    public static readonly PostV1AgreementsAgreementsUpdateRequestKind Other = new(Values.Other);

    public PostV1AgreementsAgreementsUpdateRequestKind(string value)
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
    public static PostV1AgreementsAgreementsUpdateRequestKind FromCustom(string value)
    {
        return new PostV1AgreementsAgreementsUpdateRequestKind(value);
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
        PostV1AgreementsAgreementsUpdateRequestKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AgreementsAgreementsUpdateRequestKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AgreementsAgreementsUpdateRequestKind value) =>
        value.Value;

    public static explicit operator PostV1AgreementsAgreementsUpdateRequestKind(string value) =>
        new(value);

    internal class PostV1AgreementsAgreementsUpdateRequestKindSerializer
        : JsonConverter<PostV1AgreementsAgreementsUpdateRequestKind>
    {
        public override PostV1AgreementsAgreementsUpdateRequestKind Read(
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
            return new PostV1AgreementsAgreementsUpdateRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsUpdateRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AgreementsAgreementsUpdateRequestKind ReadAsPropertyName(
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
            return new PostV1AgreementsAgreementsUpdateRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsUpdateRequestKind value,
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
