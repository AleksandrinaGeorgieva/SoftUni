<OL START=11>
	<LI><P CLASS="western" STYLE="margin-top: 0.08in; margin-bottom: 0.06in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
	<FONT COLOR="#7c380a"><FONT FACE="Calibri, serif"><FONT SIZE=5><B>**Poisonous
	Plants</B></FONT></FONT></FONT></P>
</OL>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">You are
given&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>N</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;plants
in a garden. Each of these plants has been added with some amount of
pesticide. After each day, if any plant has </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>more
pesticide</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
than the plant at </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>its
left</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">,
being weaker(more GMO) than the left one, </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>it
dies</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">.
You are given the initial values of the pesticide and position of
each plant. Print the number of days </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>after</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
which no plant dies, i.e. the time after which there are no plants
with more pesticide content than the plant to their left.</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Input Format:
</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">The
input consists of an integer&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>N</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
representing the number of plants. The next </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>single
line</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
consists of&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>N</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;integers
where every integer represents the position and amount of pesticides
of each plant.</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Constraints</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">:
1 ≤ N ≤ 100000<BR>Pesticides amount on a plant is between 0 and
1000000000</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Output Format:
</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">Output
a single value equal to the number of days after which no plants die</FONT></FONT></P>
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
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">7</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">6
			5 8 4 7 10 9</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">2</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>