namespace CalculatorF

module Parser =

open System
open CalculatorF
open MaybeBuilder

    let CheckArgsLenght (args:string[]) =
        if args.Length <> 3 then    
            None
        else
            Some args
            
    let TryParseArg (args:string[]) =
        try
            Some(Decimal.Parse(args.[0]), args.[1], Decimal.Parse(args.[2]))
        with
            | _ -> None

    let TryParseOperator (val1:decimal, operation, val2:decimal) = maybeBuilder{
        let! operator = match operation with
        | "+" -> Some Calculator.Operation.Plus
        | "-" -> Some Calculator.Operation.Minus
        | "*" -> Some Calculator.Operation.Multiply
        | "/" -> Some Calculator.Operation.Divide
        | _ -> None
        return (val1, operator, val2)
        }
        
    let Parse argv = maybeBuilder{
        let! checkArgLenght = CheckArgsLenght argv
        let! parsedArgs = TryParseArg checkArgLenght
        let! parsedArgsAndOperator = TryParseOperator parsedArgs
        return parsedArgsAndOperator
        }