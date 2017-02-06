<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">*** </SPAN><SPAN LANG="en-US">Dragon
	Army</SPAN></H2>

<P STYLE="margin-top: 0.06in">Heroes III is the best game ever.
Everyone loves it and everyone plays it all the time. Stamat is no
exclusion to this rule. His favorite units in the game are all <B>types</B>
of dragons – black, red, gold, azure etc… He likes them so much
that he gives them <B>names</B> and keeps logs of their <B>stats</B>:
<B>damage, health </B>and<B> armor</B>. The process of aggregating
all the data is quite tedious, so he would like to have a program
doing it. Since he is no programmer, it’s your task to help him</P>
<P STYLE="margin-top: 0.06in">You need to categorize dragons by their
<B>type</B>. For each dragon, identified by <B>name, </B>keep
information about his <B>stats. </B>Type is <B>preserved </B>as in
the order of input, but dragons are <B>sorted</B> alphabetically by
name. For each type, you should also print the average <B>damage</B>,
<B>health</B> and <B>armor</B> of the dragons. For each dragon, print
his own stats. 
</P>
<P STYLE="margin-top: 0.06in">There <B>may</B> be <B>missing</B>
stats in the input, though. If a stat is missing you should assign it
default values. Default values are as follows: health <B>250</B>,
damage <B>45</B>, and armor <B>10</B>. Missing stat will be marked by
<B>null</B>.</P>
<P STYLE="margin-top: 0.06in">The input is in the following format
<B>{type} {name} {damage} {health} {armor}. </B>Any of the integers
may be assigned null value. See the examples below for better
understanding of your task.</P>
<P STYLE="margin-top: 0.06in">If the same dragon is added a second
time, the new stats should <B>overwrite</B> the previous ones. Two
dragons are considered <B>equal</B> if they match by <B>both</B> name
and type.</P>
<H3 CLASS="western">Input</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">On
	the first line, you are given number N -&gt; the number of dragons
	to follow</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">On
	the next N lines you are given input in the above described format.
	There will be single space separating each element.</P>
</UL>
<H3 CLASS="western">Output</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">Print
	the aggregated data on the console</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">For
	each type, print average stats of its dragons in format
	<B>{Type}::({damage}/{health}/{armor})</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">Damage,
	health and armor should be rounded to two digits after the decimal
	separator</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">For
	each dragon, print its stats in format <B>-{Name} -&gt; damage:
	{damage}, health: {health}, armor: {armor}</B></P>
</UL>
<H3 CLASS="western">Constraints</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">N
	is in range [1…100]</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">The
	dragon type and name are one word only, starting with capital
	letter.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">Damage
	health and armor are integers in range [0 … 100000] or <B>null</B></P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=696 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=265>
	<COL WIDTH=412>
	<TR VALIGN=TOP>
		<TD WIDTH=265 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=CENTER STYLE="margin-top: 0.06in"><B>Input</B></P>
		</TD>
		<TD WIDTH=412 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=CENTER STYLE="margin-top: 0.06in"><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=265 HEIGHT=15 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">5</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Red
			Bazgargal 100 2500 25</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Black
			Dargonax 200 3500 18</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Red
			Obsidion 220 2200 35</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Blue
			Kerizsa 60 2100 20</FONT></P>
			<P><FONT FACE="Consolas, serif">Blue Algordox 65 1800 50</FONT></P>
		</TD>
		<TD WIDTH=412 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Red::(160.00/2350.00/30.00)</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-Bazgargal
			-&gt; damage: 100, health: 2500, armor: 25</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-Obsidion
			-&gt; damage: 220, health: 2200, armor: 35</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Black::(200.00/3500.00/18.00)</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-Dargonax
			-&gt; damage: 200, health: 3500, armor: 18</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Blue::(62.50/1950.00/35.00)</FONT></P>
			<P STYLE="margin-bottom: 0in"><A NAME="_GoBack"></A><FONT FACE="Consolas, serif">-Algordox
			-&gt; damage: 65, health: 1800, armor: 50</FONT></P>
			<P><FONT FACE="Consolas, serif">-Kerizsa -&gt; damage: 60, health:
			2100, armor: 20</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=265 HEIGHT=14 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=CENTER STYLE="margin-top: 0.06in"><B>Input</B></P>
		</TD>
		<TD WIDTH=412 BGCOLOR="#d9d9d9" STYLE="border-top: 1px solid #00000a; border-bottom: 1px solid #00000a; border-left: none; border-right: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0in; padding-right: 0.06in">
			<P ALIGN=CENTER STYLE="margin-top: 0.06in"><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=265 HEIGHT=14 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Gold
			Zzazx null 1000 10</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Gold
			Traxx 500 null 0</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Gold
			Xaarxx 250 1000 null</FONT></P>
			<P><FONT FACE="Consolas, serif">Gold Ardrax 100 1055 50</FONT></P>
		</TD>
		<TD WIDTH=412 BGCOLOR="#ffffff" STYLE="border-top: 1px solid #00000a; border-bottom: 1px solid #00000a; border-left: none; border-right: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Gold::(223.75/826.25/17.50)</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-Ardrax
			-&gt; damage: 100, health: 1055, armor: 50</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-Traxx
			-&gt; damage: 500, health: 250, armor: 0</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-Xaarxx
			-&gt; damage: 250, health: 1000, armor: 10</FONT></P>
			<P><FONT FACE="Consolas, serif">-Zzazx -&gt; damage: 45, health:
			1000, armor: 10</FONT></P>
		</TD>
	</TR>
</TABLE>
