<H1 CLASS="western" ALIGN=CENTER STYLE="margin-top: 0in">Problem <SPAN LANG="bg-BG">1</SPAN>
– Hornet Wings</H1>
<P STYLE="margin-top: 0.06in">The hornets are having a cardio
contest. Your task is to calculate a contestant’s distance
travelled, based upon the wing flaps he made. However some hornet
contestants are faster and less durable, while others are slower but
have more endurance.</P>
<P STYLE="margin-top: 0.06in">You will be given <B>N</B> – an
<B>integer</B> indicating the <B>wing flaps</B>, a contestant has
chosen to do. 
</P>
<P STYLE="margin-top: 0.06in">After that, you will receive <B>M</B> –
a <B>floating-point number</B> indicating the <B>distance</B>, in
<B>meters</B>, the hornet travels for <B>1000 wing flaps</B>.</P>
<P STYLE="margin-top: 0.06in">Then you will receive <B>P</B> – an
<B>integer</B> indicating the <B>endurance</B> of the contestant, or
<B>how many wing flaps</B> he can make, before <B>he stops to take a
break</B> and rest. A hornet <B>rests</B> for <B>5</B> <B>seconds</B>.</P>
<P STYLE="margin-top: 0.06in">You can assume that a hornet makes <B>100
</B>wing flaps <B>per</B> <B>second</B>.</P>
<P STYLE="margin-top: 0.06in">Your task is to <B>calculate</B> how
much <B>distance</B> will the hornet <B>travel</B>, after it <B>flaps</B>
its <B>wings</B> <B>N times</B>, and how much <B>time</B> it <B>took
him</B>, to travel it. The <B>distance</B> is measured in <B>meters</B>
and the time – in <B>seconds</B>.</P>
<H3 CLASS="western">Input</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">On the first input line you will
	receive N – the wing flaps, the hornet has chosen to do.</P>
	<LI><P STYLE="margin-top: 0.06in">On the second input line you will
	receive M – the distance the hornet travels for 1000 wing flaps.</P>
	<LI><P STYLE="margin-top: 0.06in">On the third input line you will
	receive P – the endurance of the hornet.</P>
</UL>
<H3 CLASS="western">Output</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">As output you must print the total
	distance the hornet contestant has travelled, and the amount of time
	it took him.</P>
	<LI><P STYLE="margin-top: 0.06in">The output must be in the format
	of two lines:</P>
</UL>
<UL>
	<LI><P STYLE="margin-top: 0.06in">On the first output line you must
	print the distance: “<B>{</B><SPAN LANG="en-GB"><B>metersTraveled</B></SPAN><B>}
	m.</B>”</P>
	<LI><P STYLE="margin-top: 0.06in">On the second output line you must
	print the time: “<SPAN LANG="en-GB"><B>{secondsPassed} s.</B></SPAN></P>
</UL>
<UL>
	<LI><P STYLE="margin-top: 0.06in">The <B>distance</B> must be
	<B>printed</B> to the <B>second digit</B> after the <B>decimal
	point</B>.</P>
</UL>
<H3 CLASS="western">Constrains</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">The integer <B>N</B> – the wing
	flaps, will be in <B>range [0</B><SPAN LANG="bg-BG"><B>;
	</B></SPAN><B>1,000,000,000]</B>.</P>
	<LI><P STYLE="margin-top: 0.06in">The floating-point number <B>M</B>
	– the distance for 1000 wing flaps, will be in <B>range [0</B><SPAN LANG="bg-BG"><B>;</B></SPAN><B>
	1,000,000]</B>.</P>
	<LI><P STYLE="margin-top: 0.06in"><A NAME="_GoBack"></A>The integer
	<B>P</B> – the endurance, will be in range <B>[1</B><SPAN LANG="bg-BG"><B>;</B></SPAN><B>
	N]</B>.</P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=672 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=88>
	<COL WIDTH=112>
	<COL WIDTH=446>
	<TR VALIGN=TOP>
		<TD WIDTH=88 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=112 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=446 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=88 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in">2000</P>
			<P STYLE="margin-bottom: 0in">5</P>
			<P>200</P>
		</TD>
		<TD WIDTH=112 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in">10.00 m.</P>
			<P>70 s.</P>
		</TD>
		<TD WIDTH=446 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">The
			contestant has chosen to do </FONT><FONT FACE="Consolas, serif"><B>2000
			wing flaps</B></FONT><FONT FACE="Consolas, serif">.</FONT><FONT FACE="Consolas, serif"><SPAN LANG="bg-BG">
			<BR></SPAN></FONT><FONT FACE="Consolas, serif">He moves </FONT><FONT FACE="Consolas, serif"><B>5
			meters</B></FONT><FONT FACE="Consolas, serif"> per </FONT><FONT FACE="Consolas, serif"><B>1000</B></FONT><FONT FACE="Consolas, serif">
			wing flaps.</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">He
			rests every </FONT><FONT FACE="Consolas, serif"><B>200</B></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><B>wing flaps</B></FONT><FONT FACE="Consolas, serif">
			for </FONT><FONT FACE="Consolas, serif"><B>5</B></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><B>seconds</B></FONT><FONT FACE="Consolas, serif">.</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">The
			distance is </FONT><FONT FACE="Consolas, serif"><B>(2000 / 1000) *
			5 = 2 * 5 = 10.00</B></FONT><FONT FACE="Consolas, serif"> meters.</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">The
			hornet flaps </FONT><FONT FACE="Consolas, serif"><B>100 times</B></FONT><FONT FACE="Consolas, serif">
			for a </FONT><FONT FACE="Consolas, serif"><B>second</B></FONT><FONT FACE="Consolas, serif">,
			so </FONT><FONT FACE="Consolas, serif"><B>2000 / 100 =</B></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><B>20 </B></FONT><FONT FACE="Consolas, serif">seconds.
			<BR>But it also rests for </FONT><FONT FACE="Consolas, serif"><B>5</B></FONT><FONT FACE="Consolas, serif">
			seconds every </FONT><FONT FACE="Consolas, serif"><B>200</B></FONT><FONT FACE="Consolas, serif">
			flaps.</FONT></P>
			<P><FONT FACE="Consolas, serif"><B>(2000 / 200) * 5 = 10 * 5</B></FONT><FONT FACE="Consolas, serif">
			= </FONT><FONT FACE="Consolas, serif"><B>50</B></FONT><FONT FACE="Consolas, serif">;
			</FONT><FONT FACE="Consolas, serif"><B>20</B></FONT><FONT FACE="Consolas, serif">
			+ </FONT><FONT FACE="Consolas, serif"><B>50</B></FONT><FONT FACE="Consolas, serif">
			= </FONT><FONT FACE="Consolas, serif"><B>70</B></FONT><FONT FACE="Consolas, serif">
			seconds.</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=88 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in">1000000</P>
			<P STYLE="margin-bottom: 0in">10</P>
			<P>1500</P>
		</TD>
		<TD COLSPAN=2 WIDTH=566 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in">10000.00 m.</P>
			<P>13330 s.</P>
		</TD>
	</TR>
</TABLE>