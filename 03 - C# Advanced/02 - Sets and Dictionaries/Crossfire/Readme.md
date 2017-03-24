<OL START=16>
	<LI><H2 CLASS="western" STYLE="margin-top: 0in; margin-bottom: 0.08in; line-height: 100%">
	* Crossfire</H2>
</OL>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">You
will receive two integers which represent the dimensions of a matrix.
Then, you must fill the matrix with increasing integers starting from
1, and continuing on every row, like this:<BR>first row: 1, 2, 3…
n<BR>second row: n+1, n+2, n+3… n + n.</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">You
will also receive several commands in the form of 3 integers
separated by a space. Those 3 integers will represent a row in the
matrix, a column and a radius. You must then <B>destroy</B> the cells
which correspond to those arguments <B>cross-like.</B></P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%"><B>Destroying</B>
a cell means that, <B>that</B> cell becomes completely<B> nonexistent</B>
in the matrix.<B> </B>Destroying cells <B>cross-like</B> means that
you form a <B>cross figure</B>, with center point - equal to the cell
with coordinates – the <B>given row</B> and <B>column</B>, and
<B>lines </B>with length equal to the <B>given radius</B>. See the
examples for more info. 
</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%">The
input ends when you receive the command “Nuke it from orbit”.
When that happens, you must print what has remained from the initial
matrix.</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%"><BR><BR>
</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Input</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	On the first line you will receive the dimensions of the matrix. You
	must then fill the matrix according to those dimensions.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	On the next several lines you will begin receiving 3 integers
	separated by a single <B>space</B>, which represent the row, col and
	radius. You must then destroy cells according to those coordinates.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	When you receive the command “Nuke it from orbit” the input
	ends.</P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-left: 0.75in; margin-bottom: 0.14in; line-height: 115%">
<BR><BR>
</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Output</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">The output
	is simple. You must print what is left from the matrix.</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">Every row
	must be printed on a new line and every column of a row - separated
	by a space.</P>
</UL>
<P STYLE="margin-left: 0.75in; margin-bottom: 0.14in; line-height: 115%">
<BR><BR>
</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Constraints</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">The
	dimensions of the matrix will be integers in the range [2, 100].</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">The given
	rows and columns will be valid integers in the range [-2<SUP>31 </SUP>+
	1, 2<SUP>31</SUP> - 1].</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%"> The radius
	will be in range [0, 2<SUP>31</SUP> - 1].</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">Allowed
	time/memory: 250ms/16MB.</P>
</UL>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%"><BR><BR>
</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Examples</H3>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%"><BR><BR>
</P>
<TABLE WIDTH=604 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=188>
	<COL WIDTH=96>
	<COL WIDTH=294>
	<TR VALIGN=TOP>
		<TD WIDTH=188 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=96 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Output</FONT></P>
		</TD>
		<TD WIDTH=294 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Comment</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=188 HEIGHT=33 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">5
			5</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">3
			3 2</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">4
			3 2</FONT></FONT></P>
			<P CLASS="western"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Nuke
			it from orbit</FONT></FONT></P>
		</TD>
		<TD WIDTH=96 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>1
			2 3 4 5</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>6
			7 8 10</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>11
			12 13</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>16</FONT></FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>21</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=294 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>Initial
			matrix:</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>1
			 2  3  4  5</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>6
			 7  8  </FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #fabf8f">9</SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>
			 10</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>11
			12 13 </FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #fabf8f">14</SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>
			15</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>16
			</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #fabf8f">17</SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>
			</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #fabf8f">18</SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>
			</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #fabf8f">19</SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>
			</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #fabf8f">20</SPAN></FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>21
			22 23 </FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #fabf8f">24</SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>
			25</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>Result
			from </FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #fabf8f">first</SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>
			destruction:</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>1
			 2  3  4  5</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>6
			 7  8  10</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>11
			12 13 </FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #b2a1c7">15</SPAN></FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>16
			      </FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #b2a1c7">
			 </SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>
			 </FONT></FONT></FONT>
			</P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>21
			</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #b2a1c7">22</SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>
			</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #b2a1c7">23</SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>
			</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #b2a1c7">25</SPAN></FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>Result
			from </FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2><SPAN STYLE="background: #b2a1c7">second</SPAN></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>
			destruction:</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>1
			 2  3  4  5</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>6
			 7  8  10</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>11
			12 13</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>16</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>21</FONT></FONT></FONT></P>
			<P CLASS="western"><BR>
			</P>
		</TD>
	</TR>
</TABLE>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<TABLE WIDTH=604 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=292>
	<COL WIDTH=293>
	<TR VALIGN=TOP>
		<TD WIDTH=292 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=293 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3>Output</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=292 HEIGHT=33 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">5
			5</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">4
			4 4</FONT></FONT></P>
			<P CLASS="western"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">Nuke
			it from orbit</FONT></FONT></P>
		</TD>
		<TD WIDTH=293 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>1
			2 3 4</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>6
			7 8 9</FONT></FONT></FONT></P>
			<P CLASS="western" STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>11
			12 13 14</FONT></FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>16
			17 18 19</FONT></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>