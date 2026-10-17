using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SecuritiesOperationsListBankRequestFilterItemOp.SecuritiesOperationsListBankRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct SecuritiesOperationsListBankRequestFilterItemOp : IStringEnum
{
    public static readonly SecuritiesOperationsListBankRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly SecuritiesOperationsListBankRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly SecuritiesOperationsListBankRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly SecuritiesOperationsListBankRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly SecuritiesOperationsListBankRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly SecuritiesOperationsListBankRequestFilterItemOp In = new(Values.In);

    public SecuritiesOperationsListBankRequestFilterItemOp(string value)
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
    public static SecuritiesOperationsListBankRequestFilterItemOp FromCustom(string value)
    {
        return new SecuritiesOperationsListBankRequestFilterItemOp(value);
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
        SecuritiesOperationsListBankRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SecuritiesOperationsListBankRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SecuritiesOperationsListBankRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator SecuritiesOperationsListBankRequestFilterItemOp(string value) =>
        new(value);

    internal class SecuritiesOperationsListBankRequestFilterItemOpSerializer
        : JsonConverter<SecuritiesOperationsListBankRequestFilterItemOp>
    {
        public override SecuritiesOperationsListBankRequestFilterItemOp Read(
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
            return new SecuritiesOperationsListBankRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SecuritiesOperationsListBankRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SecuritiesOperationsListBankRequestFilterItemOp ReadAsPropertyName(
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
            return new SecuritiesOperationsListBankRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SecuritiesOperationsListBankRequestFilterItemOp value,
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
        public const string Eq = "eq";

        public const string Ne = "ne";

        public const string Contains = "contains";

        public const string Gte = "gte";

        public const string Lte = "lte";

        public const string In = "in";
    }
}
