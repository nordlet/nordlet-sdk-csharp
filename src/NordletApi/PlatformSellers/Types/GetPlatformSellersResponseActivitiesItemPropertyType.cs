using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GetPlatformSellersResponseActivitiesItemPropertyType.GetPlatformSellersResponseActivitiesItemPropertyTypeSerializer)
)]
[Serializable]
public readonly record struct GetPlatformSellersResponseActivitiesItemPropertyType : IStringEnum
{
    public static readonly GetPlatformSellersResponseActivitiesItemPropertyType Dpi901 = new(
        Values.Dpi901
    );

    public static readonly GetPlatformSellersResponseActivitiesItemPropertyType Dpi902 = new(
        Values.Dpi902
    );

    public static readonly GetPlatformSellersResponseActivitiesItemPropertyType Dpi903 = new(
        Values.Dpi903
    );

    public static readonly GetPlatformSellersResponseActivitiesItemPropertyType Dpi904 = new(
        Values.Dpi904
    );

    public static readonly GetPlatformSellersResponseActivitiesItemPropertyType Dpi905 = new(
        Values.Dpi905
    );

    public static readonly GetPlatformSellersResponseActivitiesItemPropertyType Dpi906 = new(
        Values.Dpi906
    );

    public static readonly GetPlatformSellersResponseActivitiesItemPropertyType Dpi907 = new(
        Values.Dpi907
    );

    public static readonly GetPlatformSellersResponseActivitiesItemPropertyType Dpi908 = new(
        Values.Dpi908
    );

    public static readonly GetPlatformSellersResponseActivitiesItemPropertyType Dpi909 = new(
        Values.Dpi909
    );

    public static readonly GetPlatformSellersResponseActivitiesItemPropertyType Dpi910 = new(
        Values.Dpi910
    );

    public GetPlatformSellersResponseActivitiesItemPropertyType(string value)
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
    public static GetPlatformSellersResponseActivitiesItemPropertyType FromCustom(string value)
    {
        return new GetPlatformSellersResponseActivitiesItemPropertyType(value);
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
        GetPlatformSellersResponseActivitiesItemPropertyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetPlatformSellersResponseActivitiesItemPropertyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GetPlatformSellersResponseActivitiesItemPropertyType value
    ) => value.Value;

    public static explicit operator GetPlatformSellersResponseActivitiesItemPropertyType(
        string value
    ) => new(value);

    internal class GetPlatformSellersResponseActivitiesItemPropertyTypeSerializer
        : JsonConverter<GetPlatformSellersResponseActivitiesItemPropertyType>
    {
        public override GetPlatformSellersResponseActivitiesItemPropertyType Read(
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
            return new GetPlatformSellersResponseActivitiesItemPropertyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetPlatformSellersResponseActivitiesItemPropertyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetPlatformSellersResponseActivitiesItemPropertyType ReadAsPropertyName(
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
            return new GetPlatformSellersResponseActivitiesItemPropertyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetPlatformSellersResponseActivitiesItemPropertyType value,
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
