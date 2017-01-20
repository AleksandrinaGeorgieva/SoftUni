<h1>Elevator</h1>
</br>
Calculate how many courses will be needed to elevate n persons by using an elevator of capacity of p persons. The input holds two lines: the number of people n and the capacity p of the elevator.
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
			17 </br>
			3 
		</td>
		<td>
			6
		</td>
	</tr>
	<tr>
		<td>
			4 </br>
			5 
		</td>
		<td>
			1
		</td>
	</tr>
	<tr>
		<td>
			10 </br>
			5
		</td>
		<td>
			2
		</td>
	</tr>
</table>

</br>
<h4>Hints</h4>
</br>
•	You should divide n by p. This gives you the number of full courses (e.g. 17 / 3 = 5).</br>
•	If n does not divide p without a remainder, you will need one additional partially full course (e.g. 17 % 3 = 2).</br>
•	Another approach is to round up n / p to the nearest integer (ceiling), e.g. 17/3 = 5.67  rounds up to 6.</br> 
