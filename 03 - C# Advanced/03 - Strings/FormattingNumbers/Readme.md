<OL START=3>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY>Formatting Numbers</H2>
</OL>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">Write a program
that reads 3 numbers (separated by whitespace): an integer <FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>a</B></SPAN></FONT>
(0 ≤ <FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>a</B></SPAN></FONT>
≤ 2222), a floating-point <FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>b</B></SPAN></FONT>
and a floating-point <FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>c</B></SPAN></FONT>
and <B>prints them in 4 virtual columns</B>&nbsp;on the console. Each
column should have a width of 10 characters. The number <FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>a</B></SPAN></FONT>
should be printed in&nbsp;<B>hexadecimal, left aligned</B>; then the
number <FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>a</B></SPAN></FONT>
should be printed in binary form, padded with zeroes (if it is bigger
than 10 bits remove the least significant ones), then the number <FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>b</B></SPAN></FONT>
should be&nbsp;<B>printed with 2 digits after the decimal point,
right aligned</B>; the number <FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>c</B></SPAN></FONT>
should be <B>printed with 3 digits after the decimal point, left
aligned</B>.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=608 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=65>
	<COL WIDTH=68>
	<COL WIDTH=67>
	<COL WIDTH=373>
	<TR>
		<TD WIDTH=65 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>a</B></P>
		</TD>
		<TD WIDTH=68 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>b</B></P>
		</TD>
		<TD WIDTH=67 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>c</B></P>
		</TD>
		<TD WIDTH=373 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>result</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">254</FONT></P>
		</TD>
		<TD WIDTH=68 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">11.6</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">0.5</FONT></P>
		</TD>
		<TD WIDTH=373 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">|FE       
			|0011111110|     11.60|0.500     |</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">499</FONT></P>
		</TD>
		<TD WIDTH=68 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">-0.5559</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">10000</FONT></P>
		</TD>
		<TD WIDTH=373 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">|1F3      
			|0111110011|     -0.56|10000.000 |</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">0</FONT></P>
		</TD>
		<TD WIDTH=68 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">3</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">-0.1234</FONT></P>
		</TD>
		<TD WIDTH=373 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">|0        
			|0000000000|      3.00|-0.123    |</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=65 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">444</FONT></P>
		</TD>
		<TD WIDTH=68 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">-7.5</FONT></P>
		</TD>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">7.5</FONT></P>
		</TD>
		<TD WIDTH=373 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">|1BC      
			|0110111100|     -7.50|7.500     |</FONT></P>
		</TD>
	</TR>
</TABLE>