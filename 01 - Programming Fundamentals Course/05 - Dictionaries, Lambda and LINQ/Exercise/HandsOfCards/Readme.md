<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Hands of
	Cards</SPAN></H2>

<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">You are given a sequence
of people and for every person what cards he draws from the deck. The
input will be separate lines in the format:</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>{personName}: {PT, PT,
PT,… PT}</B></P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Where P (2, 3, 4, 5, 6,
7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C)
is the type. The input ends when a <B>&quot;JOKER&quot;</B> is drawn.
The name can contain any ASCII symbol except <B>':'</B>. The input
will always be valid and in the format described, there is no need to
check it.</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">A single person <U>cannot
have more than one</U> card with the same power and type, if he draws
such a card he discards it. The people are playing with <U>multiple
decks</U>. Each card has a value that is calculated by the power
multiplied by the type. Powers <B>2 to 10</B> have the same value and
<B>J to A</B> are <B>11 to 14</B>. Types are mapped to multipliers
the following way (<B>S -&gt; 4, H-&gt; 3, D -&gt; 2, C -&gt; 1</B>).</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Finally print out the
total value each player has in his hand in the format:</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>{personName}: {value}</B></P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=600 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=263>
	<COL WIDTH=318>
	<TR VALIGN=TOP>
		<TD WIDTH=263 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=CENTER STYLE="margin-top: 0.06in"><B>Input</B></P>
		</TD>
		<TD WIDTH=318 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=CENTER STYLE="margin-top: 0.06in"><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=263 HEIGHT=98 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho:
			2C, 4H, 9H, AS, QS</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Slav:
			3H, 10S, JC, KD, 5S, 10S</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Peshoslav:
			QH, QC, QS, QD</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Slav:
			6H, 7S, KC, KD, 5S, 10C</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Peshoslav:
			QH, QC, JS, JD, JC</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho:
			JD, JD, JD, JD, JD, JD</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif">JOKER</FONT></P>
		</TD>
		<TD WIDTH=318 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in">Pesho:
			167</P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in">Slav:
			175</P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Peshoslav: 197</P>
		</TD>
	</TR>
</TABLE>