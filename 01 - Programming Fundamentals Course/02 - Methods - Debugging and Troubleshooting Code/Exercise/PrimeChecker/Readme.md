<P STYLE="margin-top: 0.08in; margin-bottom: 0.06in; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#7c380a"><FONT FACE="Calibri, serif"><FONT SIZE=5><B>Prime
	Checker</B></FONT></FONT></FONT></P>
  
<P STYLE="margin-bottom: 0.14in"><FONT FACE="Calibri, serif">Write a
Boolean method </FONT><FONT FACE="Consolas, serif"><B>Is</B></FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>Prime(n)</B></SPAN></FONT><FONT FACE="Calibri, serif">
that check whether a given integer number </FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>n</B></SPAN></FONT><FONT FACE="Calibri, serif">
is </FONT><A HREF="https://en.wikipedia.org/wiki/Prime_number"><FONT COLOR="#0000ff"><FONT FACE="Calibri, serif"><U>prime</U></FONT></FONT></A><FONT FACE="Calibri, serif">.
Examples:</FONT></P>
<TABLE WIDTH=193 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=99>
	<COL WIDTH=76>
	<TR VALIGN=TOP>
		<TD WIDTH=99 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Calibri, serif"><B>n</B></FONT></P>
		</TD>
		<TD WIDTH=76 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><FONT FACE="Calibri, serif"><B>IsPrime</B><SPAN LANG="bg-BG"><B>(n)</B></SPAN></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">0</FONT></P>
		</TD>
		<TD WIDTH=76 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">false</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">1</FONT></P>
		</TD>
		<TD WIDTH=76 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">false</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">2</FONT></P>
		</TD>
		<TD WIDTH=76 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">true</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">3</FONT></P>
		</TD>
		<TD WIDTH=76 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">true</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">4</FONT></P>
		</TD>
		<TD WIDTH=76 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">false</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">5</FONT></P>
		</TD>
		<TD WIDTH=76 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">true</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">323</FONT></P>
		</TD>
		<TD WIDTH=76 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">false</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">337</FONT></P>
		</TD>
		<TD WIDTH=76 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">true</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">6737626471</FONT></P>
		</TD>
		<TD WIDTH=76 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">true</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">117342557809</FONT></P>
		</TD>
		<TD WIDTH=76 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">false</FONT></P>
		</TD>
	</TR>
</TABLE>