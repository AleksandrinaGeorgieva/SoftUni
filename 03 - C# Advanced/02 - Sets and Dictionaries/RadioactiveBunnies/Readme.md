<OL START=15>
	<LI><H2 CLASS="western" STYLE="margin-top: 0in; margin-bottom: 0.08in; line-height: 100%">
	Radioactive Mutant Vampire Bunnies</H2>
</OL>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">Browsing
through GitHub, you come across an old JS Basics teamwork game. It is
about very nasty bunnies that multiply extremely fast. There’s also
a player that has to escape from their lair. You really like the game
so you decide to port it to C# because that’s your language of
choice. The last thing that is left is the algorithm that decides if
the player will escape the lair or not.</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">The
<B>bunnies</B> are marked with <B>B,</B> the <B>player</B> is marked
with P, and <B>everything</B> else is free space, marked with a dot
(.) First, you will receive a line holding integers <B>N</B> and <B>M</B>,
which represent the rows and columns in the lair. Then you receive <B>N</B>
strings that can <B>only</B> consist of dots (.), bunnies (B), and
the player (P). They represent the initial state of the lair. There
will be <B>only </B>one player. Then you will receive a string with
<B>commands</B> such as <B>LLRRUUDD</B> – where each letter
represents the next <B>step</B> of the player (Left, Right, Up,
Down). 
</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%"><B>After</B>
each step of the player, the bunnies spread to the up, down, left and
right (neighboring cells marked as “.” <B>change</B> their value
to B). If the player <B>moves</B> to a bunny cell or a bunny <B>reaches</B>
the player, the player has died. If the player goes <B>out</B> of the
lair <B>without</B> encountering a bunny, the player has won.</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">If
the player <B>dies</B> or <B>wins</B>, the game ends. All the
activities for <B>this</B> turn continue (e.g. all the bunnies spread
normally), but there are no more turns. There will be <B>no</B>
stalemates where the moves of the player end before he dies or
escapes.</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">Print
the final state of the lair with every row on a separate line. On the
last line, print either <B>“dead: {row} {col}”</B> or <B>“won:
{row} {col}”</B>. Row and col are the coordinates of the cell where
the player has died or the last cell he has been in before escaping
the lair.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Input</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">On the first
	line of input, the number N and M are received – the number of
	rows and columns in the lair</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">On the next
	N lines, each row is received in the form of a string. The string
	will contain only “.”, “B”, “P”. All strings will be the
	same length. There will be only one “P” for all the input</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">On the last
	line, the directions are received in the form of a string,
	containing “R”, “L”, “U”, “D”</P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Output</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">On the first
	N lines, print the final state of the bunny lair</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">On the last
	line, print the outcome – “won:” or “dead:” + {row} {col}</P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Constraints</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">The
	dimensions of the lair are in range [3…20]</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">The
	directions string length is in range [1..20]</P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=677 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=363>
	<TR VALIGN=TOP>
		<TD WIDTH=296 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=363 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Output</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">5
			8</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">.......B</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">...B....</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">....B..B</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">........</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">..P.....</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">ULLL</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">BBBBBBBB</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">BBBBBBBB</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">BBBBBBBB</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">.BBBBBBB</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">..BBBBBB</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">won:
			3 0</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
</TABLE>
<BR>
</P>
<TABLE WIDTH=677 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=363>
	<TR VALIGN=TOP>
		<TD WIDTH=296 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=363 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Output</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">4
			5</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">.....</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">.....</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">.B...</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">...P.</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">LLLLLLLL</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">.B...</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">BBB..</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">BBBB.</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">BBB..</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">dead:
			3 1</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
</TABLE>
