<OL START=6>
	<LI><P CLASS="western" STYLE="margin-top: 0.08in; margin-bottom: 0.06in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
	<FONT COLOR="#7c380a"><FONT FACE="Calibri, serif"><FONT SIZE=5><B>*
	Truck Tour</B></FONT></FONT></FONT></P>
</OL>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">Suppose there is a
circle. There are</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>N</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">petrol
pumps on that circle. Petrol pumps are numbered</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;0&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">to</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;(N−1)&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">(both
inclusive). You have </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>two
pieces of information</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
corresponding to each of the petrol pump: (1) the </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>amount
of petrol</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
that particular petrol pump will give, and (2) the </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>distance
from that petrol pump</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
to the next petrol pump.</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">Initially, you have
a tank of infinite capacity carrying no petrol. You can start the
tour at </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>any</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
of the petrol pumps. Calculate the </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>first
point</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
from where the truck will be able to complete the circle. Consider
that the truck will stop at </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>each
of the petrol pumps</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">.
The truck will move one kilometer for each liter of the petrol.</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Input Format:
</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">The
first line will contain the value of&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>N</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">.<BR>The
next&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>N</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;lines
will contain a pair of integers each, i.e. the amount of petrol that
petrol pump will give and the distance between that petrol pump and
the next petrol pump.</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Output Format:
</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">An
integer which will be the smallest index of the petrol pump from
which we can start the tour.</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Constraints: </B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><BR>1
≤ N ≤ 1000001<BR>1 ≤ Amount of petrol, Distance ≤ 1000000000</FONT></FONT></P>
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
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">3</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">1
			5</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">10
			3</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">3
			4</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">1</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>