<H1 LANG="bg-BG" CLASS="western" ALIGN=CENTER STYLE="margin-top: 0in; margin-bottom: 0.08in; line-height: 100%">
<SPAN LANG="en-US">Rage Quit</SPAN></H1>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
<SPAN LANG="en-US">Every gamer knows what rage-quitting means. It’s
basically when you’re just not good enough and you blame everybody
else for losing a game. You press the CAPS LOCK key on the keyboard
and flood the chat with gibberish to show your frustration.</SPAN></P>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
<SPAN LANG="en-US">Chochko is a gamer, and a bad one at that. He asks
for your help; he wants to be the most annoying kid in his team, so
when he rage-quits he wants something truly spectacular. He’ll give
you </SPAN><SPAN LANG="en-US"><B>a series of strings followed by
non-negative numbers</B></SPAN><SPAN LANG="en-US">, e.g. &quot;a3&quot;;
you need to print on the console </SPAN><SPAN LANG="en-US"><B>each
string repeated N times</B></SPAN><SPAN LANG="en-US">; </SPAN><SPAN LANG="en-US"><B>convert
the letters to uppercase beforehand</B></SPAN><SPAN LANG="en-US">. In
the example, you need to write back &quot;AAA&quot;. </SPAN>
</P>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
<SPAN LANG="en-US">On the output, print first a statistic of the
</SPAN><SPAN LANG="en-US"><B>number of unique symbols</B></SPAN><SPAN LANG="en-US">
used (the casing of letters is irrelevant, meaning that 'a' and 'A'
are the same); the format shoud be </SPAN><SPAN LANG="en-US"><B>&quot;Unique
symbols used {0}&quot;</B></SPAN><SPAN LANG="en-US">. Then, </SPAN><SPAN LANG="en-US"><B>print
the rage message</B></SPAN><SPAN LANG="en-US"> itself.</SPAN></P>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
<SPAN LANG="en-US">The </SPAN><SPAN LANG="en-US"><B>strings and
numbers will not be separated by anything</B></SPAN><SPAN LANG="en-US">.
The input will always start with a string and for each string there
will be a corresponding number. The entire input will be given on a
</SPAN><SPAN LANG="en-US"><B>single line</B></SPAN><SPAN LANG="en-US">;
Chochko is too lazy to make your job easier.</SPAN></P>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
<SPAN LANG="en-US">Input</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The input data should be read from the console.</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">It consists of a single line holding a series of
	</SPAN><SPAN LANG="en-US"><B>string-number sequences</B></SPAN><SPAN LANG="en-US">.</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The input data will always be valid and in the
	format described. There is no need to check it explicitly.</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
<SPAN LANG="en-US">Output</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The output should be printed on the console. It
	should consist of </SPAN><SPAN LANG="en-US"><B>exactly two lines</B></SPAN><SPAN LANG="en-US">.</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">On the first line, print the </SPAN><SPAN LANG="en-US"><B>number
	of unique symbols used</B></SPAN><SPAN LANG="en-US"> in the message.</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">On the second line, print the </SPAN><SPAN LANG="en-US"><B>resulting
	rage message</B></SPAN><SPAN LANG="en-US"> itself.</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
<SPAN LANG="en-US">Constraints</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The count of </SPAN><SPAN LANG="en-US"><B>string-number
	pairs </B></SPAN><SPAN LANG="en-US">will be in the range [1 … 20
	000].</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">Each string will contain any character </SPAN><SPAN LANG="en-US"><B>except
	digits</B></SPAN><SPAN LANG="en-US">. The </SPAN><SPAN LANG="en-US"><B>length</B></SPAN><SPAN LANG="en-US">
	of each string will be in the range [1 … 20].</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The </SPAN><SPAN LANG="en-US"><B>repeat count</B></SPAN><SPAN LANG="en-US">
	for each string will be an integer in the range [0 … 20].</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><A NAME="_GoBack"></A>
	<SPAN LANG="en-US">Allowed working time for your program: 0.3
	seconds. Allowed memory: 64</SPAN><SPAN LANG="en-US"> MB.</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">
<SPAN LANG="en-US">Examples</SPAN></H3>
<TABLE WIDTH=689 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=74>
	<COL WIDTH=178>
	<COL WIDTH=411>
	<TR VALIGN=TOP>
		<TD WIDTH=74 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3><SPAN LANG="en-US">Input</SPAN></FONT></P>
		</TD>
		<TD WIDTH=178 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3><SPAN LANG="en-US">Output</SPAN></FONT></P>
		</TD>
		<TD WIDTH=411 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3><SPAN LANG="en-US">Comments</SPAN></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=74 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">a3</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=178 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">Unique
			symbols used: 1</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">AAA</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=411 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">We
			have just one string-number pair. The symbol is 'a', convert it to
			uppercase and repeat 3 times: AAA.</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">Only
			one symbol is used ('A').</SPAN></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=74 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">aSd2&amp;5s@1</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=178 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">Unique
			symbols used: 5</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">ASDASD&amp;&amp;&amp;&amp;&amp;S@</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=411 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&quot;aSd&quot;
			is converted to &quot;ASD&quot; and repeated twice; &quot;&amp;&quot;
			is repeated 5 times; &quot;s@&quot; is converted to &quot;S@&quot;
			and repeated once.</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">5
			symbols are used: 'A', 'S', 'D', '&amp;' and '@'.</SPAN></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>