open System.Linq
open System

let toBinary (n:Int32) = Convert.ToString(n,2).PadLeft(32, '0')
let toBin (n:SByte) = Convert.ToString((int)n,2).PadLeft(32, '0').Substring(24)

SByte.MaxValue
SByte.MinValue

-0b10000000y
 0b10000000y
 0b01111111y

 0b10000000y
 0b01111111y

 // max
 0b01111111y
 // min
 0b10000000y
 // -min
 -0b10000000y
 // -max
 -0b01111111y
 // -max == min?
 -0b01111111y = 0b10000000y
 // -min == min?
 -0b10000000y = 0b10000000y

 // start with 1 = negetive
 // value = -128 + binary value
 0b10000000y
 0b10000001y
 0b10000011y
 0b10000111y
 0b10001111y
 0b10011111y
 0b10111111y
 0b11111111y

 // start with 0 = positive
 // value = 0 + binary value
 0b01111111y
 0b00111111y
 0b00011111y
 0b00001111y
 0b00000111y
 0b00000011y
 0b00000001y
 0b00000000y




-SByte.MinValue
-SByte.MinValue |> toBin

-SByte.MaxValue
-SByte.MinValue |> toBin

-128y |> toBin
127y |> toBin

Int32.MinValue
Int32.MinValue |> toBinary

-Int32.MinValue
-Int32.MinValue |> toBinary

Int32.MaxValue
Int32.MaxValue |> toBinary

-Int32.MaxValue
-Int32.MaxValue |> toBinary

-0b10000000000000000000000000000000 |> toBinary

let n1 = - Int32.MaxValue
Convert.ToString(n1, 2)

let n2 = - Int32.MinValue
Convert.ToString(n2, 2)


Enumerable.Range(2010,2011).ToList()

Convert.ToSByte("10000000", 2)
Convert.ToSByte("01111111", 2)

-0b1000000y - 0b1000000y

Convert.ToInt32("10000000000000000000000000000000", 2)
Convert.ToInt32("01111111111111111111111111111111", 2)


Int32.MaxValue
Int32.MinValue

Int32.MaxValue - Int32.MinValue
Int32.MinValue - Int32.MaxValue

-Int32.MaxValue
-Int32.MinValue

let n:Int32 = -Int32.MinValue
n

-Int32.MaxValue = Int32.MaxValue
-Int32.MinValue = Int32.MinValue


Int32.MinValue
-Int32.MinValue

let n:Int32 = -Int32.MinValue
n

let n2:Int32 = Int32.MaxValue + 10
n2

let n1:Int32 = -Int32.MaxValue
let n2:Int32 = -Int32.MinValue

n1 = Int32.MinValue
n2 = Int32.MinValue

