from typing import List

class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x < 0: return False
        digits = Solution.__digits(x)
        num_digits = len(digits)
        for i, curr in enumerate(digits):
            if curr != digits[num_digits - i - 1]:
                return False
        return True
   
    def __digits(n: int) -> List[int]:
        digits = []
        while n > 0:
            digits.append(n % 10)
            n = int(n / 10)
        return digits

if __name__ == "__main__":
    print(Solution().isPalindrome(121))

