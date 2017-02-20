<P ALIGN=CENTER STYLE="margin-bottom: 0.06in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#7c380a"><FONT FACE="Calibri, serif"><FONT SIZE=5 STYLE="font-size: 20pt"><SPAN LANG="en-US"><B>Nether Realms</B></SPAN></FONT></FONT></FONT></P>
<P STYLE="margin-bottom: 0.11in">Mighty battle is coming. In the
stormy nether realms, demons are fighting against each other for
supremacy in a duel from which only one will survive. 
</P>
<P STYLE="margin-bottom: 0.11in">Your job, however is not so
exciting. You are assigned to <B>sign in all the participants</B> in
the nether realm's mighty battle's demon book, which of course is
<B>sorted alphabetically</B>. 
</P>
<P STYLE="margin-bottom: 0.11in">A demon's <B>name contains his
health and his damage</B>. 
</P>
<P STYLE="margin-bottom: 0.11in">The <B>sum of the asci codes</B> of
<B>all characters</B> (excluding numbers (0-9), arithmetic symbols
(<B>'+', '-', '*', '/'</B>) and delimiter dot (<B>'.'</B>)) gives a
<B>demon's total health</B>. 
</P>
<P STYLE="margin-bottom: 0.11in"><B>The sum of all numbers</B> in his
name forms his base damage. Note that you should consider the plus
<B>'+'</B> and minus <B>'-'</B> signs (e.g. <B>+10 is 10</B> and <B>-10
is -10</B>). However, there are some symbols (<B>'*'</B> and <B>'/'</B>)
that can further <B>alter the base damage by multiplying or dividing
it by 2</B> (e.g. in the name &quot;m<B>15</B>*/c<B>-5.0</B>&quot;,
the base damage is <B>15 + (-5.0) = 10</B> and then you need to
multiply it by 2 (e.g. 10 * 2 = 20) and then divide it by 2 (e.g. 20
/ 2 = 10)). 
</P>
<P STYLE="margin-bottom: 0.11in">So, <B>multiplication and division
</B>are applied<B> only after all numbers are included </B>in the
calculation and<B> in the order they appear in the name</B>. 
</P>
<P STYLE="margin-bottom: 0.11in">You will get all demons <B>on a
single line</B>, separated by commas and zero or more blank spaces.
Sort them in <B>alphabetical order</B> and print their names <B>along
their health and damage</B>. 
</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT SIZE=4 STYLE="font-size: 16pt"><SPAN LANG="en-US"><B>Input</B></SPAN></FONT></FONT></P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US">The
input will be read from the console. The input consists of a </SPAN><SPAN LANG="en-US"><B>single
line </B></SPAN><SPAN LANG="en-US">containing all demon names
</SPAN><SPAN LANG="en-US"><B>separated by commas and zero or more
spaces</B></SPAN><SPAN LANG="en-US"> in the format: </SPAN><SPAN LANG="en-US"><B>&quot;{demon
name}, {demon name}, … {demon name}&quot;</B></SPAN></P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT SIZE=4 STYLE="font-size: 16pt"><SPAN LANG="en-US"><B>Output</B></SPAN></FONT></FONT></P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">Print
all demons </SPAN></SPAN><SPAN LANG="en-US"><B><SPAN STYLE="background: #ffffff">sorted
by their name in ascending order</SPAN></B></SPAN><SPAN LANG="en-US"><SPAN STYLE="background: #ffffff">,
each on a separate line in the format:</SPAN></SPAN></P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="line-height: 100%"><SPAN LANG="en-US"><B><SPAN STYLE="background: #ffffff">&quot;{demon
	name} - {health points} health, {damage points} damage&quot;</SPAN></B></SPAN></P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT SIZE=4 STYLE="font-size: 16pt"><SPAN LANG="en-US"><B>Constraints</B></SPAN></FONT></FONT></P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US">A
	demon's name will contain </SPAN><SPAN LANG="en-US"><B>at least one
	character</B></SPAN></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><SPAN LANG="en-US">A
	demon's name </SPAN><SPAN LANG="en-US"><B>cannot contain</B></SPAN><SPAN LANG="en-US">
	blank spaces ' ' or commas ','</SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">A </SPAN><SPAN LANG="en-US"><B>floating point
	number will always have digits before and after its decimal
	separator</B></SPAN></P>
	<LI><P LANG="bg-BG" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US"><B>Number</B></SPAN><SPAN LANG="en-US"> in a
	demon's name </SPAN><SPAN LANG="en-US"><B>is considere</B></SPAN><SPAN LANG="en-US">d
	everything that is a valid integer or floating point number (with
	dot '.' used as separator). For example, all these are valid
	numbers: '4', '+4', '-4', '3.5', '+3.5', '-3.5' </SPAN>
	</P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.06in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT SIZE=4 STYLE="font-size: 16pt"><SPAN LANG="en-US"><B>Examples</B></SPAN></FONT></FONT></P>
<TABLE WIDTH=637 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=155>
	<COL WIDTH=172>
	<COL WIDTH=58>
	<COL WIDTH=218>
	<TR VALIGN=TOP>
		<TD WIDTH=155 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Input</B></SPAN></P>
		</TD>
		<TD WIDTH=172 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Output</B></SPAN></P>
		</TD>
		<TD COLSPAN=2 WIDTH=284 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Comments</B></SPAN></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=155 HEIGHT=73 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">M3ph-0.5s-0.5t0.0**</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=172 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">M3ph-0.5s-0.5t0.0**
			- 524 health, 8.00 damage</SPAN></FONT></FONT></P>
		</TD>
		<TD COLSPAN=2 WIDTH=284 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">M3ph-0.5s-0.5t0.0**:</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Health
			= 'M' + 'p' + 'h' + 's' + 't' = 524 health.</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Damage
			= (3 + (-0.5) + (-0.5) + 0.0) * 2 * 2 = 8 damage.</SPAN></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=155 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Input</B></SPAN></P>
		</TD>
		<TD COLSPAN=2 WIDTH=238 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Output</B></SPAN></P>
		</TD>
		<TD WIDTH=218 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Comments</B></SPAN></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=155 HEIGHT=73 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">M3ph1st0**,
			Azazel</SPAN></FONT></FONT></P>
		</TD>
		<TD COLSPAN=2 WIDTH=238 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><A NAME="_GoBack"></A><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Azazel
			- 615 health, 0.00 damage </SPAN></FONT></FONT>
			</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">M3ph1st0**
			- 524 health, 16.00 damage</SPAN></FONT></FONT></P>
			<P LANG="en-US" ALIGN=JUSTIFY><BR>
			</P>
		</TD>
		<TD WIDTH=218 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Azazel:
			</SPAN></FONT></FONT>
			</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Health
			- 'A' + 'z' + 'a' + 'z' + 'e' + 'l' = 615 health. Damage - no
			digits = 0 damage.</SPAN></FONT></FONT></P>
			<P LANG="en-US" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><BR>
			</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">M3ph1st0**:</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Health
			- 'M' + 'p' + 'h' + 's' + 't' = 524 health.</SPAN></FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Damage
			- (3 + 1 + 0) * 2 * 2 = 16 damage.</SPAN></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=155 HEIGHT=72 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Gos/ho</SPAN></FONT></FONT></P>
		</TD>
		<TD COLSPAN=2 WIDTH=238 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><SPAN LANG="en-US">Gos/ho
			- 512 health, 0.00 damage</SPAN></FONT></FONT></P>
		</TD>
		<TD WIDTH=218 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P LANG="en-US" ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
</TABLE>
