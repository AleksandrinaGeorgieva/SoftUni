<H2 CLASS="western">** Melrah Shake</H2>

<P STYLE="margin-bottom: 0.14in; line-height: 115%">You are given a
<B>string</B> of random characters, and a <B>pattern</B> of random
characters. You need to “shake off” (<B>remove</B>) all of the
<B>border</B> occurrences of that pattern, in other words, the <B>very</B>
<B>first</B> <B>match</B> and the <B>very last match </B>of the
pattern you find in the string.</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">When you
successfully shake off a match, you <B>remove</B> from the pattern
the character which corresponds to the <B>index</B> equal to <B>the
pattern’s length / 2</B>. Then you continue to shake off the border
occurrences of the new pattern until the pattern becomes <B>empty</B>
or until there is <B>less </B>than the - needed for shake, matches in
the remaining string.</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">In case you have
found at least <B>two</B> matches, and you have successfully shaken
them off, you print “Shaked it.” on the console. Otherwise you
print “No shake.”, the remains of the main string, and you end
the program. See the examples for more info.</P>
<H3 CLASS="western">Input</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	The input will consist only of two lines.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	On the first line you will get a string of random characters.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	On the second line you will receive the pattern and that ends the
	input sequence.</P>
</UL>
<H3 CLASS="western">Output</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">You must
	print “Shaked it.” for every time you successfully do the melrah
	shake.</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">If the
	melrah shake fails, you print “No shake.”, and on the next line
	you print what has remained of the main string.</P>
</UL>
<H3 CLASS="western">Constraints</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">The two
	strings may contain <B>ANY </B>ASCII character.</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">Allowed
	time/memory: 250ms/16MB.</P>
</UL>
<H3 CLASS="western">Examples</H3>
<P STYLE="margin-bottom: 0.14in; line-height: 115%"><BR><BR>
</P>
<TABLE WIDTH=599 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=285>
	<TR VALIGN=TOP>
		<TD WIDTH=296 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=285 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=3>Output</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 HEIGHT=33 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">astalavista
			baby</FONT></FONT></P>
			<P><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">sta</FONT></FONT></P>
		</TD>
		<TD WIDTH=285 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>Shaked
			it.</FONT></FONT></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>No
			shake.</FONT></FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>alavi
			baby</FONT></FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">
			</FONT></FONT>
			</P>
		</TD>
	</TR>
</TABLE>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 0.07in"><BR>
</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 0.07in"><BR>
</P>
<TABLE WIDTH=599 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=285>
	<TR VALIGN=TOP>
		<TD WIDTH=296 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=3>Input</FONT></P>
		</TD>
		<TD WIDTH=285 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=3>Output</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 HEIGHT=33 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">##mtm!!mm.mm*mtm.#</FONT></FONT></P>
			<P><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt">mtm</FONT></FONT></P>
		</TD>
		<TD WIDTH=285 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>Shaked
			it.</FONT></FONT></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>Shaked
			it.</FONT></FONT></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>No
			shake.</FONT></FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Courier New, serif"><FONT SIZE=2>##!!.*.#</FONT></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>