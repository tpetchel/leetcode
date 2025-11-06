//> using scala 3.5.1

object Solution {
    def mergeTwoLists(list1: ListNode, list2: ListNode): ListNode = {
        if (list1 != null) {
            if (list2 != null) {
                if (list1.x < list2.x) {
                    new ListNode(list1.x, mergeTwoLists(list1.next, list2))
                }
                else {
                    new ListNode(list2.x, mergeTwoLists(list1, list2.next))
                }
            }
            else {
                new ListNode(list1.x, mergeTwoLists(list1.next, list2))
            }
        }
        else {
            if (list2 != null) {
                new ListNode(list2.x, mergeTwoLists(list1, list2.next))
            }
            else {
                null
            }
        }
    }
}

@main def run(): Unit =
    val list1 = new ListNode(1, new ListNode(2, new ListNode(4)))
    val list2 = new ListNode(1, new ListNode(3, new ListNode(4)))
    val merged = Solution.mergeTwoLists(list1, list2)
    println(s"[${ListNode.toList(merged).mkString(", ")}]")
