<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Fix Emails</SPAN></H2>

<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><A NAME="__DdeLink__998_1408925518"></A>
You are given a sequence of strings, each on a new line, <B>until you
receive the “stop” command</B>. The first string is the <B>name</B>
of a person. On the second line you will receive their <B>email</B>.
Your task is to <B>collect</B> their <B>names</B> and <B>emails</B>,
and <B>remove</B> emails whose domain <B>ends with</B> &quot;<B>us</B>&quot;
or &quot;<B>uk</B>&quot; (case insensitive). Print:</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>{name} – &gt;
{email}</B> 
</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=600 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=247>
	<COL WIDTH=334>
	<TR VALIGN=TOP>
		<TD WIDTH=247 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=CENTER STYLE="margin-top: 0.06in"><B>Input</B></P>
		</TD>
		<TD WIDTH=334 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=CENTER STYLE="margin-top: 0.06in"><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=247 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#0000ff"><SPAN LANG="zxx"><U><A HREF="mailto:ivanivan@abv.bg"><FONT FACE="Consolas, serif">ivanivan@abv.bg</FONT></A></U></SPAN></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Petar
			Ivanov</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">petartudjarov@abv.bg</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Mike
			Tyson</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><A HREF="mailto:myke@gmail.us"><FONT FACE="Consolas, serif">myke@gmail.us</FONT></A></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif">stop</FONT></P>
		</TD>
		<TD WIDTH=334 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			-&gt; </FONT><FONT COLOR="#0000ff"><SPAN LANG="zxx"><U><A HREF="mailto:ivanivan@abv.bg"><FONT FACE="Consolas, serif">ivanivan@abv.bg</FONT></A></U></SPAN></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif">Petar
			Ivanov -&gt; petartudjarov@abv.bg</FONT></P>
		</TD>
	</TR>
</TABLE>		