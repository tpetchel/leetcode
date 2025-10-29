//> using scala 3.5.1
//> using dep org.scalameta::munit:1.2.1

class SolutionSuite extends munit.FunSuite:
  test("twoSum tests"):
    val cases = List(
        (Array(2,7,11,15), 9, Array(0,1)),
        (Array(3,2,4), 6, Array(1,2)),
        (Array(3,3), 6, Array(0,1)))
    for (a, b, expected) <- cases do
        val actual: Array[Int] = Solution.twoSum(a, b)
        assertEquals(actual.toSeq, expected.toSeq)
