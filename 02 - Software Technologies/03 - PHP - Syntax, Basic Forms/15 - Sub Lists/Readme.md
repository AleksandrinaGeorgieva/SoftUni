<OL START=15>
	<LI><H2 CLASS="western">Sub-Lists</H2>
</OL>
<P STYLE="margin-top: 0.06in">You are given a number <FONT FACE="Consolas, serif"><B>num1</B></FONT>
and a number <FONT FACE="Consolas, serif"><B>num2</B></FONT>. Write a
PHP script that generates a list with <B>num1</B> elements, and each
of those elements has a sub-list with <B>num2 </B>elements. Each of
the Lists has a caption “<B>List #</B>” where #<B> </B>is the
current number from <FONT FACE="Consolas, serif"><B>1</B></FONT> to
<FONT FACE="Consolas, serif"><B>num1</B></FONT><B>. </B>And each of
the elements of those lists has a caption “<B>Element #.#</B>”
where the first # is the current list number and the second <B>#</B>
is the current element from <FONT FACE="Consolas, serif"><B>1</B></FONT>
to <FONT FACE="Consolas, serif"><B>num2</B></FONT>. The input comes
as a parameters named <FONT FACE="Consolas, serif"><B>num1</B></FONT>
and <FONT FACE="Consolas, serif"><B>num2</B></FONT>, holding positive
integers.</P>
<P STYLE="margin-top: 0.06in"><BR><BR>
</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=690 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=119>
	<COL WIDTH=43>
	<COL WIDTH=294>
	<COL WIDTH=199>
	<TR VALIGN=TOP>
		<TD WIDTH=119 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Parameters names</B></P>
		</TD>
		<TD WIDTH=43 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=294 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=199 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Picture</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=119 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">num1</FONT></P>
		</TD>
		<TD WIDTH=43 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">1</FONT></P>
		</TD>
		<TD ROWSPAN=2 WIDTH=294 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;ul&gt;</FONT></P>
			<P STYLE="margin-left: 0.5in; margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;li&gt;List
			1</FONT></P>
			<P STYLE="margin-left: 1in; margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;ul&gt;</FONT></P>
			<P STYLE="margin-left: 1.5in; margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;li&gt;</FONT></P>
			<P STYLE="margin-left: 2in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Element
			1.1</FONT></P>
			<P STYLE="margin-left: 1.5in; margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;/li&gt;</FONT></P>
			<P STYLE="margin-left: 1.5in; margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;li&gt;</FONT></P>
			<P STYLE="margin-left: 2in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Element
			1.2</FONT></P>
			<P STYLE="margin-left: 1.5in; margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;/li&gt;</FONT></P>
			<P STYLE="margin-left: 1in; margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;/ul&gt;</FONT></P>
			<P STYLE="margin-left: 0.5in; margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;/li&gt;</FONT></P>
			<P><FONT FACE="Consolas, serif">&lt;/ul&gt;</FONT></P>
		</TD>
		<TD ROWSPAN=2 WIDTH=199 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><IMG SRC="i_78fae0a73d913d03_html_80173ae9.png" NAME="Picture 21" ALIGN=BOTTOM WIDTH=193 HEIGHT=78 BORDER=0></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=119 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">num2</FONT></P>
		</TD>
		<TD WIDTH=43 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">2</FONT></P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-top: 0.06in">There is <B>indentation</B> on the
elements. Each nested element is <B>tabbed</B> <B>once right</B> from
its parent.</P>