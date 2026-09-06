using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankImportTemplatesListRequestFilterItemOp.PostV1BankImportTemplatesListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1BankImportTemplatesListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1BankImportTemplatesListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1BankImportTemplatesListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1BankImportTemplatesListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1BankImportTemplatesListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1BankImportTemplatesListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1BankImportTemplatesListRequestFilterItemOp In = new(Values.In);

    public PostV1BankImportTemplatesListRequestFilterItemOp(string value)
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
    public static PostV1BankImportTemplatesListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1BankImportTemplatesListRequestFilterItemOp(value);
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
        PostV1BankImportTemplatesListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankImportTemplatesListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankImportTemplatesListRequestFilterItemOp value
    ) => value.Value;

    public static explicit operator PostV1BankImportTemplatesListRequestFilterItemOp(
        string value
    ) => new(value);

    internal class PostV1BankImportTemplatesListRequestFilterItemOpSerializer
        : JsonConverter<PostV1BankImportTemplatesListRequestFilterItemOp>
    {
        public override PostV1BankImportTemplatesListRequestFilterItemOp Read(
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
            return new PostV1BankImportTemplatesListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankImportTemplatesListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankImportTemplatesListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1BankImportTemplatesListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankImportTemplatesListRequestFilterItemOp value,
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
