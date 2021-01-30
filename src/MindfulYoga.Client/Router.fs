module MindfulYoga.Client.Router

open System
open Elmish.Navigation
open Fable.Import
open Fable.Core.JsInterop
open Browser.Types
open Elmish.UrlParser

type Page =
    | AboutMe
    | MindfulYoga
    | Lessons
    | IndividualLessons
    | CompanyLessons
    | Contact
    | Workshops
    | MindfulnessRmt
    with
        member x.Path = 
            match x with
            | AboutMe -> "/o-mne"
            | MindfulYoga -> "/mindful-yoga"
            | Lessons -> "/lekce"
            | IndividualLessons -> "/individualni-lekce"
            | CompanyLessons -> "/joga-pro-firmy"
            | Contact -> "/kontakt"
            | Workshops -> "/workshopy"
            | MindfulnessRmt -> "/mindfulness-rmt"
        static member Default = MindfulYoga


let private removeSlash (s:string) = s.TrimStart([|'/'|])
let inline private s p = p |> removeSlash |> s

let pageParser: Parser<Page -> Page, Page> =
    oneOf [
        map AboutMe (s Page.AboutMe.Path)
        map MindfulYoga (s Page.MindfulYoga.Path)
        map Lessons (s Page.Lessons.Path)
        map IndividualLessons (s Page.IndividualLessons.Path)
        map CompanyLessons (s Page.CompanyLessons.Path)
        map Contact (s Page.Contact.Path)
        map Workshops (s Page.Workshops.Path)
        map MindfulnessRmt (s Page.MindfulnessRmt.Path)
    ]

let goToUrl (e: MouseEvent) =
    e.preventDefault()
    let href = !!e.currentTarget?href
    Navigation.newUrl href |> List.map (fun f -> f ignore) |> ignore