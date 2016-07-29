


//type TSuccess = | OK | Created
//type TFailure = | ValidationError | UpdateError | SmptError

type Result<'TSuccess, 'TFailure> =
    | Success of 'TSuccess
    | Failure of 'TFailure