//> using scala 3.5.1
//> using dep org.scalameta::munit:1.2.1

class SolutionSuite extends munit.FunSuite:
  test("isPalindrome tests"):
    val cases = List(
        (121, true),
        (-121, false),
        (10, false))
    for (n, expected) <- cases do
        val actual: Boolean = Solution.isPalindrome(n)
        assertEquals(actual, expected)
