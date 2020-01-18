module MindfulYoga.Client.MindfulYoga.View

open Fulma
open Fable.React
open Fable.React.Props
open Feliz
open Feliz.Bulma
open MindfulYoga.Client
open SharedViews

let view =
    div [ Class "mindfulyoga"] [
        emptySection
        figure [ Class "image mobile-only"] [
            img [ Src "img/mindful_bg.jpg"]
        ]
        textSection [
            h1 [] [ str "MINDFUL YOGA "; sup [] [str "®"]]
            inP "Mindful yoga je praktikování jógy s důrazem na prosté uvědomování si, co se se mnou v přítomném okamžiku děje. Přijímáme pocity, emoce, myšlenky bez hodnocení, posuzování a potřeby je jakkoliv měnit. Přenášíme plnou pozornost do svého těla a k vnímání jeho signálů."
            inP "Mindful yoga (všímavá jóga) je druh formální meditační praxe."
            inP "Zaměření pozornosti na to, co se v daném okamžiku děje a jak na to reagujeme, transformuje jógu do formy meditace."
            inP "Vychází z tradiční hatha jógy a praxe mindfulness." 
            inP "Otevřené lekce probíhají v rodinném centru GaPa Kostelec nad Labem nebo v Domě jógy na Vinohradech."
            
            Html.p [
                prop.className "cta"
                prop.children [
                    Bulma.buttonLink [
                        button.isPrimary
                        button.isMedium
                        prop.href "https://rezervace.mindfulyoga.cz"
                        prop.text "Rezervovat lekci v Gapíku"
                    ]
                    
                    Bulma.buttonLink [
                        button.isPrimary
                        button.isMedium
                        prop.href "https://rezervace.dum-jogy.cz/rs/kalendar_vypis/instruktor/88"
                        prop.text "Rezervovat lekci v Domě jógy"
                    ]
                ]
            ]
            
        ]
        emptySection
        textSection [
            h2 [] [ str "Benefity mindful yogy"]
            [       
                "Zmírňuje celkový stres"
                "Uvolňuje napětí v těle"
                "Učí nás se přijímat a podporovat"
                "Posiluje sebedůvěru"
                "Učí nás být k sobě laskavý, roste laskavost i k ostatním"
                "Otevírá fyzický i duševní prostor nezbytný pro expanzi a rozvoj"
                "Podporuje růst osobní svobody"
                "Je významným nástrojem sebepoznání"
                "A samozřejmě přináší všechny fyzické výhody plynoucí z protahování a posilování"
            ] |> inList |> List.singleton |> div []
        ]
        emptySection
        textSection [
            h2 [] [ str "Čím se taková praxe liší od ostatních?"]
            [       
                "Studenti jsou neustále nabádáni k obracení pozornosti k tomu, co prožívají v přítomném okamžiku."
                "Pozorností v těle zjišťujeme, kde se v těle stres projevuje, samotné uvědomování pomáhá napětí odstranit."
                "Všímáme si pocitů, emocí, myšlenek, smyslových vjemů, aniž bychom na ně reagovali, pouze z pozice pozorovatele."
                "Zařazování jednoduchých meditačních technik během lekce, dechových technik na snížení stresu."
                "Znovu se napojíme na naše tělo a vytvoříme si prostor pro vnímání jeho signálů. Často jsme od svého těla odpojeni a žijeme jen „v hlavě“. Učíme
                                    se naslouchat našemu tělu, kde tělo říká, že se můžeme do pozice ponořit hlouběji a kde naopak máme zastavit. Při udržení této pozornosti
                                    se nedostáváme do bodu, ve kterém ucítíme bolest – každý vědomě přebírá zodpovědnost za čtení signálů vlastního těla."

                "Vnímáme, kde nás omezuje naše mysl. Kde se v ásaně nedostaneme dál
                                        ne kvůli tělu, ale kde nám brání náš „vnitřní kritik“, který našeptává, že to
                                        nedokážeme. Nebo naopak, kde se tlačíme do maximálního rozsahu jen
                                        proto, že kolega vedle na podložce se do pozice dostane a tím si
                                        ubližujeme. Prozkoumáváme svoje hranice."
                "Postupně odhalujeme a uvědomujeme si myšlenkové vzorce, tím máme možnost si uvědomit, které nám už neslouží a přeměnit je."
                "Vnímáme, jaký vliv má náš duševní a emocionální postoj na náš fyzický
                                        postoj. Změnou fyzického postoje v držení těla, dochází i k proměně
                                        postojů a pocitů."
                "Přenášíme klid a všímavost z jógamatky i do běžného života."
            ] |> inList |> List.singleton |> div []
            p [] [
                str "Vše s lehkostí, radostí, zkoumavým zájmem. Pamatujte, pokud se stresujeme
                                během praxe jógy, nemůžeme se v běžném životě zbavit stresu.
                                Jóga by nikdy neměla být brána příliš vážně."
            ]
        ]
    ]