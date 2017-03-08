module Parser

open FParsec

let p = between (pchar '[') (pchar ']') (sepBy pfloat (pchar ';'))
let parseAns (input:string) =
    match run p input with
    | Success(x,_,_) -> x
    | Failure(x,_,_) -> []