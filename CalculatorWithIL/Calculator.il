.class public auto ansi abstract sealed beforefieldinit CalculatorWithIL.Calculator
    extends [System.Private.CoreLib]System.Object
{
    .class nested public auto ansi sealed Operation
        extends [System.Private.CoreLib]System.Enum
    {
        .field public specialname rtspecialname int32 value__
        .field public static literal valuetype CalculatorWithIL.Calculator/Operation Plus = int32(0)
        .field public static literal valuetype CalculatorWithIL.Calculator/Operation Minus = int32(1)
        .field public static literal valuetype CalculatorWithIL.Calculator/Operation Divide = int32(2)
        .field public static literal valuetype CalculatorWithIL.Calculator/Operation Multiply = int32(3)
    } 

    .method public hidebysig static 
        bool Calculate (
            int32 val1,
            valuetype CalculatorWithIL.Calculator/Operation operation,
            int32 val2,
            [out] int32& result
        ) cil managed 
    {
        .maxstack 3
        .locals init (
            [0] valuetype CalculatorWithIL.Calculator/Operation,
            [1] valuetype CalculatorWithIL.Calculator/Operation,
            [2] bool,
            [3] bool
        )

        IL_0000: ldarg.3
        IL_0001: ldc.i4.0
        IL_0002: stind.i4
        IL_0003: ldarg.1
        IL_0004: stloc.1
        IL_0005: ldloc.1
        IL_0006: stloc.0
        IL_0007: ldloc.0
        IL_0008: switch (IL_0010, IL_0016, IL_0028, IL_0022)

        IL_0009: br.s IL_0042

        IL_0010: ldarg.3
        IL_0011: ldarg.0
        IL_0012: ldarg.2
        IL_0013: add
        IL_0014: stind.i4
        IL_0015: br.s IL_0042

        IL_0016: ldarg.3
        IL_0017: ldarg.0
        IL_0018: ldarg.2
        IL_0019: sub
        IL_0020: stind.i4
        IL_0021: br.s IL_0042

        IL_0022: ldarg.3
        IL_0023: ldarg.0
        IL_0024: ldarg.2
        IL_0025: mul
        IL_0026: stind.i4
        IL_0027: br.s IL_0042

        IL_0028: ldarg.2
        IL_0029: ldc.i4.0
        IL_0030: ceq
        IL_0031: stloc.2
        IL_0032: ldloc.2
        IL_0033: brfalse.s IL_0037

        IL_0034: ldc.i4.1
        IL_0035: stloc.3
        IL_0036: br.s IL_0044

        IL_0037: ldarg.3
        IL_0038: ldarg.0
        IL_0039: ldarg.2
        IL_0040: div
        IL_0041: stind.i4

        IL_0042: ldc.i4.0
        IL_0043: stloc.3

        IL_0044: ldloc.3
        IL_0045: ret
    }
}