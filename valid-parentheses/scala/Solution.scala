//> using scala 3.5.1

object Solution {
    def isValid(s: String): Boolean = {
        if (s.length % 2 == 1) false;
        else process(s, "").length == 0
    }
    
    private def process(s: String, q: String): String = {
        if (s.length == 0) q
        else {
            val cur = s.head
            if (q.length > 0) {
                if (!areBalanced(q.head, cur)) {
                    process(s.tail, s"$cur$q")
                }
                else {
                    process(s.tail, q.tail)
                }
            }
            else process(s.tail, s"$cur$q")
        }        
    }

    private inline def areBalanced(c1: Char, c2: Char) = {
        c1 match {
            case '(' => c2 == ')'
            case '[' => c2 == ']'
            case '{' => c2 == '}'
            case _ => false
        }
    }
}

@main def run(): Unit =
    println(Solution.isValid("()"))
