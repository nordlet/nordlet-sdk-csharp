using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1InventoryReorderRulesListRequestFilterItemOp.PostV1InventoryReorderRulesListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1InventoryReorderRulesListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1InventoryReorderRulesListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1InventoryReorderRulesListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1InventoryReorderRulesListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1InventoryReorderRulesListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1InventoryReorderRulesListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1InventoryReorderRulesListRequestFilterItemOp In = new(Values.In);

    public PostV1InventoryReorderRulesListRequestFilterItemOp(string value)
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
    public static PostV1InventoryReorderRulesListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1InventoryReorderRulesListRequestFilterItemOp(value);
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
        PostV1InventoryReorderRulesListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1InventoryReorderRulesListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1InventoryReorderRulesListRequestFilterItemOp value
    ) => value.Value;

    public static explicit operator PostV1InventoryReorderRulesListRequestFilterItemOp(
        string value
    ) => new(value);

    internal class PostV1InventoryReorderRulesListRequestFilterItemOpSerializer
        : JsonConverter<PostV1InventoryReorderRulesListRequestFilterItemOp>
    {
        public override PostV1InventoryReorderRulesListRequestFilterItemOp Read(
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
            return new PostV1InventoryReorderRulesListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1InventoryReorderRulesListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1InventoryReorderRulesListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1InventoryReorderRulesListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1InventoryReorderRulesListRequestFilterItemOp value,
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
