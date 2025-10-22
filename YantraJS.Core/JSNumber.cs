using System;
using System.Collections.Generic;
using System.Text;

namespace YantraJS.Core;

public struct JSNumber : IJSValue
{
    public readonly double Value;

    public readonly JSContext Context;

    public JSNumber(JSContext context)
    {
        this.Context = context;
    }

    public JSObject GetPrototype()
    {
        
    }

    public IJSValue InvokeFunction(IJSValue receiver, in Arguments args)
    {
        throw new NotImplementedException($"{Value} is not a function");
    }

    IJSValue IJSValue.ToString()
    {
        return Context.NewString(Value.ToString());
    }
}
