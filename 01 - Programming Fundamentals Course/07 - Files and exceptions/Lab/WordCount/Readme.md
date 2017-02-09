<H2 CLASS="western" ALIGN=JUSTIFY>Word Count</H2>

<P STYLE="margin-bottom: 0.14in">Write a program that reads a list of
words from the file <FONT FACE="Courier New, serif"><FONT SIZE=2><FONT FACE="Calibri, serif"><FONT SIZE=2 STYLE="font-size: 11pt"><B>words.txt</B></FONT></FONT></FONT></FONT>
and finds how many times each of the words is contained in another
file <FONT FACE="Courier New, serif"><FONT SIZE=2><FONT FACE="Calibri, serif"><FONT SIZE=2 STYLE="font-size: 11pt"><B>text.txt</B></FONT></FONT></FONT></FONT><FONT FACE="Courier New, serif"><FONT SIZE=2><FONT FACE="Calibri, serif"><FONT SIZE=2 STYLE="font-size: 11pt">.
Matching should be </FONT></FONT></FONT></FONT><FONT FACE="Courier New, serif"><FONT SIZE=2><FONT FACE="Calibri, serif"><FONT SIZE=2 STYLE="font-size: 11pt"><B>case-insensitive</B></FONT></FONT></FONT></FONT><FONT FACE="Courier New, serif"><FONT SIZE=2><FONT FACE="Calibri, serif"><FONT SIZE=2 STYLE="font-size: 11pt">.</FONT></FONT></FONT></FONT></P>
<P STYLE="margin-bottom: 0.14in">The result should be written to
another text file. <FONT FACE="Courier New, serif"><FONT SIZE=2><FONT FACE="Calibri, serif"><FONT SIZE=2 STYLE="font-size: 11pt">Sort
the words by frequency in descending order. </FONT></FONT></FONT></FONT>
</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=468 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=99>
	<COL WIDTH=244>
	<COL WIDTH=81>
	<TR VALIGN=TOP>
		<TD WIDTH=99 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=CENTER STYLE="margin-top: 0.03in"><B>words.txt</B></P>
		</TD>
		<TD WIDTH=244 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=CENTER STYLE="margin-top: 0.03in"><B>Input.txt</B></P>
		</TD>
		<TD WIDTH=81 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=CENTER STYLE="margin-top: 0.03in"><B>Output.txt</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-bottom: 0in">quick<SPAN LANG="bg-BG"> </SPAN>is
			fault</P>
			<P><BR>
			</P>
		</TD>
		<TD WIDTH=244 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-bottom: 0in">-I was quick to judge him, but it
			wasn't his fault.</P>
			<P STYLE="margin-bottom: 0in">-Is this some kind of joke?! Is it?</P>
			<P>-Quick, hide here…It is safer.</P>
		</TD>
		<TD WIDTH=81 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-bottom: 0in">is - 3</P>
			<P STYLE="margin-bottom: 0in">quick - 2</P>
			<P>fault - 1</P>
		</TD>
	</TR>
</TABLE>