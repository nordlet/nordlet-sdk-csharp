namespace NordletApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ForbiddenError(ErrorResponse body, NordletApi.RawResponse? rawResponse = null)
    : NordletApiApiException("ForbiddenError", 403, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new ErrorResponse Body => body;
}
