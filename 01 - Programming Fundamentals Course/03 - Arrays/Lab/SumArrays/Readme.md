<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Sum Arrays</SPAN></H2>

<P STYLE="margin-top: 0.06in">Write a program that reads two <B>arrays
of integers</B> and sums them. When the arrays are not of the same
size, duplicate the smaller array a few times.</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=292 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=83>
	<COL WIDTH=84>
	<COL WIDTH=99>
	<TR>
		<TD WIDTH=83 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=84 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=99 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=83 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 2 3 4</FONT></P>
			<P><FONT FACE="Consolas, serif">2 3 4 5</FONT></P>
		</TD>
		<TD WIDTH=84 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3 5 7 9</FONT></P>
			<P><BR>
			</P>
		</TD>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 2 3 4
			+</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2 3 4 5
			=</FONT></P>
			<P><FONT FACE="Consolas, serif">3 5 7 9</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=83 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 2 3 4
			5</FONT></P>
			<P><FONT FACE="Consolas, serif">2 3</FONT></P>
		</TD>
		<TD WIDTH=84 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3 5 5 7
			7</FONT></P>
			<P><BR>
			</P>
		</TD>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 2 3 4
			5 +</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2 3 </FONT><FONT COLOR="#7f7f7f"><FONT FACE="Consolas, serif">2
			3 2 </FONT></FONT><FONT FACE="Consolas, serif">=</FONT></P>
			<P><FONT FACE="Consolas, serif">3 5 5 7 7</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=83 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">5 4 3</FONT></P>
			<P><FONT FACE="Consolas, serif">2 3 1 4</FONT></P>
		</TD>
		<TD WIDTH=84 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">7 7 4 9</FONT></P>
			<P ALIGN=CENTER><BR>
			</P>
		</TD>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">5 4 3</FONT><FONT COLOR="#7f7f7f"><FONT FACE="Consolas, serif">
			5 </FONT></FONT><FONT FACE="Consolas, serif">+</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2 3 1 4
			+</FONT></P>
			<P><FONT FACE="Consolas, serif">7 7 4 9</FONT></P>
		</TD>
	</TR>
</TABLE>