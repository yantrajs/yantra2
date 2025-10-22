using System;

namespace YantraJS.Core;

public class JSContext: JSObject
{


    public readonly JSFunction Number;


    public JSContext(): base(null)
    {
        this.Context = this;

        // initialize prototypes

        this.Number = new JSNumberFunction(this);
    }

    internal IJSValue NewString(string v)
    {
        return new JSString(this, v);
    }
}
