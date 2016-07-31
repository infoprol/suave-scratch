


let fetchHtmlAsync url = async {
    let uri = System.Uri(url)
    let webClient = new System.Net.WebClient()

    let! html = webClient.AsyncDownloadString(uri)
    return html
}


let url = "https://dev.serv-a.io/swagger.json" //"http://www.bing.com"
let html = url |> fetchHtmlAsync |> Async.RunSynchronously
printf "%s" html
