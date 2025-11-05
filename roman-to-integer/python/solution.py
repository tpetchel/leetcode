class Solution:
    values = {
      "I": 1,
      "IV": 4,
      "V": 5,
      "IX": 9,
      "X": 10,
      "XL": 40,
      "L": 50,
      "XC": 90,
      "C": 100,
      "CD": 400,
      "D": 500,
      "CM": 900,
      "M": 1000,
    }

    def romanToInt(self, s: str) -> int:
        return self.__romanToIntAux(s, 0)

    def __romanToIntAux(self, s: str, sum: int) -> int:
        if len(s) == 0:
            return sum; 
        else:
            n = Solution.values.get(s[:2])
            if n:
                return self.__romanToIntAux(s[2:], sum + n)
            else:
                return self.__romanToIntAux(s[1:], sum + Solution.values[s[:1]])

if __name__ == "__main__":
    print(Solution().romanToInt("III"))

