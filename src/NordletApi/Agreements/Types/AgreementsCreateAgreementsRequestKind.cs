using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsCreateAgreementsRequestKind.AgreementsCreateAgreementsRequestKindSerializer)
)]
[Serializable]
public readonly record struct AgreementsCreateAgreementsRequestKind : IStringEnum
{
    public static readonly AgreementsCreateAgreementsRequestKind Customer = new(Values.Customer);

    public static readonly AgreementsCreateAgreementsRequestKind Supplier = new(Values.Supplier);

    public static readonly AgreementsCreateAgreementsRequestKind Employment = new(
        Values.Employment
    );

    public static readonly AgreementsCreateAgreementsRequestKind Bank = new(Values.Bank);

    public static readonly AgreementsCreateAgreementsRequestKind Lease = new(Values.Lease);

    public static readonly AgreementsCreateAgreementsRequestKind Insurance = new(Values.Insurance);

    public static readonly AgreementsCreateAgreementsRequestKind Other = new(Values.Other);

    public AgreementsCreateAgreementsRequestKind(string value)
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
    public static AgreementsCreateAgreementsRequestKind FromCustom(string value)
    {
        return new AgreementsCreateAgreementsRequestKind(value);
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

    public static bool operator ==(AgreementsCreateAgreementsRequestKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AgreementsCreateAgreementsRequestKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsCreateAgreementsRequestKind value) =>
        value.Value;

    public static explicit operator AgreementsCreateAgreementsRequestKind(string value) =>
        new(value);

    internal class AgreementsCreateAgreementsRequestKindSerializer
        : JsonConverter<AgreementsCreateAgreementsRequestKind>
    {
        public override AgreementsCreateAgreementsRequestKind Read(
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
            return new AgreementsCreateAgreementsRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsCreateAgreementsRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsCreateAgreementsRequestKind ReadAsPropertyName(
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
            return new AgreementsCreateAgreementsRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsCreateAgreementsRequestKind value,
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
