<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Bomb Numbers</SPAN></H2>

<P STYLE="margin-top: 0.06in">Write a program that <B>reads sequence
of numbers</B> and <B>special bomb number </B>with a certain<B>
power</B>. Your task is to <B>detonate every occurrence of the
special bomb number</B> and according to its power <B>his neighbors
from left and right</B>. Detonations are performed from left to right
and all detonated numbers disappear. Finally print the<B> sum of the
remaining elements</B> in the sequence.</P>
<H3 CLASS="western"><A NAME="_GoBack"></A>Examples</H3>
<TABLE WIDTH=688 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=164>
	<COL WIDTH=54>
	<COL WIDTH=444>
	<TR VALIGN=TOP>
		<TD WIDTH=164 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=54 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=444 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=164 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">2
			2</SPAN></FONT><FONT FACE="Consolas, serif"> </FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">4</SPAN></FONT></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">2
			2</SPAN></FONT><FONT FACE="Consolas, serif"> 2 9</FONT></P>
			<P><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">4</SPAN></FONT></FONT><FONT FACE="Consolas, serif">
			2</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">12</FONT></P>
		</TD>
		<TD WIDTH=444 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P>Special number is <B>4</B> with power 2. After detontaion we
			left with the sequence [1, 2, 9] with sum 12.</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=164 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 4 </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">4
			2 8</SPAN></FONT><FONT FACE="Consolas, serif"> </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">9</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">1</SPAN></FONT></P>
			<P><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">9</SPAN></FONT></FONT><FONT FACE="Consolas, serif">
			3</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">5</FONT></P>
		</TD>
		<TD WIDTH=444 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P>Special number is <B>9</B> with power 3. After detontaion we
			left with the sequence [1, 4] with sum 5. Since the 9 has only 1
			neighbour from the right we remove just it (one number instead of
			3).</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=164 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">1</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">7</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">7</SPAN></FONT><FONT FACE="Consolas, serif">
			1 2 3</FONT></P>
			<P><FONT FACE="Consolas, serif">7 1</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">6</FONT></P>
		</TD>
		<TD WIDTH=444 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P>Detonations are performed from left to right. We could not
			detonate the second occurance of 7 because its already destroyed
			by the first occurance. The numbers [1, 2, 3] survive. Their sum
			is 6.</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=164 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">1</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">2</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">1</SPAN></FONT><FONT FACE="Consolas, serif">
			1 </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">1</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">2</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">1</SPAN></FONT><FONT FACE="Consolas, serif">
			1 1</FONT></P>
			<P><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">2</SPAN></FONT></FONT><FONT FACE="Consolas, serif">
			1</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">4</FONT></P>
		</TD>
		<TD WIDTH=444 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P>The red and yellow numbers disappear in two sequential
			detonations. The result is the sequence [1, 1, 1, 1]. Sum = 4.</P>
		</TD>
	</TR>
</TABLE>