<H1 CLASS="western" ALIGN=CENTER STYLE="margin-left: 0.25in"><A NAME="_GoBack"></A>
Problem <SPAN LANG="bg-BG">1</SPAN>. SoftUni Coffee Orders</H1>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">We are placing <B>N</B>
orders at a time. You need to calculate the price after the discount
based on the following formula:</P>
<P ALIGN=CENTER STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B><FONT SIZE=2>((daysInMonth
* capsulesCount) * pricePerCapsule)</FONT></B></FONT></P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">*<B>Hint</B> – The
<FONT FACE="Consolas, serif"><B>DateTime</B></FONT> class may come in
handy to calculate the days in month.</P>
<H3 CLASS="western">Input / Constraints</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the first line
	you will receive integer <B>N</B> – the count of orders the shop
	will receive.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">For each order you
	will receive the following information:</P>
	<UL>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Price per capsule -
		<B>floating-point number in range
		[0…79,228,162,514,264,337,593,543,950,335]</B>.</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Order date - in the
		following <FONT FACE="Consolas, serif"><B>format {d/M/yyyy}</B></FONT>,
		e.g. 25/11/2016, 7/03/2016, 1/1/2020.</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Capsules count -
		<B>integer in range [0…2,147,483,647]</B>.</P>
	</UL>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">The input will be in the
described format, there is no need to check it explicitly.</P>
<H3 CLASS="western" ALIGN=JUSTIFY>Output</H3>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">The output should consist
of <B>N + 1</B> lines. For each order you must print a single line in
the following format:</P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">“<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">The
	price for the coffee is: ${</FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><B>price</B></FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">}”</FONT></FONT></P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the last line you need
to print the total price in the following format:</P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"> “<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Total:
	${</FONT></FONT><FONT FACE="Consolas, serif"><B>totalP</B></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><B>rice</B></FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">}”</FONT></FONT></P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">The <B>price must be
rounded</B> to 2 decimal places. 
</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=678 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=137>
	<COL WIDTH=198>
	<COL WIDTH=317>
	<TR VALIGN=TOP>
		<TD WIDTH=137 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=198 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=3>Output</FONT></P>
		</TD>
		<TD WIDTH=317 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=3>Comments</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=137 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">1</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN STYLE="background: #ffff00">1.53</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN STYLE="background: #ffff00">06/06/2016</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN STYLE="background: #ffff00">8</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=198 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">The
			price for the coffee is: $</FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN STYLE="background: #ffff00">367.20</SPAN></FONT></FONT></P>
			<P><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Total:
			$367.20</FONT></FONT></P>
		</TD>
		<TD WIDTH=317 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT SIZE=2 STYLE="font-size: 10pt">We
			are given only 1 order. Then we  use the formulas:</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT SIZE=2 STYLE="font-size: 10pt"><B>orderPrice</B></FONT><FONT SIZE=2 STYLE="font-size: 10pt">
			= 30 (days in June 2016) * 8 * 1.53 = 367.20</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><BR>
			</P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-bottom: 0in; line-height: 100%"><BR>
</P>
<TABLE WIDTH=473 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=137>
	<COL WIDTH=287>
	<COL WIDTH=24>
	<TR VALIGN=TOP>
		<TD WIDTH=137 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=287 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=3>Output</FONT></P>
		</TD>
		<TD WIDTH=24 BGCOLOR="#ffffff" STYLE="border-top: none; border-bottom: none; border-left: 1px solid #00000a; border-right: none; padding-top: 0in; padding-bottom: 0in; padding-left: 0.06in; padding-right: 0in">
			<P ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=137 HEIGHT=24 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">2</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN STYLE="background: #ffff00">4.99</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN STYLE="background: #ffff00">6/07/2016</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN STYLE="background: #ffff00">3</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN STYLE="background: #00ff00">0.35</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN STYLE="background: #00ff00">03/01/2013</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN STYLE="background: #00ff00">5</SPAN></FONT></FONT></P>
		</TD>
		<TD COLSPAN=2 WIDTH=319 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><A NAME="OLE_LINK3"></A><A NAME="OLE_LINK2"></A><A NAME="OLE_LINK1"></A>
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="bg-BG">The
			price for the coffee is: $</SPAN></FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN STYLE="background: #ffff00">464.07</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">The
			price for the coffee is: $</FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN STYLE="background: #00ff00">54.25</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Total:
			$518.32</FONT></FONT></P>
			<P ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
</TABLE>
