<OL START=4>
	<LI><P CLASS="western" STYLE="margin-top: 0.08in; margin-bottom: 0.06in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
	<FONT COLOR="#7c380a"><FONT FACE="Calibri, serif"><FONT SIZE=5><B>Basic
	Queue Operations</B></FONT></FONT></FONT></P>
</OL>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">Play around with a
queue. You will be given an integer </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>N
</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">representing
the amount of elements to enqueue (add), an integer </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>S
</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">representing
the amount of elements to dequeue (remove/poll) from the queue and
finally an integer </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>X</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">,
an element that you should check whether is present in the queue. If
it is print </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>true
</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">on
the console, if it’s not print the smallest element currently
present in the queue.</FONT></FONT></P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.03in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT FACE="Calibri, serif"><FONT SIZE=4 STYLE="font-size: 16pt"><B>Examples</B></FONT></FONT></FONT></P>
<TABLE WIDTH=688 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=131>
	<COL WIDTH=134>
	<COL WIDTH=397>
	<TR>
		<TD WIDTH=131 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Input</B></FONT></FONT></P>
		</TD>
		<TD WIDTH=134 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Output</B></FONT></FONT></P>
		</TD>
		<TD WIDTH=397 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P CLASS="western" ALIGN=CENTER STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Comments</B></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=131 HEIGHT=36 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">5
			2 32</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">1
			13 45 32 4</FONT></FONT></P>
		</TD>
		<TD WIDTH=134 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">true
			</FONT></FONT>
			</P>
			<P CLASS="western" STYLE="margin-top: 0.06in"><BR>
			</P>
		</TD>
		<TD WIDTH=397 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P CLASS="western" STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">We
			have to </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Consolas, serif"><B>push
			5 </B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">elements.
			Then we </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Consolas, serif"><B>pop
			2 </B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">of
			them. Finally, we have to check whether 13 is present in the
			stack. Since it is we print </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Consolas, serif"><B>true</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">.</FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=131 HEIGHT=36 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">4
			1 666</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">666
			69 13 420</FONT></FONT></P>
		</TD>
		<TD WIDTH=134 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">13</FONT></FONT></P>
		</TD>
		<TD WIDTH=397 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P CLASS="western" STYLE="margin-top: 0.06in"><BR>
			</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=131 HEIGHT=35 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">3
			3 90</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">90
			90 90</FONT></FONT></P>
		</TD>
		<TD WIDTH=134 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">0</FONT></FONT></P>
		</TD>
		<TD WIDTH=397 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P CLASS="western" STYLE="margin-top: 0.06in"><BR>
			</P>
		</TD>
	</TR>
</TABLE>