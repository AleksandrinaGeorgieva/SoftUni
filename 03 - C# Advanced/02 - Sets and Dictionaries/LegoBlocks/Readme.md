<OL START=14>
	<LI><H2 CLASS="western" STYLE="margin-top: 0in; margin-bottom: 0.08in; line-height: 100%; page-break-before: always">
	Lego Blocks</H2>
</OL>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">You
are given two <B>jagged arrays</B>. Each array represents a <B>Lego
block </B>containing integers. Your task is first to <B>reverse</B>
the second jagged array and then check if it would <B>fit perfectly</B>
in the first jagged array.<FONT SIZE=3> 
<IMG SRC="i_284cac0dc310a993_html_11ec2c61.png" NAME="Picture 9" ALIGN=BOTTOM WIDTH=696 HEIGHT=161 BORDER=0></FONT></P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%"><FONT SIZE=3>The
picture above shows exactly what fitting arrays mean. If the arrays
fit perfectly you should </FONT><FONT SIZE=3><B>print out</B></FONT><FONT SIZE=3>
the newly made rectangular matrix. If the arrays do not match (they
do not form a rectangular matrix) you should print out the </FONT><FONT SIZE=3><B>number
of cells</B></FONT><FONT SIZE=3> in the first array and in the second
array combined. The examples below should help you understand more
the assignment.</FONT></P>
<H3 CLASS="western">Input</H3>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">The
first line of the input comes as an <B>integer</B> <B>number n </B>saying
how many rows are there in both arrays. Then you have <B>2 * n</B>
lines of numbers separated by whitespace(s). The first <B>n </B>lines
are the rows of the first jagged array; the next <B>n </B>lines are
the rows of the second jagged array. There might be leading and/or
trailing whitespace(s).</P>
<H3 CLASS="western">Output</H3>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">You
should print out the combined matrix in the format:<BR><FONT FACE="Consolas, serif"><B>[</B></FONT><FONT FACE="Consolas, serif"><I><B>elem,
elem, …, elem</B></I></FONT><FONT FACE="Consolas, serif"><B>]<BR>[</B></FONT><FONT FACE="Consolas, serif"><I><B>elem,
elem, …, elem</B></I></FONT><FONT FACE="Consolas, serif"><B>]<BR>[</B></FONT><FONT FACE="Consolas, serif"><I><B>elem,
elem, …, elem</B></I></FONT><FONT FACE="Consolas, serif"><B>]</B></FONT><B><BR></B>If
the two arrays do not fit you should print out : <FONT FACE="Consolas, serif"><B>The
total number of cells is: </B></FONT><FONT FACE="Consolas, serif"><I><B>count</B></I></FONT></P>
<H3 CLASS="western">Constraints</H3>
<UL>
	<LI><P CLASS="western" STYLE="margin-bottom: 0in; line-height: 100%">
	The number n will be in the range [2…10].</P>
	<LI><P CLASS="western" STYLE="margin-bottom: 0in; line-height: 100%">
	Time limit: 0.3 sec. Memory limit: 16 MB.</P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=690 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=492>
	<COL WIDTH=180>
	<TR VALIGN=TOP>
		<TD WIDTH=492 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=180 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P CLASS="western" ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=492 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2</FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1
			1 1 1 1 1</FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2
			1 1 3</FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1
			1</FONT></P>
			<P CLASS="western"><FONT FACE="Consolas, serif">2 2 2 3</FONT></P>
		</TD>
		<TD WIDTH=180 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>[1,
			1, 1, 1, 1, 1, 1, 1]</FONT></FONT></FONT></P>
			<P CLASS="western"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>[2,
			1, 1, 3, 3, 2, 2, 2]</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=492 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2</FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1
			1 1 1 1</FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1
			1 1</FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1</FONT></P>
			<P CLASS="western"><FONT FACE="Consolas, serif">1 1 1 1 1</FONT></P>
		</TD>
		<TD WIDTH=180 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P CLASS="western"><FONT FACE="Consolas, serif">The total number
			of cells is: 14</FONT></P>
		</TD>
	</TR>
</TABLE>