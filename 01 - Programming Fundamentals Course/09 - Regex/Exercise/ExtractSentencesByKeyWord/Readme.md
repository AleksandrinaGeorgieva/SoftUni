<H2 CLASS="western" ALIGN=JUSTIFY>Extract sentences by keyword</H2>

<P STYLE="margin-bottom: 0.14in; line-height: 115%">Write a program
that <B>extracts from a text all sentences that contain a particular
word </B>(case-sensitive).</P>
<UL>
	<LI><P STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	Assume that the <B>sentences</B> are separated from each other by
	the character &quot;<FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>.</B></SPAN></FONT>&quot;
	or &quot;<FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>!</B></SPAN></FONT>&quot;
	or &quot;<FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>?</B></SPAN></FONT>&quot;.</P>
	<LI><P STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	The <B>words</B> are separated one from another by a <B>non-letter
	character</B>.</P>
	<LI><P STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	Not<SPAN LANG="bg-BG">е</SPAN> that appearance as <B>substring</B>
	is different than appearance as <B>word</B>.<SPAN LANG="bg-BG"> </SPAN>The
	sentence <I>“I am a fan of Mo</I><I><B>to</B></I><I>rhead</I>”
	does not contain the word “<I><B>to</B></I>”.<SPAN LANG="bg-BG">
	</SPAN>It contains the substring “<I><B>to</B></I>” which is not
	what we need.</P>
	<LI><P STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	Print the result <B>sentence</B><SPAN LANG="bg-BG"><B> </B></SPAN><B>text</B>
	without the separators between the sentences (&quot;<FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>.</B></SPAN></FONT>&quot;
	or &quot;<FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>!</B></SPAN></FONT>&quot;
	or &quot;<FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"><B>?</B></SPAN></FONT>&quot;)<SPAN LANG="bg-BG">.</SPAN></P>
</UL>
<H3 CLASS="western">Example</H3>
<TABLE WIDTH=697 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=687>
	<TR>
		<TD WIDTH=687 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=687 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><B><SPAN STYLE="background: #ffffff">to</SPAN></B></FONT></FONT></P>
			<P STYLE="margin-top: 0.04in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffffff">Welcome
			</SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><B><SPAN STYLE="background: #ffffff">to</SPAN></B></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffffff">
			SoftUni! You will learn programming, algorithms, problem solving
			and software technologies. You need </SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><B><SPAN STYLE="background: #ffffff">to</SPAN></B></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffffff">
			allocate for study 20-30 hours weekly. Good luck! I am fan of
			Motorhead. To be or not </SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><B><SPAN STYLE="background: #ffffff">to</SPAN></B></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffffff">
			be - that is the question. TO DO OR NOT?</SPAN></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=687 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=687 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffffff">Welcome
			</SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><B><SPAN STYLE="background: #ffffff">to</SPAN></B></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffffff">
			SoftUni</SPAN></FONT></FONT></P>
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffffff">You
			need </SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><B><SPAN STYLE="background: #ffffff">to</SPAN></B></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffffff">
			allocate for study 20-30 hours weekly</SPAN></FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffffff">To
			be or not </SPAN></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><B><SPAN STYLE="background: #ffffff">to</SPAN></B></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffffff">
			be - that is the question</SPAN></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>