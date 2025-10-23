using System;
using System.Collections.Generic;
using System.Text;

namespace YantraJS.Core;

public abstract class JSFunction : JSBaseFunction
{
    public JSFunction(JSContext context) : base(context)
    {
    }

    public JSFunction(JSContext context, in StringSpan code) : base(context, code)
    {
    }



    class Apply : JSBaseFunction
    {
        public Apply(JSContext context) : base(context)
        {
        }

        public override IJSValue InvokeFunction(IJSValue receiver, in Arguments args)
        {
            throw new NotImplementedException();
        }
    }

}
