// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    //Zad 4
    let SquareArea a b :float =
        a * b
    Console.WriteLine("Pole powierzchni kwadratu: {0}", SquareArea 4.0 4.0)

    let CircleArea r :float =
        r ** 2.0 * Math.PI
    Console.WriteLine("Pole powierzchni koła: {0}", CircleArea 5.0)

    //Zad 5
    let CalcPolynomial x y :float= 
        ((-5.0 * y ** 4.0) + (1.0/3.0*x**2.0) + (3.0 * y - 7.0))
    Console.WriteLine("Obliczony wielomian: ", CalcPolynomial 4.0 3.0)
    let a = Console.ReadLine() |> float
    Console.WriteLine(a)

    0 // return an integer exit code