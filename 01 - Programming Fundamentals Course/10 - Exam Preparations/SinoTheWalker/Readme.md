
<H1 CLASS="western" ALIGN=CENTER><A NAME="_GoBack"></A>
Sino The Walker</H1>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Sino is one of those
people that lives in SoftUni. He leaves every now and then, but when
he leaves he always takes a different route, so he needs to know how
much time it will take for him to go home. Your job is to help him
with the calculations.</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">You will receive the <B>time
that Sino leaves</B> SoftUni, the <B>steps taken</B> and <B>time for
each step in seconds</B>. 
</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">You need to print the
exact <B>time</B> that he will <B>arrive at home in the format
specified</B>.</P>
<H2 CLASS="western" ALIGN=JUSTIFY>Input / Constrains</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">The first line will
	be the time Sino leaves SoftUni in the following format: <B>HH:mm:ss</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">The second line will
	contain the <B>number of steps</B> that he needs to walk to his
	home. This number will be an integer in range <B>[0…2,147,483,647]</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the final line
	you will receive the <B>time in seconds</B> for each <B>step</B>.
	This number will be an integer in range <B>[0…2,147,483,647]</B></P>
</UL>
<H2 CLASS="western" ALIGN=JUSTIFY>Output</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Print the <B>time of
	arrival</B> at home in the following format:</P>
	<UL>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>Time
		Arrival: {hours}:{minutes}:{seconds}</B></FONT></P>
	</UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">If hours, minutes or
	seconds are a single digit number, add a zero in front.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">If, for example,
	hours are equal to zero, print a <FONT FACE="Consolas, serif"><B>00</B></FONT>
	in their place. The same is true for minutes or seconds.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Time of day starts
	at <FONT FACE="Consolas, serif"><B>00:00:00</B></FONT> and ends at
	<FONT FACE="Consolas, serif"><B>23:59:59</B></FONT></P>
</UL>
<H2 CLASS="western">Examples</H2>
<TABLE WIDTH=684 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=297>
	<COL WIDTH=369>
	<TR VALIGN=TOP>
		<TD WIDTH=297 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=369 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=297 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">12:30:30</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">90</FONT></P>
			<P><FONT FACE="Consolas, serif">1</FONT></P>
		</TD>
		<TD WIDTH=369 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">Time Arrival: 12:32:00</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=297 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=369 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=297 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">23:49:13</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">5424</FONT></P>
			<P><FONT FACE="Consolas, serif">2</FONT></P>
		</TD>
		<TD WIDTH=369 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">Time Arrival: 02:50:01</FONT></P>
		</TD>
	</TR>
</TABLE>
