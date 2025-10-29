from typing import List
from more_itertools import one

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        for i, num1 in enumerate(nums):
            for j, num2 in enumerate(nums):
                if i != j and num1 + num2 == target:
                    return [i, j]
        raise Exception("Input must have one solution.")
    
    # Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
    def twoSum2(self, nums: List[int], target: int) -> List[int]:
        m = {}
        for i, curr in enumerate(nums):
            diff = target - curr
            candidates = m.get(diff)
            if candidates != None:
                return [i, one(j for j in candidates if j != i)]
            indices = m.get(curr)
            if indices != None:
                indices.add(i)
            else:
                indices = [i]
                m[curr] = indices
        raise Exception("Input must have one solution.")

if __name__ == "__main__":
    print(Solution().twoSum([2,7,11,15], 9))

