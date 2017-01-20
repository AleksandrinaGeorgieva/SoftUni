<h1>6.	Triples of Latin Letters</h1>
</br>
Write a program to read an integer n and print all triples of the first n small Latin letters, ordered alphabetically:
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
			3
		</td>
		<td>
			aaa</br>
			aab</br>
			aac</br>
			aba</br>
			abb</br>
			abc</br>
			aca</br>
			acb</br>
			acc</br>
			baa</br>
			bab</br>
			bac</br>
			bba</br>
			bbb</br>
			bbc</br>
			bca</br>
			bcb</br>
			bcc</br>
			caa</br>
			cab</br>
			cac</br>
			cba</br>
			cbb</br>
			cbc</br>
			cca</br>
			ccb</br>
			ccc

		</td>
	</tr>
</table>

</br>
<h4>Hints</h4>
</br>
Perform 3 nested loops from 0 to n-1. For each number num print its corresponding Latin letter as follows:
</br>
char letter = (char)('a' + num);
