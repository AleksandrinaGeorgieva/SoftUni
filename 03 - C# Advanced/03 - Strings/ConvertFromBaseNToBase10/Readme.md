<H2 CLASS="western">Convert from base-N to base-10</H2>

<P STYLE="margin-bottom: 0.14in; line-height: 115%">Write a program
that takes a base-N number and converts it to a base-10 number<FONT COLOR="#ff0000">
</FONT>(0 to 10<SUP>50</SUP>), where 2 &lt;= N &lt;= 10.<BR>The input
consists of 1 line containing two numbers separated by a single
space. The first number is the base N to which you have to convert.
The second one is the base N number to be converted. <B>Do not use
any built in converting functionality, try to write your own
algorithm.</B></P>
<H3 CLASS="western">Hints</H3>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">See <A HREF="http://4.bp.blogspot.com/-_ozWsmbO7-g/VMj49QivTWI/AAAAAAAACbg/b5BxEpJqAQ4/s1600/Algorithm%2Bto%2Bconvert%2BBinary%2Bto%2BDecimal%2Bin%2BJava.gif">this</A>
picture for more clarity about base-2 to base-10. Again the algorithm
for N-base is similar.</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=150 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=65>
	<COL WIDTH=67>
	<TR>
		<TD WIDTH=65 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Base-N</B></P>
		</TD>
		<TD WIDTH=67 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Base-10</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">7 13</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">10</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">3 12201</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">154</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">5 443</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">123</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">4 33220</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">1000</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">9 4704</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">3487</FONT></P>
		</TD>
	</TR>
</TABLE>