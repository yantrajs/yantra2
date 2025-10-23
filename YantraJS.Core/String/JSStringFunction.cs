using System;
using System.Collections.Generic;
using System.Text;

namespace YantraJS.Core;

internal class JSStringFunction : JSFunction
{

    public override IJSValue InvokeFunction(IJSValue receiver, in Arguments a)
    {
        if (a.Length == 0)
            return context.NewString("");

        var a0 = a.Get0();

        if (a0.IsObject)
        {
            return a0.InvokeMethod(a0, KeyStrings.toString, in Arguments.Empty);
        }

        return a0.ToString();
    }

    public JSStringFunction(JSContext context) : base(context)
    {

        this[KeyStrings.prototype] = 

    }
}

