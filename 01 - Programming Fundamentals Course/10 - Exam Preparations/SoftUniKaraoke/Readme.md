<H1 CLASS="western" ALIGN=CENTER>SoftUni Karaoke</H1>
<P STYLE="margin-top: 0.06in"><A NAME="_GoBack"></A>SoftUni
cultivates talent whether it's coding talent or something else and in
this case, something else is singing. Since you love music you want
to take part in the event but as a programmer you simply lack the
&quot;something else&quot; so your job is to make the software to
track participants' awards.</P>
<P STYLE="margin-top: 0.06in"><B>On the first line</B>, you will
receive a <B>list with all participants that applied for performance</B>.
</P>
<P STYLE="margin-top: 0.06in"><B>On the second line</B>, you will
receive <B>the list with all available songs</B>. 
</P>
<P STYLE="margin-top: 0.06in"><B>On the next lines</B>, until the
&quot;<B>dawn</B>&quot; <B>command</B>, you will get the <B>names of
people</B>, <B>the song that they are performing</B> on stage and <B>the
award they get</B> from the audience.</P>
<P STYLE="margin-top: 0.06in">However<SPAN LANG="bg-BG">,</SPAN> not
every time the plan goes according to schedule. In other words,
<B>everyone</B> (listed or not) <B>can go on stage and perform a song
that is not even available</B> and he <B>still gets awards from the
audience</B>. However, you should <B>record only the awards for
listed participants</B> that <B>perform songs </B><SPAN LANG="en-GB"><B>available</B></SPAN><B>
in the list</B>. In case someone is <B>not listed</B> or sings a <B>song
that is not available</B> you <B>should not record neither the
participant, nor his award</B>.  
</P>
<P STYLE="margin-top: 0.06in">When the &quot;dawn&quot; comes, you
need to <B>print all participants</B>, the <B>count of the unique
awards they received</B> and all unique awards. Participants should
be <B>sorted by number of awards</B> in <B>descending order</B> and
<B>then by participant name alphabetically</B>. Awards should be
<B>sorted in alphabetical order</B>.</P>
<H3 CLASS="western"><FONT SIZE=5>Input</FONT></H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">On the first line, you will
	receive list with all participants that applied for performance in
	the format: <B>&quot;{participant}, {participant} … {participant}&quot;</B></P>
	<LI><P STYLE="margin-top: 0.06in">On the second line, you will get
	all available songs in the in the format: <B>&quot;{song}, {song} …
	{song}&quot;</B></P>
	<LI><P STYLE="margin-top: 0.06in"><SPAN LANG="en-GB">On the next
	lines, until the </SPAN><SPAN LANG="en-GB"><B>&quot;dawn&quot;</B></SPAN><SPAN LANG="en-GB">
	command you will receive every stage performance in the format:
	</SPAN><SPAN LANG="en-GB"><B>&quot;{participant}, {song}, {award}&quot;
	</B></SPAN>
	</P>
	<LI><P STYLE="margin-top: 0.06in"><SPAN LANG="en-GB">Performances
	and songs will be </SPAN><SPAN LANG="en-GB"><B>separated by a comma
	and a single or multiple white spaces</B></SPAN></P>
</UL>
<H2 CLASS="western">Output</H2>
<UL>
	<LI><P STYLE="margin-top: 0.06in">Print all participants along with
	the number of unique awards they won in the format: 
	</P>
	<UL>
		<LI><P STYLE="margin-top: 0.06in"><B>&quot;{participant}: {award
		count} awards&quot;</B></P>
		<LI><P STYLE="margin-top: 0.06in"><B>&quot;--{award}&quot;</B></P>
	</UL>
	<LI><P STYLE="margin-top: 0.06in">Print participants <B>sorted by
	unique awards count in descending order</B>. If two participants
	have the same unique award count<B>, sort them alphabetically by
	name</B></P>
	<LI><P STYLE="margin-top: 0.06in">Print unique <B>awards</B> for
	every participant <B>sorted alphabetically</B></P>
	<LI><P STYLE="margin-top: 0.06in">If there are<B> no awards, </B>print<B>
	&quot;No awards&quot;</B></P>
</UL>
<H2 CLASS="western">Constrains</H2>
<UL>
	<LI><P STYLE="margin-top: 0.06in">The number of total participants
	will be in range [1 … 100]</P>
	<LI><P STYLE="margin-top: 0.06in">The number of total songs will be
	in range [1 … 100]</P>
	<LI><P STYLE="margin-top: 0.06in">The input will always end with the
	&quot;dawn&quot; command</P>
</UL>
<P STYLE="margin-bottom: 0.14in"><BR><BR>
</P>
<H2 CLASS="western" STYLE="page-break-before: always">Examples</H2>
<TABLE WIDTH=679 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=480>
	<COL WIDTH=180>
	<TR VALIGN=TOP>
		<TD WIDTH=480 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=180 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=480 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Trifon,
			Vankata, Gesha</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Dragana
			- Kukavice, Bon Jovi - It's my life, Lorde - Royals</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Gesha,
			Bon Jovi - It's my life, Best Rock</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Vankata,
			Dragana - Kukavice, Best Srabsko</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Vankata,
			Dragana - Kukavice, Best Srabsko</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Vankata,
			Dragana - Kukavice, Stiga Tolko Srabsko</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Vankata,
			PHP Web, Educational 101</FONT></P>
			<P><FONT FACE="Consolas, serif">dawn</FONT></P>
		</TD>
		<TD WIDTH=180 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Vankata:
			2 awards</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">--Best
			Srabsko</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">--Stiga
			Tolko Srabsko</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Gesha:
			1 awards</FONT></P>
			<P><FONT FACE="Consolas, serif">--Best Rock</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=480 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Gesha</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Bon
			Jovi - It's my life</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Gesha,
			Bon Jovi - It's my life, Best Rock</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Vankata,
			Dragana - Kukavice, Best Srabsko</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Vankata,
			Dragana - Kukavice, Stiga Tolko Srabsko</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Vankata,
			PHP Web, Educational 101</FONT></P>
			<P><FONT FACE="Consolas, serif">dawn</FONT></P>
		</TD>
		<TD WIDTH=180 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Gesha:
			1 awards</FONT></P>
			<P><FONT FACE="Consolas, serif">--Best Rock</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=480 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Sino</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Vasko
			Naidenov - Nova Godina</FONT></P>
			<P><FONT FACE="Consolas, serif">dawn</FONT></P>
		</TD>
		<TD WIDTH=180 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">No awards</FONT></P>
		</TD>
	</TR>
</TABLE>