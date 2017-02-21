<H1 LANG="bg-BG" CLASS="western"><A NAME="_GoBack"></A>
Cubic’s <SPAN LANG="en-US">Messages</SPAN></H1>
<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">Cubic
is a veteran soldier from The Great Cubic Army. He has even
participated in the Spherical Invasion as a Sergeant First Class. As
a veteran, Cubic has some personal security issues – he
communicates only trough text messages and sends them in a specific
encrypted way, which you must decrypt in order to understand what he
is saying.</SPAN></P>
<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">You
will begin receiving lines of input, which will consist of random
ASCII characters – Cubic’s encrypted lines. After each line you
will receive a number – the length of the message he sent. Cubic
might send false messages, in an act to confuse his “enemies”.
You must capture only the messages that follow a certain format. </SPAN>
</P>
<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">According
to that format the </SPAN><SPAN LANG="en-US"><B>valid</B></SPAN><SPAN LANG="en-US">
messages:</SPAN></P>
<UL>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">Consist
	of </SPAN><SPAN LANG="en-US"><B>m </B></SPAN><SPAN LANG="en-US">characters,
	where </SPAN><SPAN LANG="en-US"><B>m </B></SPAN><SPAN LANG="en-US">is
	the integer entered after each encrypted line.  </SPAN>
	</P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">Has
	only digits before itself in the encrypted line</SPAN></P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">Consists
	only of English alphabet letters</SPAN></P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">Has
	no English alphabet letters after itself in the encrypted line</SPAN></P>
</UL>
<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US"><B>Any</B></SPAN><SPAN LANG="en-US">
message that </SPAN><SPAN LANG="en-US"><B>does not follow</B></SPAN><SPAN LANG="en-US">
the, specified above, rules, is </SPAN><SPAN LANG="en-US"><B>invalid</B></SPAN><SPAN LANG="en-US">,
and you must </SPAN><SPAN LANG="en-US"><B>ignore it</B></SPAN><SPAN LANG="en-US">.</SPAN></P>
<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">After
you find </SPAN><SPAN LANG="en-US"><B>all valid</B></SPAN><SPAN LANG="en-US">
messages, you need to find their </SPAN><SPAN LANG="en-US"><B>verification
code</B></SPAN><SPAN LANG="en-US">. Every message has its own
verification code, which Cubic gives in order to verify the message.
</SPAN><SPAN LANG="en-US"><B>Take all the digits before the message</B></SPAN><SPAN LANG="en-US">
and all the digits </SPAN><SPAN LANG="en-US"><B>after the message</B></SPAN><SPAN LANG="en-US">
and consider them as </SPAN><SPAN LANG="en-US"><B>indexes</B></SPAN><SPAN LANG="en-US">.
If they are </SPAN><SPAN LANG="en-US"><B>valid existing</B></SPAN><SPAN LANG="en-US">
indexes </SPAN><SPAN LANG="en-US"><B>in the message</B></SPAN><SPAN LANG="en-US">,
</SPAN><SPAN LANG="en-US"><B>form a string</B></SPAN><SPAN LANG="en-US">
with those indexes </SPAN><SPAN LANG="en-US"><B>taking characters
from the message</B></SPAN><SPAN LANG="en-US">. If an index is
</SPAN><SPAN LANG="en-US"><B>nonexistent</B></SPAN><SPAN LANG="en-US">,
put a </SPAN><SPAN LANG="en-US"><B>space </B></SPAN><SPAN LANG="en-US">there.
The string you form up is the verification code for the current
message. </SPAN>
</P>
<H3 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Input</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">The
	input will always come in the form of 2 lines, except when it is the
	line terminating the input sequence.</SPAN></P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">The
	first input line will contain random ASCII characters, and the
	second – a number.</SPAN></P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">When
	the line “</SPAN><SPAN LANG="en-US"><B>Over!</B></SPAN><SPAN LANG="en-US">”
	is entered, the input sequence ends. </SPAN>
	</P>
</UL>
<H3 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Output</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">The
	output is simple. You must print all the valid messages you’ve
	found, each on a new line, and their verification codes, if they
	have such.</SPAN></P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">The
	format of output is “</SPAN><SPAN LANG="en-US"><B>{message} ==
	{verificationCode}</B></SPAN><SPAN LANG="en-US">”.</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Constraints</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">The
	input lines can consist of </SPAN><SPAN LANG="en-US"><B>ANY ASCII</B></SPAN><SPAN LANG="en-US">
	character.</SPAN></P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">There
	will be </SPAN><SPAN LANG="en-US"><B>NO </B></SPAN><SPAN LANG="en-US">such
	cases as an encrypted message without a number before it.</SPAN></P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">The
	number will be a valid integer in the range [0, 100].</SPAN></P>
	<LI><P LANG="bg-BG" STYLE="margin-bottom: 0.14in"><SPAN LANG="en-US">Allowed
	time/memory: 100ms/16MB</SPAN></P>
</UL>
<P CLASS="western" STYLE="margin-bottom: 0.14in"><BR><BR>
</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in"><BR><BR>
</P>
<H3 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Examples</SPAN></H3>
<TABLE WIDTH=599 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=285>
	<TR VALIGN=TOP>
		<TD WIDTH=296 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" ALIGN=LEFT><B><FONT FACE="Calibri, serif">Input</FONT></B></P>
		</TD>
		<TD WIDTH=285 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" ALIGN=LEFT><B><FONT FACE="Calibri, serif">Output</FONT></B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 HEIGHT=33 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><SPAN LANG="en-US">1234test4321</SPAN></P>
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><SPAN LANG="en-US">4</SPAN></P>
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><SPAN LANG="en-US">0000oooo0000</SPAN></P>
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><SPAN LANG="en-US">4</SPAN></P>
			<P LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Over!</SPAN></P>
		</TD>
		<TD WIDTH=285 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<SPAN LANG="en-US">test == est  tse</SPAN></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><SPAN LANG="en-US">oooo
			== oooooooo</SPAN></P>
		</TD>
	</TR>
</TABLE>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 0.07in">
<BR>
</P>
<TABLE WIDTH=599 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=285>
	<TR VALIGN=TOP>
		<TD WIDTH=296 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" ALIGN=LEFT><B><FONT FACE="Calibri, serif">Input</FONT></B></P>
		</TD>
		<TD WIDTH=285 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" ALIGN=LEFT><B><FONT FACE="Calibri, serif">Output</FONT></B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 HEIGHT=33 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><SPAN LANG="en-US">1wat!</SPAN></P>
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><SPAN LANG="en-US">3</SPAN></P>
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><SPAN LANG="en-US">#23asd33</SPAN></P>
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><SPAN LANG="en-US">3</SPAN></P>
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><SPAN LANG="en-US">333asd3a</SPAN></P>
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><SPAN LANG="en-US">3</SPAN></P>
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><SPAN LANG="en-US">100dun2</SPAN></P>
			<P LANG="bg-BG" CLASS="western" STYLE="margin-bottom: 0in"><SPAN LANG="en-US">3</SPAN></P>
			<P LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Over!</SPAN></P>
		</TD>
		<TD WIDTH=285 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<SPAN LANG="en-US">wat == a</SPAN></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><SPAN LANG="en-US">dun
			== uddn</SPAN></P>
		</TD>
	</TR>
</TABLE>