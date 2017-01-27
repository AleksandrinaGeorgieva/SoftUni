<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Max Sequence
	of Increasing Elements</SPAN></H2>

<P STYLE="margin-top: 0.06in">Write a program that finds the <B>longest
increasing subsequence</B> in an array of integers. The longest
increasing subsequence is a <B>portion of the array</B> (subsequence)
that is strongly <B>increasing</B> and has the <B>longest possible
length</B>. If several such subsequences exist, find the left most of
them.</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=225 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=121>
	<COL WIDTH=86>
	<TR VALIGN=TOP>
		<TD WIDTH=121 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=86 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=121 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">3 </FONT><FONT FACE="Consolas, serif"><B>2
			3 4</B></FONT><FONT FACE="Consolas, serif"> 2 2 4</FONT></P>
		</TD>
		<TD WIDTH=86 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">2 3 4</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=121 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">4 5 </FONT><FONT FACE="Consolas, serif"><B>1
			2 3 4 5</B></FONT></P>
		</TD>
		<TD WIDTH=86 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">1 2 3 4 5</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=121 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><B>3 4 5 6</B></FONT></P>
		</TD>
		<TD WIDTH=86 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">3 4 5 6</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=121 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><B>0 1 </B></FONT><FONT FACE="Consolas, serif">1
			2 2 3 3</FONT></P>
		</TD>
		<TD WIDTH=86 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">0 1</FONT></P>
		</TD>
	</TR>
</TABLE>