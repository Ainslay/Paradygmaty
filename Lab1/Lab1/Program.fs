// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    // Zad 1/2
    //Console.Write("Podaj swoje imię: ");
    //let imie = Console.ReadLine();
    //Console.WriteLine("Twoje imię to {0}", imie)

    //Console.Write("Podaj swoje nazwisko: ");
    //let nazwisko = Console.ReadLine();

    //let pelneImie = imie + " " + nazwisko

    //Console.WriteLine("Twoje pelne dane: {0}", pelneImie)
    
    // Zad 3
    (*
    let objetoscWalca (r:float) (h:float) :float =
        Math.PI * r * r * h
    let r: float = 4.0
    let h = float 5
    printfn "Objetnosc walca o promienu 4 i wysokosci 5 wynosi %.2F" (objetoscWalca r h)
    *)

    // Zad 6
    (*
    let rec obliczNtyWyraz (a1:int) (q:int) (n:int) :int = 
        if n <= 1 then a1
        else obliczNtyWyraz a1 q (n - 1) * q
    let a1 = 2
    let q = 2
    let n = 3
    Console.WriteLine("3 wyraz ciagu wynosi: {0}", (obliczNtyWyraz a1 q n))
    
    *)

    // Zad 7
    (*
    let x = 25
    printfn "Liczba dziesiętna całkowita:%i" x
    printfn "Dodatkowe 5 spacji:% 7i" x         // z jakiegoś powodu trzeba dać dwie więcej żeby faktycznie bylo 5
    printfn "Dodatkowe 6 zer:%08i" x
    printfn "Znak +: %+i" x
    printfn "Ósemkowo: %o" x
    printfn "Szesnastkowo: %X" x
    *)
    // Zad 8
    let z = 56.123
    printfn "Postać wykładnicza: %E" z
    printfn "Cztery miejsca po przecinku: %.4F" z

    Console.ReadKey(); |> ignore 
    0 // return an integer exit code
