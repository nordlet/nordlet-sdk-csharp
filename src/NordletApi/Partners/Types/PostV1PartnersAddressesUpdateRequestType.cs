using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersAddressesUpdateRequestType.PostV1PartnersAddressesUpdateRequestTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersAddressesUpdateRequestType : IStringEnum
{
    public static readonly PostV1PartnersAddressesUpdateRequestType Billing = new(Values.Billing);

    public static readonly PostV1PartnersAddressesUpdateRequestType Shipping = new(Values.Shipping);

    public static readonly PostV1PartnersAddressesUpdateRequestType Registered = new(
        Values.Registered
    );

    public static readonly PostV1PartnersAddressesUpdateRequestType Other = new(Values.Other);

    public PostV1PartnersAddressesUpdateRequestType(string value)
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
    public static PostV1PartnersAddressesUpdateRequestType FromCustom(string value)
    {
        return new PostV1PartnersAddressesUpdateRequestType(value);
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
        PostV1PartnersAddressesUpdateRequestType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersAddressesUpdateRequestType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersAddressesUpdateRequestType value) =>
        value.Value;

    public static explicit operator PostV1PartnersAddressesUpdateRequestType(string value) =>
        new(value);

    internal class PostV1PartnersAddressesUpdateRequestTypeSerializer
        : JsonConverter<PostV1PartnersAddressesUpdateRequestType>
    {
        public override PostV1PartnersAddressesUpdateRequestType Read(
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
            return new PostV1PartnersAddressesUpdateRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersAddressesUpdateRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersAddressesUpdateRequestType ReadAsPropertyName(
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
            return new PostV1PartnersAddressesUpdateRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersAddressesUpdateRequestType value,
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
