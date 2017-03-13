<OL START=5>
	<LI><P CLASS="western" STYLE="margin-top: 0.08in; margin-bottom: 0.06in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
	<FONT COLOR="#7c380a"><FONT FACE="Calibri, serif"><FONT SIZE=5><B>Calculate
	Sequence with Queue</B></FONT></FONT></FONT></P>
</OL>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">We are given the
following sequence of numbers:</FONT></FONT></P>
<UL>
	<LI><P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">1</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	= N</FONT></FONT></P>
	<LI><P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">2</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	= S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">1</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	+ 1</FONT></FONT></P>
	<LI><P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">3</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	= 2*S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">1</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	+ 1</FONT></FONT></P>
	<LI><P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">4</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	= S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">1</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	+ 2</FONT></FONT></P>
	<LI><P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">5</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	= S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">2</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	+ 1</FONT></FONT></P>
	<LI><P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">6</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	= 2*S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">2</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	+ 1</FONT></FONT></P>
	<LI><P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">7</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	= S</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">2</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	+ 2</FONT></FONT></P>
	<LI><P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	<FONT COLOR="#00000a">…</FONT></P>
</UL>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">Using the
</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Consolas, serif"><B>ArrayDeque&lt;E&gt;</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
class, write a program to print its first 50 members for given N.</FONT></FONT></P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.03in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT FACE="Calibri, serif"><FONT SIZE=4 STYLE="font-size: 16pt"><B>Examples</B></FONT></FONT></FONT></P>
<TABLE WIDTH=677 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=363>
	<TR VALIGN=TOP>
		<TD WIDTH=296 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><FONT SIZE=3><B>Input</B></FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=363 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><FONT SIZE=3><B>Output</B></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">2</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">2
			3 5 4 4 7 5 6 11 7 5 9 6 …</FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">-1</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">-1
			0 -1 1 1 1 2 …</FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">1000</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">1000
			1001 2001 1002 1002 2003 1003 …</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>