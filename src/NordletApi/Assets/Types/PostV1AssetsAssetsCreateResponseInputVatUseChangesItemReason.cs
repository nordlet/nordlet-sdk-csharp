using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason.PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReasonSerializer)
)]
[Serializable]
public readonly record struct PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason
    : IStringEnum
{
    public static readonly PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason UseChange =
        new(Values.UseChange);

    public static readonly PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason Sale = new(
        Values.Sale
    );

    public static readonly PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason Withdrawal =
        new(Values.Withdrawal);

    public PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason(string value)
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
    public static PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason FromCustom(
        string value
    )
    {
        return new PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason(value);
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
        PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason value
    ) => value.Value;

    public static explicit operator PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason(
        string value
    ) => new(value);

    internal class PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReasonSerializer
        : JsonConverter<PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason>
    {
        public override PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason Read(
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
            return new PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason ReadAsPropertyName(
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
            return new PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsCreateResponseInputVatUseChangesItemReason value,
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
