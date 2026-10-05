using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InsurancePoliciesListAgreementsRequestFilterItemOp.InsurancePoliciesListAgreementsRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct InsurancePoliciesListAgreementsRequestFilterItemOp : IStringEnum
{
    public static readonly InsurancePoliciesListAgreementsRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly InsurancePoliciesListAgreementsRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly InsurancePoliciesListAgreementsRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly InsurancePoliciesListAgreementsRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly InsurancePoliciesListAgreementsRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly InsurancePoliciesListAgreementsRequestFilterItemOp In = new(Values.In);

    public InsurancePoliciesListAgreementsRequestFilterItemOp(string value)
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
    public static InsurancePoliciesListAgreementsRequestFilterItemOp FromCustom(string value)
    {
        return new InsurancePoliciesListAgreementsRequestFilterItemOp(value);
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
        InsurancePoliciesListAgreementsRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InsurancePoliciesListAgreementsRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        InsurancePoliciesListAgreementsRequestFilterItemOp value
    ) => value.Value;

    public static explicit operator InsurancePoliciesListAgreementsRequestFilterItemOp(
        string value
    ) => new(value);

    internal class InsurancePoliciesListAgreementsRequestFilterItemOpSerializer
        : JsonConverter<InsurancePoliciesListAgreementsRequestFilterItemOp>
    {
        public override InsurancePoliciesListAgreementsRequestFilterItemOp Read(
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
            return new InsurancePoliciesListAgreementsRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InsurancePoliciesListAgreementsRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InsurancePoliciesListAgreementsRequestFilterItemOp ReadAsPropertyName(
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
            return new InsurancePoliciesListAgreementsRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InsurancePoliciesListAgreementsRequestFilterItemOp value,
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
