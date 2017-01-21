<h1>18.	* Different Integers Size</h1>
</br>
Given an input integer, you must determine which primitive data types are capable of properly storing that input.
</br>

<h4>Input</h4>
</br>
You receive N - integer which can be arbitrarily large or small </br>

<h4>Output</h4>
</br>
You must determine if the given primitives are capable of storing it. If yes, then print: </br>
<pre>
	{N} can fit in: 
	* dataType
</pre>
</br>
If there is more than one appropriate data type, print each one on its own line and order them by size (sbyte < byte < short < ushort < int < uint < long).</br>
If the number cannot be stored in one of the four aforementioned primitives, print the line: </br>
<pre>
	{N} can't fit in any type
</pre>
<h4>Examples</h4>
</br>
<table>
	<tr>
		<th>Input</th>
		<th>Output</th>
	</tr>
	<tr>
		<td>
			-150
		</td>
		<td>
			<pre>
				-150 can fit in:
				* short
				* int
				* long
			</pre>
		</td>
	</tr>
	<tr>
		<td>
			150000
		</td>
		<td>
			150000 can fit in:
			* int
			* uint
			* long
		</td>
	</tr>
	<tr>
		<td>
			21333333333333333333333333333333333333333333333333333333333
		</td>
		<td>
			<pre>
				21333333333333333333333333333333333333333333333333333333333
				can't fit in any type
			</pre>
		</td>
	</tr>
</table>

</br>
<h4>Hints</h4>
</br>
Use the <b> try... catch </b> construction.
