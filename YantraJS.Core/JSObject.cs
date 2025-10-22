using System;
using System.Collections.Generic;
using System.Text;

namespace YantraJS.Core;

public class JSObject : IJSValue
{
    public JSContext Context { get; protected set; }

    public JSObject(JSContext context)
    {
        this.Context = context;
    }

    public IJSValue InvokeFunction(IJSValue receiver, in Arguments args)
    {
        throw new NotImplementedException();
    }

    IJSValue IJSValue.ToString()
    {
        throw new NotImplementedException();
    }

    public JSObject GetPrototype()
    {
        throw new NotImplementedException();
    }
}
