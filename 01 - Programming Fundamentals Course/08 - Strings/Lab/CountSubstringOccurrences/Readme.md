<H2 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
	Count substring occurrences</H2>

<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="line-height: 0.24in">
<SPAN LANG="en-US">Write a program to </SPAN><SPAN LANG="en-US"><B>find
how many times a given string appears in a given text as substring</B></SPAN><SPAN LANG="en-US">.
The text is given at the first input line. The search string is given
at the second input line. The output is an integer number. Please
ignore the </SPAN><SPAN LANG="en-US"><B>character casing</B></SPAN><SPAN LANG="en-US">.
</SPAN><SPAN LANG="en-US"><B>Overlapping</B></SPAN><SPAN LANG="en-US">
between occurrences is </SPAN><SPAN LANG="en-US"><B>allowed</B></SPAN><SPAN LANG="en-US">.
Examples:</SPAN></P>
<TABLE WIDTH=688 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=607>
	<COL WIDTH=62>
	<TR VALIGN=TOP>
		<TD WIDTH=607 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=CENTER><SPAN LANG="en-US"><B>Input</B></SPAN></P>
		</TD>
		<TD WIDTH=62 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=CENTER STYLE="margin-left: -0.06in">
			<SPAN LANG="en-US"><B>Output</B></SPAN></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=607 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B>Wel</B></SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="en-US">come
			to the Software University (SoftUni)! </SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B>Wel</B></SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="en-US">come
			to programming. Programming is </SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B>wel</B></SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="en-US">lness
			for developers, said Max</SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B>wel</B></SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="en-US">l.</SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><SPAN LANG="en-US">wel</SPAN></FONT></P>
		</TD>
		<TD WIDTH=62 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">4</SPAN></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=607 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B>aaaaaa</B></SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><SPAN LANG="en-US">aa</SPAN></FONT></P>
		</TD>
		<TD WIDTH=62 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><SPAN LANG="en-US">5</SPAN></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=607 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B>ababa</B></SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="en-US">
			c</SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B>aba</B></SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><SPAN LANG="en-US">aba</SPAN></FONT></P>
		</TD>
		<TD WIDTH=62 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><SPAN LANG="en-US">3</SPAN></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=607 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">Welcome to SoftUni</SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Java</SPAN></FONT></P>
		</TD>
		<TD WIDTH=62 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><SPAN LANG="en-US">0</SPAN></FONT></P>
		</TD>
	</TR>
</TABLE>