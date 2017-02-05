<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">** Сръбско
	Unleashed</SPAN></H2>

<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; line-height: 100%">Admit
it – the СРЪБСКО is your favorite sort of music. You never
miss a concert and you have become quite the geek concerning
everything involved with СРЪБСКО. You can’t decide between
all the singers you know who your favorite one is. One way to find
out is to keep statistics of how much money their concerts make.
Write a program that does all the boring calculations for you.</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; line-height: 100%">On
each input line you’ll be given data in format: <B>&quot;</B><FONT FACE="Consolas, serif"><B>singer
@venue ticketsPrice ticketsCount</B></FONT><B>&quot;</B>. There will
be <B>no redundant whitespaces anywhere</B> in the input. Aggregate
the data <B>by venue and by singer</B>. For each venue, print the
singer and the total amount of money his/her concerts have made on a
separate line. <B>Venues </B>should be kept in the <B>same order </B>they
were entered; the <B>singers </B>should be<B> sorted by how much
money </B>they have made in<B> descending order</B>. If two singers
have made the same amount of money, keep them <B>in the order </B>in
which<B> they were entered.</B> 
</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; line-height: 100%">Keep
in mind that if a line is in incorrect format, it should be skipped
and its data should not be added to the output. Each of the four
tokens must be separated by <B>a space</B>, everything else is
invalid. The venue should be denoted with <B>@</B> in front of it,
such as @Sunny Beach</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; line-height: 100%"><B>SKIP
THOSE</B>: Ceca@Belgrade125 12378, Ceca @Belgrade12312 123</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; line-height: 100%">The
singer and town name may consist of one to three words. 
</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Input</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	input data should be read from the console.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">It
	consists of a variable number of lines and ends when the command
	“<B>End</B>&quot; is received.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	input data will always be valid and in the format described. There
	is no need to check it explicitly.</P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Output</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	output should be printed on the console.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">Print
	the aggregated data for each venue and singer in the format shown
	below.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">Format
	for singer lines is <B>#{2*space}{singer}{space}-&gt;{space}{total
	money}</B></P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Constraints</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	<B>number of input lines</B> will be in the range [2 … 50].</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	<B>ticket price</B> will be an integer in the range [0 … 200].</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	<B>ticket count </B>will be an integer in the range [0 … 100 000]</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><B>Singers</B>
	and <B>venues</B> are case sensitive</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">Allowed
	working time for your program: 0.1 seconds. Allowed memory: 16 MB.</P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=677 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=363>
	<TR VALIGN=TOP>
		<TD WIDTH=296 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=363 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT SIZE=3>Output</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Lepa
			Brena @Sunny Beach 25 3500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Dragana
			@Sunny Beach 23 3500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Ceca
			@Sunny Beach 28 3500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Mile
			Kitic @Sunny Beach 21 3500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Ceca
			@Sunny Beach 35 3500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Ceca
			@Sunny Beach 70 15000</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Saban
			Saolic @Sunny Beach 120 35000</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">End</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Sunny
			Beach</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">#
			 Saban Saolic -&gt; 4200000</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">#
			 Ceca -&gt; 1270500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">#
			 Lepa Brena -&gt; 87500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">#
			 Dragana -&gt; 80500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">#
			 Mile Kitic -&gt; 73500</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<TABLE WIDTH=677 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=363>
	<TR VALIGN=TOP>
		<TD WIDTH=296 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=363 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT SIZE=3>Output</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Lepa
			Brena @Sunny Beach 25 3500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Dragana@Belgrade23
			3500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Ceca
			@Sunny Beach 28 3500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Mile
			Kitic @Sunny Beach 21 3500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Ceca
			@Belgrade 35 3500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Ceca
			@Sunny Beach 70 15000</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Saban
			Saolic @Sunny Beach 120 35000</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">End</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Sunny
			Beach</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">#
			 Saban Saolic -&gt; 4200000</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">#
			 Ceca -&gt; 1148000</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">#
			 Lepa Brena -&gt; 87500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">#
			 Mile Kitic -&gt; 73500</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Belgrade</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">#
			 Ceca -&gt; 122500</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>