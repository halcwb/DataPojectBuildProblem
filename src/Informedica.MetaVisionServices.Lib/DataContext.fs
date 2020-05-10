module DataContext


open System
//    open System.Linq
//    open System.Data
//    open System.Data.Linq
//    open System.Data.Linq.SqlClient
//    open Microsoft.FSharp.Quotations
open FSharp.Data.TypeProviders
//    open Microsoft.FSharp.Linq
//    open FSharp.Linq.RuntimeHelpers


[<Literal>]
let conString = ""

type schema = SqlDataConnection<ConnectionString = conString,
                                LocalSchemaFile = @"./schema.dbml",
                                Views = false,
                                Functions = false,
                                StoredProcedures = false,
                                ContextTypeName = "Test">

