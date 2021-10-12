module SomeCode
    type MaybeBuilder() =
        member b.Zero() = None
        member b.Bind(x,f)=
            match x with
            | Some x -> f x
            | None -> None
        member b.Return x = Some x
        member b.ReturnForm x = x : _ option

    let maybe = MaybeBuilder()

    let printM m =
        match m with
        | Some x -> printf $"{x}"
        | None -> printf "Nothing"
        

    let add x y =
        match x with
        | Some xx -> match y with
                    | Some yy -> Some (xx + yy)
                    | None -> None
        | None -> None

    [<EntryPoint>]
    let main argv =
        let v1 = Some 1
        let v2 = None 

        let r = maybe {
            let! v11 = v1
            let! v22 = v2
            let r = v11 + v22
            return r
            }

        let r = add v1 v2
        printM r

        0