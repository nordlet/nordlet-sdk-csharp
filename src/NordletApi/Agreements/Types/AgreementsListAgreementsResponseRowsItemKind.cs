using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsListAgreementsResponseRowsItemKind.AgreementsListAgreementsResponseRowsItemKindSerializer)
)]
[Serializable]
public readonly record struct AgreementsListAgreementsResponseRowsItemKind : IStringEnum
{
    public static readonly AgreementsListAgreementsResponseRowsItemKind Customer = new(
        Values.Customer
    );

    public static readonly AgreementsListAgreementsResponseRowsItemKind Supplier = new(
        Values.Supplier
    );

    public static readonly AgreementsListAgreementsResponseRowsItemKind Employment = new(
        Values.Employment
    );

    public static readonly AgreementsListAgreementsResponseRowsItemKind Bank = new(Values.Bank);

    public static readonly AgreementsListAgreementsResponseRowsItemKind Lease = new(Values.Lease);

    public static readonly AgreementsListAgreementsResponseRowsItemKind Insurance = new(
        Values.Insurance
    );

    public static readonly AgreementsListAgreementsResponseRowsItemKind Other = new(Values.Other);

    public AgreementsListAgreementsResponseRowsItemKind(string value)
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
    public static AgreementsListAgreementsResponseRowsItemKind FromCustom(string value)
    {
        return new AgreementsListAgreementsResponseRowsItemKind(value);
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
        AgreementsListAgreementsResponseRowsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AgreementsListAgreementsResponseRowsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsListAgreementsResponseRowsItemKind value) =>
        value.Value;

    public static explicit operator AgreementsListAgreementsResponseRowsItemKind(string value) =>
        new(value);

    internal class AgreementsListAgreementsResponseRowsItemKindSerializer
        : JsonConverter<AgreementsListAgreementsResponseRowsItemKind>
    {
        public override AgreementsListAgreementsResponseRowsItemKind Read(
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
            return new AgreementsListAgreementsResponseRowsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsListAgreementsResponseRowsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsListAgreementsResponseRowsItemKind ReadAsPropertyName(
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
            return new AgreementsListAgreementsResponseRowsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsListAgreementsResponseRowsItemKind value,
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
