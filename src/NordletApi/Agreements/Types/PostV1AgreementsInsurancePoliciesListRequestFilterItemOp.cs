using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AgreementsInsurancePoliciesListRequestFilterItemOp.PostV1AgreementsInsurancePoliciesListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1AgreementsInsurancePoliciesListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1AgreementsInsurancePoliciesListRequestFilterItemOp Eq = new(
        Values.Eq
    );

    public static readonly PostV1AgreementsInsurancePoliciesListRequestFilterItemOp Ne = new(
        Values.Ne
    );

    public static readonly PostV1AgreementsInsurancePoliciesListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1AgreementsInsurancePoliciesListRequestFilterItemOp Gte = new(
        Values.Gte
    );

    public static readonly PostV1AgreementsInsurancePoliciesListRequestFilterItemOp Lte = new(
        Values.Lte
    );

    public static readonly PostV1AgreementsInsurancePoliciesListRequestFilterItemOp In = new(
        Values.In
    );

    public PostV1AgreementsInsurancePoliciesListRequestFilterItemOp(string value)
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
    public static PostV1AgreementsInsurancePoliciesListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1AgreementsInsurancePoliciesListRequestFilterItemOp(value);
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
        PostV1AgreementsInsurancePoliciesListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AgreementsInsurancePoliciesListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1AgreementsInsurancePoliciesListRequestFilterItemOp value
    ) => value.Value;

    public static explicit operator PostV1AgreementsInsurancePoliciesListRequestFilterItemOp(
        string value
    ) => new(value);

    internal class PostV1AgreementsInsurancePoliciesListRequestFilterItemOpSerializer
        : JsonConverter<PostV1AgreementsInsurancePoliciesListRequestFilterItemOp>
    {
        public override PostV1AgreementsInsurancePoliciesListRequestFilterItemOp Read(
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
            return new PostV1AgreementsInsurancePoliciesListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AgreementsInsurancePoliciesListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AgreementsInsurancePoliciesListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1AgreementsInsurancePoliciesListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AgreementsInsurancePoliciesListRequestFilterItemOp value,
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
