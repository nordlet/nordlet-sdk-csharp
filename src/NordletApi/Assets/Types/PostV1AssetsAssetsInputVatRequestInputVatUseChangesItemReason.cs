using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason.PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReasonSerializer)
)]
[Serializable]
public readonly record struct PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason
    : IStringEnum
{
    public static readonly PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason UseChange =
        new(Values.UseChange);

    public static readonly PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason Sale = new(
        Values.Sale
    );

    public static readonly PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason Withdrawal =
        new(Values.Withdrawal);

    public PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason(string value)
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
    public static PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason FromCustom(
        string value
    )
    {
        return new PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason(value);
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
        PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason value
    ) => value.Value;

    public static explicit operator PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason(
        string value
    ) => new(value);

    internal class PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReasonSerializer
        : JsonConverter<PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason>
    {
        public override PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason Read(
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
            return new PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason ReadAsPropertyName(
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
            return new PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason value,
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
        public const string UseChange = "use_change";

        public const string Sale = "sale";

        public const string Withdrawal = "withdrawal";
    }
}
