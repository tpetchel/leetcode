//> using scala 3.5.1

object Solution {
    def longestCommonPrefix(strs: Array[String]): String = longestCommonPrefixAux(strs, 0, strs.map(str => str.length).min)

    private def longestCommonPrefixAux(strs: Array[String], i: Int, max: Int): String = {
        if (i < max && strs.forall(s => s(i) == strs(0)(i))) s"${strs(0)(i)}${longestCommonPrefixAux(strs, i + 1, max)}"
        else ""
    }
}

@main def run(): Unit =
  println(Solution.longestCommonPrefix(Array("flower","flow","flight")))
