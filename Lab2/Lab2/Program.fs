open System

[<EntryPoint>]
let main argv =
    
    // Zad 1
    (*let rec silnia n =
        if n <= 1 then 1
        else n * silnia (n - 1)
    Console.WriteLine("Silnia z 5: {0}", silnia 5)
    
    let rec fib n =
        if n <= 0 then 0
        elif n <= 1 then 1
        else fib (n - 1) + fib (n - 2)

    let rec fib2 n =
        match n with
        | 0 -> 0
        | 1 -> 1
        | _ -> fib2 (n - 1) + fib2 (n - 2)
    Console.WriteLine("5 wyraz ciągu fibonacciego: {0}", fib 7)
    
    let rec euklidesOdejmowanie (a:int) (b:int) :int =
        if a = b then a
        elif a > b then euklidesOdejmowanie (a - b) b
        else euklidesOdejmowanie a (b - a)

    let rec euklidesOdejmowanie2 (a:int) (b:int) :int =
        match a = b with
        | true -> a
        | false -> match a > b with
                    | true -> euklidesOdejmowanie2 (a - b) b
                    | false -> euklidesOdejmowanie2 a (b - a)

    Console.WriteLine("Odejmowanie NWD(1989,867): {0}", (euklidesOdejmowanie 1989 867))
    
    let rec euklidesModulo (a:int) (b:int) :int =
        if b = 0 then a
        else euklidesModulo b (a % b)

    let rec euklidesModuloMatch (a:int) (b:int) :int =
        match b with
        | 0 -> a
        | _ -> euklidesModuloMatch b (a % b)

    Console.WriteLine("Modulo NWD(1989,867): {0}", (euklidesModulo 1989 867))

    let rec sumaCyfr (a:Int32) :Int32 =
        if a = 0 then 0
        else a % 10 + sumaCyfr (a / 10)

    Console.WriteLine("Suma cyfr w 123: {0}", sumaCyfr 12)
    
    // Zad 2
    let SameRemainder (a, b) =
        match (a % 4) = (b % 4) with
        | true -> Console.WriteLine("Liczby {0} i {1} mają taka samą reszte z dzielenia przez 4", a, b)
        | false -> Console.WriteLine("Liczby {0} i {1} mają różną reszte z dzielenia przez 4", a, b)

    SameRemainder (2, 4)

    // Zad 3
    let mutable seq1 = seq {1 .. 10 }
    let seq2 = seq {0 .. 10 .. 100 }
    let seq3 = seq { for i in 1 .. 10 do yield i * i}
    let seq4 = seq { for i in 1 .. 10 -> i * i}
    //printfn "seq1: %A" seq1
    //printfn "seq2: %A" seq2
    //printfn "seq3: %A" seq3
    //printfn "seq4: %A" seq4
    
    seq1 <- Seq.append seq1 [9]
    
    for x in seq1 do
        printf "%i, " x
    Console.WriteLine();

    let seqEmpty = Seq.empty
    let seqSingleton = Seq.singleton 10

    let potegiDwojki = Seq.init 8 (fun n -> pown 2 n)
    Seq.iter (fun element -> printf "%i, " element) potegiDwojki

    // Zad 5
    let reszta (a:int) (b:int) =
        match a % b with
        | 0 -> None
        | _ -> Some(a % b)

    let wynik = reszta 5 5
    
    if wynik.IsSome then Console.WriteLine("Reszta z dzielenia wynosi: {0}", wynik.Value)
    if wynik.IsNone then Console.WriteLine("Reszta wynosi 0")

    let mutable lista = [1; 2; 3]
    lista <- 10::lista              // dodaj na początku

    printfn "%A" lista

    lista <- List.append lista [10] // dodaj na końcu

    for element in lista do
        Console.Write("{0} ", element)
    Console.WriteLine()

    printfn "Czy lista jest pusta : %b" (lista.IsEmpty)
    printfn "Długość listy : %d" (lista.Length)
    printfn "Pierwszy element listy : %d" (lista.Head)
    printfn "Drugi element listy : %d" (lista.Tail.Head)
    printfn "Trzeci element listy : %d" (lista.Tail.Tail.Head)
    printfn "Element o indeksie(1) : %d" (lista.Item(1))

    let posortowana = List.sort [-4; 2; 9; -11; 0; 4]
    printfn "Lista posortowana: %A" posortowana

    let listaA = [80 .. 200]
    let szukana = List.find (fun x -> x % 17 = 0) listaA
    printfn "Pierwsza liczba podzielna przez 17: : %d" szukana

    let listaB = [1 .. 10]
    let nowa = List.map (fun x -> x + 1) listaB
    printfn "nowa lista na podstawie istniejącej: %A" nowa
*)
    // Zad 7
    let tablica = [| 1; 2; 3 |]
    printfn "tablica: %A" tablica
    let tablica1 = Array.create 5 1     // stwórz tablicę 5 elementów i uzupełnij ją 1

    printfn "tablica1: %A" tablica1
    printfn "długość tablicy: %A" tablica.Length

    tablica.[2] <- 7
    printfn "zmiana elementu tablicy1: %A" tablica1
    Array.set tablica1 2 7
    printfn "zmiana elementu tablicy1: %A" tablica1

    Console.ReadKey() |> ignore
    0 // return an integer exit code
