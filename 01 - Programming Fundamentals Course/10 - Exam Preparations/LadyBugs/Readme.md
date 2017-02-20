<H1 CLASS="western" ALIGN=CENTER>Ladybugs</H1>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">You are <B>given a field
size</B> and the <B>indexes of ladybugs</B> inside the field. After
that on every new line <B>until the &quot;end&quot; command</B> is
given, a <B>ladybug changes its position</B> either to its <B>left or
to its right</B> <B>by a given fly length</B>. 
</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">A <B>command</B><SPAN LANG="bg-BG"><B>
</B></SPAN><SPAN LANG="en-GB"><B>to a ladybug</B></SPAN> looks like
this: &quot;<B>0 right 1</B>&quot;. This means that the little insect
placed on index 0 should fly one index to its right. If the ladybug
<B>lands on a fellow ladybug</B>, it <B>continues to fly</B> in the
same direction <B>by the same fly length</B>. If the ladybug <B>flies
out of the field, it is gone</B>.</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">For example, imagine you
are given a field with size 3 and ladybugs on indexes 0 and 1. If the
ladybug on index 0 needs to fly to its right by the length of 1 (0
right 1) it will attempt to land on index 1 but as there is another
ladybug there it will continue further to the right by additional
length of 1, landing on index 2. After that, if the same ladybug
needs to fly to its right by the length of 1 (2 right 1), it will
land somewhere outside of the field, so it flies away:</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><IMG SRC="i_f5d473a1a2275c29_html_ec7c360f.gif"></P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">If you are given ladybug
index that does not have ladybug there, nothing happens. If you are
given ladybug index that is outside the field, nothing happens. 
</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Your job is to create the
program, simulating the ladybugs flying around doing nothing. At the
end, <B>print all cells in the field separated by blank spaces</B>.
For each cell that has a ladybug on it print '<B>1</B>' and for each
empty cells print '<B>0</B>'. For the example above, the output
should be <B>'0 1 0'</B>. 
</P>
<H3 CLASS="western" ALIGN=JUSTIFY><FONT SIZE=5>Input</FONT></H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the first line
	you will receive an integer - the size of the field</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the second line
	you will receive the initial <B>indexes</B> of all ladybugs
	separated by a blank space<SPAN LANG="bg-BG">. </SPAN><SPAN LANG="en-GB"><B>The
	given indexes</B></SPAN><SPAN LANG="en-GB"> may or may not be inside
	the field range</SPAN></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the next lines,
	until you get the &quot;end&quot; command you will receive commands
	in the format: &quot;<B>{ladybug index} {direction} {fly length}</B>&quot;</P>
</UL>
<H2 CLASS="western" ALIGN=JUSTIFY>Output</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Print the <B>all
	cells within the field in format: &quot;{cell} {cell} … {cell}&quot;</B></P>
	<UL>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">If a cell has
		ladybug in it, print <B>'1'</B></P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">If a cell is empty,
		print <B>'0'</B> 
		</P>
	</UL>
</UL>
<H2 CLASS="western" ALIGN=JUSTIFY>Constrains</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">The size of the
	field will be in the range [0 … 1000]</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">The ladybug indexes
	will be in the range [-2,147,483,647<SUP> </SUP>… 2,147,483,647]</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">The number of
	commands will be in the range [0 … 100] 
	</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">The fly length will
	be in the range [<SPAN LANG="bg-BG">-</SPAN>2,147,483,647<SUP> </SUP>…
	2,147,483,647]</P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in"><BR><BR>
</P>
<H2 CLASS="western" ALIGN=JUSTIFY STYLE="page-break-before: always">Examples</H2>
<TABLE WIDTH=692 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=102>
	<COL WIDTH=58>
	<COL WIDTH=505>
	<TR VALIGN=TOP>
		<TD WIDTH=102 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><B>Input</B></P>
		</TD>
		<TD WIDTH=58 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><B>Output</B></P>
		</TD>
		<TD WIDTH=505 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><B>Comments</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=102 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">0
			1</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">0
			right 1</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2
			right 1</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">end</FONT></P>
		</TD>
		<TD WIDTH=58 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">0 1 0</FONT></P>
		</TD>
		<TD WIDTH=505 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.04in; margin-bottom: 0in">1
			1 0 - Initial field</P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.04in; margin-bottom: 0in">0
			1 1 - field after &quot;0 right 1&quot;</P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.04in">0 1 0 - field after &quot;2
			right 1&quot;</P>
		</TD>
	</TR>
</TABLE>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><BR><BR>
</P>
<TABLE WIDTH=442 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=102>
	<COL WIDTH=58>
	<COL WIDTH=58>
	<COL WIDTH=105>
	<COL WIDTH=77>
	<TR VALIGN=TOP>
		<TD WIDTH=102 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><B>Input</B></P>
		</TD>
		<TD WIDTH=58 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><B>Output</B></P>
		</TD>
		<TD WIDTH=58 BGCOLOR="#ffffff" STYLE="border-top: none; border-bottom: none; border-left: 1px solid #00000a; border-right: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><BR>
			</P>
		</TD>
		<TD WIDTH=105 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><B>Input</B></P>
		</TD>
		<TD WIDTH=77 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=102 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">0
			1 2</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">0
			right 1</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1
			right 1</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2
			right 1</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">end</FONT></P>
		</TD>
		<TD WIDTH=58 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">0 0 0</FONT></P>
		</TD>
		<TD WIDTH=58 BGCOLOR="#ffffff" STYLE="border-top: none; border-bottom: none; border-left: 1px solid #00000a; border-right: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><BR>
			</P>
		</TD>
		<TD WIDTH=105 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">5</SPAN></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">3</SPAN></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">3</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">left</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">2</SPAN></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1
			left </FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">-2</SPAN></FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">end</FONT></P>
		</TD>
		<TD WIDTH=77 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">0 0 </FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">0
			</SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">1</SPAN></FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">
			0</SPAN></FONT></P>
		</TD>
	</TR>
</TABLE>
