<H1 LANG="bg-BG" CLASS="western" ALIGN=CENTER STYLE="margin-top: 0in; margin-bottom: 0.08in; line-height: 100%"><A NAME="_GoBack"></A>
<SPAN LANG="en-US"></SPAN><SPAN LANG="en-US"> – Command
Interpreter</SPAN></H1>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
<SPAN LANG="en-US">Jagged arrays, regular expressions, asynchronous
programming… Tough stuff. But simple structures like arrays are
piece of cake, right? Let’s see how well you can manipulate data in
a collection.</SPAN></P>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
<SPAN LANG="en-US">You will be given a series of strings on a single
line, separated by one or more whitespaces. These represent the
collection you’ll be working with.</SPAN></P>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
<SPAN LANG="en-US">On the next input lines, until you receive the
command </SPAN><SPAN LANG="en-US"><B>&quot;end&quot;</B></SPAN><SPAN LANG="en-US">,
you’ll receive a series of commands in one of the following
formats:</SPAN></P>
<UL>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
	<SPAN LANG="en-US"><B>&quot;reverse from [start] count [count]&quot;</B></SPAN><SPAN LANG="en-US">
	– this instructs you to reverse a </SPAN><SPAN LANG="en-US"><B>portion</B></SPAN><SPAN LANG="en-US">
	of the array – just [count] elements starting at index [start];</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
	<SPAN LANG="en-US"><B>&quot;sort from [start] count [count]&quot;</B></SPAN><SPAN LANG="en-US">
	– this instructs you to sort a </SPAN><SPAN LANG="en-US"><B>portion</B></SPAN><SPAN LANG="en-US">
	of the array - [count] elements starting at index [start];</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
	<SPAN LANG="en-US"><B>&quot;rollLeft [count] times&quot;</B></SPAN><SPAN LANG="en-US">
	– this instructs you to move </SPAN><SPAN LANG="en-US"><B>all</B></SPAN><SPAN LANG="en-US">
	elements in the array to the left [count] times. On each roll, the
	first element is placed at the end of the array;</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
	<SPAN LANG="en-US"><B>&quot;rollRight [count] times&quot;</B></SPAN><SPAN LANG="en-US">
	– this instructs you to move </SPAN><SPAN LANG="en-US"><B>all</B></SPAN><SPAN LANG="en-US">
	elements in the array to the right [count] times. On each roll, the
	last element is placed at the beginning of the array;</SPAN></P>
</UL>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
<SPAN LANG="en-US">If any of the provided indices or counts is
</SPAN><SPAN LANG="en-US"><B>invalid</B></SPAN><SPAN LANG="en-US">
(non-existent or negative), you should print a message on the console
– </SPAN><SPAN LANG="en-US"><B>&quot;Invalid input parameters.&quot;
</B></SPAN><SPAN LANG="en-US">and</SPAN><SPAN LANG="en-US"><B> keep
the collection unchanged.</B></SPAN></P>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 100%">
<SPAN LANG="en-US">After you’re done, print the resulting array in
the following format: </SPAN><SPAN LANG="en-US"><B>&quot;[arr0, arr1
… arrN]&quot;</B></SPAN><SPAN LANG="en-US">. The examples should
help you understand the task better.</SPAN></P>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
<SPAN LANG="en-US">Input</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The input data should be read from the console.</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The first input line will hold </SPAN><SPAN LANG="en-US"><B>a
	series of strings</B></SPAN><SPAN LANG="en-US">, separated by </SPAN><SPAN LANG="en-US"><B>one
	or more whitespaces</B></SPAN><SPAN LANG="en-US">.</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The next lines will hold </SPAN><SPAN LANG="en-US"><B>commands</B></SPAN><SPAN LANG="en-US">
	in the described formats (exactly).</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The input ends with the keyword </SPAN><SPAN LANG="en-US"><B>&quot;end&quot;.</B></SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The input data will always be valid and in the
	format described. There is no need to check it explicitly.</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
<SPAN LANG="en-US">Output</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The output should be printed on the console. </SPAN>
	</P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">Each time an invalid command is received
	(containing an invalid index or count parameter), print the
	following line: </SPAN><SPAN LANG="en-US"><B>&quot;Invalid input
	parameters.&quot;</B></SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">After receiving the &quot;</SPAN><SPAN LANG="en-US"><B>end</B></SPAN><SPAN LANG="en-US">&quot;
	command, print the </SPAN><SPAN LANG="en-US"><B>resulting array</B></SPAN><SPAN LANG="en-US">
	on the console in the format specified above.</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
<SPAN LANG="en-US">Constraints</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The </SPAN><SPAN LANG="en-US"><B>count of strings</B></SPAN><SPAN LANG="en-US">
	in the collection will be in the range [1 … 50].</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The </SPAN><SPAN LANG="en-US"><B>number of
	commands</B></SPAN><SPAN LANG="en-US"> will be in the range [1 …
	20].</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">All commands will be in the described format; an
	invalid command is a command containing invalid [start] or [count],
	</SPAN><SPAN LANG="en-US"><B>there won’t be any missing or
	misspelled words</B></SPAN><SPAN LANG="en-US">.</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">[</SPAN><SPAN LANG="en-US"><B>start</B></SPAN><SPAN LANG="en-US">]
	and [</SPAN><SPAN LANG="en-US"><B>count</B></SPAN><SPAN LANG="en-US">]
	will be integers in the range [-2</SPAN><SUP><SPAN LANG="en-US">31</SPAN></SUP><SPAN LANG="en-US">
	… 2</SPAN><SUP><SPAN LANG="en-US">31 </SPAN></SUP><SPAN LANG="en-US">-
	1].</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">Allowed working time for your program: 0.1
	seconds. Allowed memory: 16</SPAN><SPAN LANG="en-US"> MB.</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">
<SPAN LANG="en-US">Examples</SPAN></H3>
<TABLE WIDTH=437 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=182>
	<COL WIDTH=237>
	<TR VALIGN=TOP>
		<TD WIDTH=182 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3><SPAN LANG="en-US">Input</SPAN></FONT></P>
		</TD>
		<TD WIDTH=237 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT SIZE=3><SPAN LANG="en-US">Output</SPAN></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=182 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">1
			2 </SPAN></FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US"><B><SPAN STYLE="background: #808080">5
			8 7 3</SPAN></B></SPAN></FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">
			10 6 4 9</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">reverse
			from 2 count 4</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">end</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=237 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">[1,
			2, </SPAN></FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US"><B><SPAN STYLE="background: #c0c0c0">3,
			7, 8, 5</SPAN></B></SPAN></FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">,
			10, 6, 4, 9]</SPAN></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>