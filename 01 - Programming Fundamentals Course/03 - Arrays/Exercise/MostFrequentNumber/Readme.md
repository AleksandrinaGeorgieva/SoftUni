<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Most
	Frequent Number</SPAN></H2>

<P STYLE="margin-top: 0.06in">Write a program that finds the <B>most
frequent number</B> in a given sequence of numbers. 
</P>
<UL>
	<LI><P STYLE="margin-top: 0.06in">Numbers will be in the range
	[0…<FONT COLOR="#222222"><SPAN STYLE="background: #ffffff">65535].</SPAN></FONT></P>
	<LI><P STYLE="margin-top: 0.06in"><FONT COLOR="#222222"><SPAN STYLE="background: #ffffff">In
	case of multiple numbers with the same maximal frequency, print the
	leftmost of them.</SPAN></FONT></P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=699 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=207>
	<COL WIDTH=54>
	<COL WIDTH=413>
	<TR VALIGN=TOP>
		<TD WIDTH=207 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=54 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=413 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=207 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><B>4</B></FONT><FONT FACE="Consolas, serif">
			1 1 </FONT><FONT FACE="Consolas, serif"><B>4</B></FONT><FONT FACE="Consolas, serif">
			2 3 </FONT><FONT FACE="Consolas, serif"><B>4 4</B></FONT><FONT FACE="Consolas, serif">
			1 2 </FONT><FONT FACE="Consolas, serif"><B>4</B></FONT><FONT FACE="Consolas, serif">
			9 3</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">4</FONT></P>
		</TD>
		<TD WIDTH=413 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">The number </FONT><FONT FACE="Consolas, serif"><B>4</B></FONT><FONT FACE="Consolas, serif">
			is the most frequent (occurs 5 times)</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=207 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><B>2 2 2 2</B></FONT><FONT FACE="Consolas, serif">
			1 </FONT><FONT FACE="Consolas, serif"><B>2 2 2</B></FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">2</FONT></P>
		</TD>
		<TD WIDTH=413 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">The number </FONT><FONT FACE="Consolas, serif"><B>2</B></FONT><FONT FACE="Consolas, serif">
			is the most frequent (occurs 7 times)</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=207 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><B>7 7 7</B></FONT><FONT FACE="Consolas, serif">
			0 2 2 2 0 10 10 10</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">7</FONT></P>
		</TD>
		<TD WIDTH=413 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">The numbers </FONT><FONT FACE="Consolas, serif"><B>2</B></FONT><FONT FACE="Consolas, serif">,
			</FONT><FONT FACE="Consolas, serif"><B>7</B></FONT><FONT FACE="Consolas, serif">
			and </FONT><FONT FACE="Consolas, serif"><B>10</B></FONT><FONT FACE="Consolas, serif">
			have the same maximal frequence (each occurs 3 times). The
			leftmost of them is </FONT><FONT FACE="Consolas, serif"><B>7</B></FONT><FONT FACE="Consolas, serif">.</FONT></P>
		</TD>
	</TR>
</TABLE>