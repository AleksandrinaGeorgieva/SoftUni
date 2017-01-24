<P STYLE="margin-top: 0.08in; margin-bottom: 0.06in; page-break-inside: avoid; page-break-after: avoid">
	<FONT COLOR="#7c380a"><FONT FACE="Calibri, serif"><FONT SIZE=5><B>Fibonacci
	Numbers</B></FONT></FONT></FONT></P>
  
<P STYLE="margin-bottom: 0.14in"><FONT FACE="Calibri, serif">Define a
method </FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>Fib(n)</B></SPAN></FONT><FONT FACE="Calibri, serif">
that calculates the n</FONT><SUP><FONT FACE="Calibri, serif">th</FONT></SUP><FONT FACE="Calibri, serif">
</FONT><A HREF="https://en.wikipedia.org/wiki/Fibonacci_number"><FONT COLOR="#0000ff"><FONT FACE="Calibri, serif"><U>Fibonacci
number</U></FONT></FONT></A><FONT FACE="Calibri, serif">. Examples:</FONT></P>
<TABLE WIDTH=111 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=35>
	<COL WIDTH=59>
	<TR VALIGN=TOP>
		<TD WIDTH=35 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Calibri, serif"><B>n</B></FONT></P>
		</TD>
		<TD WIDTH=59 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Calibri, serif"><SPAN LANG="bg-BG"><B>Fib(n)</B></SPAN></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=35 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">0</FONT></P>
		</TD>
		<TD WIDTH=59 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">1</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=35 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">1</FONT></P>
		</TD>
		<TD WIDTH=59 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">1</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=35 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">2</FONT></P>
		</TD>
		<TD WIDTH=59 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">2</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=35 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">3</FONT></P>
		</TD>
		<TD WIDTH=59 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">3</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=35 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">4</FONT></P>
		</TD>
		<TD WIDTH=59 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">5</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=35 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">5</FONT></P>
		</TD>
		<TD WIDTH=59 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">8</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=35 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">6</FONT></P>
		</TD>
		<TD WIDTH=59 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">13</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=35 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">11</FONT></P>
		</TD>
		<TD WIDTH=59 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">144</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=35 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">25</FONT></P>
		</TD>
		<TD WIDTH=59 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Consolas, serif">121393</FONT></P>
		</TD>
	</TR>
</TABLE>