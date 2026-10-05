using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesListSalesRequestFilterItemOp.InvoicesListSalesRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct InvoicesListSalesRequestFilterItemOp : IStringEnum
{
    public static readonly InvoicesListSalesRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly InvoicesListSalesRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly InvoicesListSalesRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly InvoicesListSalesRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly InvoicesListSalesRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly InvoicesListSalesRequestFilterItemOp In = new(Values.In);

    public InvoicesListSalesRequestFilterItemOp(string value)
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
    public static InvoicesListSalesRequestFilterItemOp FromCustom(string value)
    {
        return new InvoicesListSalesRequestFilterItemOp(value);
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

    public static bool operator ==(InvoicesListSalesRequestFilterItemOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesListSalesRequestFilterItemOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesListSalesRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator InvoicesListSalesRequestFilterItemOp(string value) =>
        new(value);

    internal class InvoicesListSalesRequestFilterItemOpSerializer
        : JsonConverter<InvoicesListSalesRequestFilterItemOp>
    {
        public override InvoicesListSalesRequestFilterItemOp Read(
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
            return new InvoicesListSalesRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesListSalesRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesListSalesRequestFilterItemOp ReadAsPropertyName(
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
            return new InvoicesListSalesRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesListSalesRequestFilterItemOp value,
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
