using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(CreatePlatformSellersRequestKind.CreatePlatformSellersRequestKindSerializer))]
[Serializable]
public readonly record struct CreatePlatformSellersRequestKind : IStringEnum
{
    public static readonly CreatePlatformSellersRequestKind Individual = new(Values.Individual);

    public static readonly CreatePlatformSellersRequestKind Entity = new(Values.Entity);

    public CreatePlatformSellersRequestKind(string value)
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
    public static CreatePlatformSellersRequestKind FromCustom(string value)
    {
        return new CreatePlatformSellersRequestKind(value);
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

    public static bool operator ==(CreatePlatformSellersRequestKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreatePlatformSellersRequestKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreatePlatformSellersRequestKind value) => value.Value;

    public static explicit operator CreatePlatformSellersRequestKind(string value) => new(value);

    internal class CreatePlatformSellersRequestKindSerializer
        : JsonConverter<CreatePlatformSellersRequestKind>
    {
        public override CreatePlatformSellersRequestKind Read(
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
            return new CreatePlatformSellersRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreatePlatformSellersRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreatePlatformSellersRequestKind ReadAsPropertyName(
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
            return new CreatePlatformSellersRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreatePlatformSellersRequestKind value,
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
        public const string Individual = "individual";

        public const string Entity = "entity";
    }
}
