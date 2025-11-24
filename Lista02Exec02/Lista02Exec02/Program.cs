int[] nums = {-7, -3, 2, 3, 11};


int[] quadrados = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
    quadrados[i] = nums[i] * nums[i];
}

Array.Sort(quadrados);

Console.WriteLine("Array de quadrados ordenado:");
foreach (int num in quadrados)
{
    Console.Write(num + " ");
}