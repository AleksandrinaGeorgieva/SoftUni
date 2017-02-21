<H1 CLASS="western" ALIGN=CENTER>
Football Standings</H1>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>You will be given</B>
information about <B>results of football matches</B>. <B>Create a
standings table by points. </B>For <B>win the team gets 3</B> <B>points</B>,
<B>for loss – 0</B> and <B>for draw – 1</B>. Also<B> find the top
3 teams with most scored goals in descending order</B>. If <B>two or
more teams</B> are with <B>same goals scored</B> or <B>same points</B>
<B>order them by name</B> in <B>ascending order</B>.</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><A NAME="_GoBack"></A>The
name of each team is <B>encrypted</B>. You must <B>decrypt it before</B>
<B>proceeding with calculating</B> statistics. You will be given some
<B>string key</B> and the <B>team name will be placed between that
key in reversed order.</B></P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>For example:</B> the
<B>key</B><SPAN LANG="bg-BG">: </SPAN>“<FONT FACE="Consolas, serif"><B><SPAN STYLE="background: #00ff00">???</SPAN></B></FONT>”;</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>String to decrypt</B><SPAN LANG="bg-BG">:
</SPAN>“<FONT FACE="Consolas, serif"><B>kfle</B></FONT><FONT FACE="Consolas, serif"><B><SPAN STYLE="background: #00ff00">???</SPAN></B></FONT><FONT FACE="Consolas, serif"><B><SPAN STYLE="background: #ffff00">airagluB</SPAN></B></FONT><FONT FACE="Consolas, serif"><B><SPAN STYLE="background: #00ff00">???</SPAN></B></FONT><FONT FACE="Consolas, serif"><B>gertIt%%</B></FONT>”<SPAN LANG="bg-BG">
-&gt; </SPAN>“<FONT FACE="Consolas, serif"><B>airagluB</B></FONT><SPAN LANG="bg-BG">”</SPAN>
-&gt; “<FONT FACE="Consolas, serif"><B>Bulgaria</B></FONT>”</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Also you should <B>ignore
the letter casing</B> in the team names. <B>For example:</B></P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>buLgariA
= BulGAria = bulGARIA = BULGARIA</B></FONT></P>
<H2 CLASS="western" ALIGN=JUSTIFY>Input / Constrains</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the <B>first line</B>
	of input you will get the <B>key</B> that will be used for
	decryption</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the next lines
	until you receive “<B>final</B>” you will get lines in format:</P>
</UL>
<P ALIGN=JUSTIFY STYLE="text-indent: 0.3in; margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>{encrypted
teamA} {encrypted teamB} {teamA score}:{teamB score}</B></FONT></P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>Team scores</B>
	will be <B>integer numbers</B> in the <B>range [0...2</B><SUP><B>31</B></SUP><B>]</B></P>
</UL>
<H2 CLASS="western" ALIGN=JUSTIFY>Output<SPAN DIR="LTR" STYLE="float: left; width: 2.6in; height: 1.54in; border: 1px solid #000000; padding: 0.05in 0.1in; background: #ffffff">
	<P STYLE="margin-bottom: 0in; line-height: 100%"><FONT FACE="Consolas, serif"><B>League
	standings:</B></FONT></P>
	<P STYLE="line-height: 100%"><FONT FACE="Consolas, serif"><B>{place}.
	{TEAM NAME} {points}</B></FONT></P>
	<P STYLE="line-height: 100%"><FONT FACE="Consolas, serif"><B>...</B></FONT></P>
</SPAN><BR CLEAR=LEFT>
</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>Print the
	standings table</B> <B>ordered descending by points</B> in format:</P>
</UL>
<P ALIGN=JUSTIFY STYLE="text-indent: 0.3in; margin-bottom: 0in; line-height: 100%">
Where <B>place</B> is a number in range <B>[1… number of teams].</B><SPAN DIR="LTR" STYLE="float: left; width: 2.6in; height: 1.54in; border: 1px solid #000000; padding: 0.05in 0.1in; background: #ffffff">
	<P STYLE="margin-bottom: 0in; line-height: 100%"><FONT FACE="Consolas, serif"><B>Top
	3 scored goals:</B></FONT></P>
	<P STYLE="margin-bottom: 0in; line-height: 100%"><FONT FACE="Consolas, serif"><B>-
	{</B></FONT><SPAN STYLE="text-transform: uppercase"><FONT FACE="Consolas, serif"><B>team
	name</B></FONT></SPAN><FONT FACE="Consolas, serif"><B>} -&gt;
	{goals}</B></FONT></P>
	<P STYLE="margin-bottom: 0in; line-height: 100%"><FONT FACE="Consolas, serif"><B>-
	{</B></FONT><SPAN STYLE="text-transform: uppercase"><FONT FACE="Consolas, serif"><B>team
	name</B></FONT></SPAN><FONT FACE="Consolas, serif"><B>} -&gt;
	{goals}</B></FONT></P>
	<P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>-
	{</B></FONT><SPAN STYLE="text-transform: uppercase"><FONT FACE="Consolas, serif"><B>team
	name</B></FONT></SPAN><FONT FACE="Consolas, serif"><B>} -&gt;
	{goals}</B></FONT></P>
</SPAN><BR CLEAR=LEFT>
</P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Then you should
	print the top 3 team <B>ordered by goals in descending order</B> in
	format:</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>All team’s
	names </B>should be<B> uppercase.</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><B>For more
	clarification, see the examples on the next page.</B></P>
</UL>
<H2 CLASS="western" STYLE="page-break-before: always">Examples</H2>
<TABLE WIDTH=448 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=268>
	<COL WIDTH=161>
	<TR VALIGN=TOP>
		<TD WIDTH=268 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=161 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=268 HEIGHT=137 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><SPAN STYLE="background: #ff0000">??</SPAN></P>
			<P STYLE="margin-bottom: 0in"><SPAN STYLE="background: #ff0000">??</SPAN><SPAN STYLE="background: #ffff00">ecnarF</SPAN><SPAN STYLE="background: #ff0000">??</SPAN>
			<SPAN STYLE="background: #ff0000">??</SPAN>kramneD<SPAN STYLE="background: #ff0000">??</SPAN>
			<SPAN STYLE="background: #ffff00">0:0</SPAN></P>
			<P STYLE="margin-bottom: 0in">..<SPAN STYLE="background: #ff0000">??</SPAN><SPAN STYLE="background: #00ff00">airagluB</SPAN><SPAN STYLE="background: #ff0000">??</SPAN>32
			<SPAN STYLE="background: #ff0000">??</SPAN>dnalgnE<SPAN STYLE="background: #ff0000">??</SPAN>gf
			<SPAN STYLE="background: #00ff00">3:2</SPAN></P>
			<P STYLE="margin-bottom: 0in">Fg<SPAN STYLE="background: #ff0000">??</SPAN>NIAPS<SPAN STYLE="background: #ff0000">??</SPAN>
			fgdrt%#$<SPAN STYLE="background: #ff0000">??</SPAN>YNAMREG<SPAN STYLE="background: #ff0000">??</SPAN>gtr
			3:4</P>
			<P STYLE="margin-bottom: 0in"><SPAN STYLE="background: #ff0000">??</SPAN><SPAN STYLE="background: #ffff00">eCnArF</SPAN><SPAN STYLE="background: #ff0000">??</SPAN>
			&gt;&gt;<SPAN STYLE="background: #ff0000">??</SPAN>yLATi<SPAN STYLE="background: #ff0000">??</SPAN>&lt;&lt;
			<SPAN STYLE="background: #ffff00">2:2</SPAN></P>
			<P>final</P>
		</TD>
		<TD WIDTH=161 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">League
			standings:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1.
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">BULGARIA</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">3</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2.
			GERMANY 3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3.
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">FRANCE</SPAN></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">2</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">4.
			DENMARK 1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">5.
			ITALY 1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">6.
			ENGLAND 0</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">7.
			SPAIN 0</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Top 3
			scored goals:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-
			GERMANY -&gt; 4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-
			BULGARIA -&gt; 3</FONT></P>
			<P><FONT FACE="Consolas, serif">- SPAIN -&gt; 3</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=268 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=161 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=268 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><SPAN STYLE="background: #ff0000">KZL</SPAN></P>
			<P STYLE="margin-bottom: 0in">fd<SPAN STYLE="background: #ff0000">KZL</SPAN><SPAN STYLE="background: #ffff00">airagluB</SPAN><SPAN STYLE="background: #ff0000">KZL</SPAN>
			<SPAN STYLE="background: #ff0000">KZL</SPAN><SPAN STYLE="background: #00ffff">kramneD</SPAN><SPAN STYLE="background: #ff0000">KZL</SPAN>ll
			<SPAN STYLE="background: #ffff00">2</SPAN>:<SPAN STYLE="background: #00ffff">0</SPAN></P>
			<P STYLE="margin-bottom: 0in">kzljjj<SPAN STYLE="background: #ff0000">KZL</SPAN><SPAN STYLE="background: #ffff00">AiRaGluB</SPAN><SPAN STYLE="background: #ff0000">KZL</SPAN>
			<SPAN STYLE="background: #ff0000">KZL</SPAN><SPAN STYLE="background: #00ff00">ylATI</SPAN><SPAN STYLE="background: #ff0000">KZL</SPAN>kk
			<SPAN STYLE="background: #ffff00">1</SPAN>:<SPAN STYLE="background: #00ff00">1</SPAN></P>
			<P STYLE="margin-bottom: 0in"><SPAN STYLE="background: #ff0000">KZL</SPAN><SPAN STYLE="background: #00ffff">kRamned</SPAN><SPAN STYLE="background: #ff0000">KZL</SPAN>
			<SPAN STYLE="background: #ff0000">KZL</SPAN><SPAN STYLE="background: #00ff00">Ylati</SPAN><SPAN STYLE="background: #ff0000">KZL</SPAN>
			<SPAN STYLE="background: #00ffff">4</SPAN>:<SPAN STYLE="background: #00ff00">4</SPAN></P>
			<P>final</P>
		</TD>
		<TD WIDTH=161 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">League
			standings:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1.
			BULGARIA 4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2.
			ITALY 2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3.
			DENMARK 1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Top 3
			scored goals:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">- </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">ITALY</SPAN></FONT><FONT FACE="Consolas, serif">
			-&gt; </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">5</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ffff">DENMARK</SPAN></FONT><FONT FACE="Consolas, serif">
			-&gt; </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ffff">4</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif">- </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">BULGARIA</SPAN></FONT><FONT FACE="Consolas, serif">
			-&gt; </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">3</SPAN></FONT></P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-top: 0.06in"><BR><BR>
</P>
