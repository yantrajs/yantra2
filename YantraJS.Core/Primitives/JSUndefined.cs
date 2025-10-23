using System;
using System.Collections.Generic;
using System.Text;

namespace YantraJS.Core.Primitives;

public struct JSUndefined : IJSValue
{
    private readonly JSContext context;

    public bool IsObject => false;

    public JSUndefined(JSContext context)
    {
        this.context = context;
    }

    public JSObject GetPrototype()
    {
        throw new NotImplementedException();
    }

    public IJSValue GetValue(IJSValue receiver, uint key)
    {
        throw new NotImplementedException();
    }

    public IJSValue GetValue(IJSValue receiver, KeyString key)
    {
        throw new NotImplementedException();
    }

    public IJSValue GetValue(IJSValue receiver, JSSymbol key)
    {
        throw new NotImplementedException();
    }

    public IJSValue InvokeFunction(IJSValue receiver, in Arguments args)
    {
        throw context.NewTypeError("undefined is not a function");
    }

    IJSValue IJSValue.ToString()
    {
        throw new NotImplementedException();
    }
}
