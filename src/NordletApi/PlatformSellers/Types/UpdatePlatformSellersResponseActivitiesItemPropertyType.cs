using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UpdatePlatformSellersResponseActivitiesItemPropertyType.UpdatePlatformSellersResponseActivitiesItemPropertyTypeSerializer)
)]
[Serializable]
public readonly record struct UpdatePlatformSellersResponseActivitiesItemPropertyType : IStringEnum
{
    public static readonly UpdatePlatformSellersResponseActivitiesItemPropertyType Dpi901 = new(
        Values.Dpi901
    );

    public static readonly UpdatePlatformSellersResponseActivitiesItemPropertyType Dpi902 = new(
        Values.Dpi902
    );

    public static readonly UpdatePlatformSellersResponseActivitiesItemPropertyType Dpi903 = new(
        Values.Dpi903
    );

    public static readonly UpdatePlatformSellersResponseActivitiesItemPropertyType Dpi904 = new(
        Values.Dpi904
    );

    public static readonly UpdatePlatformSellersResponseActivitiesItemPropertyType Dpi905 = new(
        Values.Dpi905
    );

    public static readonly UpdatePlatformSellersResponseActivitiesItemPropertyType Dpi906 = new(
        Values.Dpi906
    );

    public static readonly UpdatePlatformSellersResponseActivitiesItemPropertyType Dpi907 = new(
        Values.Dpi907
    );

    public static readonly UpdatePlatformSellersResponseActivitiesItemPropertyType Dpi908 = new(
        Values.Dpi908
    );

    public static readonly UpdatePlatformSellersResponseActivitiesItemPropertyType Dpi909 = new(
        Values.Dpi909
    );

    public static readonly UpdatePlatformSellersResponseActivitiesItemPropertyType Dpi910 = new(
        Values.Dpi910
    );

    public UpdatePlatformSellersResponseActivitiesItemPropertyType(string value)
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
    public static UpdatePlatformSellersResponseActivitiesItemPropertyType FromCustom(string value)
    {
        return new UpdatePlatformSellersResponseActivitiesItemPropertyType(value);
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
        UpdatePlatformSellersResponseActivitiesItemPropertyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdatePlatformSellersResponseActivitiesItemPropertyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdatePlatformSellersResponseActivitiesItemPropertyType value
    ) => value.Value;

    public static explicit operator UpdatePlatformSellersResponseActivitiesItemPropertyType(
        string value
    ) => new(value);

    internal class UpdatePlatformSellersResponseActivitiesItemPropertyTypeSerializer
        : JsonConverter<UpdatePlatformSellersResponseActivitiesItemPropertyType>
    {
        public override UpdatePlatformSellersResponseActivitiesItemPropertyType Read(
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
            return new UpdatePlatformSellersResponseActivitiesItemPropertyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdatePlatformSellersResponseActivitiesItemPropertyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdatePlatformSellersResponseActivitiesItemPropertyType ReadAsPropertyName(
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
            return new UpdatePlatformSellersResponseActivitiesItemPropertyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdatePlatformSellersResponseActivitiesItemPropertyType value,
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
        public const string Dpi901 = "DPI901";

        public const string Dpi902 = "DPI902";

        public const string Dpi903 = "DPI903";

        public const string Dpi904 = "DPI904";

        public const string Dpi905 = "DPI905";

        public const string Dpi906 = "DPI906";

        public const string Dpi907 = "DPI907";

        public const string Dpi908 = "DPI908";

        public const string Dpi909 = "DPI909";

        public const string Dpi910 = "DPI910";
    }
}
