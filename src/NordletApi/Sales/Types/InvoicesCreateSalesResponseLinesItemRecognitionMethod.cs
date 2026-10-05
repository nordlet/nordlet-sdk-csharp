using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesCreateSalesResponseLinesItemRecognitionMethod.InvoicesCreateSalesResponseLinesItemRecognitionMethodSerializer)
)]
[Serializable]
public readonly record struct InvoicesCreateSalesResponseLinesItemRecognitionMethod : IStringEnum
{
    public static readonly InvoicesCreateSalesResponseLinesItemRecognitionMethod PointInTime = new(
        Values.PointInTime
    );

    public static readonly InvoicesCreateSalesResponseLinesItemRecognitionMethod Ratable = new(
        Values.Ratable
    );

    public static readonly InvoicesCreateSalesResponseLinesItemRecognitionMethod Milestone = new(
        Values.Milestone
    );

    public static readonly InvoicesCreateSalesResponseLinesItemRecognitionMethod PercentComplete =
        new(Values.PercentComplete);

    public InvoicesCreateSalesResponseLinesItemRecognitionMethod(string value)
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
    public static InvoicesCreateSalesResponseLinesItemRecognitionMethod FromCustom(string value)
    {
        return new InvoicesCreateSalesResponseLinesItemRecognitionMethod(value);
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
        InvoicesCreateSalesResponseLinesItemRecognitionMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesCreateSalesResponseLinesItemRecognitionMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        InvoicesCreateSalesResponseLinesItemRecognitionMethod value
    ) => value.Value;

    public static explicit operator InvoicesCreateSalesResponseLinesItemRecognitionMethod(
        string value
    ) => new(value);

    internal class InvoicesCreateSalesResponseLinesItemRecognitionMethodSerializer
        : JsonConverter<InvoicesCreateSalesResponseLinesItemRecognitionMethod>
    {
        public override InvoicesCreateSalesResponseLinesItemRecognitionMethod Read(
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
            return new InvoicesCreateSalesResponseLinesItemRecognitionMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesCreateSalesResponseLinesItemRecognitionMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesCreateSalesResponseLinesItemRecognitionMethod ReadAsPropertyName(
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
            return new InvoicesCreateSalesResponseLinesItemRecognitionMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesCreateSalesResponseLinesItemRecognitionMethod value,
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
        public const string PointInTime = "point_in_time";

        public const string Ratable = "ratable";

        public const string Milestone = "milestone";

        public const string PercentComplete = "percent_complete";
    }
}
