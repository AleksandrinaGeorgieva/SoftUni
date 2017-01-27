<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Fold and Sum</SPAN>
		</H2>

<P STYLE="margin-top: 0.06in">Read an array of <B>4*k</B> integers,
fold it like shown below, and print the sum of the upper and lower
two rows (each holding 2 * k integers):</P>
<P ALIGN=CENTER STYLE="margin-top: 0.06in; margin-bottom: 0in"><IMG SRC="i_4f07e5111275acac_html_b94b2c26.png" NAME="Picture 5" ALIGN=BOTTOM WIDTH=231 HEIGHT=175 BORDER=0></P>
<H3 CLASS="western" STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=534 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=212>
	<COL WIDTH=124>
	<COL WIDTH=172>
	<TR VALIGN=TOP>
		<TD WIDTH=212 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=124 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=172 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=212 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">5 </FONT><FONT FACE="Consolas, serif"><B>2
			3</B></FONT><FONT FACE="Consolas, serif"> 6</FONT></P>
		</TD>
		<TD WIDTH=124 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">7 9</FONT></P>
		</TD>
		<TD WIDTH=172 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">5  6  +</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2  3  =</FONT></P>
			<P><FONT FACE="Consolas, serif">7  9</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=212 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">1 2 </FONT><FONT FACE="Consolas, serif"><B>3
			4 5 6</B></FONT><FONT FACE="Consolas, serif"> 7 8</FONT></P>
		</TD>
		<TD WIDTH=124 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">5 5 13 13</FONT></P>
		</TD>
		<TD WIDTH=172 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2  1  8
			 7  +</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3  4  5
			 6  =</FONT></P>
			<P><FONT FACE="Consolas, serif">5  5 13 13</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=212 HEIGHT=11 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">4 3 -1 </FONT><FONT FACE="Consolas, serif"><B>2
			5 0 1 9 8</B></FONT><FONT FACE="Consolas, serif"> 6 7 -2</FONT></P>
		</TD>
		<TD WIDTH=124 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">1 8 4 -1 16 14</FONT></P>
		</TD>
		<TD WIDTH=172 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-1  3 
			4 -2  7  6  +</FONT></P>
			<P STYLE="margin-bottom: 0in"> <FONT FACE="Consolas, serif">2  5 
			0  1  9  8  =</FONT></P>
			<P> <FONT FACE="Consolas, serif">1  8  4 -1 16 14</FONT></P>
		</TD>
	</TR>
</TABLE>