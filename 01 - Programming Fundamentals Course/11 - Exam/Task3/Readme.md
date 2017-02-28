<H1 CLASS="western" ALIGN=CENTER STYLE="margin-top: 0in">Problem 3 –
Hornet Assault</H1>
<P STYLE="margin-top: 0.06in">The hornets are preparing an assault on
beehives. It takes very little amount of hornets to annihilate a
beehive, but the bees are far from defenseless. You must calculate
how many beehives, can the hornets annihilate, before they die.</P>
<P STYLE="margin-top: 0.06in">You will be given a <B>sequence of
integers</B>, separated by a <B>space</B>. The integers will
represent the <B>beehives</B> and the <B>amount of bees</B> in them.
You will then receive <B>another</B> sequence of integers, which will
represent the <B>hornets</B>, and their <B>power</B>. The <B>power</B>
indicates <B>how many bees</B> a hornet can <B>kill</B>.</P>
<P STYLE="margin-top: 0.06in">The hornets must <B>start attacking</B>
the beehives <B>one</B> by <B>one</B>. If the bees are <B>more</B> or
<B>equal to</B> the <B>summed-up power</B> of the <B>hornets</B>, the
<B>first</B> (<B>entered</B>) hornet, <B>currently alive</B>, <B>dies</B>
in the assault of the<B> current beehive</B>.</P>
<P STYLE="margin-top: 0.06in">When the hornets assault a beehive,
they <B>kill</B> an <B>amount of bees</B>, <B>equal</B> to their
<B>summed-up power</B>. This means that you must <B>decrease</B> the
<B>integer</B> of the <B>beehive</B>, with the <B>value</B> of the
summed-up power, of the <B>live hornets</B>.</P>
<P STYLE="margin-top: 0.06in">After you’ve successfully assaulted
all beehives, you must print the result of the <B>winning side</B>.
If there are <B>ANY</B> <B>beehives</B> with <B>live bees</B> inside
them, you must print them. If there aren’t, you must print the <B>live
hornets</B>.</P>
<H3 CLASS="western">Input</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">On the first line of input you
	will receive a sequence of integers, separated by <B>spaces</B> –
	the <B>beehives</B>.</P>
	<LI><P STYLE="margin-top: 0.06in">On the second line of input you
	will receive a sequence of integers, separated by <B>spaces</B> –
	the <B>hornets</B>.</P>
</UL>
<H3 CLASS="western">Output</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">Depending on the case of printing
	you must either print the <B>live</B> beehives, or the <B>live</B>
	hornets.</P>
	<LI><P STYLE="margin-top: 0.06in">They are sequences of integers, so
	in both cases you must print them <B>separated</B> by a <B>space</B>.
		</P>
</UL>
<H3 CLASS="western">Constrains</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">The input will consist only of
	integers in <B>range [0</B><SPAN LANG="bg-BG"><B>;</B></SPAN><B>
	1</B><SPAN LANG="bg-BG"><B>,</B></SPAN><B>000</B><SPAN LANG="bg-BG"><B>,</B></SPAN><B>000]</B>.</P>
	<LI><P STYLE="margin-top: 0.06in">There will be <B>NO</B> <B>STALEMATE</B>
	situations.</P>
	<LI><P STYLE="margin-top: 0.06in">The input sequences may consist of
	up to <B>3000</B> elements. 
	</P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=704 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=156>
	<COL WIDTH=102>
	<COL WIDTH=420>
	<TR VALIGN=TOP>
		<TD WIDTH=156 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=102 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=420 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=156 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">20 10
			20 30</FONT></P>
			<P><FONT FACE="Consolas, serif">5 10 5 3</FONT></P>
		</TD>
		<TD WIDTH=102 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">7</FONT></P>
		</TD>
		<TD WIDTH=420 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in">The <B>summed power</B> of the
			<B>hornets</B> is 23.<BR>They kill the first <B>3 beehives</B>,
			due to overwhelming power.</P>
			<P STYLE="margin-bottom: 0in"><BR>
			</P>
			<P STYLE="margin-bottom: 0in">The last beehive has <B>higher
			value</B>, and its left with <B>7 bees</B> <B>alive</B> inside it.
			The <B>first hornet</B> (<B>5</B>) <B>dies</B>.</P>
			<P>All other beehives <B>are dead</B>, so we print <B>only this
			one</B>.</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=156 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">10 20
			10 15</FONT></P>
			<P><FONT FACE="Consolas, serif">5 6 7</FONT></P>
		</TD>
		<TD WIDTH=102 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">2 2</FONT></P>
		</TD>
		<TD WIDTH=420 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in">The <B>summed power</B> is <B>18</B>.
			The first beehive dies. In the second one, 18 bees die, but due to
			higher power, the <B>first hornet</B> (<B>5</B>) <B>dies</B>.</P>
			<P STYLE="margin-bottom: 0in"><BR>
			</P>
			<P STYLE="margin-bottom: 0in">Now the <B>summed power</B> is <B>13</B>.
			The third beehive dies, but the fourth one has <B>higher</B>
			value. <B>13 bees die</B> from the <B>fourth</B> beehive and the
			<B>current first hornet</B> (<B>6</B>) <B>dies</B>.</P>
			<P>We have the <B>second</B> and the <B>fourth</B> beehive with <B>2
			bees</B>, each, so we print them.</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=156 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">20 100
			40 45 20 10</FONT></P>
			<P><FONT FACE="Consolas, serif">40 10 5 40 5</FONT></P>
		</TD>
		<TD COLSPAN=2 WIDTH=530 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><A NAME="_GoBack"></A><FONT FACE="Consolas, serif">10 5 40 5</FONT></P>
		</TD>
	</TR>
</TABLE>