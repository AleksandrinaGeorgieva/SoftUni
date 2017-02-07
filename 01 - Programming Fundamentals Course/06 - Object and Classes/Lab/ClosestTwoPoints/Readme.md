<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Closest Two
	Points</SPAN></H2>

<P STYLE="margin-top: 0.06in">Write a program to read <B>n </B>points
and find the <B>closest two</B> of them.</P>
<H3 CLASS="western">Input</H3>
<P STYLE="margin-top: 0.06in">The <B>input</B> holds the number of
points <FONT FACE="Consolas, serif"><B>n</B></FONT> and <FONT FACE="Consolas, serif"><B>n</B></FONT>
lines, each holding a point {<FONT FACE="Consolas, serif"><B>X</B></FONT>
and <FONT FACE="Consolas, serif"><B>Y</B></FONT> coordinate}.</P>
<H3 CLASS="western">Output</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">The <B>output</B> holds the
	shortest distance and the closest two points.</P>
	<LI><P STYLE="margin-top: 0.06in">If several pairs of points are
	equally close, print <B>the first</B> of them (from top to bottom). 
	</P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=688 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=59>
	<COL WIDTH=68>
	<COL WIDTH=243>
	<COL WIDTH=284>
	<TR VALIGN=TOP>
		<TD WIDTH=59 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=68 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=243 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Visualization</B></P>
		</TD>
		<TD WIDTH=284 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=59 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0.04in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">4</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">3
			4</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">6
			8</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">2
			5</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">-1 3</SPAN></FONT></P>
		</TD>
		<TD WIDTH=68 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0.04in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">1.414</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">(3,
			4)</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">(2, 5)</SPAN></FONT></P>
		</TD>
		<TD WIDTH=243 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><IMG SRC="i_06150e0ccd5c2c1c_html_e79a7217.png" NAME="Picture 226" ALIGN=BOTTOM WIDTH=226 HEIGHT=214 BORDER=0></P>
		</TD>
		<TD WIDTH=284 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P>The closest two points are <B>{3, 4}</B> and <B>{2, 5}</B> at
			distance 1.4142135623731 ≈ <B>1.414</B>.</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=59 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0.04in"><FONT FACE="Consolas, serif">3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">12
			-30</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">6
			18</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">6 18</SPAN></FONT></P>
		</TD>
		<TD WIDTH=68 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0.04in"><FONT FACE="Consolas, serif">0.000</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">(6,
			18)</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">(6, 18)</SPAN></FONT></P>
		</TD>
		<TD WIDTH=243 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><IMG SRC="i_06150e0ccd5c2c1c_html_5e4cb5fb.png" NAME="Picture 227" ALIGN=BOTTOM WIDTH=188 HEIGHT=236 BORDER=0></P>
		</TD>
		<TD WIDTH=284 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P>Two of the points have the same coordinates <B>{6, 18}</B>, so
			the distance between them is <B>0</B>.</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=59 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0.04in"><FONT FACE="Consolas, serif">3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2 2</FONT></P>
			<P><FONT FACE="Consolas, serif">3 3</FONT></P>
		</TD>
		<TD WIDTH=68 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0.04in"><FONT FACE="Consolas, serif">1.414</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">(1, 1)</FONT></P>
			<P><FONT FACE="Consolas, serif">(2, 2)</FONT></P>
		</TD>
		<TD WIDTH=243 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><IMG SRC="i_06150e0ccd5c2c1c_html_b6017255.png" NAME="Picture 228" ALIGN=BOTTOM WIDTH=216 HEIGHT=170 BORDER=0></P>
		</TD>
		<TD WIDTH=284 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P>The pairs of points {{1, 1}, {2, 2}} and {{2,2}, {3,3}} stay at
			the same distance, but the first pair is {<B>{1, 1}</B>, <B>{2,
			2}</B>}. The distance between them is 1.4142135623731 ≈ <B>1.414</B>.</P>
		</TD>
	</TR>
</TABLE>