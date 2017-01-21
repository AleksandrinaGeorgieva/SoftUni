<h1>Thea the Photographer</h1>
</br>
<pre>
	Thea is a photographer. She takes pictures of people on special events. She is a good friend and you want to help her.

She wants to inform her clients when their pictures will be ready. Since the number of pictures is big and it requires time for editing (#nofilter, #allnatural) every single picture - you decide to write a program in order to help her.

Thea follows this pattern: first she takes all pictures. Then she goes through every single picture to filter these pictures that are considered "good". Then she needs to upload every single filtered picture to her cloud. She is considered ready when all filtered pictures are uploaded in her picture storage.

You will receive the amount of pictures she had taken. Then the approximate time in seconds for every picture to be filtered. Then a filter factor – a percentage (integer number) of the total photos (rounded to the nearest bigger integer value e.g. 5.01 -> 6) that are good enough to be given to her clients (Photoshop may do miracles but Thea does not). Approximate time for every picture to be uploaded will be given again in seconds. Your task is: based on this input to display total time needed for her to be ready with the pictures in given below format.

</pre>
</br>

<h4>Input</h4>
</br>
<pre>
	On the first line you will receive an integer N – the amount of pictures Thea had taken.

On the second line you will receive an integer FT – the amount of time (filter time) in seconds that Thea will require to filter every single picture.

On the third line you will receive an integer FF – the filter factor or the percentage of the total pictures that are considered “good” to be uploaded.

On the fourth line you will receive an integer UT – the amount of time needed for every filtered picture to be uploaded to her storage.

The input will be in the described format, there is no need to check it explicitly.
	</pre>

<h4>Output</h4>
</br>
<pre>
	Print the amount of time Thea will need in order to have her pictures ready to be sent to her client in given format:
	d:HH:mm:ss 
	d - days needed – starting from 0.
	HH –  hours needed – from 00 to 24.
	mm – minutes needed – from 00 to 59.
	ss – seconds needed – from 00 to 59.

</pre>

<h4>
	Constrains
</h4>
</br>
<pre>
The amount of total pictures Thea will have taken is range [0 … 1 000 000]
The seconds for both filtering and uploading will be in range [0 … 100 000]
The filter factor will be an integer number between [0 … 100].
</pre>
<h4>Examples</h4>
</br>
<table>
	<tr>
		<th>Input</th>
		<th>Output</th>
		<th>Comments</th>
	</tr>
	<tr>
		<td>
			<pre>
				1000
				1
				50
				1
			</pre>
		</td>
		<td>0:00:25:00
		</td>
		<td>
			<pre>
				Total pictures = 1 000, 50% of them are useful 
					-> Filtered pictures = 500 
				Total pictures * filter time = 1000 s
				Filtered pictures * upload time = 500 s
				Total time = 1500 s
			</pre>
		</td>
	</tr>
	<tr>
		<td>
			<pre>
				5342
				2
				82
				3
			</pre>
		</td>
		<td>0:06:37:07
		</td>
		<td>
			<pre>
				Total pictures = 5342 - 82% of them are useful 
					-> 4380.44-> 4381 filtered.
			</pre>
		</td>
	</tr>
</table>

</br>
<h4>Hints</h4>
</br>