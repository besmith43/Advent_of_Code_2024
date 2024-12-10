#!/usr/bin/env dotnet-script


using System.IO;
using System.Runtime.CompilerServices;

string path = "";

public static string GetScriptPath([CallerFilePath] string path = null) => path;
public static string GetScriptFolder([CallerFilePath] string path = null) => Path.GetDirectoryName(path);

path = GetScriptFolder();


var content = read($"{path}/example_input.txt");
// var content = read($"{path}/input.txt");

Console.WriteLine($"Total: {process(content)}");

int process(List<string> list)
{
	int total = 0;

	foreach (var line in list)
	{
		int index = line.IndexOf(':');
		// Console.Error.WriteLine("{0}", line);
		// Console.Error.WriteLine("{0}", index);
		string newline = line.Remove(index, 1);
		// Console.Error.WriteLine("{0}", newline);
		string[] temp = newline.Split();
		List<int> nums = new List<int>();

		foreach (var num in temp)
		{
			nums.Add(Int32.Parse(num));
		}

		if (check(nums))
		{
			total += nums[0];
		}
	}

	return total;
}

bool check(List<int> nums)
{
	int num_of_operations = nums.Count - 2;
	int total_permutations = (int)Math.Pow(2, num_of_operations);
	// Console.WriteLine($"{total_permutations}");
	// List<char> options = new List<char>();

	List<char> operations = new List<char>();

	// foreach(int num in nums)

	return true;
}

List<string> read(string path)
{
	string[] content = File.ReadAllLines(path);
	return new List<string>(content);
}
