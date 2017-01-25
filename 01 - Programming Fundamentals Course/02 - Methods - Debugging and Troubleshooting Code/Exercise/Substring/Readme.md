<H2 CLASS="western">Debugging Exercise: Substring</H2>
  
<P STYLE="margin-top: 0.06in">The goal of this exercise is to
practice <B>debugging techniques </B>in scenarios where a piece of
code does not work correctly. Your task is to <B>pinpoint the bug</B>
and <B>fix it</B> (without rewriting the entire code). Test your
fixed solution in the judge system: 
</P>
<P STYLE="margin-top: 0.06in"><A NAME="_GoBack"></A>You can download
the broken solution from <A HREF="https://softuni.bg/downloads/svn/soft-tech/Sep-2016/Programming-Fundamentals-Sep-2016/03.%20Programming-Fundamentals-Methods-Debugging-and-Troubleshooting-Code/03.%20Programming-Fundamentals-Methods-and-Debugging-Exercises-Broken-Solutions.zip">here</A>.</P>
<H3 CLASS="western">Problem Description</H3>
<P STYLE="line-height: 100%"><FONT COLOR="#000000"><FONT FACE="Calibri, serif"><FONT SIZE=3><FONT SIZE=2 STYLE="font-size: 11pt">You
are given a </FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>text </B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">and
a number </FONT><FONT FACE="Consolas, serif"><B><FONT SIZE=2 STYLE="font-size: 11pt">count</FONT></B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">.
Your program should search through the text for the letter '</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>p</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">'
(ASCII code </FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>112</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">)
and print '</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>p</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">'
along with </FONT><FONT FACE="Consolas, serif"><B><FONT SIZE=2 STYLE="font-size: 11pt">count</FONT></B></FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>
</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">letters to its right.</FONT></FONT></FONT></FONT></P>
<P STYLE="line-height: 100%"><FONT COLOR="#000000"><FONT FACE="Calibri, serif"><FONT SIZE=3><FONT SIZE=2 STYLE="font-size: 11pt">For
example, we are given the </FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>text</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">
&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>phahah put</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;
and </FONT><FONT FACE="Consolas, serif"><B><FONT SIZE=2 STYLE="font-size: 11pt">count</FONT></B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">
= </FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>3</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">.
We find a match of '</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>p</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">'
in the first letter so we print it and the 3 letters to its right.
The result is &quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>phah</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;.
We continue and find another match of '</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>p</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">',
but there aren't 3 letters to its right, so we print only &quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>put</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;.
</FONT></FONT></FONT></FONT>
</P>
<P STYLE="line-height: 100%"><FONT COLOR="#000000"><FONT FACE="Calibri, serif"><FONT SIZE=3><FONT SIZE=2 STYLE="font-size: 11pt">Each
match should be printed on a separate line. If there are no matches
of '</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>p</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">'
in the text, we print &quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>no</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;.</FONT></FONT></FONT></FONT></P>
<H3 CLASS="western">Input</H3>
<UL>
	  <P STYLE="margin-top: 0.06in">The first line holds the <B>text</B>
	to be processed (string).</P>
	  <P STYLE="margin-top: 0.06in">The second line holds the <B>number
	</B><FONT FACE="Consolas, serif"><B>count</B></FONT>.</P>
</UL>
<H3 CLASS="western">Output</H3>
<P STYLE="margin-top: 0.06in">For each match, print the <B>matched
substring</B> at separate line. Print &quot;<B>no</B>&quot; if there
are no matches.</P>
<H3 CLASS="western">Constraints</H3>
<UL>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">The
	number <FONT FACE="Consolas, serif"><B>count</B></FONT><B> </B>will
	be in the range [0 ... 100].</P>
</UL>
<H3 CLASS="western">Tests</H3>
<TABLE WIDTH=456 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=159>
	<COL WIDTH=130>
	<COL WIDTH=123>
	<TR VALIGN=TOP>
		<TD WIDTH=159 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.06in"><B>Input</B></P>
		</TD>
		<TD WIDTH=130 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.06in"><B>Program Output</B></P>
		</TD>
		<TD WIDTH=123 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.06in"><B>Expected Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=159 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>phahah
			put</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>3</FONT></FONT></P>
		</TD>
		<TD WIDTH=130 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>no</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=123 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>phah</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>put</FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=159 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>No
			match</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>5</FONT></FONT></P>
		</TD>
		<TD WIDTH=130 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>no</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><BR>
			</P>
		</TD>
		<TD WIDTH=123 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>no</FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=159 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>preparation</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>4</FONT></FONT></P>
		</TD>
		<TD WIDTH=130 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>no</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=123 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>prepa</FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=159 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>preposition</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>0</FONT></FONT></P>
		</TD>
		<TD WIDTH=130 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>no</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=123 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>P</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>p</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>