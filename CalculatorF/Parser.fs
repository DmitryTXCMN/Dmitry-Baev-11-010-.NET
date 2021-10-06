namespace CalculatorF

open System

module Parser =
    let CheckArgsLenghtOrQuit (args:string[]) =
        if args.Length <> 3 then false
        else
        printf "Programm needs 3 args, but there is {args.Length}"
        true

    let TryParseArgsOrQuit (arg:string) (result:byref<int>) =
        if Int32.TryParse(arg, &result) then
            false
        else
            Console.WriteLine($"value is not int. The value was {arg}");
            true    

    let TryParseOperatorOrQuit arg (result:byref<Calculator.Operation>) =
        match arg with
        | "+" -> result = Calculator.Operation.Plus
        | "-" -> result = Calculator.Operation.Minus
        | "*" -> result = Calculator.Operation.Multiply
        | "/" -> result = Calculator.Operation.Divide
        | _ -> true
        false