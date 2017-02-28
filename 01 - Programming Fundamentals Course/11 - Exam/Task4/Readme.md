<H1 CLASS="western" ALIGN=CENTER STYLE="margin-top: 0in">Problem <SPAN LANG="bg-BG">4</SPAN>
– Hornet Armada</H1>
<P STYLE="margin-top: 0.06in">The Hornet Overlord Nostalgia, who is
famed for his absolute discipline and strict orders, owns the most
sorted army in the Hornet history. Help Nostalgia “computerize”
the process of sorting out his army.</P>
<P STYLE="margin-top: 0.06in">You will be given <B>N</B> – an
integer.<BR>On the next <B>N</B> lines you will be given input
containing<SPAN LANG="bg-BG"> </SPAN>information about soldiers in
the following format:</P>
<P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB"><B>{lastActivity}
= {legionName} -&gt; {soldierType}:{soldierCount}</B></SPAN></FONT></P>
<P STYLE="margin-top: 0.06in"><A NAME="_GoBack"></A><SPAN LANG="en-GB">The
</SPAN><SPAN LANG="en-GB"><B>last activity</B></SPAN><SPAN LANG="en-GB">
is an </SPAN><SPAN LANG="en-GB"><B>integer</B></SPAN><SPAN LANG="en-GB">.
The </SPAN><SPAN LANG="en-GB"><B>legion name</B></SPAN><SPAN LANG="en-GB">
and </SPAN><SPAN LANG="en-GB"><B>soldier type</B></SPAN><SPAN LANG="en-GB">,
will both be </SPAN><SPAN LANG="en-GB"><B>strings</B></SPAN><SPAN LANG="en-GB">.
The </SPAN><SPAN LANG="en-GB"><B>soldier count</B></SPAN><SPAN LANG="en-GB">
will be an </SPAN><SPAN LANG="en-GB"><B>integer</B></SPAN><SPAN LANG="en-GB">.
You must </SPAN><SPAN LANG="en-GB"><B>store</B></SPAN><SPAN LANG="en-GB">
</SPAN><SPAN LANG="en-GB"><B>every</B></SPAN><SPAN LANG="en-GB">
</SPAN><SPAN LANG="en-GB"><B>legion</B></SPAN><SPAN LANG="en-GB">
with its </SPAN><SPAN LANG="en-GB"><B>activity</B></SPAN><SPAN LANG="en-GB">,
and </SPAN><SPAN LANG="en-GB"><B>every</B></SPAN><SPAN LANG="en-GB">
</SPAN><SPAN LANG="en-GB"><B>soldier type</B></SPAN><SPAN LANG="en-GB">
with its </SPAN><SPAN LANG="en-GB"><B>count</B></SPAN><SPAN LANG="en-GB">,
in its </SPAN><SPAN LANG="en-GB"><B>legion</B></SPAN><SPAN LANG="en-GB">.</SPAN></P>
<P STYLE="margin-top: 0.06in"><SPAN LANG="en-GB">If a </SPAN><SPAN LANG="en-GB"><B>given
legion already exists</B></SPAN><SPAN LANG="en-GB">, you must </SPAN><SPAN LANG="en-GB"><B>add</B></SPAN><SPAN LANG="en-GB">
the new </SPAN><SPAN LANG="en-GB"><B>soldier type</B></SPAN><SPAN LANG="en-GB">,
with its count. If the soldier type exists </SPAN><SPAN LANG="en-GB"><B>ALSO</B></SPAN><SPAN LANG="en-GB">,
you should just </SPAN><SPAN LANG="en-GB"><B>add</B></SPAN><SPAN LANG="en-GB">
the </SPAN><SPAN LANG="en-GB"><B>soldier count</B></SPAN><SPAN LANG="en-GB">.
</SPAN>
</P>
<P STYLE="margin-top: 0.06in"><SPAN LANG="en-GB"><B>IN</B></SPAN><SPAN LANG="en-GB">
</SPAN><SPAN LANG="en-GB"><B>BOTH</B></SPAN><SPAN LANG="en-GB">
cases, stated above, you should </SPAN><SPAN LANG="en-GB"><B>update</B></SPAN><SPAN LANG="en-GB">
the </SPAN><SPAN LANG="en-GB"><B>last</B></SPAN><SPAN LANG="en-GB">
</SPAN><SPAN LANG="en-GB"><B>activity</B></SPAN><SPAN LANG="en-GB">,
with the newly entered one, </SPAN><SPAN LANG="en-GB"><B>ONLY</B></SPAN><SPAN LANG="en-GB">
if the </SPAN><SPAN LANG="en-GB"><B>entered</B></SPAN><SPAN LANG="en-GB">
</SPAN><SPAN LANG="en-GB"><B>one </B></SPAN><SPAN LANG="en-GB">is
</SPAN><SPAN LANG="en-GB"><B>GREATER</B></SPAN><SPAN LANG="en-GB">
than the </SPAN><SPAN LANG="en-GB"><B>previous one</B></SPAN><SPAN LANG="en-GB">.</SPAN></P>
<P STYLE="margin-top: 0.06in">After you’ve read <B>all N</B> input
lines, you will receive a line in one of the following formats:</P>
<UL>
	<LI><P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>{activity}\{soldierType}</B></FONT></P>
	<LI><P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>{soldierType}</B></FONT></P>
</UL>
<P STYLE="margin-top: 0.06in">In the <B>first case,</B> you must
print all <B>legions</B>, and the <B>count of soldiers</B> they have
from the <B>given</B> <B>soldier</B> <B>type</B>, who’s <B>last
activity</B> is <B>LOWER </B>than the <B>given activity</B>. The
legions must be printed in <B>descending order</B> by <B>soldier
count</B>.</P>
<P STYLE="margin-top: 0.06in">In the <B>second case</B>, you must
print all legions which <B>have</B> the <B>given soldier type</B>,
with <B>last activity</B>, and <B>legion name</B>. The legions must
be printed in <B>descending</B> <B>order </B>of<B> </B>their<B>
activity</B>.</P>
<H3 CLASS="western">Input</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">On the first line you will receive
	<B>N </B>–<B> </B>the<B> integer</B>.</P>
	<LI><P STYLE="margin-top: 0.06in">On the next <B>N</B> lines you
	will receive data about <B>soldiers</B> and <B>legions</B>.</P>
	<LI><P STYLE="margin-top: 0.06in">On the last line you will receive
	<B>one</B> of the <B>two commands</B>, which will <B>determine</B>
	the <B>output</B>. 
	</P>
</UL>
<H3 CLASS="western">Output</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">If you are given the <B>last
	activity</B> and <B>soldier type</B> on the last command, you must
	print the legions in this format:</P>
</UL>
<UL>
	<LI><P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>{legionName}
	-&gt; {soldierCount}</B></FONT></P>
</UL>
<UL>
	<LI><P STYLE="margin-top: 0.06in">If you are given <B>only</B> the
	<B>soldier type</B> on the last command, you must print the legions
	in this format:</P>
</UL>
<UL>
	<LI><P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>{lastActivity}
	: {legionName}</B></FONT></P>
</UL>
<H3 CLASS="western">Constrains</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">The first integer – <B>N</B>,
	will be in <B>range [0</B><SPAN LANG="bg-BG"><B>;</B></SPAN><B>
	10</B><SPAN LANG="bg-BG"><B>,</B></SPAN><B>000]</B>.</P>
	<LI><P STYLE="margin-top: 0.06in">The <B>legion names</B> and
	<B>soldier types</B> may consist of <B>any ASCII </B>character,
	except “<B>=</B>”, “<B>-</B>”, “<B>&gt;</B>”, “<B>:</B>”,
	<SPAN LANG="en-GB">“ ”(</SPAN><SPAN LANG="en-GB"><B>space</B></SPAN><SPAN LANG="en-GB">).</SPAN></P>
	<LI><P STYLE="margin-top: 0.06in">The <B>soldier count</B> and <B>last
	activity</B> will be integers in <B>range [0</B><SPAN LANG="bg-BG"><B>;</B></SPAN><B>
	1,000,000,000]</B>. 
	</P>
	<LI><P STYLE="margin-top: 0.06in">All input data will be exactly as
	stated above. There will be <B>NO invalid</B> input lines.</P>
	<LI><P STYLE="margin-top: 0.06in">Data which has <B>NO specified
	order</B> must be sorted in <B>order of</B> <B>input</B>.</P>
</UL>
<P STYLE="margin-top: 0.06in"><BR><BR>
</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=499 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=309>
	<COL WIDTH=172>
	<TR VALIGN=TOP>
		<TD WIDTH=309 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=172 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=309 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">6</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">1
			= BlackBeatles -&gt; Soldier:2000</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">2
			= BlackBeatles -&gt; Worker:1000</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">1
			= Red_Ones -&gt; Soldier:10000</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">5
			= Rm -&gt; Soldier:30000</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">2
			= Red_Ones -&gt; Soldier:20000</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">10
			= RND -&gt; Soldier:100000</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">10\Soldier</SPAN></FONT></P>
		</TD>
		<TD WIDTH=172 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Red_Ones
			-&gt; 30000</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Rm
			-&gt; 30000</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">BlackBeatles -&gt;
			2000</SPAN></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=309 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">7</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">1000
			= F1rstL3gion -&gt; Aisers:15000</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">500
			= F1rstL3gion -&gt; Aisers:1000</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">200
			= F1rstL3gion -&gt; Guards:2000</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">2000
			= Second!egion -&gt; Guards:2000</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">1500
			= Second!egion -&gt; Aisers:15000</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">2500
			= Second!egion -&gt; Spies:2000</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">1000
			= Forked_Ones -&gt; Guards:10000000</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Guards</SPAN></FONT></P>
		</TD>
		<TD WIDTH=172 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">2500
			: Second!egion</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">1000
			: F1rstL3gion</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">1000 :
			Forked_Ones</SPAN></FONT></P>
		</TD>
	</TR>
</TABLE>