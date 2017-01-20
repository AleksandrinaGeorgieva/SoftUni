<h1>5.	Special Numbers</h1>
</br>
A number is special when its sum of digits is 5, 7 or 11. </br>
Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).
</br>
<h4>Examples</h4>
</br>
<table>
	<tr>
		<th>Input</th>
		<th>Output</th>
	</tr>
	<tr>
		<td>
			15
		</td>
		<td>
			1 -> False</br>
			2 -> False</br>
			3 -> False</br>
			4 -> False</br>
			5 -> True</br>
			6 -> False</br>
			7 -> True</br>
			8 -> False</br>
			9 -> False</br>
			10 -> False</br>
			11 -> False</br>
			12 -> False</br>
			13 -> False</br>
			14 -> True</br>
			15 -> False
		</td>
	</tr>
</table>

</br>
<h4>Hints</h4>
</br>
To calculate the sum of digits of given number num, you might repeat the following: sum the last digit (num % 10) and remove it (sum = sum / 10) until num reaches 0.
