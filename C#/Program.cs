using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			foreach (var permutation in StringPermutator.Permutate ("abc")) {
				Console.WriteLine (permutation);
			}

			Console.Read ();
		}
			
		/// <summary>
		/// Find all permutations of a string.
		/// Example: 'abc' will return the the list ['abc', 'acb', 'bac', 'bca', 'cab', 'cba']
		/// </summary>
		class StringPermutator
		{
			public static IEnumerable<string> Permutate (string input)
			{
				return Recurse (input, input.Length);
			}

			private static IEnumerable<string> Recurse (string input, int recursionLevel)
			{
				if (recursionLevel == 1)
					return input.Select (t => t.ToString ());

				var partialPermutations = Recurse (input, recursionLevel - 1);

				return partialPermutations.SelectMany (s1 => input.Where (s2 => !s1.Contains (s2)), (t1, t2) => t1 + t2);
			}
		}
	}
}

