<h1>8.	Refactor Volume of Pyramid </h1>
</br>
You are given a working code that finds the volume of a pyramid. However, you should consider that the variables exceed their optimum span and have improper naming. Also, search for variables that have multiple purpose.
</br>
<h4>Code</h4>
</br>
<table>
	<tr>
		<th>Sample code</th>
	</tr>
	<tr>
		<td>
			double dul, sh, V = 0;</br>
			Console.Write("Length: ");</br>
			dul = double.Parse(Console.ReadLine());</br>
			Console.Write("Width: ");</br>
			sh = double.Parse(Console.ReadLine());</br>
			Console.Write("Heigth: ");</br>
			V = double.Parse(Console.ReadLine());</br>
			V = (dul + sh + V) / 3;</br>
			Console.WriteLine("Pyramid Volume: {0:F2}", V);</br>
		</td>
	</tr>
</table>

</br>
<h4>Hints</h4>
</br>
•	Reduce the span of the variables by declaring them in the moment they receive a value, not before</br>
•	Rename your variables to represent their real purpose (example: "dul" should become length, etc.)</br>
•	Search for variables that have multiple purpose. If you find any, introduce a new variable.

