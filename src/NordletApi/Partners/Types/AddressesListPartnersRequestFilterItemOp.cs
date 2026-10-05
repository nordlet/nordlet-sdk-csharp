using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AddressesListPartnersRequestFilterItemOp.AddressesListPartnersRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct AddressesListPartnersRequestFilterItemOp : IStringEnum
{
    public static readonly AddressesListPartnersRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly AddressesListPartnersRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly AddressesListPartnersRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly AddressesListPartnersRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly AddressesListPartnersRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly AddressesListPartnersRequestFilterItemOp In = new(Values.In);

    public AddressesListPartnersRequestFilterItemOp(string value)
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
    public static AddressesListPartnersRequestFilterItemOp FromCustom(string value)
    {
        return new AddressesListPartnersRequestFilterItemOp(value);
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
        AddressesListPartnersRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AddressesListPartnersRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AddressesListPartnersRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator AddressesListPartnersRequestFilterItemOp(string value) =>
        new(value);

    internal class AddressesListPartnersRequestFilterItemOpSerializer
        : JsonConverter<AddressesListPartnersRequestFilterItemOp>
    {
        public override AddressesListPartnersRequestFilterItemOp Read(
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
            return new AddressesListPartnersRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AddressesListPartnersRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AddressesListPartnersRequestFilterItemOp ReadAsPropertyName(
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
            return new AddressesListPartnersRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AddressesListPartnersRequestFilterItemOp value,
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
