using System;

public class Program {
    public static void Main() {
        int[] nums = {3, 2, 2, 3}; // Örnek dizi
        int val = 3; // Kaldırılacak değer

        Solution solution = new Solution();
        int remainingCount = solution.RemoveElement(nums, val);

        Console.WriteLine("Kalan Eleman Sayısı: " + remainingCount);
        Console.WriteLine("Kalan Elemanlar: ");
        for (int i = 0; i < remainingCount; i++) {
            Console.Write(nums[i] + " ");
        }
    }
}

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int remainingCount = 0; // Kalan elemanların sayısını tutacak
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[remainingCount] = nums[i];
                remainingCount++;
            }
        }
        return remainingCount;
    }
}
