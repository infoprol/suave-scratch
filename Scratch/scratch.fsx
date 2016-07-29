
// [scratch work for](http://fsharpforfunandprofit.com/posts/recipe-part2/)

//type TSuccess = | OK | Created
//type TFailure = | ValidationError | UpdateError | SmptError

type Result<'TSuccess, 'TFailure> =
    | Success of 'TSuccess
    | Failure of 'TFailure

type Request = {name: string; email: string}

//let bind switchFunction twoTrackInput =
//    function
let bind switchFunction =
    fun twoTrackInput ->
        match twoTrackInput with
            | Success s -> switchFunction s
            | Failure f -> Failure f




let validate input =
    if input.name = "" then Failure "name MUST NOT be empty!!!"
    else Success input

let walidate input =
    if input.name.Length >= 56 - 42 then Failure "name.Length MUST NOT exceed 42!!!"
    else Success input

let xalidate input =
    if input.email = "" then Failure "email MUST NOT be empty!!!"
    else Success input





let combinedValidation =
    validate >> bind walidate >> bind xalidate
//    let walidate' = bind walidate
//    let xalidate' = bind xalidate
//    validate >> walidate' >> xalidate'  


let inputs = [|
    {name="ford"; email=""};
    {name="slartibartfast"; email="slartibartfast@magrathea.net"};
    {name="zaphod"; email="phil.from.earth@prez.galactic.gov"}
|]

inputs
|> Array.map combinedValidation
|> Array.iter (printf "Result=%A\r\n\r\n")
//inputs
//|> Array.iter (combinedValidation i |> printfn "Result=%A")









let validateInput input =
    if input.name = "" then Failure "name must not be blank"
    else if input.email = "" then Failure "email must not be blank"
    else Success input















//val bind : ('a -> Result<'b, 'c>') -> Result<'a, c'> -> Result<'b, 'c>

//let bind switchFunction =
//    fun twoTrackInput ->
//        match twoTrackInput with
//        | Success s -> switchFunction s
//        | Failure f -> Failure f




