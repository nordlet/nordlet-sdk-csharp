using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsUpdateAgreementsRequestKind.AgreementsUpdateAgreementsRequestKindSerializer)
)]
[Serializable]
public readonly record struct AgreementsUpdateAgreementsRequestKind : IStringEnum
{
    public static readonly AgreementsUpdateAgreementsRequestKind Customer = new(Values.Customer);

    public static readonly AgreementsUpdateAgreementsRequestKind Supplier = new(Values.Supplier);

    public static readonly AgreementsUpdateAgreementsRequestKind Employment = new(
        Values.Employment
    );

    public static readonly AgreementsUpdateAgreementsRequestKind Bank = new(Values.Bank);

    public static readonly AgreementsUpdateAgreementsRequestKind Lease = new(Values.Lease);

    public static readonly AgreementsUpdateAgreementsRequestKind Insurance = new(Values.Insurance);

    public static readonly AgreementsUpdateAgreementsRequestKind Other = new(Values.Other);

    public AgreementsUpdateAgreementsRequestKind(string value)
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
    public static AgreementsUpdateAgreementsRequestKind FromCustom(string value)
    {
        return new AgreementsUpdateAgreementsRequestKind(value);
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

    public static bool operator ==(AgreementsUpdateAgreementsRequestKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AgreementsUpdateAgreementsRequestKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsUpdateAgreementsRequestKind value) =>
        value.Value;

    public static explicit operator AgreementsUpdateAgreementsRequestKind(string value) =>
        new(value);

    internal class AgreementsUpdateAgreementsRequestKindSerializer
        : JsonConverter<AgreementsUpdateAgreementsRequestKind>
    {
        public override AgreementsUpdateAgreementsRequestKind Read(
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
            return new AgreementsUpdateAgreementsRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsUpdateAgreementsRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsUpdateAgreementsRequestKind ReadAsPropertyName(
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
            return new AgreementsUpdateAgreementsRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsUpdateAgreementsRequestKind value,
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
