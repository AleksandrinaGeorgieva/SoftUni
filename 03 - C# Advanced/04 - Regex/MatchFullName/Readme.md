<OL>
	<LI><H2 CLASS="western">Match Full Name</H2>
</OL>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
<SPAN LANG="en-US">Write a regular expression to match a valid full
name. A valid full name consists of </SPAN><SPAN LANG="en-US"><B>two
words</B></SPAN><SPAN LANG="en-US">, each word </SPAN><SPAN LANG="en-US"><B>starts</B></SPAN><SPAN LANG="en-US">
with a </SPAN><SPAN LANG="en-US"><B>capital letter</B></SPAN><SPAN LANG="en-US">
and contains </SPAN><SPAN LANG="en-US"><B>only lowercase letters
afterwards</B></SPAN><SPAN LANG="en-US">; each word should be </SPAN><SPAN LANG="en-US"><B>at
least two letters long</B></SPAN><SPAN LANG="en-US">; the two words
should be </SPAN><SPAN LANG="en-US"><B>separated by a single space</B></SPAN><SPAN LANG="en-US">.
</SPAN>
</P>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
<SPAN LANG="en-US">To help you out, we've outlined several steps:</SPAN></P>
<UL>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	<SPAN LANG="en-US">Use an online regex tester like
	</SPAN><FONT COLOR="#0563c1"><SPAN LANG="zxx"><U><A HREF="https://regex101.com/"><SPAN LANG="en-US">https://regex101.com/</SPAN></A></U></SPAN></FONT><SPAN LANG="en-US">
	</SPAN>
	</P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	<SPAN LANG="en-US">Check out how to use </SPAN><SPAN LANG="en-US"><B>character
	sets</B></SPAN><SPAN LANG="en-US"> (denoted with square brackets -
	&quot;[]&quot;)</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	<SPAN LANG="en-US">Specify that you want two words with a space
	between them (the </SPAN><SPAN LANG="en-US"><B>space character ' '</B></SPAN><SPAN LANG="en-US">,
	and not any whitespace symbol)</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	<SPAN LANG="en-US">For each word, specify that it should begin with
	an uppercase letter using a </SPAN><SPAN LANG="en-US"><B>character
	set</B></SPAN><SPAN LANG="en-US">. The desired characters are in a
	range – </SPAN><SPAN LANG="en-US"><B>from 'A' to 'Z'</B></SPAN><SPAN LANG="en-US">.</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	<SPAN LANG="en-US">For each word, specify that what follows the
	first letter are only </SPAN><SPAN LANG="en-US"><B>lowercase
	letters</B></SPAN><SPAN LANG="en-US">, one or more – use another
	character set and the correct </SPAN><SPAN LANG="en-US"><B>quantifier</B></SPAN><SPAN LANG="en-US">.</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	<SPAN LANG="en-US">To prevent capturing of letters across new lines,
	put &quot;\b&quot; at the beginning and at the end of your regex.
	This will ensure that what precedes and what follows the match is a
	word boundary (like a new line).</SPAN></P>
</UL>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
<SPAN LANG="en-US">In order to check your regex, use these values for
reference (paste all of them in the Test String field):</SPAN></P>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">
Examples</H3>
<TABLE WIDTH=690 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=206>
	<COL WIDTH=454>
	<TR>
		<TD WIDTH=206 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P LANG="bg-BG" CLASS="western" ALIGN=CENTER STYLE="margin-top: 0.03in">
			<SPAN LANG="en-US"><B>Match ALL of these</B></SPAN></P>
		</TD>
		<TD WIDTH=454 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P LANG="bg-BG" CLASS="western" ALIGN=CENTER STYLE="margin-top: 0.03in">
			<SPAN LANG="en-US"><B>Match NONE of these</B></SPAN></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=206 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P LANG="bg-BG" CLASS="western" STYLE="margin-top: 0.04in"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Ivan
			Ivanov</SPAN></FONT></P>
		</TD>
		<TD WIDTH=454 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P LANG="bg-BG" CLASS="western" STYLE="margin-top: 0.04in"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">ivan
			ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov,
			Ivan	Ivanov</SPAN></FONT></P>
		</TD>
	</TR>
</TABLE>
<P CLASS="western" STYLE="margin-bottom: 0.14in; line-height: 115%"><BR><BR>
</P>
<TABLE WIDTH=692 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=211>
	<COL WIDTH=462>
	<TR VALIGN=TOP>
		<TD WIDTH=211 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=CENTER><SPAN LANG="en-US"><B>Input</B></SPAN></P>
		</TD>
		<TD WIDTH=462 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=CENTER STYLE="margin-left: -0.06in">
			<SPAN LANG="en-US"><B>Output</B></SPAN></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=211 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">ivan ivanov</SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><SPAN LANG="en-US">Ivan Ivanov</SPAN></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><SPAN LANG="en-US">end</SPAN></FONT></P>
		</TD>
		<TD WIDTH=462 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Ivan
			Ivanov</SPAN></FONT></P>
		</TD>
	</TR>
</TABLE>