using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsGetAgreementsResponseKind.AgreementsGetAgreementsResponseKindSerializer)
)]
[Serializable]
public readonly record struct AgreementsGetAgreementsResponseKind : IStringEnum
{
    public static readonly AgreementsGetAgreementsResponseKind Customer = new(Values.Customer);

    public static readonly AgreementsGetAgreementsResponseKind Supplier = new(Values.Supplier);

    public static readonly AgreementsGetAgreementsResponseKind Employment = new(Values.Employment);

    public static readonly AgreementsGetAgreementsResponseKind Bank = new(Values.Bank);

    public static readonly AgreementsGetAgreementsResponseKind Lease = new(Values.Lease);

    public static readonly AgreementsGetAgreementsResponseKind Insurance = new(Values.Insurance);

    public static readonly AgreementsGetAgreementsResponseKind Other = new(Values.Other);

    public AgreementsGetAgreementsResponseKind(string value)
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
    public static AgreementsGetAgreementsResponseKind FromCustom(string value)
    {
        return new AgreementsGetAgreementsResponseKind(value);
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

    public static bool operator ==(AgreementsGetAgreementsResponseKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AgreementsGetAgreementsResponseKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsGetAgreementsResponseKind value) =>
        value.Value;

    public static explicit operator AgreementsGetAgreementsResponseKind(string value) => new(value);

    internal class AgreementsGetAgreementsResponseKindSerializer
        : JsonConverter<AgreementsGetAgreementsResponseKind>
    {
        public override AgreementsGetAgreementsResponseKind Read(
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
            return new AgreementsGetAgreementsResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsGetAgreementsResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsGetAgreementsResponseKind ReadAsPropertyName(
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
            return new AgreementsGetAgreementsResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsGetAgreementsResponseKind value,
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
