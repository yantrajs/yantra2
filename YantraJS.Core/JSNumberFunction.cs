namespace YantraJS.Core;

internal class JSNumberFunctionApply : JSFunction
{
    public JSNumberFunctionApply(JSContext context, in StringSpan code) : base(context, code)
    {
    }

    public override IJSValue InvokeFunction(IJSValue receiver, in Arguments args)
    {
        throw new System.NotImplementedException();
    }
}

internal class JSNumberFunction : JSFunction
{
    public JSNumberFunction(JSContext jSContext): base(jSContext, "native")
    {



    }

    public override IJSValue InvokeFunction(IJSValue receiver, in Arguments args)
    {
        throw new System.NotImplementedException();
    }
}