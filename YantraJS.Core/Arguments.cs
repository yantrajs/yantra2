namespace YantraJS.Core;

public readonly struct Arguments
{
    public readonly IJSValue Arg0;
    public readonly IJSValue Arg1;
    public readonly IJSValue Arg2;
    public readonly IJSValue Arg3;

    public readonly IJSValue[] Args;

    public Arguments(IJSValue arg0)
    {
        this.Arg0 = arg0;
    }

    public Arguments(IJSValue arg0, IJSValue arg1)
    {
        this.Arg0 = arg0;
        this.Arg1 = arg1;
    }

    public Arguments(IJSValue arg0, IJSValue arg1, IJSValue arg2)
    {
        this.Arg0 = arg0;
        this.Arg1 = arg1;
        this.Arg2 = arg2;
    }

    public Arguments(IJSValue arg0, IJSValue arg1, IJSValue arg2, IJSValue arg3)
    {
        this.Arg0 = arg0;
        this.Arg1 = arg1;
        this.Arg2 = arg2;
        this.Arg3 = arg3;
    }

    public Arguments(IJSValue[] args)
    {
        if (args.Length < 5)
        {
            this.Arg0 = args[0];
            this.Arg1 = args[1];
            this.Arg2 = args[2];
            this.Arg3 = args[3];
            return;
        }
        this.Args = args;
    }
}
