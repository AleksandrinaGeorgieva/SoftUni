<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Triple Sum</SPAN></H2>
<P STYLE="margin-top: 0.06in">Write a program to read <B>an array of
integers</B> and find all triples of elements <B>a</B>, <B>b</B> and
<B>c</B>, such that <B>a</B> + <B>b</B> == <B>c</B> <SPAN LANG="bg-BG">(</SPAN>where
<B>a</B> stays left from <B>b</B>). Print “<B>No</B>” if no such
triples exist.</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=216 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=99>
	<COL WIDTH=98>
	<TR>
		<TD WIDTH=99 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=98 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">1 1 1 1</FONT></P>
		</TD>
		<TD WIDTH=98 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">No</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">4 2 8 6</FONT></P>
		</TD>
		<TD WIDTH=98 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">4 + 2
			== 6</FONT></P>
			<P><FONT FACE="Consolas, serif">2 + 6 == 8</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">2 7 5 0</FONT></P>
		</TD>
		<TD WIDTH=98 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2 + 5
			== 7</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2 + 0
			== 2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">7 + 0
			== 7</FONT></P>
			<P><FONT FACE="Consolas, serif">5 + 0 == 5</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=99 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">3 1 5 6 1 2</FONT></P>
		</TD>
		<TD WIDTH=98 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3 + 5
			== 5</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 + 5
			== 6</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 + 1
			== 2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 + 2
			== 3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">5 + 1
			== 6</FONT></P>
			<P><FONT FACE="Consolas, serif">1 + 2 == 3</FONT></P>
		</TD>
	</TR>
</TABLE>