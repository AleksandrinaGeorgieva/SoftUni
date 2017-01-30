<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Equal Sums</SPAN></H2>

<P STYLE="margin-top: 0.06in">Write a program that determines if
there <B>exists an element in the array</B> such that the <B>sum of
the elements on its left</B> is <B>equal</B> to the <B>sum of the
elements on its right</B>. If there are <B>no elements to the left /
right</B>, their <B>sum is considered to be 0</B>. Print the <B>index</B>
that satisfies the required condition or <B>“no”</B> if there is
no such index.</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=612 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=196>
	<COL WIDTH=54>
	<COL WIDTH=336>
	<TR VALIGN=TOP>
		<TD WIDTH=196 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=54 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=336 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=196 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">1
			2</SPAN></FONT><FONT FACE="Consolas, serif"> </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">3</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ffff">3</SPAN></FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">2</FONT></P>
		</TD>
		<TD WIDTH=336 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">At a[2]
			-&gt; </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">left
			sum = 3</SPAN></FONT><FONT FACE="Consolas, serif">, </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ffff">right
			sum = 3</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif">a[0] + a[1] = a[3]</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=196 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">1 2</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">no</FONT></P>
		</TD>
		<TD WIDTH=336 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">At a[0]
			-&gt; left sum = 0, right sum = 2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">At a[1]
			-&gt; left sum = 1, right sum = 0</FONT></P>
			<P><FONT FACE="Consolas, serif">No such index exists</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=196 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">1</SPAN></FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">0</FONT></P>
		</TD>
		<TD WIDTH=336 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">At a[0] -&gt; left sum = 0, right
			sum = 0</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=196 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">1 2 3</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">no</FONT></P>
		</TD>
		<TD WIDTH=336 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">No such index exists</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=196 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">10
			5 5</SPAN></FONT><FONT FACE="Consolas, serif"> </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">99</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ffff">3
			4 2 5 1 1 4</SPAN></FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">3</FONT></P>
		</TD>
		<TD WIDTH=336 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">At a[3]
			-&gt; </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">left
			sum = 20</SPAN></FONT><FONT FACE="Consolas, serif">, </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ffff">right
			sum = 20</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif">a[0] + a[1] + a[2] = a[4] + a[5] +
			a[6] + a[7] + a[8] + a[9] + a[10]</FONT></P>
		</TD>
	</TR>
</TABLE>