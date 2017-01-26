<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Rounding
	Numbers Away from Zero</SPAN></H2>
<P STYLE="margin-top: 0.06in">Write a program to read <B>an array of
real numbers</B> (space separated values), <B>round</B> them to the
nearest integer in “<B>away from 0</B>” style and <B>print</B>
the output as in the examples below.</P>
<P STYLE="margin-top: 0.06in">Rounding in “<A HREF="https://www.mathsisfun.com/numbers/rounding-methods.html">away
from zero</A>” style means:</P>
<UL>
	<LI><P STYLE="margin-top: 0.06in">To round to the nearest integer,
	e.g. 2.9 <FONT FACE="Wingdings, serif"></FONT> 3; <SPAN LANG="bg-BG">-1.75</SPAN>
	<FONT FACE="Wingdings, serif"></FONT> <SPAN LANG="bg-BG">-2</SPAN></P>
	<LI><P STYLE="margin-top: 0.06in">In case the number is exactly in
	the middle of two integers (midpoint value), round it to the next
	integer which is away from the 0:</P>
</UL>
<P ALIGN=CENTER STYLE="margin-top: 0.06in"><IMG SRC="i_1180bccb40deaf7f_html_15894ab4.gif" NAME="Picture 5" ALIGN=BOTTOM WIDTH=438 HEIGHT=83 BORDER=0></P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=337 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=212>
	<COL WIDTH=107>
	<TR>
		<TD WIDTH=212 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=107 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=212 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">0.9 1.5 2.4 2.5
			3.14</SPAN></FONT></P>
		</TD>
		<TD WIDTH=107 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">0.9 =&gt;
			1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">1.5
			=&gt; 2</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">2.4
			=&gt; 2</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">2.5
			=&gt; 3</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">3.14 =&gt; 3</SPAN></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=212 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">-5.01 -1.599 -2.5 -1.50 0</FONT></P>
		</TD>
		<TD WIDTH=107 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-5.01
			=&gt; -5</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">-1.599
			=&gt; -2</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">-2.5
			=&gt; -3</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">-1.50
			=&gt; -2</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">0 =&gt; 0</SPAN></FONT></P>
		</TD>
	</TR>
</TABLE>