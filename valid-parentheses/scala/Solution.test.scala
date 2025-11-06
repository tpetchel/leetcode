//> using scala 3.5.1
//> using dep org.scalameta::munit:1.2.1

class SolutionSuite extends munit.FunSuite:
  test("isValid tests"):
    val cases = List(
      ("()", true),
      ("()[]{}", true),
      ("(]", false),
      ("([])", true),
      ("([)]", false))
    for (s, expected) <- cases do
        val actual: Boolean = Solution.isValid(s)
        assertEquals(actual, expected)
