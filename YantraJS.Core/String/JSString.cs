using System;

namespace YantraJS.Core;

public struct JSString : IJSValue
{
    private JSContext context;
    public readonly string Value;

    public JSString(JSContext jSContext, string v)
    {
        this.context = jSContext;
        this.Value = v;
    }

    public IJSValue InvokeFunction(IJSValue receiver, in Arguments args)
    {
        throw new NotImplementedException($"\"{Value}\" is not a function");
    }

    IJSValue IJSValue.ToString()
    {
        return this;
    }

    public JSObject GetPrototype()
    {
        throw new NotImplementedException();
    }
}