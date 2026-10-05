using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsCreateAgreementsResponseKind.AgreementsCreateAgreementsResponseKindSerializer)
)]
[Serializable]
public readonly record struct AgreementsCreateAgreementsResponseKind : IStringEnum
{
    public static readonly AgreementsCreateAgreementsResponseKind Customer = new(Values.Customer);

    public static readonly AgreementsCreateAgreementsResponseKind Supplier = new(Values.Supplier);

    public static readonly AgreementsCreateAgreementsResponseKind Employment = new(
        Values.Employment
    );

    public static readonly AgreementsCreateAgreementsResponseKind Bank = new(Values.Bank);

    public static readonly AgreementsCreateAgreementsResponseKind Lease = new(Values.Lease);

    public static readonly AgreementsCreateAgreementsResponseKind Insurance = new(Values.Insurance);

    public static readonly AgreementsCreateAgreementsResponseKind Other = new(Values.Other);

    public AgreementsCreateAgreementsResponseKind(string value)
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
    public static AgreementsCreateAgreementsResponseKind FromCustom(string value)
    {
        return new AgreementsCreateAgreementsResponseKind(value);
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

    public static bool operator ==(AgreementsCreateAgreementsResponseKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AgreementsCreateAgreementsResponseKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsCreateAgreementsResponseKind value) =>
        value.Value;

    public static explicit operator AgreementsCreateAgreementsResponseKind(string value) =>
        new(value);

    internal class AgreementsCreateAgreementsResponseKindSerializer
        : JsonConverter<AgreementsCreateAgreementsResponseKind>
    {
        public override AgreementsCreateAgreementsResponseKind Read(
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
            return new AgreementsCreateAgreementsResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsCreateAgreementsResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsCreateAgreementsResponseKind ReadAsPropertyName(
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
            return new AgreementsCreateAgreementsResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsCreateAgreementsResponseKind value,
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
