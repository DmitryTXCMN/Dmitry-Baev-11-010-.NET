module Program

open System
open MaybeBuilder

    [<EntryPoint>]
    let main argv =
        let result = maybeBuilder {
            let! parsed = Parser.Parse argv
            let! result = Calculator.Calculate parsed
            return result
        }
        
        match result with
        | Some value ->
            printf $"{value}"
            0
        | None ->
            printf "None"
            1