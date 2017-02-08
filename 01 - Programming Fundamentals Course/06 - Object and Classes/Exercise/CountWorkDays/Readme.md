<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Count
	Working Days</SPAN></H2>

<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Write a program that
<B>reads two dates </B>in format<B> </B><FONT FACE="Consolas, serif"><B>dd-MM-yyyy</B></FONT>
and prints the <B>number of working days</B> between these two dates
<B>inclusive</B>. Non-working days are:</P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">All days that are
	<B>Saturday</B> or <B>Sunday</B>.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">All days that are
	<B>official holidays</B> in Bulgaria:</P>
	<UL>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">New Year Eve (<B>1
		Jan</B>)</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Liberation Day (<B>3
		March</B>)</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Worker’s day (<B>1
		May</B>)</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Saint George’s
		Day (<B>6 May</B>)</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Saints Cyril and
		Methodius Day (<B>24 May</B>)</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Unification Day (<B>6
		Sept</B>)</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Independence Day
		(<B>22 Sept</B>)</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">National Awakening
		Day (<B>1 Nov</B>)</P>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Christmas (<B>24</B>,
		<B>25</B> and <B>26 Dec</B>)</P>
	</UL>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">All days not mentioned
above are <B>working </B>and should count.</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=162 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=91>
	<COL WIDTH=53>
	<TR VALIGN=TOP>
		<TD WIDTH=91 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=53 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=91 HEIGHT=28 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">11-04-2016</FONT></P>
			<P><FONT FACE="Consolas, serif">14-04-2016</FONT></P>
		</TD>
		<TD WIDTH=53 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">4</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=91 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">11-04-2016</FONT></P>
			<P><FONT FACE="Consolas, serif">22-04-2016</FONT></P>
		</TD>
		<TD WIDTH=53 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">10</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=91 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">20-12-2015</FONT></P>
			<P><FONT FACE="Consolas, serif">31-12-2015</FONT></P>
		</TD>
		<TD WIDTH=53 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">7</FONT></P>
		</TD>
	</TR>
</TABLE>