using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AddressesUpdatePartnersRequestType.AddressesUpdatePartnersRequestTypeSerializer)
)]
[Serializable]
public readonly record struct AddressesUpdatePartnersRequestType : IStringEnum
{
    public static readonly AddressesUpdatePartnersRequestType Billing = new(Values.Billing);

    public static readonly AddressesUpdatePartnersRequestType Shipping = new(Values.Shipping);

    public static readonly AddressesUpdatePartnersRequestType Registered = new(Values.Registered);

    public static readonly AddressesUpdatePartnersRequestType Other = new(Values.Other);

    public AddressesUpdatePartnersRequestType(string value)
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
    public static AddressesUpdatePartnersRequestType FromCustom(string value)
    {
        return new AddressesUpdatePartnersRequestType(value);
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

    public static bool operator ==(AddressesUpdatePartnersRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AddressesUpdatePartnersRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AddressesUpdatePartnersRequestType value) => value.Value;

    public static explicit operator AddressesUpdatePartnersRequestType(string value) => new(value);

    internal class AddressesUpdatePartnersRequestTypeSerializer
        : JsonConverter<AddressesUpdatePartnersRequestType>
    {
        public override AddressesUpdatePartnersRequestType Read(
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
            return new AddressesUpdatePartnersRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AddressesUpdatePartnersRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AddressesUpdatePartnersRequestType ReadAsPropertyName(
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
            return new AddressesUpdatePartnersRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AddressesUpdatePartnersRequestType value,
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
        public const string Billing = "billing";

        public const string Shipping = "shipping";

        public const string Registered = "registered";

        public const string Other = "other";
    }
}
