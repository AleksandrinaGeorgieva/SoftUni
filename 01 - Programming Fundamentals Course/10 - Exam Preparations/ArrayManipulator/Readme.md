<H1 LANG="bg-BG" CLASS="western" ALIGN=CENTER STYLE="margin-top: 0in; margin-bottom: 0.08in; line-height: 100%"><A NAME="_GoBack"></A>
<SPAN LANG="en-US">Array Manipulator</SPAN></H1>
<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">Trifon
has finally become a junior developer and has received his first
task. It’s about manipulating an array of integers. He is not quite
happy about it, since he hates manipulating arrays. They are going to
pay him a lot of money, though, and he is willing to give somebody
half of it if to help him do his job. You, on the other hand, love
arrays (and money) so you decide to try your luck.</SPAN></P>
<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">The
array may be manipulated by one of the following commands</SPAN></P>
<UL>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
	<SPAN LANG="en-US"><B>exchange {index}</B></SPAN><SPAN LANG="en-US">
	– splits the array </SPAN><SPAN LANG="en-US"><B>after</B></SPAN><SPAN LANG="en-US">
	the given index, and exchanges the places of the two resulting
	sub-arrays. E.g. [1, 2, 3, 4, 5] -&gt; exchange 2 -&gt; result: [4,
	5, 1, 2, 3]</SPAN></P>
	<UL>
		<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
		<SPAN LANG="en-US">If the index is outside the boundaries of the
		array, print “</SPAN><SPAN LANG="en-US"><B>Invalid index</B></SPAN><SPAN LANG="en-US">”</SPAN></P>
	</UL>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
	<SPAN LANG="en-US"><B>max</B></SPAN><SPAN LANG="en-US"> </SPAN><SPAN LANG="en-US"><B>even/odd</B></SPAN><SPAN LANG="en-US">–
	returns the </SPAN><SPAN LANG="en-US"><B>INDEX</B></SPAN><SPAN LANG="en-US">
	of the max even/odd element -&gt; [1, 4, 8, 2, 3] -&gt; </SPAN><SPAN LANG="en-US"><B>max
	odd</B></SPAN><SPAN LANG="en-US"> -&gt; print </SPAN><SPAN LANG="en-US"><B>4</B></SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
	<SPAN LANG="en-US"><B>min</B></SPAN><SPAN LANG="en-US"> </SPAN><SPAN LANG="en-US"><B>even/odd
	</B></SPAN><SPAN LANG="en-US">– returns the </SPAN><SPAN LANG="en-US"><B>INDEX</B></SPAN><SPAN LANG="en-US">
	of the min even/odd element -&gt; [1, 4, 8, 2, 3] -&gt; </SPAN><SPAN LANG="en-US"><B>min
	even</B></SPAN><SPAN LANG="en-US"> &gt; print </SPAN><SPAN LANG="en-US"><B>3</B></SPAN></P>
	<UL>
		<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
		<SPAN LANG="en-US">If there are two or more equal </SPAN><SPAN LANG="en-US"><B>min/max</B></SPAN><SPAN LANG="en-US">
		elements, return the index of the </SPAN><SPAN LANG="en-US"><B>rightmost</B></SPAN><SPAN LANG="en-US">
		one</SPAN></P>
		<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
		<SPAN LANG="en-US">If a </SPAN><SPAN LANG="en-US"><B>min/max
		even/odd </B></SPAN><SPAN LANG="en-US">element </SPAN><SPAN LANG="en-US"><B>cannot</B></SPAN><SPAN LANG="en-US">
		be found, print </SPAN><SPAN LANG="en-US"><B>“No matches”</B></SPAN></P>
	</UL>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
	<SPAN LANG="en-US"><B>first {count}</B></SPAN><SPAN LANG="en-US">
	</SPAN><SPAN LANG="en-US"><B>even/odd</B></SPAN><SPAN LANG="en-US">–
	returns the first {count} elements -&gt; [1, 8, 2, 3] -&gt; </SPAN><SPAN LANG="en-US"><B>first
	2 even</B></SPAN><SPAN LANG="en-US"> -&gt; print [</SPAN><SPAN LANG="en-US"><B>8,
	2]</B></SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
	<SPAN LANG="en-US"><B>last {count}</B></SPAN><SPAN LANG="en-US">
	</SPAN><SPAN LANG="en-US"><B>even/odd </B></SPAN><SPAN LANG="en-US">–
	returns the last {count} elements -&gt; [1, 8, 2, 3] -&gt; </SPAN><SPAN LANG="en-US"><B>last
	2 odd</B></SPAN><SPAN LANG="en-US"> -&gt; print [</SPAN><SPAN LANG="en-US"><B>1,
	3]</B></SPAN></P>
	<UL>
		<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
		<SPAN LANG="en-US">If the count is greater than the array length,
		print “</SPAN><SPAN LANG="en-US"><B>Invalid count</B></SPAN><SPAN LANG="en-US">”</SPAN></P>
		<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
		<SPAN LANG="en-US">If there are </SPAN><SPAN LANG="en-US"><B>not</B></SPAN><SPAN LANG="en-US">
		</SPAN><SPAN LANG="en-US"><B>enough</B></SPAN><SPAN LANG="en-US">
		elements to satisfy the count, print as many as you can. If there
		are </SPAN><SPAN LANG="en-US"><B>zero</B></SPAN><SPAN LANG="en-US">
		</SPAN><SPAN LANG="en-US"><B>even/odd</B></SPAN><SPAN LANG="en-US">
		elements, print an empty array “[]”</SPAN></P>
	</UL>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
	<SPAN LANG="en-US"><B>end </B></SPAN><SPAN LANG="en-US">– stop
	taking input and print the final state of the array</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
<SPAN LANG="en-US">Input</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The input data should be read from the console.</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">On the first line, the initial array is received
	as a line of integers, separated by a single space</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">On the next lines, until the command “</SPAN><SPAN LANG="en-US"><B>end</B></SPAN><SPAN LANG="en-US">”
	is received, you will receive the array manipulation commands</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The input data will always be valid and in the
	format described. There is no need to check it explicitly.</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
<SPAN LANG="en-US">Output</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The output should be printed on the console.</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">On a separate line, print the output of the
	corresponding command</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">On the last line, print the final array in </SPAN><SPAN LANG="en-US"><B>square
	brackets</B></SPAN><SPAN LANG="en-US"> with its elements separated
	by a comma and a space </SPAN>
	</P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">See the examples below to get a better
	understanding of your task</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
<SPAN LANG="en-US">Constraints</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The </SPAN><SPAN LANG="en-US"><B>number of input
	lines</B></SPAN><SPAN LANG="en-US"> will be in the range [2 … 50].</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The </SPAN><SPAN LANG="en-US"><B>array elements</B></SPAN><SPAN LANG="en-US">
	will be integers in the range [0 … 1000].</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The </SPAN><SPAN LANG="en-US"><B>number of
	elements</B></SPAN><SPAN LANG="en-US"> will be in the range [1 ..
	50]</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The </SPAN><SPAN LANG="en-US"><B>split index </B></SPAN><SPAN LANG="en-US">will
	be an integer in the range [-2</SPAN><SUP><SPAN LANG="en-US">31 </SPAN></SUP><SPAN LANG="en-US">…
	2</SPAN><SUP><SPAN LANG="en-US">31</SPAN></SUP><SPAN LANG="en-US"> –
	1]</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US"><B>first/last count </B></SPAN><SPAN LANG="en-US">will
	be an integer in the range [1</SPAN><SUP><SPAN LANG="en-US"> </SPAN></SUP><SPAN LANG="en-US">…
	2</SPAN><SUP><SPAN LANG="en-US">31</SPAN></SUP><SPAN LANG="en-US"> –
	1]</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">There will </SPAN><SPAN LANG="en-US"><B>not</B></SPAN><SPAN LANG="en-US">
	be redundant whitespace anywhere in the input</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">Allowed working time for your program: 0.1
	seconds. Allowed memory: 16</SPAN><SPAN LANG="en-US"> MB.</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">
<SPAN LANG="en-US">Examples</SPAN></H3>
<TABLE WIDTH=677 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=363>
	<TR VALIGN=TOP>
		<TD WIDTH=296 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3><SPAN LANG="en-US">Input</SPAN></FONT></P>
		</TD>
		<TD WIDTH=363 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3><SPAN LANG="en-US">Output</SPAN></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">1
			3 5 7 9</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">exchange
			1</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">max
			odd</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">min
			even</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">first
			2 odd</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">last
			2 even</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">exchange
			3</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">end</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">2</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">No
			matches</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">[5,
			7]</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">[]</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">[3,
			5, 7, 9, 1]</SPAN></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<TABLE WIDTH=677 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=363>
	<TR VALIGN=TOP>
		<TD WIDTH=296 HEIGHT=21 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3><SPAN LANG="en-US">Input</SPAN></FONT></P>
		</TD>
		<TD WIDTH=363 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3><SPAN LANG="en-US">Output</SPAN></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">1
			10 100 1000</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">max
			even</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">first
			5 even</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">exchange
			10</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">min
			odd</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">exchange
			0</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">max
			even</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">min
			even</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">end</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">3</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">Invalid
			count</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">Invalid
			index</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">0</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">2</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">0</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">[10,
			100, 1000, 1]</SPAN></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
<BR><BR>
</P>
<TABLE WIDTH=677 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=363>
	<TR VALIGN=TOP>
		<TD WIDTH=296 HEIGHT=21 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3><SPAN LANG="en-US">Input</SPAN></FONT></P>
		</TD>
		<TD WIDTH=363 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3><SPAN LANG="en-US">Output</SPAN></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">1
			10 100 1000</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">exchange
			3</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">first
			2 odd</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">last
			4 odd</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">end</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">[1]</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">[1]</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">[1,
			10, 100, 1000]</SPAN></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>
