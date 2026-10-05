using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ProductsListEcommerceResponseRowsItemType.ProductsListEcommerceResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct ProductsListEcommerceResponseRowsItemType : IStringEnum
{
    public static readonly ProductsListEcommerceResponseRowsItemType Product = new(Values.Product);

    public static readonly ProductsListEcommerceResponseRowsItemType Service = new(Values.Service);

    public static readonly ProductsListEcommerceResponseRowsItemType Set = new(Values.Set);

    public ProductsListEcommerceResponseRowsItemType(string value)
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
    public static ProductsListEcommerceResponseRowsItemType FromCustom(string value)
    {
        return new ProductsListEcommerceResponseRowsItemType(value);
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
        ProductsListEcommerceResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ProductsListEcommerceResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ProductsListEcommerceResponseRowsItemType value) =>
        value.Value;

    public static explicit operator ProductsListEcommerceResponseRowsItemType(string value) =>
        new(value);

    internal class ProductsListEcommerceResponseRowsItemTypeSerializer
        : JsonConverter<ProductsListEcommerceResponseRowsItemType>
    {
        public override ProductsListEcommerceResponseRowsItemType Read(
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
            return new ProductsListEcommerceResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ProductsListEcommerceResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ProductsListEcommerceResponseRowsItemType ReadAsPropertyName(
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
            return new ProductsListEcommerceResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ProductsListEcommerceResponseRowsItemType value,
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
        public const string Product = "product";

        public const string Service = "service";

        public const string Set = "set";
    }
}
