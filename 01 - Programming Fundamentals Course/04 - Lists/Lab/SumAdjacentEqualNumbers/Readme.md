<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Sum Adjacent
	Equal Numbers</SPAN></H2>

<P STYLE="margin-top: 0.06in">Write a program to <B>sum all adjacent
equal numbers</B> in a list of decimal numbers, starting from <B>left
to right</B>.</P>
<UL>
	<LI><P STYLE="margin-top: 0.06in">After two numbers are summed, the
	obtained result could be equal to some of its neighbors and should
	be summed as well (see the examples below).</P>
	<LI><P STYLE="margin-top: 0.06in">Always sum the <B>leftmost</B> two
	equal neighbors (if several couples of equal neighbors are
	available).</P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=594 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=101>
	<COL WIDTH=66>
	<COL WIDTH=400>
	<TR VALIGN=TOP>
		<TD WIDTH=101 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=66 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=400 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Explanation</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=101 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">3 3 6 1</SPAN></FONT></P>
		</TD>
		<TD WIDTH=66 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">12 1</FONT></P>
		</TD>
		<TD WIDTH=400 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><B>3 3</B></FONT><FONT FACE="Consolas, serif">
			6 1 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><B>6 6</B></FONT><FONT FACE="Consolas, serif">
			1 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			12 1</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=101 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">8 2 2 4 8 16</FONT></P>
		</TD>
		<TD WIDTH=66 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">16 8 16</FONT></P>
		</TD>
		<TD WIDTH=400 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">8 </FONT><FONT FACE="Consolas, serif"><B>2
			2</B></FONT><FONT FACE="Consolas, serif"> 4 8 16 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			8 </FONT><FONT FACE="Consolas, serif"><B>4 4</B></FONT><FONT FACE="Consolas, serif">
			8 16 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><B>8 8</B></FONT><FONT FACE="Consolas, serif">
			8 16 </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			16 8 16</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=101 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">5 4 2 1 1 4</SPAN></FONT></P>
		</TD>
		<TD WIDTH=66 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">5 8 4</SPAN></FONT></P>
		</TD>
		<TD WIDTH=400 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">5 4 2 </SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>1
			1</B></SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">
			4</SPAN></FONT><FONT FACE="Consolas, serif"> </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">5 4 </SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>2
			</B></SPAN></FONT><FONT FACE="Consolas, serif"><B>2</B></FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">
			4</SPAN></FONT><FONT FACE="Consolas, serif"> </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">5 </SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>4
			</B></SPAN></FONT><FONT FACE="Consolas, serif"><B>4</B></FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">
			4</SPAN></FONT><FONT FACE="Consolas, serif"> </FONT><FONT FACE="Wingdings, serif"></FONT><FONT FACE="Consolas, serif">
			5 8 4</FONT></P>
		</TD>
	</TR>
</TABLE>