<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Condense
	Array to Number</SPAN></H2>

<P STYLE="margin-top: 0.06in">Write a program to read <B>an array of
integers</B> and <B>condense</B> them by <B>summing</B> adjacent
couples of elements until a <B>single integer</B> is obtained. For
example, if we have 3 elements {2, 10, 3}, we sum the first two and
the second two elements and obtain {2+10, 10+3} = {12, 13}, then we
sum again all adjacent elements and obtain {12+13} = {25}.</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=688 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=83>
	<COL WIDTH=54>
	<COL WIDTH=525>
	<TR>
		<TD WIDTH=83 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=54 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=525 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=83 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">2 10 3</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">25</FONT></P>
		</TD>
		<TD WIDTH=525 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">2 10 3 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			2+10 10+3 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			12 13 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			12 + 13 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			25</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=83 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">5 0 4 1 2</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">35</FONT></P>
		</TD>
		<TD WIDTH=525 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">5 0 4 1 2 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			5+0 0+4 4+1 1+2 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			5 4 5 3 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			5+4 4+5 5+3 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			9 9 8 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			9+9 9+8 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			18 17 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			18+17 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			35</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=83 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">1</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">1</FONT></P>
		</TD>
		<TD WIDTH=525 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">1</FONT> is already condensed to
			number</P>
		</TD>
	</TR>
</TABLE>