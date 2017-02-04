<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">* Population
	Counter</SPAN></H2>

<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; line-height: 100%">So
many people! It’s hard to count them all. But that’s your job as
a statistician. You get raw data for a given city and you need to
aggregate it. 
</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; line-height: 100%">On
each input line you’ll be given data in format:
<B>&quot;city|country|population&quot;</B>. There will be <B>no
redundant whitespaces anywhere</B> in the input. Aggregate the data
<B>by country and by city</B> and print it on the console. For each
country, print its <B>total population</B> and on separate lines the
data for each of its cities. <B>Countries should be ordered by their
total population in descending order</B> and within each country, the
<B>cities should be ordered by the same criterion</B>. If two
countries/cities have the same population, keep them <B>in the order
in which they were entered.</B> Check out the examples; follow the
output format strictly!</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Input</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	input data should be read from the console.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">It
	consists of a variable number of lines and ends when the command
	&quot;<B>report</B>&quot; is received.</P>
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
	the aggregated data for each country and city in the format shown
	below.</P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Constraints</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	name of the city, country and the population count will be separated
	from each other by <B>a pipe ('|')</B>.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	<B>number of input lines</B> will be in the range [2 … 50].</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">A
	city-country pair will not be repeated.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	<B>population count</B> of each city will be an integer in the range
	[0 … 2 000 000 000].</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">Allowed
	working time for your program: 0.1 seconds. Allowed memory: 16 MB.</P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=677 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=212>
	<COL WIDTH=447>
	<TR VALIGN=TOP>
		<TD WIDTH=212 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=447 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT SIZE=3>Output</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=212 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Sofia|Bulgaria|1000000</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">report</FONT></FONT></P>
		</TD>
		<TD WIDTH=447 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Bulgaria
			(total population: 1000000)</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">=&gt;Sofia:
			1000000</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<TABLE WIDTH=677 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=212>
	<COL WIDTH=447>
	<TR VALIGN=TOP>
		<TD WIDTH=212 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=447 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT SIZE=3>Output</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=212 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Sofia|Bulgaria|1</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Veliko
			Tarnovo|Bulgaria|2</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">London|UK|4</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Rome|Italy|3</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">report</FONT></FONT></P>
		</TD>
		<TD WIDTH=447 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">UK
			(total population: 4)</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">=&gt;London:
			4</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Bulgaria
			(total population: 3)</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">=&gt;Veliko
			Tarnovo: 2</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">=&gt;Sofia:
			1</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Italy
			(total population: 3)</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">=&gt;Rome:
			3</FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=212 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><BR>
			</P>
		</TD>
		<TD WIDTH=447 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><BR>
			</P>
		</TD>
	</TR>
</TABLE>
