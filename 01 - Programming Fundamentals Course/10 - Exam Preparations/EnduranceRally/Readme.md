
<P ALIGN=CENTER STYLE="margin-bottom: 0.06in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#7c380a"><FONT FACE="Calibri, serif"><FONT SIZE=5 STYLE="font-size: 20pt"><SPAN LANG="en-US"><B>Endurance Rally</B></SPAN></FONT></FONT></FONT></P>
<P STYLE="margin-bottom: 0.11in"><SPAN LANG="en-US">The goal of the
Endurance Rally is, simply, to finish the race.</SPAN></P>
<P STYLE="margin-bottom: 0.11in"><A NAME="_GoBack"></A><SPAN LANG="en-US">You
are given </SPAN><SPAN LANG="en-US"><B>the names of the participants</B></SPAN><SPAN LANG="en-US">,
</SPAN><SPAN LANG="en-US"><B>the track layout</B></SPAN><SPAN LANG="en-US">
and </SPAN><SPAN LANG="en-US"><B>the</B></SPAN><SPAN LANG="en-US">
</SPAN><SPAN LANG="en-US"><B>checkpoint </B></SPAN><SPAN LANG="en-US">indexes.
</SPAN>
</P>
<P STYLE="margin-bottom: 0.11in"><SPAN LANG="en-US">The starting fuel
of each participant is </SPAN><SPAN LANG="en-US"><B>equal to the
ASCII code</B></SPAN><SPAN LANG="en-US"> of the </SPAN><SPAN LANG="en-US"><B>first
character</B></SPAN><SPAN LANG="en-US"> of his name.</SPAN></P>
<P STYLE="margin-bottom: 0.11in"><SPAN LANG="en-US">Track layout
consists of zones represented by numbers, given on a single line
separated by a single space. Every number </SPAN><SPAN LANG="en-US"><B>represents</B></SPAN><SPAN LANG="en-US">
the </SPAN><SPAN LANG="en-US"><B>fuel given</B></SPAN><SPAN LANG="en-US">
or the </SPAN><SPAN LANG="en-US"><B>fuel taken</B></SPAN><SPAN LANG="en-US">
by the current zone of the track: </SPAN>
</P>
<UL>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in; line-height: 115%">
	<SPAN LANG="en-US">If the current zone </SPAN><SPAN LANG="en-US"><B>is
	a checkpoint</B></SPAN><SPAN LANG="en-US">, the value of the zone is
	</SPAN><SPAN LANG="en-US"><B>added</B></SPAN><SPAN LANG="en-US"> to
	the driver's </SPAN><SPAN LANG="en-US"><B>fuel</B></SPAN><SPAN LANG="en-US">.
	</SPAN>
	</P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in; line-height: 115%">
	<SPAN LANG="en-US">If the current zone </SPAN><SPAN LANG="en-US"><B>is
	not a checkpoint</B></SPAN><SPAN LANG="en-US">, the value of the
	zone is </SPAN><SPAN LANG="en-US"><B>subtracted </B></SPAN><SPAN LANG="en-US">from
	the driver's fuel.</SPAN></P>
</UL>
<P STYLE="margin-bottom: 0.11in"><SPAN LANG="en-US">Zones are
</SPAN><SPAN LANG="en-US"><B>indexed</B></SPAN><SPAN LANG="en-US">.
Indexes are sequential and always</SPAN><SPAN LANG="en-US"><B> start
from zero </B></SPAN><SPAN LANG="en-US">(like an array).</SPAN></P>
<P STYLE="margin-bottom: 0.11in"><SPAN LANG="en-US">The </SPAN><SPAN LANG="en-US"><B>checkpoints</B></SPAN><SPAN LANG="en-US">
are numbers, representing indexes that show if </SPAN><SPAN LANG="en-US"><B>a
zone of the track</B></SPAN><SPAN LANG="en-US"> </SPAN><SPAN LANG="en-US"><B>is
a checkpoint</B></SPAN><SPAN LANG="en-US">. For example, you are
given checkpoints 0, 3 and 5, that means that zones at index 0, 3 and
5 of the track are checkpoints and therefore provide fuel for the
driver.</SPAN></P>
<P STYLE="margin-bottom: 0.11in"><SPAN LANG="en-US">Given this
information, you need to </SPAN><SPAN LANG="en-US"><B>check if a
driver can finish</B></SPAN><SPAN LANG="en-US"> and </SPAN><SPAN LANG="en-US"><B>print
the fuel that he is left with</B></SPAN><SPAN LANG="en-US">. If a
driver </SPAN><SPAN LANG="en-US"><B>can't finish</B></SPAN><SPAN LANG="en-US">
you need to </SPAN><SPAN LANG="en-US"><B>print the zone he managed to
reach</B></SPAN><SPAN LANG="en-US">. </SPAN>
</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT SIZE=4 STYLE="font-size: 16pt"><SPAN LANG="en-US"><B>Input</B></SPAN></FONT></FONT></P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US">The
input will be read from the console. The input consists of </SPAN><SPAN LANG="en-US"><B>exactly
three lines</B></SPAN><SPAN LANG="en-US">:</SPAN></P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US">The
	first line holds the drivers' names separated by a space:</SPAN><SPAN LANG="en-US"><B>
	&quot;{driver 1} {driver 2} … {driver N}&quot;</B></SPAN></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US">On
	the second line is the track layout (zones) in the form of numbers
	separated by a space: </SPAN><SPAN LANG="en-US"><B>&quot;{zone 0}
	{zone 1} … {zone N}&quot;</B></SPAN></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US">On
	the third line are the checkpoint indexes also separated by a space:</SPAN><SPAN LANG="en-US"><B>
	&quot;{index 0} {index 1} … {index N}&quot;</B></SPAN></P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT SIZE=4 STYLE="font-size: 16pt"><SPAN LANG="en-US"><B>Output</B></SPAN></FONT></FONT></P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">Print
all drivers </SPAN></SPAN><SPAN LANG="en-US"><B><SPAN STYLE="background: #ffffff">in
the order of their appearance</SPAN></B></SPAN><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">,
each on a separate line:</SPAN></SPAN></P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="line-height: 100%"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">If
	the driver finished, print his name and fuel left to the second
	digit after the decimal point in the format:</SPAN></SPAN><SPAN LANG="en-US"><B><SPAN STYLE="background: #ffffff">
	&quot;{driver name} - fuel left {fuel points}&quot;</SPAN></B></SPAN></P>
	<LI><P ALIGN=JUSTIFY STYLE="line-height: 100%"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">If
	the driver could not finish, print:</SPAN></SPAN><SPAN LANG="en-US"><B><SPAN STYLE="background: #ffffff">
	&quot;{driver name} - reached {zone index}&quot;</SPAN></B></SPAN></P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT SIZE=4 STYLE="font-size: 16pt"><SPAN LANG="en-US"><B>Constrains</B></SPAN></FONT></FONT></P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US">Drivers
	count will be in the range [0 … 200]</SPAN></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US">Zone
	fuel will be a floating-point number</SPAN></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US">Checkpoints
	will be integers in the range [-2</SPAN><SUP><SPAN LANG="en-US">31</SPAN></SUP><SPAN LANG="en-US">
	… 2</SPAN><SUP><SPAN LANG="en-US">31 </SPAN></SUP><SPAN LANG="en-US">-
	1]</SPAN></P>
</UL>
<P LANG="en-US" STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.06in; line-height: 115%; page-break-inside: avoid; page-break-before: always; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT SIZE=4 STYLE="font-size: 16pt"><SPAN LANG="en-US"><B>Examples</B></SPAN></FONT></FONT></P>
<TABLE WIDTH=637 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=184>
	<COL WIDTH=190>
	<COL WIDTH=237>
	<TR VALIGN=TOP>
		<TD WIDTH=184 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Input</B></SPAN></P>
		</TD>
		<TD WIDTH=190 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Output</B></SPAN></P>
		</TD>
		<TD WIDTH=237 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Comments</B></SPAN></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=184 HEIGHT=73 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Garry
			Clark</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">69
			</SPAN></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B>1</B></SPAN></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">
			</SPAN></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B>15</B></SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">
			5</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">1
			</SPAN></SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">2</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=190 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Garry
			- fuel left 13.00</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Clark
			- reached 0</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=237 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Zones
			1 and 2 -&gt; checkpoints.</SPAN></FONT></FONT></P>
			<P LANG="en-US" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><BR>
			</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Garry
			('G' = 71) </SPAN></FONT></FONT>
			</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">-&gt;
			71 - 69 + 1 + 15 - 5 = 13.00</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Garry
			finished with 13 fuel </SPAN></FONT></FONT>
			</P>
			<P LANG="en-US" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><BR>
			</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Clark
			('C' = 67)</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">-&gt;
			67 - 69 = -2 </SPAN></FONT></FONT>
			</P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Clark
			reached 0</SPAN></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=184 HEIGHT=73 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Garry
			Clark Larry</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B><SPAN STYLE="background: #ffffff">4</SPAN></B></SPAN></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">
			</SPAN></SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">5
			12 </SPAN></SPAN></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B><SPAN STYLE="background: #ffffff">0</SPAN></B></SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">
			8 </SPAN></SPAN></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B><SPAN STYLE="background: #ffffff">7</SPAN></B></SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">
			13 22 </SPAN></SPAN></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B><SPAN STYLE="background: #ffffff">5.5</SPAN></B></SPAN></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">
			</SPAN></SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">26</SPAN></SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">0
			3 5 8</SPAN></SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=190 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Garry
			- fuel left 1.50</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Clark
			- reached 9</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Larry
			- fuel left 6.50</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=237 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P LANG="en-US" ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=184 HEIGHT=72 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Garry</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">-29
			</SPAN></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B>-5.0</B></SPAN></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">
			</SPAN></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><B>-5.0</B></SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">1
			</SPAN></SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">2</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=190 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Garry
			- fuel left 90.00</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=237 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P LANG="en-US" ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
