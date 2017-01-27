<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Rotate and
	Sum</SPAN></H2>

<P STYLE="margin-top: 0.06in">To “<B>rotate</B> an array on the
right” means to move its last element first: {1, 2, 3} <FONT FACE="Wingdings, serif"></FONT>
{3, 1, 2}.</P>
<P STYLE="margin-top: 0.06in">Write a program to read an array of <B>n</B>
<B>integers</B> (space separated on a single line) and an integer <B>k</B>,
rotate the array right <B>k</B> <B>times</B> and sum the obtained
arrays after each rotation as shown below.</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=437 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=83>
	<COL WIDTH=100>
	<COL WIDTH=228>
	<TR VALIGN=TOP>
		<TD WIDTH=83 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=100 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=228 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=83 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3 2 4
			-1</FONT></P>
			<P><FONT FACE="Consolas, serif">2</FONT></P>
		</TD>
		<TD WIDTH=100 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3 2 5 6</FONT></P>
			<P><BR>
			</P>
		</TD>
		<TD WIDTH=228 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=RIGHT STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">rotated1[]
			= -1  3  2  4</FONT></P>
			<P ALIGN=RIGHT STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">rotated2[]
			=  4 -1  3  2</FONT></P>
			<P ALIGN=RIGHT><FONT FACE="Consolas, serif">sum[] =  </FONT><FONT FACE="Consolas, serif">3
			 2  5  6</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=83 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 2 3</FONT></P>
			<P><FONT FACE="Consolas, serif">1</FONT></P>
		</TD>
		<TD WIDTH=100 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3 1 2</FONT></P>
			<P><BR>
			</P>
		</TD>
		<TD WIDTH=228 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=RIGHT STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">rotated1[]
			= </FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">3 1 2</SPAN></FONT></P>
			<P ALIGN=RIGHT><FONT FACE="Consolas, serif">sum[] = </FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">3
			1 2</SPAN></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=83 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 2 3 4
			5</FONT></P>
			<P><FONT FACE="Consolas, serif">3</FONT></P>
		</TD>
		<TD WIDTH=100 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">12 10 8
			6 9</FONT></P>
			<P ALIGN=CENTER><BR>
			</P>
		</TD>
		<TD WIDTH=228 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=RIGHT STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">rotated1[]
			=</FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"> </SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">5  1  2  3 
			4</SPAN></FONT></P>
			<P ALIGN=RIGHT STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">rotated2[]
			=</FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"> </SPAN></FONT><FONT FACE="Consolas, serif">
			4</FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">  5  1  2 
			3</SPAN></FONT></P>
			<P ALIGN=RIGHT STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">rotated</FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">3</SPAN></FONT><FONT FACE="Consolas, serif">[]
			=</FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG"> </SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">3  4  5  1 
			2</SPAN></FONT></P>
			<P ALIGN=RIGHT><FONT FACE="Consolas, serif">sum[] = </FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">12
			10  8  6  9</SPAN></FONT></P>
		</TD>
	</TR>
</TABLE>