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
			1 -> False
			2 -> False
			3 -> False
			4 -> False
			5 -> True
			6 -> False
			7 -> True
			8 -> False
			9 -> False
			10 -> False
			11 -> False
			12 -> False
			13 -> False
			14 -> True
			15 -> False
		</td>
	</tr>
</table>

</br>
<h4>Hints</h4>
</br>
To calculate the sum of digits of given number num, you might repeat the following: sum the last digit (num % 10) and remove it (sum = sum / 10) until num reaches 0.
