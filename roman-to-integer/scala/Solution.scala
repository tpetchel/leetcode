//> using scala 3.5.1

object Solution {
    private val values = Map(
        "I" -> 1,
        "IV" -> 4,
        "V" -> 5,
        "IX" -> 9,
        "X" -> 10,
        "XL" -> 40,
        "L" -> 50,
        "XC" -> 90,
        "C" -> 100,
        "CD" -> 400,
        "D" -> 500,
        "CM" -> 900,
        "M" -> 1000)

    def romanToInt(s: String): Int = romanToIntAux(s, 0)

    private def romanToIntAux(s: String, sum: Int): Int = {
        s.length match {
            case 0 => sum
            case _ => {
                values.get(s.take(2)) match {
                    case Some(n) => romanToIntAux(s.drop(2), sum + n)
                    case _ => romanToIntAux(s.drop(1), sum + values.getOrElse(s.take(1), throw new NoSuchElementException("Key not found")))
                }
            }
        }
    }
}

@main def run(): Unit =
  println(Solution.romanToInt("III"))
