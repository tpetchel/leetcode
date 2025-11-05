from typing import List

class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str: return self.__longestCommonPrefix(strs, 0, min(len(s) for s in strs))

    def __longestCommonPrefix(self, strs: List[str], i: int, max: int) -> str:
        if i < max and all(s[i] == strs[0][i] for s in strs): return f"{strs[0][i]}{self.__longestCommonPrefix(strs, i + 1, max)}"
        else: return ""

if __name__ == "__main__":
    print(Solution().longestCommonPrefix(["flower","flow","flight"]))

