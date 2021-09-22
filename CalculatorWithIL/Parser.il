.class public auto ansi abstract sealed beforefieldinit CalculatorWithIL.Parser
    extends [System.Private.CoreLib]System.Object
{
    .method public hidebysig static 
        bool TryParseOperatorOrQuit (
            string arg,
            [out] valuetype CalculatorWithIL.Calculator/Operation& operation
        ) cil managed 
    {
        .maxstack 2
        .locals init (
            [0] string,
            [1] string,
            [2] bool
        )

        IL_0000: ldarg.0
        IL_0001: stloc.1
        IL_0002: ldloc.1
        IL_0003: stloc.0
        IL_0004: ldloc.0
        IL_0005: ldstr "+"
        IL_0006: call bool [System.Private.CoreLib]System.String::op_Equality(string, string)
        IL_0007: brtrue.s IL_0021

        IL_0008: ldloc.0
        IL_0009: ldstr "-"
        IL_0010: call bool [System.Private.CoreLib]System.String::op_Equality(string, string)
        IL_0011: brtrue.s IL_0025

        IL_0012: ldloc.0
        IL_0013: ldstr "*"
        IL_0014: call bool [System.Private.CoreLib]System.String::op_Equality(string, string)
        IL_0015: brtrue.s IL_0029

        IL_0016: ldloc.0
        IL_0017: ldstr "/"
        IL_0018: call bool [System.Private.CoreLib]System.String::op_Equality(string, string)
        IL_0019: brtrue.s IL_0033

        IL_0020: br.s IL_0037

        IL_0021: ldarg.1
        IL_0022: ldc.i4.0
        IL_0023: stind.i4
        IL_0024: br.s IL_0043

        IL_0025: ldarg.1
        IL_0026: ldc.i4.1
        IL_0027: stind.i4
        IL_0028: br.s IL_0043

        IL_0029: ldarg.1
        IL_0030: ldc.i4.3
        IL_0031: stind.i4
        IL_0032: br.s IL_0043

        IL_0033: ldarg.1
        IL_0034: ldc.i4.2
        IL_0035: stind.i4
        IL_0036: br.s IL_0043

        IL_0037: ldarg.1
        IL_0038: ldc.i4.0
        IL_0039: stind.i4
        IL_0040: ldc.i4.1
        IL_0041: stloc.2
        IL_0042: br.s IL_0046

        IL_0043: ldc.i4.0
        IL_0044: stloc.2
        IL_0045: br.s IL_0046

        IL_0046: ldloc.2
        IL_0047: ret
    } 
    
    .method public hidebysig static 
        bool TryParseArgsOrQuit (
            string arg,
            [out] int32& result
        ) cil managed 
    {
        .maxstack 2
        .locals init (
            [0] bool,
            [1] bool
        )

        IL_0000: ldarg.0
        IL_0001: ldarg.1
        IL_0002: call bool [System.Private.CoreLib]System.Int32::TryParse(string, int32&)
        IL_0003: ldc.i4.0
        IL_0004: ceq
        IL_0005: stloc.0
        IL_0006: ldloc.0
        IL_0007: brfalse.s IL_0015

        IL_0008: ldstr "Inputed value isn't int: "
        IL_0009: ldarg.0
        IL_0010: call string [System.Private.CoreLib]System.String::Concat(string, string)
        IL_0011: call void [System.Console]System.Console::WriteLine(string)
        IL_0012: ldc.i4.1
        IL_0013: stloc.1
        IL_0014: br.s IL_0018

        IL_0015: ldc.i4.0
        IL_0016: stloc.1
        IL_0017: br.s IL_0018

        IL_0018: ldloc.1
        IL_0019: ret
    }

    .method public hidebysig static 
        bool CheckArgsLenghtOrQuit (
            string[] args
        ) cil managed 
    {
        .maxstack 2
        .locals init (
            [0] bool,
            [1] bool
        )

        IL_0000: ldarg.0
        IL_0001: ldlen
        IL_0002: conv.i4
        IL_0003: ldc.i4.3
        IL_0004: ceq
        IL_0005: ldc.i4.0
        IL_0006: ceq
        IL_0007: stloc.0
        IL_0008: ldloc.0
        IL_0009: brfalse.s IL_0020

        IL_0010: ldstr "Programm needs 3 args, but there is {0}"
        IL_0011: ldarg.0
        IL_0012: ldlen
        IL_0013: conv.i4
        IL_0014: box [System.Private.CoreLib]System.Int32
        IL_0015: call string [System.Private.CoreLib]System.String::Format(string, object)
        IL_0016: call void [System.Console]System.Console::WriteLine(string)
        IL_0017: ldc.i4.1
        IL_0018: stloc.1
        IL_0019: br.s IL_0023

        IL_0020: ldc.i4.0
        IL_0021: stloc.1
        IL_0022: br.s IL_0023

        IL_0023: ldloc.1
        IL_0024: ret
    }
} 