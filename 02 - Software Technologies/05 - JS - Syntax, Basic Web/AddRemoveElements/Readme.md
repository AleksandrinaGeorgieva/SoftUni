<OL START=10>
	<LI><H2 CLASS="western">Add / Remove Elements</H2>
</OL>
<P STYLE="margin-top: 0.06in">You will be given a sequence of
<B>commands</B> (pairs of elements separated by a space): <B>command</B>
and <B>argument</B>. You start by an empty array.</P>
<UL>
	<LI><P STYLE="margin-top: 0.06in">The command “<B>add number</B>”
	appends the <B>number</B> to the array.</P>
	<LI><P STYLE="margin-top: 0.06in">The command “<B>remove index</B>”<B>
	</B>removes the element at the specified <B>index</B>. If the index
	is nonexistent, ignore that input line. When an element is deleted,
	all elements on the right from it, go one position left.</P>
</UL>
<P STYLE="margin-top: 0.06in">When you process all input data, <B>print
the array’s elements</B> each on a separate line.</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=464 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=51>
	<COL WIDTH=54>
	<COL WIDTH=16>
	<COL WIDTH=76>
	<COL WIDTH=54>
	<COL WIDTH=17>
	<COL WIDTH=76>
	<COL WIDTH=54>
	<TR VALIGN=TOP>
		<TD WIDTH=51 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=54 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=16 BGCOLOR="#ffffff" STYLE="border-top: none; border-bottom: none; border-left: 1px solid #00000a; border-right: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><BR>
			</P>
		</TD>
		<TD WIDTH=76 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=54 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD ROWSPAN=2 WIDTH=17 BGCOLOR="#ffffff" STYLE="border-top: none; border-bottom: none; border-left: 1px solid #00000a; border-right: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><BR>
			</P>
		</TD>
		<TD WIDTH=76 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=54 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=51 HEIGHT=53 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">add 3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">add 5</FONT></P>
			<P><FONT FACE="Consolas, serif">add 7</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">5</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">7</FONT></P>
		</TD>
		<TD WIDTH=16 STYLE="border-top: none; border-bottom: none; border-left: 1px solid #00000a; border-right: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.06in; padding-right: 0.06in">
			<P><BR>
			</P>
		</TD>
		<TD WIDTH=76 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">add 3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">add 5</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">remove
			1</FONT></P>
			<P><FONT FACE="Consolas, serif">add 2</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3</FONT></P>
			<P><FONT FACE="Consolas, serif">2</FONT></P>
		</TD>
		<TD WIDTH=76 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">add 3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">add 5</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">remove
			2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">remove
			0</FONT></P>
			<P><FONT FACE="Consolas, serif">add 7</FONT></P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">5</FONT></P>
			<P><FONT FACE="Consolas, serif">7</FONT></P>
		</TD>
	</TR>
</TABLE>