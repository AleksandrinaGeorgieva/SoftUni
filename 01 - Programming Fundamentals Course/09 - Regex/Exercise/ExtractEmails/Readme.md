<H2 CLASS="western" ALIGN=JUSTIFY>Extract emails</H2>

<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><FONT COLOR="#000000"><FONT FACE="Calibri, serif"><FONT SIZE=3><FONT SIZE=2 STYLE="font-size: 11pt">Write
a program to </FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>extract
all email addresses from a given text</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">.
The text comes at the only input line. Print the emails on the
console, each at a separate line. Emails are considered to be in
format </FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>&lt;user&gt;@&lt;host&gt;</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">,
where: </FONT></FONT></FONT></FONT>
</P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.05in; line-height: 100%">
	<FONT COLOR="#000000"><FONT FACE="Calibri, serif"><FONT SIZE=3><FONT SIZE=2 STYLE="font-size: 11pt"><B>&lt;user&gt;
	</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">is a sequence of
	letters and digits, where '</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>.</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">',
	'</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>-</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">'
	and '</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>_</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">'
	can appear between them. Examples of valid users: &quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>stephan</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>mike03</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>s.johnson</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>st_steward</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>softuni-bulgaria</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>12345</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;.
	Examples of invalid users: ''</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>--123</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;.....&quot;, &quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>nakov_-</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>_steve</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>.info</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;.
	</FONT></FONT></FONT></FONT>
	</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.05in; line-height: 100%">
	<FONT COLOR="#000000"><FONT FACE="Calibri, serif"><FONT SIZE=3><FONT SIZE=2 STYLE="font-size: 11pt"><B>&lt;host&gt;
	</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">is a sequence of at
	least two words, separated by dots '</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>.</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">'.
	Each word is sequence of letters and can have hyphens '</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>-</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">'
	between the letters. Examples of hosts: &quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>softuni.bg</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>software-university.com</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>intoprogramming.info</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>mail.softuni.org</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;.
	Examples of invalid hosts: &quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>helloworld</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>.unknown.soft.</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>invalid-host-</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;,
	&quot;</FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>invalid-</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">&quot;.
	</FONT></FONT></FONT></FONT>
	</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.05in; line-height: 100%">
	<FONT COLOR="#000000"><FONT FACE="Calibri, serif"><FONT SIZE=3><FONT SIZE=2 STYLE="font-size: 11pt">Examples
	of </FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>valid emails</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">:
	info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com,
	s.peterson@mail.uu.net,
	</FONT><FONT COLOR="#0000ff"><SPAN LANG="zxx"><U><A HREF="mailto:info-bg@software-university.software.academy"><FONT SIZE=2 STYLE="font-size: 11pt">info-bg@software-university.software.academy</FONT></A></U></SPAN></FONT><FONT SIZE=2 STYLE="font-size: 11pt">.
	</FONT></FONT></FONT></FONT>
	</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.05in; line-height: 100%">
	<FONT COLOR="#000000"><FONT FACE="Calibri, serif"><FONT SIZE=3><FONT SIZE=2 STYLE="font-size: 11pt">Examples
	of </FONT><FONT SIZE=2 STYLE="font-size: 11pt"><B>invalid emails</B></FONT><FONT SIZE=2 STYLE="font-size: 11pt">:
	</FONT><FONT COLOR="#0000ff"><SPAN LANG="zxx"><U><A HREF="mailto:--123@gmail.com"><FONT SIZE=2 STYLE="font-size: 11pt">--123@gmail.com</FONT></A></U></SPAN></FONT><FONT SIZE=2 STYLE="font-size: 11pt">,
	…@mail.bg, </FONT><FONT COLOR="#0000ff"><SPAN LANG="zxx"><U><A HREF="mailto:.info@info.info"><FONT SIZE=2 STYLE="font-size: 11pt">.info@info.info</FONT></A></U></SPAN></FONT><FONT SIZE=2 STYLE="font-size: 11pt">,
	</FONT><FONT COLOR="#0000ff"><SPAN LANG="zxx"><U><A HREF="mailto:_steve@yahoo.cn"><FONT SIZE=2 STYLE="font-size: 11pt">_steve@yahoo.cn</FONT></A></U></SPAN></FONT><FONT SIZE=2 STYLE="font-size: 11pt">,
	mike@helloworld, </FONT><FONT COLOR="#0000ff"><SPAN LANG="zxx"><U><A HREF="mailto:mike@.unknown.soft"><FONT SIZE=2 STYLE="font-size: 11pt">mike@.unknown.soft</FONT></A></U></SPAN></FONT><FONT SIZE=2 STYLE="font-size: 11pt">.,
	</FONT><A HREF="mailto:s.johnson@invalid-"><FONT SIZE=2 STYLE="font-size: 11pt">s.johnson@invalid-</FONT></A><FONT SIZE=2 STYLE="font-size: 11pt">.</FONT></FONT></FONT></FONT></P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples:</H3>
<TABLE WIDTH=694 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=487>
	<COL WIDTH=189>
	<TR VALIGN=TOP>
		<TD WIDTH=487 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=189 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=487 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">Please contact us
			at: support@github.com.</FONT></P>
		</TD>
		<TD WIDTH=189 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><I>support@github.com</I></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=487 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><A NAME="__DdeLink__1520_1553542260"></A><A NAME="__DdeLink__1548_1553542260"></A>
			<FONT FACE="Consolas, serif">Just send email to s.miller@mit.edu
			and j.hopking@york.ac.uk for more information.</FONT></P>
		</TD>
		<TD WIDTH=189 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><I>s.miller@mit.edu</I></FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><I>j.hopking@york.ac.uk</I></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=487 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">Many users @ SoftUni
			confuse email addresses. We @ Softuni.BG provide high-quality
			training @ home or @ class. –- steve.parker@softuni.de.</FONT></P>
		</TD>
		<TD WIDTH=189 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><I>steve.parker@softuni.de</I></FONT></P>
		</TD>
	</TR>
</TABLE>