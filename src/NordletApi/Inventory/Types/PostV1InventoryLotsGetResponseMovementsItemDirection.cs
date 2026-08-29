using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1InventoryLotsGetResponseMovementsItemDirection.PostV1InventoryLotsGetResponseMovementsItemDirectionSerializer)
)]
[Serializable]
public readonly record struct PostV1InventoryLotsGetResponseMovementsItemDirection : IStringEnum
{
    public static readonly PostV1InventoryLotsGetResponseMovementsItemDirection In = new(Values.In);

    public static readonly PostV1InventoryLotsGetResponseMovementsItemDirection Out = new(
        Values.Out
    );

    public PostV1InventoryLotsGetResponseMovementsItemDirection(string value)
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
    public static PostV1InventoryLotsGetResponseMovementsItemDirection FromCustom(string value)
    {
        return new PostV1InventoryLotsGetResponseMovementsItemDirection(value);
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
        PostV1InventoryLotsGetResponseMovementsItemDirection value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1InventoryLotsGetResponseMovementsItemDirection value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1InventoryLotsGetResponseMovementsItemDirection value
    ) => value.Value;

    public static explicit operator PostV1InventoryLotsGetResponseMovementsItemDirection(
        string value
    ) => new(value);

    internal class PostV1InventoryLotsGetResponseMovementsItemDirectionSerializer
        : JsonConverter<PostV1InventoryLotsGetResponseMovementsItemDirection>
    {
        public override PostV1InventoryLotsGetResponseMovementsItemDirection Read(
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
            return new PostV1InventoryLotsGetResponseMovementsItemDirection(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1InventoryLotsGetResponseMovementsItemDirection value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1InventoryLotsGetResponseMovementsItemDirection ReadAsPropertyName(
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
            return new PostV1InventoryLotsGetResponseMovementsItemDirection(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1InventoryLotsGetResponseMovementsItemDirection value,
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
        public const string In = "in";

        public const string Out = "out";
    }
}
