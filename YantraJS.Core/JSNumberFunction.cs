namespace YantraJS.Core;

internal class JSNumberFunction : JSBaseFunction
{
    public JSNumberFunction(JSContext jSContext): base(jSContext, "native")
    {



    }

    public override IJSValue InvokeFunction(IJSValue receiver, in Arguments args)
    {
        throw new System.NotImplementedException();
    }
}