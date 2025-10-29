//> using scala 3.5.1
import scala.util.boundary, boundary.break

object Solution {
    def twoSum(nums: Array[Int], target: Int): Array[Int] = {
        boundary[Array[Int]]:
            for ((num1, i) <- nums.zipWithIndex) 
                for ((num2, j) <- nums.zipWithIndex) 
                    if i != j && num1 + num2 == target then
                        break(Array(i, j))
            throw new Exception
    }
}

@main def run(): Unit =
  Solution.twoSum(Array(2,7,11,15), 9).foreach(println)
