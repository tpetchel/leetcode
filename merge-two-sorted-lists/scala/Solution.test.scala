//> using scala 3.5.1
//> using dep org.scalameta::munit:1.2.1

class SolutionSuite extends munit.FunSuite:
  test("mergeTwoLists tests"):
    val cases = List(
        (
          new ListNode(1, new ListNode(2, new ListNode(4))),
          new ListNode(1, new ListNode(3, new ListNode(4))),
          List(1, 1, 2, 3, 4, 4)),
        (
          null,
          null,
          List()),
        (
          null,
          new ListNode(0),
          List(0)))
    for (list1, list2, expected) <- cases do
        val actual: ListNode = Solution.mergeTwoLists(list1, list2)
        assertEquals(ListNode.toList(actual), expected)
