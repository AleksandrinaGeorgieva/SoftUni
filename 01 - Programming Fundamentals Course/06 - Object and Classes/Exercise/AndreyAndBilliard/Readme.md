<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Andrey and
	billiard</SPAN></H2>

<P STYLE="margin-top: 0.06in">Andrey is the guy who gives us food and
drinks at the game bar. He likes to play <B>billiard</B>. Since you
are nice guy you want to help him play more of his favorite game. You
decide to create a program which will help him to take orders faster
and generate billing information. 
</P>
<P STYLE="margin-top: 0.06in">First you will receive an integer - the
<B>amount</B> of entities with prices (separated by <I>&quot;-&quot;</I>).
Then you will receive a <B>list</B> of <B>client</B>. For every
consumer you will receive <B>what</B> to buy and <B>how much</B>.
When you receive a command: &quot;<I>end of clients</I>&quot; you
should display information about every <B>client</B> described below.
After that say how much total money were <B>spent</B> while Andrey
was playing billiard.</P>
<H3 CLASS="western">Constraints</H3>
<UL>
	<LI><P STYLE="margin-top: 0.06in"><FONT SIZE=3>If an entity is added
	more than once you should </FONT><FONT SIZE=3><B>override</B></FONT><FONT SIZE=3>
	the previous price.</FONT></P>
	<LI><P STYLE="margin-top: 0.06in"><FONT SIZE=3>If buyer tries to buy
	an entity that is not existing - you should </FONT><FONT SIZE=3><B>ignore</B></FONT><FONT SIZE=3>
	that line.</FONT></P>
	<LI><P STYLE="margin-top: 0.06in"><FONT SIZE=3>Buyers should be
	</FONT><FONT SIZE=3><B>ordered</B></FONT><FONT SIZE=3> by name
	ascending. </FONT>
	</P>
	<LI><P STYLE="margin-top: 0.06in"><FONT SIZE=3>All floating point
	digits must be rounded to </FONT><FONT SIZE=3><B>2 digits</B></FONT><FONT SIZE=3>
	after decimal separator.</FONT></P>
	<LI><P STYLE="margin-top: 0.06in"><FONT SIZE=3>In the end of </FONT><FONT SIZE=3><B>every</B></FONT><FONT SIZE=3>
	buyer his bill should be </FONT><FONT SIZE=3><B>summed</B></FONT><FONT SIZE=3>.</FONT></P>
	<LI><P STYLE="margin-top: 0.06in"><FONT SIZE=3>Quantity is an
	integer. Price – floating point.</FONT></P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=693 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=291>
	<COL WIDTH=201>
	<COL WIDTH=175>
	<TR>
		<TD WIDTH=291 HEIGHT=9 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=201 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=175 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=291 HEIGHT=27 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Cola-1.25</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Sandwich-2.30</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Bira-0.01</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">Bira-2</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Toshko-Bira,3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Mira-Sandwich,1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">Marto-Kola,2</SPAN></FONT></P>
			<P STYLE="margin-top: 0.04in"><FONT FACE="Consolas, serif">end of
			clients</FONT></P>
		</TD>
		<TD WIDTH=201 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Mira</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">--
			Sandwich - 1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Bill:
			2.30</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Toshko</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-- Bira
			- 3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Bill:
			6.00</FONT></P>
			<P><FONT FACE="Consolas, serif">Total bill: 8.30</FONT></P>
		</TD>
		<TD WIDTH=175 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">Bira</SPAN></FONT><FONT FACE="Consolas, serif">'s
			price </FONT><FONT FACE="Consolas, serif"><B>is</B></FONT><FONT FACE="Consolas, serif">
			</FONT><FONT FACE="Consolas, serif"><B>overwritten</B></FONT><FONT FACE="Consolas, serif">.</FONT></P>
			<P><FONT FACE="Consolas, serif">Since there is no entity named
			&quot;</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">Kola</SPAN></FONT><FONT FACE="Consolas, serif">&quot;-
			we should </FONT><FONT FACE="Consolas, serif"><B>ignore</B></FONT><FONT FACE="Consolas, serif">
			that line.</FONT></P>
		</TD>
	</TR>
</TABLE>