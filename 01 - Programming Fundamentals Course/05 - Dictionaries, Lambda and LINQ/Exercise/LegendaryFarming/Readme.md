<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">* Legendary
	Farming</SPAN></H2>

<P STYLE="margin-top: 0.06in; margin-bottom: 0in">You’ve beaten all
the content and the last thing left to accomplish is own a legendary
item. However, it’s a tedious process and requires quite a bit of
farming. Anyway, you are not too pretentious – any legendary will
do. The possible items are:</P>
<UL>
	<LI><P STYLE="margin-bottom: 0in"><B>Shadowmourne</B> – requires
	<B>250 Shards</B>;</P>
	<LI><P STYLE="margin-bottom: 0in"><B>Valanyr</B> – requires <B>250
	Fragments</B>;</P>
	<LI><P STYLE="margin-bottom: 0in"><B>Dragonwrath </B>– requires
	<B>250 Motes</B>;</P>
</UL>
<P STYLE="margin-top: 0.06in"><B>Shards, Fragments </B>and<B> Motes
</B>are the <B>key materials</B>, all else is <B>junk. </B>You will
be given lines of input, such as <BR><B>2 motes 3 ores 15 stones.
</B>Keep track of the <B>key materials - </B>the <B>first</B> that
reaches the <B>250 mark</B> <B>wins</B> the <B>race</B>. At that
point, print the corresponding legendary obtained. Then, print the
<B>remaining</B> shards, fragments, motes, ordered by <B>quantity</B>
in <B>descending</B> order, then by <B>name</B> in <B>ascending
</B>order, each on a new line. Finally, print the collected <B>junk</B>
items, in <B>alphabetical </B>order.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Input</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in">Each line of input is in format
	<B>{quantity} {material} {quantity} {material} … {quantity}
	{material}</B></P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Output</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in">On the first line, print the
	obtained item in format <B>{Legendary item} obtained!</B></P>
	<LI><P STYLE="margin-bottom: 0.14in">On the next three lines, print
	the remaining key materials in descending order by quantity</P>
	<UL>
		<LI><P STYLE="margin-bottom: 0.14in">If two key materials have the
		same quantity, print them in alphabetical order</P>
	</UL>
	<LI><P STYLE="margin-bottom: 0.14in">On the final several lines,
	print the junk items in alphabetical order</P>
	<UL>
		<LI><P STYLE="margin-bottom: 0.14in">All materials are printed in
		format <B>{material}: {quantity}</B></P>
		<LI><P STYLE="margin-bottom: 0.14in">All output should be
		<B>lowercase</B>, except the first letter of the legendary</P>
	</UL>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Constraints</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in">The quantity-material pairs are
	between 1 and 25 per line.</P>
	<LI><P STYLE="margin-bottom: 0.14in">The number of lines is in range
	[1..10]</P>
	<LI><P STYLE="margin-bottom: 0.14in">All materials are
	case-insensitive.</P>
	<LI><P STYLE="margin-bottom: 0.14in">Allowed working time: 0.25s</P>
	<LI><P STYLE="margin-bottom: 0.14in">Allowed memory: 16 MB</P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=677 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=290>
	<COL WIDTH=369>
	<TR VALIGN=TOP>
		<TD WIDTH=290 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=369 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT SIZE=3>Output</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=290 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">3
			Motes 5 stones 5 Shards</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">6
			leathers 255 fragments 7 Shards</FONT></FONT></P>
		</TD>
		<TD WIDTH=369 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Valanyr
			obtained!</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">fragments:
			5</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">shards:
			5</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">motes:
			3</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">leathers:
			6</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">stones:
			5</FONT></FONT></P>
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
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">123
			silver 6 shards 8 shards 5 motes</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">9
			fangs 75 motes 103 MOTES 8 Shards</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">86
			Motes 7 stones 19 silver</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Dragonwrath
			obtained!</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">shards:
			22</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">motes:
			19</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">fragments:
			0</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">fangs:
			9</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">silver:
			123</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>