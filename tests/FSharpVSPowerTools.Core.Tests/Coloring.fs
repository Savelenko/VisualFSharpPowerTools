﻿module Module1

let moduleValue = 1
let moduleFunction x = x + 1
let higherOrderFunction func x = (func x) - 1
let usingModuleValue = moduleValue + 1

type Class() =
    let event = Event<_>()
    static let staticEvent = Event<_>()
    let classLetValue = 1
    let classLetFunction x = x
    member x.Method y = y
    member x.Property = 1
    static member StaticMethod x = x
    static member StaticProperty = 1
    member x.Event = event.Publish
    static member StaticEvent = staticEvent.Publish
    new (x: int) = new Class()
    interface System.IDisposable with
        member x.Dispose() = ()
    member x.PropWithGetterAndSetter 
                with get() = 1 
                and set(value: int) = ()

let dateTime = new System.Net.WebClient()

module M1 =
    module M2 =
        type Type() = class end

let m1m2Type = M1.M2.Type()

type GenericClass<'T>() = class end
let genericClassOfInt = GenericClass<int>()
let genericClassOfUserFSharpType = GenericClass<M1.M2.Type>()
let genericClassOfCLIType = GenericClass<System.DateTime>()

type Record = { IntField: int; UserTypeField: M1.M2.Type }

let valueTypeAbbriviation: int = 1
let valueType: System.Int32 = 2
let valueTypeConstructor = System.DateTime()
type UserValueType = struct end
type UserValueTypeAbbriviation = UserValueType
let userValueType = UserValueType()
let userValueTypeAbbriviation: UserValueTypeAbbriviation = UserValueTypeAbbriviation()

type DUWithFunction = FuncCase of (unit -> unit)
let (FuncCase funcCase) = FuncCase (fun() -> ())
match FuncCase (fun() -> ()) with FuncCase func -> func()
let ``double_quoted_function_without_spaces`` () = ()
let ``double quoted function with spaces`` () = ()
[<System.Diagnostics.DebuggerDisplay "name">]
type TypeWithAttribute() = class end
let asyncRunSync = Async.RunSynchronously
seq {
    let func x = x
    yield func 1
} |> ignore

type CustomBuilder() =
    member x.Yield (()) = ()
    [<CustomOperation ("add", MaintainsVariableSpace = true)>]
    member x.Add (_, pattern: string) = pattern
let customComputationExpression = CustomBuilder()

let _ = customComputationExpression { add "str" }
let _ = System.Environment.MachineName.ToLower()
let _ = System.Guid.NewGuid().ToString("N").Substring(1)
let _ = list<_>.Empty
let _ = Microsoft.FSharp.Collections.List<int>.Empty
type System.String with
    member x.``Long func``() = "x"
let _ = "x".``Long func``().Substring(3)
let arr = [|1|]
let _ = arr.[0]
let mutable mutableValue = 1
type MutableRecord = 
    { mutable MutableField: int }
type MutableClass() = 
    let mutable mutableField = 0
let func() =
    let mutable mutableLocalVar = 1
    ()