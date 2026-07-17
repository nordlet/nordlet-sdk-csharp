using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersAddressesCreateRequestType.PostV1PartnersAddressesCreateRequestTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersAddressesCreateRequestType : IStringEnum
{
    public static readonly PostV1PartnersAddressesCreateRequestType Billing = new(Values.Billing);

    public static readonly PostV1PartnersAddressesCreateRequestType Shipping = new(Values.Shipping);

    public static readonly PostV1PartnersAddressesCreateRequestType Registered = new(
        Values.Registered
    );

    public static readonly PostV1PartnersAddressesCreateRequestType Other = new(Values.Other);

    public PostV1PartnersAddressesCreateRequestType(string value)
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
    public static PostV1PartnersAddressesCreateRequestType FromCustom(string value)
    {
        return new PostV1PartnersAddressesCreateRequestType(value);
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
        PostV1PartnersAddressesCreateRequestType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersAddressesCreateRequestType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersAddressesCreateRequestType value) =>
        value.Value;

    public static explicit operator PostV1PartnersAddressesCreateRequestType(string value) =>
        new(value);

    internal class PostV1PartnersAddressesCreateRequestTypeSerializer
        : JsonConverter<PostV1PartnersAddressesCreateRequestType>
    {
        public override PostV1PartnersAddressesCreateRequestType Read(
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
            return new PostV1PartnersAddressesCreateRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersAddressesCreateRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersAddressesCreateRequestType ReadAsPropertyName(
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
            return new PostV1PartnersAddressesCreateRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersAddressesCreateRequestType value,
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
