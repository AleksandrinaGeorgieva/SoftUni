<h1>Exact Sum of Real Numbers</h1>
</br>
Write program to enter n numbers and calculate and print their exact sum (without rounding).
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
			3 </br>
			1000000000000000000 </br>
			5 </br>
			10
		</td>
		<td>
			1000000000000000015
		</td>
	</tr>
</table>
<table>
	<tr>
		<th>Input</th>
		<th>Output</th>
	</tr>
	<tr>
		<td>
			2 </br>
			0.00000000003 </br>
			333333333333.3
		</td>
		<td>
			333333333333.30000000003
		</td>
	</tr>
</table>
</br>
<h4>Hints</h4>
</br>
If you use types like float or double, the result will lose some of its precision. Also it might be printed in scientific notation.</br>
You might use the decimal data type which holds real numbers with high precision with less loss.</br>
Note that decimal numbers sometimes hold the unneeded zeroes after the decimal point, so 0m is different than 0.0m and 0.00000m.</br>