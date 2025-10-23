using System;
using System.Collections.Generic;
using System.Text;

namespace YantraJS.Core;

public interface IJSValue
{
    IJSValue InvokeFunction(IJSValue receiver, in Arguments args);

    IJSValue ToString();

    JSObject GetPrototype();

    bool IsObject {  get; }

    IJSValue GetValue(IJSValue receiver, uint key);
    IJSValue GetValue(IJSValue receiver, KeyString key);

    IJSValue GetValue(IJSValue receiver, JSSymbol key);

}
