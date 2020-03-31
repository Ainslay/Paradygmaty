open System

[<EntryPoint>]
let main argv =

    // Zad 1
    //let mutable intigerList = [1; 2; 3; 4; 5]

    //let average list =
    //    List.averageBy (fun x -> float x) list

    //Console.WriteLine("Srednia tych elementow wynosi: {0}", average intigerList)

    // Zad 2
    //let removeAllLowerThanAverage (list:List<int>) = 
    //    let avg = List.averageBy (fun x -> float x) list
    //    List.filter (fun element -> int element < int avg)  list
    
    //intigerList <- removeAllLowerThanAverage intigerList
    
    //printfn "Po usunięciu wszystkich poniżej średniej: %A" intigerList

    // Zad 3
    //let intigerList2 = [1; 2; 7; 4; 5]

    //let findMinMaxPair (list:List<int>) :int*int =
    //    (List.min list, List.max list)
    //let minMax = findMinMaxPair intigerList2

    //printf "Minimalna: %i Maksymalna: %i" (fst minMax) (snd minMax)

    // Zad 4
    //let intigerList3 = [2; 2; 3; 4; 5; 6; 7; 8]

    //let rec findEvenCount (list:List<int>) :int =
    //    if list.Tail.IsEmpty then Math.Abs((list.Head % 2) - 1)
    //    else Math.Abs((list.Head % 2) - 1) + (findEvenCount list.Tail)
       
    //Console.WriteLine("Ilość liczb parzystych w liście: {0}", (findEvenCount intigerList3))
    
    // Zad 5
    let intigerList4 = [1; 2; 3; 4; 5; 6]
    
    let GetListPair (list:List<int>) :List<int>*List<int> =
        (List.filter (fun x -> x % 2 = 1) list, List.filter (fun x -> x % 5 = 0) list)
    
    Console.WriteLine("Para list liczb nieparzystych i podzielnych przez 5: {0}", GetListPair intigerList4)
    
    0 // return an integer exit code
