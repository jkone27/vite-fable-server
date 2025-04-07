open Fable.Core
open Glutinum.Express
open Glutinum.ExpressServeStaticCore

let port = 3000
let app = express.express ()

app.get (
    "/",
    fun (req: Request) (res: Response) ->
        JS.console.log ($"New request, %s{req.hostname}")
        res.send ("Hello world")
)

let viteNodeApp = app.listen (
    port,
    fun () -> JS.console.log $"Started listening on http://127.0.0.1:%i{port}"
)