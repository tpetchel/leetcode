class ListNode(_x: Int = 0, _next: ListNode = null) {
    var next: ListNode = _next
    var x: Int = _x
}

object ListNode {
    def toList(list: ListNode): List[Int] = {
        if (list == null) {
            List()
        }
        else if (list.next != null) {
            list.x :: toList(list.next)
        }
        else {
            List(list.x)
        }
    }
}