using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorStrap.Util
{
    public class BootstrapComponentBase : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)] protected IDictionary<string, object> UnknownParameters { get; set; }
    }
}