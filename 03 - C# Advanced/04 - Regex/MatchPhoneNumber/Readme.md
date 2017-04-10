<OL START=2>
	<LI><H2 CLASS="western">Match Phone Number</H2>
</OL>
<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%"><A NAME="_GoBack1"></A>
<SPAN LANG="en-US">Write a regular expression to match a valid phone
number from Sofia. A valid number will start with &quot;+359&quot;
followed by the area code (2) and then the number itself, consisting
of 7 digits (separated in two group of 3 and 4 digits respectively).
The different parts of the number are separated by </SPAN><SPAN LANG="en-US"><B>either
a space or a hyphen</B></SPAN><SPAN LANG="en-US"> ('-'). Refer to the
examples to get the idea. </SPAN>
</P>
<UL>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in; line-height: 115%">
	<SPAN LANG="en-US">Use quantifiers to match a specific number of
	digits</SPAN></P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in; line-height: 115%">
	<SPAN LANG="en-US">Use a capturing group to make sure the delimiter
	is </SPAN><SPAN LANG="en-US"><B>only one of the allowed characters</B></SPAN><SPAN LANG="en-US">
	</SPAN><SPAN LANG="en-US"><B>(space or hyphen)</B></SPAN><SPAN LANG="en-US">
	and not a combination of both. Use the group number to achieve this</SPAN></P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in; line-height: 115%">
	<SPAN LANG="en-US">Add a word boundary at the end of the match to
	avoid partial matches (the last example on the right-hand side)</SPAN></P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in; line-height: 115%">
	<SPAN LANG="en-US">Ensure that before the '+' sign there is either a
	space or the beginning of the string</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">
Examples</H3>
<TABLE WIDTH=654 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=147>
	<COL WIDTH=477>
	<TR>
		<TD WIDTH=147 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P LANG="bg-BG" CLASS="western" ALIGN=CENTER STYLE="margin-top: 0.03in">
			<SPAN LANG="en-US"><B>Match ALL of these</B></SPAN></P>
		</TD>
		<TD WIDTH=477 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P LANG="bg-BG" CLASS="western" ALIGN=CENTER STYLE="margin-top: 0.03in">
			<SPAN LANG="en-US"><B>Match NONE of these</B></SPAN></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=147 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P LANG="bg-BG" CLASS="western" STYLE="margin-top: 0.04in; margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">+359 2 222 2222</SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">+359-2-222-2222</SPAN></FONT></P>
		</TD>
		<TD WIDTH=477 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P LANG="bg-BG" CLASS="western" STYLE="margin-top: 0.04in; margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">359-2-222-2222,
			+359/2/222/2222, +359-2 222 2222</SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">+359
			2-222-2222, +359-2-222-222, +359-2-222-22222</SPAN></FONT></P>
		</TD>
	</TR>
</TABLE>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
<BR><BR>
</P>
<TABLE WIDTH=654 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=154>
	<COL WIDTH=482>
	<TR VALIGN=TOP>
		<TD WIDTH=154 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=CENTER><SPAN LANG="en-US"><B>Input</B></SPAN></P>
		</TD>
		<TD WIDTH=482 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=CENTER STYLE="margin-left: -0.06in">
			<SPAN LANG="en-US"><B>Output</B></SPAN></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=154 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">+359 2 222 2222</SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">+3591345123</SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><SPAN LANG="en-US">end</SPAN></FONT></P>
		</TD>
		<TD WIDTH=482 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">+359 2 222 2222</SPAN></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=154 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">+359 2 234 5678</SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">+359-2-234-5678</SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">+359-2 234-5678</SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><SPAN LANG="en-US">end</SPAN></FONT></P>
		</TD>
		<TD WIDTH=482 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">+359 2 234 5678</SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><SPAN LANG="en-US">+359-2-234-5678</SPAN></FONT></P>
		</TD>
	</TR>
</TABLE>