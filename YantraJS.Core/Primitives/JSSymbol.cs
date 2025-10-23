using System;
using System.Collections.Generic;
using System.Text;

namespace YantraJS.Core;

public struct JSSymbol : IJSValue
{
    public readonly JSContext context;
    public readonly uint Key;
    public JSSymbol(JSContext context, uint key)
    {
        this.context = context;
        Key = key;
    }

    public JSObject GetPrototype()
    {
        throw new NotImplementedException();
    }

    public IJSValue InvokeFunction(IJSValue receiver, in Arguments args)
    {
        throw new NotImplementedException();
    }

    IJSValue IJSValue.ToString()
    {
        throw new NotImplementedException();
    }
}
