using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using YantraJS.Core.Core.Storage;

namespace YantraJS.Core;

public class JSObject : IJSValue
{
    private ElementArray elements;
    private PropertySequence ownProperties;
    private SAUint32Map<JSProperty> symbols;
    private long? uid;

    private static long NextID = 0;
    internal long UniqueID => uid ??= Interlocked.Increment(ref NextID);

    public JSContext Context { get; protected set; }

    public bool IsObject => true;

    public JSObject(JSContext context)
    {
        this.Context = context;
    }

    public IJSValue InvokeFunction(IJSValue receiver, in Arguments args)
    {
        throw new NotImplementedException();
    }

    IJSValue IJSValue.ToString()
    {
        throw new NotImplementedException();
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
        ref var p = ref ownProperties.GetValue(key.Key);
        if (!p.IsEmpty)
        {
            return (receiver ?? this).GetValue(p);
        }
        return Context.Undefined;
    }

    public IJSValue GetValue(IJSValue receiver, JSSymbol key)
    {
        throw new NotImplementedException();
    }

}
