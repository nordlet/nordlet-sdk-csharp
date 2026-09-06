using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AgreementsAgreementsUpdateResponseKind.PostV1AgreementsAgreementsUpdateResponseKindSerializer)
)]
[Serializable]
public readonly record struct PostV1AgreementsAgreementsUpdateResponseKind : IStringEnum
{
    public static readonly PostV1AgreementsAgreementsUpdateResponseKind Customer = new(
        Values.Customer
    );

    public static readonly PostV1AgreementsAgreementsUpdateResponseKind Supplier = new(
        Values.Supplier
    );

    public static readonly PostV1AgreementsAgreementsUpdateResponseKind Employment = new(
        Values.Employment
    );

    public static readonly PostV1AgreementsAgreementsUpdateResponseKind Bank = new(Values.Bank);

    public static readonly PostV1AgreementsAgreementsUpdateResponseKind Lease = new(Values.Lease);

    public static readonly PostV1AgreementsAgreementsUpdateResponseKind Insurance = new(
        Values.Insurance
    );

    public static readonly PostV1AgreementsAgreementsUpdateResponseKind Other = new(Values.Other);

    public PostV1AgreementsAgreementsUpdateResponseKind(string value)
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
    public static PostV1AgreementsAgreementsUpdateResponseKind FromCustom(string value)
    {
        return new PostV1AgreementsAgreementsUpdateResponseKind(value);
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
        PostV1AgreementsAgreementsUpdateResponseKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AgreementsAgreementsUpdateResponseKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AgreementsAgreementsUpdateResponseKind value) =>
        value.Value;

    public static explicit operator PostV1AgreementsAgreementsUpdateResponseKind(string value) =>
        new(value);

    internal class PostV1AgreementsAgreementsUpdateResponseKindSerializer
        : JsonConverter<PostV1AgreementsAgreementsUpdateResponseKind>
    {
        public override PostV1AgreementsAgreementsUpdateResponseKind Read(
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
            return new PostV1AgreementsAgreementsUpdateResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsUpdateResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AgreementsAgreementsUpdateResponseKind ReadAsPropertyName(
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
            return new PostV1AgreementsAgreementsUpdateResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsUpdateResponseKind value,
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
