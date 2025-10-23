using System;
using System.Collections.Generic;
using System.Text;

namespace YantraJS.Core;


/// <summary>
/// JSFunction does not inherit from JSObject for performance reasons.
/// </summary>
public abstract class JSBaseFunction : IJSValue
{
    public readonly JSContext context;
    public readonly StringSpan OrignalCode;
    private string code;

    private static StringSpan native = "native";

    public JSBaseFunction(JSContext context)
    {
        this.context = context;
        this.OrignalCode = native;
    }


    public JSBaseFunction(JSContext context, in StringSpan code)
    {
        this.context = context;
        this.OrignalCode = code;
    }

    public JSObject GetPrototype()
    {
        throw new NotImplementedException();
    }

    public abstract IJSValue InvokeFunction(IJSValue receiver, in Arguments args);

    IJSValue IJSValue.ToString()
    {
        this.code ??= OrignalCode.Value;
        return this.context.NewString(code);
    }

}
