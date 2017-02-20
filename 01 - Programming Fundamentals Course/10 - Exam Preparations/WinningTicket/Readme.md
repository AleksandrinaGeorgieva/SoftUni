<P ALIGN=CENTER STYLE="margin-bottom: 0.06in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#7c380a"><FONT FACE="Calibri, serif"><FONT SIZE=5 STYLE="font-size: 20pt"><SPAN LANG="en-US"><B>Winning Ticket</B></SPAN></FONT></FONT></FONT></P>
<P STYLE="margin-bottom: 0.11in">Lottery is exciting. What is not, is
checking a million tickets for winnings only by hand. So, you are
given the task to create a program which automatically checks if a
ticket is a winner. 
</P>
<P STYLE="margin-bottom: 0.11in">You are given a <B>collection of
tickets separated by commas and spaces</B>. You need to check every
one of them if it has a winning combination of symbols.</P>
<P STYLE="margin-bottom: 0.11in"><B>A valid ticket should have
exactly 20 characters</B>. The winning symbols are '<B>@</B>', '<B>#</B>',
'<B>$</B>' and '<B>^</B>'. But in order for a ticket to be a winner
the symbol should uninterruptedly repeat for at least <B>6 times</B>
in both the <B>tickets left half</B> and the <B>tickets right half</B>.
</P>
<P STYLE="margin-bottom: 0.11in">For example, a valid winning ticket
should be something like this: 
</P>
<P STYLE="margin-bottom: 0.11in">&quot;<B>Cash$$$$$$Ca$$$$$$sh</B>&quot;
</P>
<P STYLE="margin-bottom: 0.11in">The left half &quot;<B>Cash$$$$$$</B>&quot;
contains &quot;<B>$$$$$$</B>&quot;, which is also contained in the
tickets right half &quot;<B>Ca$$$$$$sh</B>&quot;. A winning ticket
should contain symbols repeating up to 10 times in both halves, which
is considered a Jackpot (for example: &quot;<B>$$$$$$$$$$$$$$$$$$$$</B>&quot;).</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT SIZE=4 STYLE="font-size: 16pt"><SPAN LANG="en-US"><B>Input</B></SPAN></FONT></FONT></P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US">The
input will be read from the console. The input consists of a </SPAN><SPAN LANG="en-US"><B>single
line </B></SPAN><SPAN LANG="en-US">containing all tickets </SPAN><SPAN LANG="en-US"><B>separated
by commas and one or more white spaces</B></SPAN><SPAN LANG="en-US">
in the format:</SPAN></P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US"><B>&quot;{ticket},
	{ticket}, … {ticket}&quot;</B></SPAN></P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT SIZE=4 STYLE="font-size: 16pt"><SPAN LANG="en-US"><B>Output</B></SPAN></FONT></FONT></P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US">Print
the result for every ticket in the order of their appearance, each on
a separate line in the format:</SPAN></P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="line-height: 100%"><SPAN LANG="en-US"><B>Invalid
	ticket - &quot;invalid ticket&quot;</B></SPAN></P>
	<LI><P ALIGN=JUSTIFY STYLE="line-height: 100%"><SPAN LANG="en-US"><B>No
	match - &quot;ticket &quot;{ticket}&quot; - no match&quot;</B></SPAN></P>
	<LI><P ALIGN=JUSTIFY STYLE="line-height: 100%"><SPAN LANG="en-US"><B>Match
	with length 6 to 9 - &quot;ticket &quot;{ticket}&quot; - {match
	length}{match symbol}&quot;</B></SPAN></P>
	<LI><P ALIGN=JUSTIFY STYLE="line-height: 100%"><SPAN LANG="en-US"><B>Match
	with length 10 - &quot;ticket &quot;{ticket}&quot; - {match
	length}{match symbol} Jackpot!&quot;</B></SPAN></P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT SIZE=4 STYLE="font-size: 16pt"><SPAN LANG="en-US"><B>Constrains</B></SPAN></FONT></FONT></P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><A NAME="_GoBack"></A>
	<SPAN LANG="en-US">Number of tickets will be in range [0 … 100]</SPAN></P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.06in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT SIZE=4 STYLE="font-size: 16pt"><SPAN LANG="en-US"><B>Examples</B></SPAN></FONT></FONT></P>
<TABLE WIDTH=680 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=274>
	<COL WIDTH=388>
	<TR VALIGN=TOP>
		<TD WIDTH=274 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Input</B></SPAN></P>
		</TD>
		<TD WIDTH=388 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Output</B></SPAN></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=274 HEIGHT=73 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">Cash$$$$$$Ca$$$$$$sh</FONT></P>
		</TD>
		<TD WIDTH=388 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">ticket
			&quot;</SPAN></FONT></FONT><FONT FACE="Consolas, serif">Cash$$$$$$Ca$$$$$$sh&quot;
			- 6$</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=274 HEIGHT=47 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">$$$$$$$$$$$$$$$$$$$$
			  ,   aabb  ,     th@@@@@@eemo@@@@@@ey</FONT></P>
		</TD>
		<TD WIDTH=388 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">ticket
			&quot;</SPAN></FONT></FONT><FONT FACE="Consolas, serif">$$$$$$$$$$$$$$$$$$$$</FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">&quot;
			- 10$ Jackpot!</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">invalid
			ticket</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">ticket
			&quot;</SPAN></FONT></FONT><FONT FACE="Consolas, serif">th@@@@@@eemo@@@@@@ey</FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">&quot;
			- 6@</SPAN></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=274 HEIGHT=30 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">validticketnomatch:(</FONT></P>
		</TD>
		<TD WIDTH=388 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">ticket
			&quot;</SPAN></FONT></FONT><FONT FACE="Consolas, serif">validticketnomatch:(</FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">&quot;
			- no match</SPAN></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>
