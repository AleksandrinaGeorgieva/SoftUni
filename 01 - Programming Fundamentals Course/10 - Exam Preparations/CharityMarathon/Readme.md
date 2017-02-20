<H1 CLASS="western" ALIGN=CENTER>
Charity Marathon</H1>
<P STYLE="margin-top: 0.06in">Every year a charity marathon takes
place in your town in which all major companies are obliged to <B>make
donations depending on the total kilometers ran by runners in a
number of days</B>. And this year you have been chosen to create the
software for it.</P>
<P STYLE="margin-top: 0.06in">The <B>marathon can last for variable
number days</B> and a <B>variable number of runners can participate</B>
in it on a <B>track that can have a variable length</B>. However, the
<B>track that can take only a limited number of runners per day</B>.
If the runners that want to take part are more than the capacity,
then the number of runners that will run will be <B>equal to the
maximum capacity of the track</B>.</P>
<P STYLE="margin-top: 0.06in">The <B>amount of money raised per
kilometer is voted</B> in advance by all companies and the final
money per kilometer is <B>calculated by an average of all votes</B>. 
</P>
<P STYLE="margin-top: 0.06in">The goal is simple, create a program
that calculates the total money raised through the marathon.</P>
<H2 CLASS="western" ALIGN=JUSTIFY>Input</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the first line of
	input you will get the <B>length of the marathon in days</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the second line
	of input you will get <B>the number of runners that will participate</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the third line
	you will get the <B>average number of laps every runner</B> makes</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the fourth line
	you will get the <B>length of the track</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the fifth line
	you will get the <B>capacity of the track</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the sixth line
	you will get <B>the amount of money donated per kilometer</B></P>
</UL>
<H2 CLASS="western" ALIGN=JUSTIFY>Output</H2>
<UL>
	<LI><P STYLE="margin-top: 0.06in">Print the money raised, <B>rounded
	by the second digit after the decimal point</B> from the charity
	marathon in the format: &quot;<B>Money raised: {money}</B>&quot;</P>
</UL>
<H2 CLASS="western" ALIGN=JUSTIFY>Constraints</H2>
<UL>
	<LI><P STYLE="margin-top: 0.06in">Marathon day count will be an
	integer in the range [0 … 365]</P>
	<LI><P STYLE="margin-top: 0.06in">Runner count will be an integer in
	the range [0 … 2,147,483,647]</P>
	<LI><P STYLE="margin-top: 0.06in">Average number of laps will be an
	integer in the range [0 … 100]</P>
	<LI><P STYLE="margin-top: 0.06in">Lap length will be an integer in
	the range [0 … 2,147,483,647]</P>
	<LI><P STYLE="margin-top: 0.06in"><A NAME="_GoBack"></A>Track
	capacity will be an integer in the range [0 … 1000]</P>
	<LI><P STYLE="margin-top: 0.06in">Money per kilometer will all be a
	floating point number</P>
</UL>
<P STYLE="margin-bottom: 0.14in"><BR><BR>
</P>
<H2 CLASS="western" STYLE="page-break-before: always">Examples</H2>
<TABLE WIDTH=701 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=67>
	<COL WIDTH=172>
	<COL WIDTH=437>
	<TR VALIGN=TOP>
		<TD WIDTH=67 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=172 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=437 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">50</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">400</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">30</FONT></P>
			<P><FONT FACE="Consolas, serif">3</FONT></P>
		</TD>
		<TD WIDTH=172 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">Money raised: 120.00</FONT></P>
		</TD>
		<TD WIDTH=437 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">The
			marathon runs for 2 days, with 50 runners that will make an
			average of 2 laps on a track that is long 400 meters. </FONT>
			</P>
			<P STYLE="margin-bottom: 0in"><BR>
			</P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">The
			capacity of the track is 30 runners per day. So a total of 30 * 2
			= 60 maximum runners. But only 50 runners are listed, so 50 will
			run.</FONT></P>
			<P STYLE="margin-bottom: 0in"><BR>
			</P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Total
			meters = 50 runners * 2 laps * 400 m = 40,000 m</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Total
			kilometers = 40,000 m / 1,000 = 40 km</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Money
			raised by kilometer = 3</FONT></P>
			<P><FONT FACE="Consolas, serif">Money raised for the marathon = 40
			* 3 = 120 </FONT>
			</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=67 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">50</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">10</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">400</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1</FONT></P>
			<P><FONT FACE="Consolas, serif">2.5</FONT></P>
		</TD>
		<TD WIDTH=172 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">Money raised: 10.00</FONT></P>
		</TD>
		<TD WIDTH=437 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">The
			listed runners are 50, but the maximum capacity of the track is 1
			runner per day and the marathon will last for 1 day. So 1 runner
			will run in total.</FONT></P>
			<P STYLE="margin-bottom: 0in"><BR>
			</P>
			<P STYLE="margin-bottom: 0in"><BR>
			</P>
			<P><BR>
			</P>
		</TD>
	</TR>
</TABLE>