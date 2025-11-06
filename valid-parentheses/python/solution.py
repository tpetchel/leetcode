from collections import deque

class Solution:
    def isValid(self, s: str) -> bool: 
        stack = deque()
        for c in s:
            if len(stack) > 0:
                top = stack.pop()
                if not Solution.__are_balanced(top, c):
                    stack.append(top)
                    stack.append(c)
            else:
                stack.append(c)
        while len(stack) > 1:
            top = stack.pop()
            next = stack.pop()
            if not Solution.__are_balanced(next, top):
                return False
        return len(stack) == 0

    def __are_balanced(c1: chr, c2: chr):
        match c1:
            case '(': return c2 == ')'
            case '[': return c2 == ']'
            case '{': return c2 == '}'
            case _: return False

if __name__ == "__main__":
    print(Solution().isValid("()"))
