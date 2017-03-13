<OL START=7>
	<LI><P CLASS="western" STYLE="margin-top: 0.08in; margin-bottom: 0.06in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
	<FONT COLOR="#7c380a"><FONT FACE="Calibri, serif"><FONT SIZE=5><B>Balanced
	Parentheses</B></FONT></FONT></FONT></P>
</OL>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">Given a sequence
consisting of parentheses, determine whether the expression is
balanced. A sequence of parentheses is balanced if every open
parenthesis can be paired uniquely with a closed parenthesis that
occurs after the former. Also, the interval between them must be
balanced. You will be given three types of parentheses:&nbsp;(,&nbsp;{,
and&nbsp;[.</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">{[()]} - This is a
balanced parenthesis.</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">{[(])} - This is
not a balanced parenthesis.</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Input Format:
</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">Each
input consists of a single line,&nbsp;S, the sequence of parentheses.</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Constraints:</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;<BR>1
≤ len</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">s
</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">≤
1000, where&nbsp;len</FONT></FONT><FONT COLOR="#00000a"><SUB><FONT FACE="Calibri, serif">s</FONT></SUB></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;is
the length of the sequence.&nbsp;<BR>Each character of the sequence
will be one of&nbsp;{, },&nbsp;(,&nbsp;),&nbsp;[,&nbsp;].</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Output Format:
</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">For
each test case, print on a new line &quot;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><I>YES</I></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&quot;
if the parentheses are balanced. Otherwise, print &quot;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><I>NO</I></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&quot;.
Do not print the quotes.</FONT></FONT></P>
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
			<P CLASS="western" STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">{[()]}</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">YES</FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=296 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">{[(])}</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">NO</FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=296 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">{{[[(())]]}}</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">YES</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>