// See https://aka.ms/new-console-template for more information
using LeetCode;

int target = 2;
int[] nums = { 1, 3, 5, 6 };

SearchInsertPosition search = new SearchInsertPosition();
int a = search.SearchInsert(nums, target);

Console.WriteLine(a);  