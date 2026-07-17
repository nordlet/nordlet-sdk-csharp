using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersAddressesListRequestFilterItemOp.PostV1PartnersAddressesListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersAddressesListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1PartnersAddressesListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1PartnersAddressesListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1PartnersAddressesListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1PartnersAddressesListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1PartnersAddressesListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1PartnersAddressesListRequestFilterItemOp In = new(Values.In);

    public PostV1PartnersAddressesListRequestFilterItemOp(string value)
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
    public static PostV1PartnersAddressesListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1PartnersAddressesListRequestFilterItemOp(value);
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
        PostV1PartnersAddressesListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersAddressesListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersAddressesListRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator PostV1PartnersAddressesListRequestFilterItemOp(string value) =>
        new(value);

    internal class PostV1PartnersAddressesListRequestFilterItemOpSerializer
        : JsonConverter<PostV1PartnersAddressesListRequestFilterItemOp>
    {
        public override PostV1PartnersAddressesListRequestFilterItemOp Read(
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
            return new PostV1PartnersAddressesListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersAddressesListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersAddressesListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1PartnersAddressesListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersAddressesListRequestFilterItemOp value,
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
