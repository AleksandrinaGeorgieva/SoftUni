<OL START=13>
	<LI><H2 CLASS="western" STYLE="margin-top: 0in; margin-bottom: 0.08in; line-height: 100%">
	Target Practice</H2>
</OL>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
Cotton-eye Gosho has a problem. Snakes! An infestation of snakes!
Gosho is a red-neck which means he doesn’t really care about animal
rights, so he bought some ammo, loaded his shotgun and started
shooting at the poor creatures. He has a favorite spot –
rectangular stairs which the snakes like to climb in order to reach
Gosho’s stash of whiskey in the attic. You’re tasked with the
horrible cleanup of the aftermath.</P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
A <B>snake</B> is represented by <B>a string</B>. The <B>stairs</B>
are a <B>rectangular matrix of size NxM</B>. A snake starts climbing
the stairs from the <B>bottom-right corner</B> and slithers its way
up in a <B>zigzag</B> – first it moves left until it reaches the
left wall, it climbs on the next row and starts moving right, then on
the third row, moving left again and so on. The first cell
(bottom-right corner) is filled with the first symbol of the snake,
the second cell (to the left of the first) is filled with the second
symbol, etc. The snake is as long as it takes in order to <B>fill the
stairs completely</B> – if you reach the end of the string
representing the snake, start again at the beginning. Gosho is
patient and a sadist, he’ll wait until the stairs are completely
covered with snake and will then fire a shot.</P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
The shot has three parameters – <B>impact row, impact column and
radius</B>. When the projectile lands on the specified coordinates of
the matrix it <B>destroys all symbols in the given radius (turns them
into a space)</B>. You can check whether a cell is inside the blast
radius using the Pythagorean Theorem (very similar to the &quot;point
inside a circle&quot; problem).</P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
The symbols above the impact area start <B>falling down until they
land on other symbols (meaning a symbol moves down a row as long as
there is a space below)</B>. When the horror ends, print on the
console the <B>resulting staircase, each row on a new line</B>. You
should really check out the examples at this point.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Input</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	input data should be read from the console. It consists of exactly
	three lines.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">On
	the first line, you’ll receive the <B>dimensions</B> of the stairs
	in format: <B>&quot;N M&quot;</B>, where <B>N</B> is the number of
	<B>rows</B>, and <B>M</B> is the number of <B>columns</B>. They’ll
	be separated by a single space.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">On
	the second line you’ll receive the string representing the <B>snake</B>.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">On
	the third line, you’ll receive the <B>shot parameters (impact row,
	impact column and radius)</B>, all separated by a <B>single space</B>.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	input data will always be valid and in the format described. There
	is no need to check it explicitly.</P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-left: 0.5in; margin-bottom: 0in; line-height: 100%">
<BR>
</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Output</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	output should be printed on the console. It should consist of <B>N
	lines</B>. 
	</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">Each
	line should contain a string representing the respective row of the
	final matrix.</P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-left: 0.5in; margin-bottom: 0in; line-height: 100%">
<BR>
</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Constraints</H3>
<UL>
	<LI><P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	The <B>dimensions</B> N and M of the matrix will be integers in the
	range [1 … 12].</P>
	<LI><P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	The <B>snake</B> will be a string with length in the range [1 …
	20] and <B>will not contain any whitespace characters</B>.</P>
	<LI><P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	The shot’s <B>impact row and column</B> will always be <B>valid
	coordinates</B> in the matrix – they will be integers in the range
	[0 … N – 1] and [0 … M – 1] respectively.</P>
	<LI><P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	The shot’s <B>radius</B> will be an integer in the range [0 …
	4].</P>
	<LI><P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	Allowed working time for your program: 0.1 seconds. Allowed memory:
	16 MB.</P>
</UL>
<P CLASS="western" STYLE="margin-bottom: 0in; line-height: 115%; page-break-before: always">
Examples</P>
<TABLE WIDTH=668 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=62>
	<COL WIDTH=52>
	<COL WIDTH=528>
	<TR VALIGN=TOP>
		<TD WIDTH=62 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=52 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Output</FONT></P>
		</TD>
		<TD WIDTH=528 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Comments</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=62 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">5
			6</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">SoftUni</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">2
			3 2</FONT></FONT></P>
		</TD>
		<TD WIDTH=52 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">US
			  t</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">tn
			  f</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">iSi
			UU</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">nUt
			oS</FONT></FONT></P>
		</TD>
		<TD WIDTH=528 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><IMG SRC="i_284cac0dc310a993_html_4e05b9a6.gif" ALIGN=LEFT><IMG SRC="i_284cac0dc310a993_html_d5184364.gif" ALIGN=LEFT><IMG SRC="i_284cac0dc310a993_html_5dba09c6.gif" ALIGN=LEFT><IMG SRC="i_284cac0dc310a993_html_d5184364.gif" ALIGN=LEFT><IMG SRC="i_284cac0dc310a993_html_5dba09c6.gif" ALIGN=LEFT><IMG SRC="i_284cac0dc310a993_html_d5184364.gif" ALIGN=LEFT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">The
			matrix has 5 rows and 6 columns. Fill it in the described pattern:</FONT></FONT></P>
			<TABLE WIDTH=115 CELLPADDING=0 CELLSPACING=0>
				<COL WIDTH=18>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=18>
				<TR>
					<TD WIDTH=18 HEIGHT=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">f</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">f</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">f</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">f</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
				</TR>
			</TABLE>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">The
			shot lands on cell (2,3). It has a radius of 2 cells. The impact
			cell is shaded black and the other cells within the shot radius
			are shaded grey.</FONT></FONT></P>
			<TABLE WIDTH=115 CELLPADDING=0 CELLSPACING=0>
				<COL WIDTH=18>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=18>
				<TR>
					<TD WIDTH=18 HEIGHT=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#bfbfbf" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#bfbfbf" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#bfbfbf" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#bfbfbf" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">f</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#bfbfbf" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">f</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#bfbfbf" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#000000" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#bfbfbf" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#bfbfbf" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#bfbfbf" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#bfbfbf" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">f</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#bfbfbf" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#bfbfbf" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">f</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
				</TR>
			</TABLE>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
			<BR>
			</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Replace
			all characters in the blast area with a space:</FONT></FONT></P>
			<TABLE WIDTH=115 CELLPADDING=0 CELLSPACING=0 BGCOLOR="#ffffff">
				<COL WIDTH=18>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=18>
				<TR>
					<TD WIDTH=18 HEIGHT=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">f</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
				</TR>
			</TABLE>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
			<BR>
			</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">All
			characters start falling down until they land on other characters:</FONT></FONT></P>
			<TABLE WIDTH=115 CELLPADDING=0 CELLSPACING=0 BGCOLOR="#ffffff">
				<COL WIDTH=18>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=18>
				<TR>
					<TD WIDTH=18 HEIGHT=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><IMG SRC="i_284cac0dc310a993_html_312ade47.gif" ALIGN=LEFT>
						<BR>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><IMG SRC="i_284cac0dc310a993_html_bd3acd28.gif" ALIGN=LEFT>
						<BR>
						</P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">f</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><IMG SRC="i_284cac0dc310a993_html_5edae8ba.gif" ALIGN=LEFT>
						<BR>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><IMG SRC="i_284cac0dc310a993_html_5edae8ba.gif" ALIGN=LEFT>
						<BR>
						</P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
				</TR>
			</TABLE>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
			<BR>
			</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">The
			resulting matrix is:</FONT></FONT></P>
			<TABLE WIDTH=115 CELLPADDING=0 CELLSPACING=0 BGCOLOR="#ffffff">
				<COL WIDTH=18>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=19>
				<COL WIDTH=18>
				<TR>
					<TD WIDTH=18 HEIGHT=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n
						</FONT></FONT>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER> 
						</P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">f
						</FONT></FONT>
						</P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">i</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
				</TR>
				<TR>
					<TD WIDTH=18 HEIGHT=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">n</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">U</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">t</FONT></FONT></P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><BR>
						</P>
					</TD>
					<TD WIDTH=19 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">o</FONT></FONT></P>
					</TD>
					<TD WIDTH=18 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0in">
						<P CLASS="western" ALIGN=CENTER><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">S</FONT></FONT></P>
					</TD>
				</TR>
			</TABLE>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
			<BR>
			</P>
		</TD>
	</TR>
</TABLE>