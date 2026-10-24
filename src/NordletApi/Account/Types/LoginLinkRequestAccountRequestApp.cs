using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LoginLinkRequestAccountRequestApp.LoginLinkRequestAccountRequestAppSerializer)
)]
[Serializable]
public readonly record struct LoginLinkRequestAccountRequestApp : IStringEnum
{
    public static readonly LoginLinkRequestAccountRequestApp Invoice = new(Values.Invoice);

    public LoginLinkRequestAccountRequestApp(string value)
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
    public static LoginLinkRequestAccountRequestApp FromCustom(string value)
    {
        return new LoginLinkRequestAccountRequestApp(value);
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

    public static bool operator ==(LoginLinkRequestAccountRequestApp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LoginLinkRequestAccountRequestApp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LoginLinkRequestAccountRequestApp value) => value.Value;

    public static explicit operator LoginLinkRequestAccountRequestApp(string value) => new(value);

    internal class LoginLinkRequestAccountRequestAppSerializer
        : JsonConverter<LoginLinkRequestAccountRequestApp>
    {
        public override LoginLinkRequestAccountRequestApp Read(
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
            return new LoginLinkRequestAccountRequestApp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LoginLinkRequestAccountRequestApp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LoginLinkRequestAccountRequestApp ReadAsPropertyName(
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
            return new LoginLinkRequestAccountRequestApp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LoginLinkRequestAccountRequestApp value,
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
        public const string Invoice = "invoice";
    }
}
