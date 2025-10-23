using System;
using YantraJS.Core.Primitives;

namespace YantraJS.Core;

public class JSContext: JSObject
{


    public readonly JSBaseFunction Number;
    public readonly JSUndefined Undefined;


    public JSContext(): base(null)
    {
        this.Context = this;

        this.Undefined = new JSUndefined();

        // initialize prototypes

        this.Number = new JSNumberFunction(this);
    }

    internal IJSValue NewString(string v)
    {
        return new JSString(this, v);
    }

    internal Exception NewTypeError(string v)
    {
        throw new Exception(v);
    }
}
