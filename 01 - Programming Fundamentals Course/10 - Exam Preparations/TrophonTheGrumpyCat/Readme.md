<H1 CLASS="western" ALIGN=CENTER>Trophon the Grumpy Cat</H1>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Trophon is very angry
with his owner, because he left him alone during the teamwork
defenses for the Software Technologies Course at SoftUni. It’s time
for Trophon to get his payback and he will do it, by breaking various
household items. 
</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Each item has a <B>price
rating</B> which is a number that describes how valuable is that item
for Trophon’s owner. You will be <B>given an entry point</B> from
which Trophon will start <B>breaking</B> the <B>items to his left</B>,
and <B>then</B> to <B>his right</B>. Trophon <B>will never</B> break
the item at the <B>entry point</B>. 
</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><A NAME="_GoBack"></A>You
must calculate the damage to <B>both</B> his <B>left</B>, and <B>right</B>,
then print <B>only the higher (bigger)</B> damage to the household.
If both <B>sums</B> are <B>equal</B> print the <B>left-most</B> one.</P>
<H2 CLASS="western" ALIGN=JUSTIFY>Input / Constrains</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the <B>first line
	</B>you will receive the <B>price ratings</B>, separated by (space).
	Each element will be integer in range <B>[-2</B><SUP><B>31</B></SUP><B>…
	2</B><SUP><B>31</B></SUP><B>]</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the <B>second
	line</B> you will receive the <B>entry point</B>, which will always
	be between the second and the penultimate element in the array</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the <B>third line
	</B>you will receive the <B>type of items</B> Trophon wants to
	break, which will be one of the following:</P>
	<UL>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>cheap</B> –
		items that have <B>lower price rating</B> than the entry point item</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>expensive</B> –
		items that have <B>same price rating</B>,<SPAN LANG="bg-BG"> </SPAN>or
		<B>higher price rating</B> than the entry point item</P>
	</UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the <B>last line</B>
	you will receive the <B>type of price ratings</B> that Trophon will
	look for, which will be one of the following:</P>
	<UL>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>positive</B> –
		price ratings <B>above </B>0</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>negative</B> –
		price ratings <B>below</B> 0</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>all</B> – <B>any</B>
		price ratings</P>
	</UL>
</UL>
<H2 CLASS="western" ALIGN=JUSTIFY>Output</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Single line
	containing the sum of price ratings and their position based on the
	entry point in the following format:</P>
	<UL>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">“{<FONT FACE="Consolas, serif"><B>position</B></FONT>}
		– {<FONT FACE="Consolas, serif"><B>sum of price ratings</B></FONT>}”</P>
	</UL>
</UL>
<H2 CLASS="western">Examples</H2>
<TABLE WIDTH=703 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=108>
	<COL WIDTH=124>
	<COL WIDTH=20>
	<COL WIDTH=313>
	<COL WIDTH=95>
	<TR VALIGN=TOP>
		<TD WIDTH=108 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=124 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=20 BGCOLOR="#ffffff" STYLE="border-top: none; border-bottom: none; border-left: 1px solid #00000a; border-right: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><BR>
			</P>
		</TD>
		<TD WIDTH=313 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=95 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=108 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 5 1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">cheap</FONT></P>
			<P><FONT FACE="Consolas, serif">all</FONT></P>
		</TD>
		<TD WIDTH=124 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">Left - 1</FONT></P>
		</TD>
		<TD WIDTH=20 BGCOLOR="#ffffff" STYLE="border-top: none; border-bottom: none; border-left: 1px solid #00000a; border-right: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.06in; padding-right: 0.06in">
			<P><BR>
			</P>
		</TD>
		<TD WIDTH=313 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-2 2 1
			5 9 3 2 -2 1 -1 -3 3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">7</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">expensive</FONT></P>
			<P><FONT FACE="Consolas, serif">positive</FONT></P>
		</TD>
		<TD WIDTH=95 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">Left – 22</FONT></P>
		</TD>
	</TR>
</TABLE>