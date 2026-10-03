using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason.PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReasonSerializer)
)]
[Serializable]
public readonly record struct PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason
    : IStringEnum
{
    public static readonly PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason UseChange =
        new(Values.UseChange);

    public static readonly PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason Sale =
        new(Values.Sale);

    public static readonly PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason Withdrawal =
        new(Values.Withdrawal);

    public PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason(string value)
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
    public static PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason FromCustom(
        string value
    )
    {
        return new PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason(value);
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
        PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason value
    ) => value.Value;

    public static explicit operator PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason(
        string value
    ) => new(value);

    internal class PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReasonSerializer
        : JsonConverter<PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason>
    {
        public override PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason Read(
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
            return new PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason ReadAsPropertyName(
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
            return new PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsModernizeResponseInputVatUseChangesItemReason value,
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
