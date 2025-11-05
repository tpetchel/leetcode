//> using scala 3.5.1
//> using dep org.scalameta::munit:1.2.1

class SolutionSuite extends munit.FunSuite:
  test("longestCommonPrefix tests"):
    val cases = List(
        (Array("flower","flow","flight"), "fl"),
        (Array("dog","racecar","car"), ""))
    for (arr, expected) <- cases do
        val actual: String = Solution.longestCommonPrefix(arr)
        assertEquals(actual, expected)
