using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RefundLiabilityListSalesRequestFilterItemOp.RefundLiabilityListSalesRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct RefundLiabilityListSalesRequestFilterItemOp : IStringEnum
{
    public static readonly RefundLiabilityListSalesRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly RefundLiabilityListSalesRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly RefundLiabilityListSalesRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly RefundLiabilityListSalesRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly RefundLiabilityListSalesRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly RefundLiabilityListSalesRequestFilterItemOp In = new(Values.In);

    public RefundLiabilityListSalesRequestFilterItemOp(string value)
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
    public static RefundLiabilityListSalesRequestFilterItemOp FromCustom(string value)
    {
        return new RefundLiabilityListSalesRequestFilterItemOp(value);
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
        RefundLiabilityListSalesRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RefundLiabilityListSalesRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RefundLiabilityListSalesRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator RefundLiabilityListSalesRequestFilterItemOp(string value) =>
        new(value);

    internal class RefundLiabilityListSalesRequestFilterItemOpSerializer
        : JsonConverter<RefundLiabilityListSalesRequestFilterItemOp>
    {
        public override RefundLiabilityListSalesRequestFilterItemOp Read(
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
            return new RefundLiabilityListSalesRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RefundLiabilityListSalesRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RefundLiabilityListSalesRequestFilterItemOp ReadAsPropertyName(
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
            return new RefundLiabilityListSalesRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RefundLiabilityListSalesRequestFilterItemOp value,
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
