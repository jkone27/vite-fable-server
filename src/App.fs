namespace App

open Fable.Core
open Glutinum.Express
open Glutinum.ExpressServeStaticCore

module Server = 

    let port = 3000
    let app = express.express()

    app.get ("/", fun (req: Request) (res: Response) ->
        printfn $"New request, %s{req.hostname}"
        res.send "Hello World!"
    )

    [<Emit("import.meta.env.PROD")>]
    let isProd: bool = jsNative

    // in development mode, the server is started by vite
    if isProd then
        app.listen(port, fun () -> 
            printfn $"Production server started on port {port}"
        ) |> ignore

    let viteNodeApp = app
