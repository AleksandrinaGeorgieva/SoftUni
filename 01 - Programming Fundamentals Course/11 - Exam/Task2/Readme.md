<H1 CLASS="western" ALIGN=CENTER STYLE="margin-top: 0in">Problem 2 –
Hornet <SPAN LANG="en-GB">Comm</SPAN></H1>
<P STYLE="margin-top: 0.06in">The Hornet Ex-King – Horny, has
established an innovative technology providing communication for his
fellow hornets, called Hornet Comm. Inc. Hornet Comm. provides
functionality from private messages to wide broadcasts.</P>
<P STYLE="margin-top: 0.06in">You will be given data of several
tracked comm. channels, which you must decrypt. The input data will
come in the following format:</P>
<P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B><SPAN LANG="en-GB">{firstQuery}
&lt;-&gt; {secondQuery}</SPAN></B></FONT></P>
<P STYLE="margin-top: 0.06in">If the <B>first query</B> consists <B>only
of digits</B> and the <B>second one</B> consists of <B>digits and /
or letters</B>, it is a <B>private message</B>.</P>
<P STYLE="margin-top: 0.06in">If the <B>first query</B> consists of
<B>anything but digits</B>, and the <B>second one</B> consists of
<B>letters and / or digits,</B> it is a <B>broadcast</B>.</P>
<P STYLE="margin-top: 0.06in">Any input that <B>does</B> <B>NOT</B>
<B>follow</B> the format, specified above, should be <B>IGNORED</B>. 
</P>
<P STYLE="margin-top: 0.06in">If the <B>given data</B> is a <B>private
message</B>, the first query is the <B>recipient’s code</B>, and
the second query is the <B>message</B>. You must <B>reverse</B> the
<B>recipient’s code</B> and <B>store</B> it along with the message.</P>
<P STYLE="margin-top: 0.06in">If the <B>given data</B> is a
<B>broadcast</B>, the first query is the message, and the second
query is the <B>frequency</B>. You must take the <B>frequency</B> and
make <B>all capital letters</B> – <B>small</B> and <B>all small
letters</B> – <B>capital</B>. Then you must <B>store</B> it, along
with the <B>message</B>.</P>
<P STYLE="margin-top: 0.06in">You must <B>keep</B> all input
broadcasts and messages after you <B>decrypt</B> them.</P>
<P STYLE="margin-top: 0.06in"><A NAME="_GoBack"></A>When you receive
the command “<B>Hornet is Green</B>”, the input sequences <B>ends</B>,
and you must print the stored broadcasts and messages. 
</P>
<H3 CLASS="western">Input</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">The input comes in the form of
	several input lines in the format specified above.</P>
	<LI><P STYLE="margin-top: 0.06in">The input ends when you receive
	the command “<B>Hornet is Green</B>”.</P>
</UL>
<H3 CLASS="western">Output</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">As output you must print all
	broadcasts and messages, printing first the broadcasts, in the
	following format:</P>
	<UL>
		<LI><P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>Broadcasts:</B></FONT></P>
		<LI><P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>{frequency}
		-&gt; {message}</B></FONT></P>
		<LI><P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>.
		. .</B></FONT></P>
		<LI><P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>Messages:</B></FONT></P>
		<LI><P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>{recipient}
		-&gt; {message}</B></FONT></P>
		<LI><P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>.
		. .</B></FONT></P>
	</UL>
	<LI><P STYLE="margin-top: 0.06in">If there are <B>no messages</B>,
	or <B>no broadcasts</B>, print “<B>None</B>” in their place.</P>
</UL>
<H3 CLASS="western">Constrains</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in">The input lines may consist of <B>any
	ASCII</B> character.</P>
	<LI><P STYLE="margin-top: 0.06in">There will be <B>NO</B> more than
	1000 lines of input.</P>
	<LI><P STYLE="margin-top: 0.06in"><B>All data</B> must be printed in
	<B>order of input</B>.</P>
</UL>
<P STYLE="margin-top: 0.06in"><BR><BR>
</P>
<P STYLE="margin-top: 0.06in"><BR><BR>
</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=394 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=196>
	<COL WIDTH=180>
	<TR VALIGN=TOP>
		<TD WIDTH=196 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=180 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=196 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">213094
			&lt;-&gt; BeeQueenDown</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">213094
			&lt;-&gt; Repeat</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Foxtrot
			&lt;-&gt; 123321</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">213094
			&lt;-&gt; BeeQueenDown</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Unicorn
			&lt;-&gt; 871203</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Charlie
			&lt;-&gt; 56210</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Kilo
			&lt;-&gt; 423211</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Hornet is Green</SPAN></FONT></P>
		</TD>
		<TD WIDTH=180 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Broadcasts:</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">123321
			-&gt; Foxtrot</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">871203
			-&gt; Unicorn</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">56210
			-&gt; Charlie</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">423211
			-&gt; Kilo</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Messages:</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">490312
			-&gt;BeeQueenDown</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">490312
			-&gt;Repeat</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">490312
			-&gt;BeeQueenDown</SPAN></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=196 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">&lt;+&gt;.&lt;+&gt;
			&lt;-&gt; az13b6</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">&lt;-&gt;.&lt;-&gt;
			&lt;-&gt; P2Z4x789</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">12345
			&lt;-&gt; Pr1v@teM3ssage</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Hornet is Green</SPAN></FONT></P>
		</TD>
		<TD WIDTH=180 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Broadcasts:</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">AZ13B6
			-&gt; &lt;+&gt;.&lt;+&gt;</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">p2z4X789
			-&gt; &lt;-&gt;.&lt;-&gt;</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">Messages:</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">None</SPAN></FONT></P>
		</TD>
	</TR>
</TABLE>