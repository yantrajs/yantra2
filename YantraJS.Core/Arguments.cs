namespace YantraJS.Core;

public readonly struct Arguments
{

    public static readonly Arguments Empty = new Arguments();

    public readonly IJSValue Arg0;
    public readonly IJSValue Arg1;
    public readonly IJSValue Arg2;
    public readonly IJSValue Arg3;

    public readonly IJSValue[] Args;

    public readonly int Length;

    public Arguments(IJSValue arg0)
    {
        this.Arg0 = arg0;
        this.Length = 1;
    }

    public Arguments(IJSValue arg0, IJSValue arg1)
    {
        this.Arg0 = arg0;
        this.Arg1 = arg1;
        this.Length = 2;
    }

    public Arguments(IJSValue arg0, IJSValue arg1, IJSValue arg2)
    {
        this.Arg0 = arg0;
        this.Arg1 = arg1;
        this.Arg2 = arg2;
        this.Length = 3;
    }

    public Arguments(IJSValue arg0, IJSValue arg1, IJSValue arg2, IJSValue arg3)
    {
        this.Arg0 = arg0;
        this.Arg1 = arg1;
        this.Arg2 = arg2;
        this.Arg3 = arg3;
        this.Length = 4;
    }

    public Arguments(IJSValue[] args)
    {
        if (args.Length < 5)
        {
            this.Arg0 = args[0];
            this.Arg1 = args[1];
            this.Arg2 = args[2];
            this.Arg3 = args[3];
            this.Length = 4;
            return;
        }
        this.Args = args;
        this.Length = args.Length;
    }

    public IJSValue Get0()
    {
        return this.Args?[0] ?? this.Arg0;
    }
}
