//> using scala 3.5.1

object Solution {
    def isPalindrome(x: Int): Boolean = {
        if (x < 0) return false
        val digits = extractDigits(x)
        val pairs = digits.zip(digits.reverse)
        pairs.forall((x,y) => x == y)
    }

    private def extractDigits(n: Int): List[Int] = {
        if (n <= 0) Nil
        else n % 10 :: extractDigits(n / 10)
    }
}

@main def run(): Unit =
  println(Solution.isPalindrome(121))
