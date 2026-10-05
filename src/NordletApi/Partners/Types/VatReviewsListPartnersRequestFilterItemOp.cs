using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VatReviewsListPartnersRequestFilterItemOp.VatReviewsListPartnersRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct VatReviewsListPartnersRequestFilterItemOp : IStringEnum
{
    public static readonly VatReviewsListPartnersRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly VatReviewsListPartnersRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly VatReviewsListPartnersRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly VatReviewsListPartnersRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly VatReviewsListPartnersRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly VatReviewsListPartnersRequestFilterItemOp In = new(Values.In);

    public VatReviewsListPartnersRequestFilterItemOp(string value)
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
    public static VatReviewsListPartnersRequestFilterItemOp FromCustom(string value)
    {
        return new VatReviewsListPartnersRequestFilterItemOp(value);
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
        VatReviewsListPartnersRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VatReviewsListPartnersRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VatReviewsListPartnersRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator VatReviewsListPartnersRequestFilterItemOp(string value) =>
        new(value);

    internal class VatReviewsListPartnersRequestFilterItemOpSerializer
        : JsonConverter<VatReviewsListPartnersRequestFilterItemOp>
    {
        public override VatReviewsListPartnersRequestFilterItemOp Read(
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
            return new VatReviewsListPartnersRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatReviewsListPartnersRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatReviewsListPartnersRequestFilterItemOp ReadAsPropertyName(
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
            return new VatReviewsListPartnersRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatReviewsListPartnersRequestFilterItemOp value,
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
