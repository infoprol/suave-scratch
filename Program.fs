open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful


let app =
    choose
        [ GET >=> choose
            [ path "/snip" >=> OK "GET snip\r\n"
              path "/snap" >=> OK "GET snap\r\n"  ]
          POST >=> choose
            [ path "/snip" >=> OK "POST snip\r\n"
              path "/snap" >=> OK "POST snap\r\n"] ]


startWebServer defaultConfig app