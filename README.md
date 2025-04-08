# Vite Fable Server (F#) ⚡️🍇
```ascii
        __
     __ {_/
     \_}\\ _
        _\(_)_
       (_)_)(_)_
      (_)(_)_)(_)
       (_)(_))_)
        (_(_(_)
         (_)_)
          (_)                    
        +---------------------------------------+
        |      Vite + Fable + Express.js = ❤️   |
        +---------------------------------------+
```  

A quick template for building an Express.js server with Fable (F#) using Vite for development. This setup is inspired by the `vite-feliz-solid` repo and is designed to provide a simple starting point for F# server-side applications.

## Features (and Goals) - WIP 👷🏾‍♀️

- ✅ Write your server logic in F# `.fs` - transparently 
- ❌ HMR with vite and node.js (not working, help >>> fix this)
- ❌ vitest unit tests (not working, help >>> fix this)

## Getting Started 🏃🏽

### Prerequisites

Make sure you have the following installed:

- [Node.js](https://nodejs.org/) (v18 or higher)
- [dotnet SDK](https://dotnet.microsoft.com/download) (v8.0 or higher)
- [Bun](https://bun.sh/) (optional, as an alternative to npm)

### Development 🛸

* `npm i` or [bun](bun.sh) alternative...

* `npm run dev` or [bun](bun.sh) alternative...

### Dependencies 🍃

* [Fable](fable.io): [F#](https://dotnet.microsoft.com/en-us/languages/fsharp) to JavaScript compiler, via [vite-plugin-fable](https://fable.io/vite-plugin-fable/)
* [Express.js](https://expressjs.com/en/starter/hello-world.html): Web framework for Node.js.
* [vite-plugin-node](https://github.com/axe-me/vite-plugin-node): Vite plugin for Node.js integration.
* [dotnet-sdk](https://dotnet.microsoft.com/en-us/): .NET sdk is currently required to work with vite-plugin-fable.


