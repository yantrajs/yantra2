using System;
using System.Collections.Generic;
using System.Text;

namespace YantraJS.Core;

public interface IJSValue
{
    IJSValue InvokeFunction(IJSValue receiver, in Arguments args);

    IJSValue ToString();

    JSObject GetPrototype();

}
