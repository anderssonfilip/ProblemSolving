{\rtf1\ansi\ansicpg1252\cocoartf1347\cocoasubrtf570
{\fonttbl\f0\fnil\fcharset0 Menlo-Regular;\f1\fnil\fcharset0 Menlo-Italic;}
{\colortbl;\red255\green255\blue255;\red0\green150\blue149;\red51\green51\blue51;\red51\green100\blue164;
\red245\green125\blue0;\red136\green136\blue136;}
\margl1440\margr1440\vieww18240\viewh11580\viewkind0
\deftab720
\pard\pardeftab720

\f0\fs24 \cf2 using\cf3  System;\uc0\u8232 \cf2 using\cf3  System.Collections.Generic;\uc0\u8232 \cf2 using\cf3  System.Linq;\uc0\u8232 \u8232 \cf2 namespace\cf3  ProblemSolving\uc0\u8232 \{\u8232 	\cf2 class\cf3  \cf4 MainClass\uc0\u8232 \cf3 	\{\uc0\u8232 		\cf2 public\cf3  \cf2 static\cf3  \cf2 void\cf3  Main (\cf2 string\cf3 [] args)\uc0\u8232 		\{\u8232 			\cf2 foreach\cf3  (\cf2 var\cf3  permutation \cf2 in\cf3  PermutateString (\cf5 "abc"\cf3 )) \{\uc0\u8232 				\cf4 Console\cf3 .WriteLine (permutation);\uc0\u8232 			\}\u8232 \u8232 			\cf4 Console\cf3 .Read ();\uc0\u8232 		\}\u8232 \u8232 		
\f1\i \cf6 /// <summary>\uc0\u8232 
\f0\i0 \cf3 		
\f1\i \cf6 /// Find all permutations of a string.\uc0\u8232 
\f0\i0 \cf3 		
\f1\i \cf6 /// Example: passing the string 'abc' will return the the list ['abc', 'acb', 'bac', 'bca', 'cab', 'cba']\uc0\u8232 
\f0\i0 \cf3 		
\f1\i \cf6 /// </summary>\uc0\u8232 
\f0\i0 \cf3 		
\f1\i \cf6 /// <param name="input">the string to permutate</param>\uc0\u8232 
\f0\i0 \cf3 		
\f1\i \cf6 /// <param name="recursionLevel"></param>\uc0\u8232 
\f0\i0 \cf3 		\cf2 static\cf3  \cf4 IEnumerable\cf3 <\cf2 string\cf3 > PermutateString (\cf2 string\cf3  input, \cf2 int\cf3 ? recursionLevel = \cf2 null\cf3 )\uc0\u8232 		\{\u8232 			\cf2 if\cf3  (recursionLevel == \cf2 null\cf3 )\uc0\u8232 				recursionLevel = input.Length;\u8232 \u8232 			\cf2 if\cf3  (recursionLevel == \cf5 1\cf3 )\uc0\u8232 				\cf2 return\cf3  input.Select (t => t.ToString ());\uc0\u8232 \u8232 			\cf2 var\cf3  array = PermutateString (input, recursionLevel - \cf5 1\cf3 );\uc0\u8232 \u8232 			\cf2 return\cf3  array.SelectMany (s1 => input.Where (s2 => !s1.Contains (s2)), (t1, t2) => t1 + t2);\uc0\u8232 		\}\u8232 	\}\u8232 \}\u8232 }