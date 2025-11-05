//> using scala 3.5.1
//> using dep org.scalameta::munit:1.2.1

class SolutionSuite extends munit.FunSuite:
  test("romanToInt tests"):
    val cases = List(
        ("III", 3),
        ("LVIII", 58),
        ("MCMXCIV", 1994))
    for (s, expected) <- cases do
        val actual: Int = Solution.romanToInt(s)
        assertEquals(actual, expected)
