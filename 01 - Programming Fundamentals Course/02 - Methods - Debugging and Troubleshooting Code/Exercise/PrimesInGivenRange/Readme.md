<P STYLE="margin-top: 0.08in; margin-bottom: 0.06in; page-break-inside: avoid; page-break-after: avoid">
	<FONT COLOR="#7c380a"><FONT FACE="Calibri, serif"><FONT SIZE=5><B>*
	Primes in Given Range</B></FONT></FONT></FONT></P>
  
<P STYLE="margin-bottom: 0.14in"><FONT FACE="Calibri, serif">Write a
method that calculates </FONT><FONT FACE="Calibri, serif"><B>all
prime numbers in given range</B></FONT><FONT FACE="Calibri, serif">
and returns them as list of integers:</FONT></P>
<TABLE WIDTH=695 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=685>
	<TR>
		<TD WIDTH=685 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif">static</FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif">
			</FONT></FONT><FONT COLOR="#2b91af"><FONT FACE="Consolas, serif">List</FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif">&lt;</FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif">int</FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif">&gt;
			FindPrimesInRange(startNum, endNum)</FONT></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif">{</FONT></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#000000">    …</FONT></P>
			<P><FONT COLOR="#000000"><FONT FACE="Consolas, serif">}</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-top: 0.08in; margin-bottom: 0.14in"><FONT FACE="Calibri, serif">Write
a method to </FONT><FONT FACE="Calibri, serif"><B>print a list of
integers</B></FONT><FONT FACE="Calibri, serif">. Write a program that
enters two integer numbers (each at a separate line) and prints all
primes in their range, separated by a comma.</FONT></P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=694 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=145>
	<COL WIDTH=530>
	<TR VALIGN=TOP>
		<TD WIDTH=145 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Calibri, serif"><B>Start and End Number</B></FONT></P>
		</TD>
		<TD WIDTH=530 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Calibri, serif"><B>Output</B></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=145 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">0</FONT></P>
			<P><FONT FACE="Consolas, serif">10</FONT></P>
		</TD>
		<TD WIDTH=530 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">2, 3, 5, 7</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=145 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">5</FONT></P>
			<P><FONT FACE="Consolas, serif">11</FONT></P>
		</TD>
		<TD WIDTH=530 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">5, 7, 11</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=145 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">100</FONT></P>
			<P><FONT FACE="Consolas, serif">200</FONT></P>
		</TD>
		<TD WIDTH=530 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">101, 103, 107, 109, 113, 127, 131,
			137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197,
			199</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=145 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">250</FONT></P>
			<P><FONT FACE="Consolas, serif">950</FONT></P>
		</TD>
		<TD WIDTH=530 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">251, 257, 263, 269, 271, 277, 281,
			283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367,
			373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443,
			449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523,
			541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613,
			617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691,
			701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787,
			797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877,
			881, 883, 887, 907, 911, 919, 929, 937, 941, 947</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=145 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">100</FONT></P>
			<P><FONT FACE="Consolas, serif">50</FONT></P>
		</TD>
		<TD WIDTH=530 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif"><I>(empty list)</I></FONT></P>
		</TD>
	</TR>
</TABLE>