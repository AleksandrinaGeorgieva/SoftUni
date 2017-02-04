<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">* Logs
	Aggregator</SPAN></H2>
<P STYLE="margin-top: 0.06in">You are given a sequence of access logs
in format <B>&lt;IP&gt; &lt;user&gt; &lt;duration&gt;</B>. For
example:</P>
<UL>
	<LI><P STYLE="line-height: 100%">192.168.0.11 peter 33</P>
	<LI><P STYLE="line-height: 100%">10.10.17.33 alex 12</P>
	<LI><P STYLE="line-height: 100%">10.10.17.35 peter 30</P>
	<LI><P STYLE="line-height: 100%">10.10.17.34 peter 120</P>
	<LI><P STYLE="line-height: 100%">10.10.17.34 peter 120</P>
	<LI><P STYLE="line-height: 100%">212.50.118.81 alex 46</P>
	<LI><P STYLE="line-height: 100%">212.50.118.81 alex 4</P>
</UL>
<P STYLE="margin-top: 0.06in">Write a program to aggregate the logs
data and print <B>for each user</B> the <B>total duration</B> of his
sessions and a <B>list of unique IP addresses</B> in format &quot;<B>&lt;user&gt;:
&lt;duration&gt; [&lt;IP</B><SUB><B>1</B></SUB><B>&gt;, &lt;IP</B><SUB><B>2</B></SUB><B>&gt;,
…]</B>&quot;. Order the <B>users alphabetically</B>. Order the <B>IPs
alphabetically</B>. In our example, the output should be the
following:</P>
<UL>
	<LI><P STYLE="line-height: 100%">alex: 62 [10.10.17.33,
	212.50.118.81]</P>
	<LI><P STYLE="line-height: 100%">peter: 303 [10.10.17.34,
	10.10.17.35, 192.168.0.11]</P>
</UL>
<H3 CLASS="western">Input</H3>
<P STYLE="margin-top: 0.06in">The input comes from the console. At
the first line a number <B>n</B> stays which says how many log lines
will follow. Each of the next n lines holds a log information in
format <B>&lt;IP&gt; &lt;user&gt; &lt;duration&gt;</B>. The input
data will always be valid and in the format described. There is no
need to check it explicitly.</P>
<H3 CLASS="western">Output</H3>
<P STYLE="margin-top: 0.06in">Print <B>one line for each user</B>
(order users alphabetically). For each user print its sum of
durations and all of his sessions' IPs, ordered alphabetically in
format <B>&lt;user&gt;: &lt;duration&gt; [&lt;IP</B><SUB><B>1</B></SUB><B>&gt;,
&lt;IP</B><SUB><B>2</B></SUB><B>&gt;, …]</B>. Remove any duplicated
values in the IP addresses and order them alphabetically (like we
order strings).</P>
<H3 CLASS="western">Constraints</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">The <B>count</B>
	of the order lines <B>n</B> is in the range [1…1000].</P>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">The <B>&lt;IP&gt;</B>
	is a standard IP address in format <B>a.b.c.d</B> where <B>a</B>, <B>b</B>,
	<B>c</B> and <B>d</B> are integers in the range [0…255].</P>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">The <B>&lt;user&gt;</B>
	consists of only of <B>Latin characters</B>, with length of [1…20].</P>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">The <B>&lt;duration&gt;</B>
	is an integer number in the range [1…1000].</P>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">Time limit: 0.3
	sec. Memory limit: 16 MB.</P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=635 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=195>
	<COL WIDTH=421>
	<TR VALIGN=TOP>
		<TD WIDTH=195 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER STYLE="margin-top: 0.06in"><B>Input</B></P>
		</TD>
		<TD WIDTH=421 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=CENTER STYLE="margin-top: 0.06in"><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=195 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-top: 0.06in; margin-bottom: 0.06in"><FONT FACE="Consolas, serif">7</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">192.168.0.11
			peter 33</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">10.10.17.33
			alex 12</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">10.10.17.35
			peter 30</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">10.10.17.34
			peter 120</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">10.10.17.34
			peter 120</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">212.50.118.81
			alex 46</FONT></P>
			<P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif">212.50.118.81
			alex 4</FONT></P>
		</TD>
		<TD WIDTH=421 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">alex:
			62 [10.10.17.33, 212.50.118.81]</FONT></P>
			<P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif">peter:
			303 [10.10.17.34, 10.10.17.35, 192.168.0.11]</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=195 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-top: 0.06in; margin-bottom: 0.06in"><FONT FACE="Consolas, serif">2</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">84.238.140.178
			nakov 25</FONT></P>
			<P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif">84.238.140.178
			nakov 35</FONT></P>
		</TD>
		<TD WIDTH=421 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif">nakov:
			60 [84.238.140.178]</FONT></P>
		</TD>
	</TR>
</TABLE>