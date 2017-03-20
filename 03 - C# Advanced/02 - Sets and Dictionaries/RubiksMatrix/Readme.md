<OL START=12>
	<LI><H2 CLASS="western" STYLE="margin-top: 0in; margin-bottom: 0.08in; line-height: 100%">
	Rubik’s Matrix</H2>
</OL>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">Rubik’s
cube – everyone’s favorite head-scratcher. Writing a program to
solve it will be quite a difficult task for an exam, though. Instead,
we have a Rubik’s matrix prepared for you. You will be given a pair
of dimensions: <B>R</B> and <B>C. </B>To prepare the matrix, fill
each row with increasing integers, starting from one. For example, <B>2
x 4</B> matrix must look like this:</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%"><TABLE DIR="LTR" ALIGN=LEFT WIDTH=88 HSPACE=4 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=7>
	<COL WIDTH=8>
	<COL WIDTH=8>
	<COL WIDTH=7>
	<TR VALIGN=TOP>
		<TD WIDTH=7 HEIGHT=16 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">1</FONT></P>
		</TD>
		<TD WIDTH=8 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">2</FONT></P>
		</TD>
		<TD WIDTH=8 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">3</FONT></P>
		</TD>
		<TD WIDTH=7 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">4</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=7 HEIGHT=15 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">5</FONT></P>
		</TD>
		<TD WIDTH=8 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">6</FONT></P>
		</TD>
		<TD WIDTH=8 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">7</FONT></P>
		</TD>
		<TD WIDTH=7 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">8</FONT></P>
		</TD>
	</TR>
</TABLE><BR><BR>
</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%"><BR><BR>
</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">Next,
you will receive series of commands, indicating which row or column
you must move, in which direction, and how many times. For example, <B>1
up 1</B> means: column 1, direction: up, 1 move. After executing it,
the matrix should look like:</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%"><TABLE DIR="LTR" ALIGN=LEFT WIDTH=88 HSPACE=4 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=7>
	<COL WIDTH=8>
	<COL WIDTH=8>
	<COL WIDTH=7>
	<TR VALIGN=TOP>
		<TD WIDTH=7 HEIGHT=16 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">1</FONT></P>
		</TD>
		<TD WIDTH=8 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">6</FONT></P>
		</TD>
		<TD WIDTH=8 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">3</FONT></P>
		</TD>
		<TD WIDTH=7 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">4</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=7 HEIGHT=15 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">5</FONT></P>
		</TD>
		<TD WIDTH=8 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">2</FONT></P>
		</TD>
		<TD WIDTH=8 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">7</FONT></P>
		</TD>
		<TD WIDTH=7 STYLE="border: 1px solid #00000a; padding: 0in 0.08in">
			<P CLASS="western"><FONT SIZE=5 STYLE="font-size: 20pt">8</FONT></P>
		</TD>
	</TR>
</TABLE><BR><BR>
</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%"><BR><BR>
</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">Directions
<B>left</B> and <B>right</B> mean you must move the corresponding
<B>row</B>, while <B>up</B> and <B>down</B> and related to the
<B>columns. </B>After shuffling the Rubik’s matrix, you have to
<B>rearrange</B> it (meaning that the <B>values in each cell</B>
should be in <B>increasing order</B>, such as the ones in the
original matrix). The rearranging process should start at <B>top-left</B>
and end at <B>bottom-right</B>. Find the <B>position</B> of the value
you need, and print the <B>swap</B> <B>command</B> on the console, in
the format described below.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Input</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">On the first
	line, you are given the integers <B>R</B> and <B>C</B>, separated by
	a space.</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">On the
	second line, you are given an integer <B>N</B>, indicating the
	number of commands to follow</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">On the next
	N lines, you are given commands in format <B>{row/col} {direction}
	{moves}</B></P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Output</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">On <B>R</B>
	* <B>C</B> number of lines, print the <B>swap commands </B>needed to
	rearrange the matrix, either:</P>
	<UL>
		<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%"><B>Swap
		({row}, {col}) with ({row}, {col})   </B>or</P>
		<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%"><B>No swap
		required</B></P>
	</UL>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Constraints</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%"><B>R, C, N</B>
	are integers in range [1 … 100]</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">{<B>row</B>}
	and {<B>col</B>} will always be inside the matrix</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">{<B>moves</B>}
	is in range [0 … 2<SUP>31</SUP>-1]</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">Allowed time
	and memory: 0.25s / 16 MB</P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=624 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=147>
	<COL WIDTH=148>
	<COL WIDTH=148>
	<COL WIDTH=147>
	<TR VALIGN=TOP>
		<TD WIDTH=147 HEIGHT=11 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=148 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Output</FONT></P>
		</TD>
		<TD WIDTH=148 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=147 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Output</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=147 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">3
			3</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">2</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">1
			down 1</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">1
			left 1</FONT></FONT></P>
		</TD>
		<TD WIDTH=148 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">No
			swap required</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Swap
			(0, 1) with (1, 0)</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">No
			swap required</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Swap
			(1, 0) with (1, 2)</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Swap
			(1, 1) with (2, 1)</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Swap
			(1, 2) with (2, 1)</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">No
			swap required</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">No
			swap required</P>
			<P CLASS="western" ALIGN=JUSTIFY>No swap required</P>
		</TD>
		<TD WIDTH=148 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">3
			3</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">2</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">0
			down 3</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">0
			left 3</FONT></FONT></P>
		</TD>
		<TD WIDTH=147 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">No
			swap required</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">No
			swap required</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">No
			swap required</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">No
			swap required</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">No
			swap required</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">No
			swap required</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">No
			swap required</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">No
			swap required</P>
			<P CLASS="western" ALIGN=JUSTIFY>No swap required</P>
		</TD>
	</TR>
</TABLE>