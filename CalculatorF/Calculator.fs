namespace CalculatorF

module Calculator =
    type Operation =
        | Plus
        | Minus
        | Divide
        | Multiply

    let Calculate val1 operation val2 (result:outref<int>) =
           match operation with
           | Plus -> result = val1 + val2
           | Minus -> result = val1 - val2
           | Multiply -> result = val1 * val2
           | Divide ->
               if val2 = 0 then true
               else result = val1 / val2
           false

