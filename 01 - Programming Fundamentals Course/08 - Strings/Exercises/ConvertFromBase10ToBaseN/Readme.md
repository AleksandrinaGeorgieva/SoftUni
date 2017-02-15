<H2 CLASS="western">Convert from base-10 to base-N</H2>

<P STYLE="margin-bottom: 0.14in; line-height: 115%">Write a program
that takes a base-10 number (0 to 10<SUP>50</SUP>)<FONT COLOR="#ff0000">
</FONT>and converts it to a base-N number, where 2 &lt;= N &lt;=
10.<BR>The input consists of 1 line containing two numbers separated
by a single space. The first number is the base N to which you have
to convert. The second one is the base 10 number to be converted. <B>Do
not use any built in converting functionality, try to write your own
algorithm.</B></P>
<H3 CLASS="western">Hints</H3>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">About the
algorithm (from base-10 to base-2) you can read this <A HREF="https://interactivepython.org/runestone/static/pythonds/BasicDS/ConvertingDecimalNumberstoBinaryNumbers.html">article</A>.</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">The algorithm for
converting from base-10 to base-N is similar: instead of “ % 2”,
use “% N”.</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=150 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=65>
	<COL WIDTH=67>
	<TR>
		<TD WIDTH=65 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Base-10</B></P>
		</TD>
		<TD WIDTH=67 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Base-N</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">7 10</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">13</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">3 154</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">12201</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">5 123</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">443</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">4 1000</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">33220</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">9 3487</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">4704</FONT></P>
		</TD>
	</TR>
</TABLE>