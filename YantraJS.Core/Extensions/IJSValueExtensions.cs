using System;
using System.Collections.Generic;
using System.Text;

namespace YantraJS.Core;

public static class IJSValueExtensions
{

    public static IJSValue InvokeMethod(IJSValue callee, KeyString methodName)
    {
        var fx = callee.GetValue(callee, methodName);
        if (fx)
    }

}
