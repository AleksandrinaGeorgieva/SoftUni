<OL START=10>
	<LI><P CLASS="western" STYLE="margin-top: 0.08in; margin-bottom: 0.06in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
	<FONT COLOR="#7c380a"><FONT FACE="Calibri, serif"><FONT SIZE=5><B>*Simple
	Text Editor</B></FONT></FONT></FONT></P>
</OL>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">You are given an
empty text. Your task is to implement 4 commands related to
manipulating the text</FONT></FONT></P>
<UL>
	<LI><P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">1 someString -
	</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>append</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">s
	someString to the end of the text</FONT></FONT></P>
	<LI><P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">2 count - </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>erases</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	the last </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><I>count
	</I></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">elements
	from the text</FONT></FONT></P>
	<LI><P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">3 index - </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>returns</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	the element at position </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><I>index
	</I></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">from
	the text</FONT></FONT></P>
	<LI><P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
	<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">4 - </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>undoes</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
	the last not undone command of type </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><I>1
	/ 2 </I></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">and
	returns the text to the state before that operation</FONT></FONT></P>
</UL>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Input format:
</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><SPAN STYLE="background: #ffffff">T</SPAN></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">he
first line contains </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><I><B>n</B></I></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">,
the number of operations. </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><BR></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">Each
of the following </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><I><B>n</B></I></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
lines contains the name of the operation followed by the command
argument, if any, separated by space in the following format
</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><I><B>CommandName
Argument</B></I></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">.
</FONT></FONT>
</P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">For example:</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 100%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">3</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 100%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">1 abc</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 100%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">2 2</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 100%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">4</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 100%">
<BR>
</P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Output Format:
</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">For
each operation of type </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><I><B>3
</B></I></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">print
a single line with the returned character of that operation.</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>Constraints: </B></FONT></FONT>
</P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">1 ≤ N ≤ </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">105</FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">The length of the
text will not exceed 1000000 </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><BR></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">All
input characters are English letters. </FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><BR></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">It
is guaranteed that the sequence of input operation is possible to
perform</FONT></FONT></P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.03in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT FACE="Calibri, serif"><FONT SIZE=4 STYLE="font-size: 16pt"><B>Examples</B></FONT></FONT></FONT></P>
<TABLE WIDTH=677 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=296>
	<COL WIDTH=363>
	<TR VALIGN=TOP>
		<TD WIDTH=296 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><FONT SIZE=3><B>Input</B></FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=363 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><FONT SIZE=3><B>Output</B></FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=296 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">8</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">1
			abc</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">3
			3</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">2
			3</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">1
			xy</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">3
			2</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">4</FONT></FONT></P>
			<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">4
			</FONT></FONT>
			</P>
			<P CLASS="western" STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">3
			1</FONT></FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in">
			<FONT COLOR="#00000a"><FONT FACE="Consolas, serif">c</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in; margin-bottom: 0in">
			<FONT COLOR="#00000a"><FONT FACE="Consolas, serif">y</FONT></FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT COLOR="#00000a"><FONT FACE="Consolas, serif">a</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%">
<BR><BR>
</P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.03in; line-height: 115%; page-break-inside: avoid; page-break-after: avoid">
<FONT COLOR="#8f400b"><FONT FACE="Calibri, serif"><FONT SIZE=4 STYLE="font-size: 16pt"><B>Explanation</B></FONT></FONT></FONT></P>
<P CLASS="western" STYLE="margin-top: 0.06in; margin-bottom: 0.08in; line-height: 115%"><A NAME="_GoBack"></A>
<FONT COLOR="#00000a"><FONT FACE="Calibri, serif">There
are&nbsp;8&nbsp;operations. Initially,&nbsp;the text&nbsp;is
empty.&nbsp;<BR>In the first operation, we append&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>abc</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
to&nbsp;the text.&nbsp;<BR>Then, we print its&nbsp;3rd&nbsp;character,</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>
</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">which
is&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>c</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;at
this point.&nbsp;<BR>Next, we erase its
last&nbsp;3&nbsp;characters,&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>abc</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">.&nbsp;<BR>After
that, we append&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>xy</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">
to the text.&nbsp;<BR>The text&nbsp;becomes&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>xy</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;after
these previous two modifications.&nbsp;<BR>Then, we are asked to
return the&nbsp;2nd&nbsp;character of&nbsp;the text, which
is&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>y</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">.<BR>After
that, we have to undo the last update to&nbsp;the text, so&nbsp;it&nbsp;becomes
empty.<BR>The next operation asks us to undo the update before that,
so&nbsp;the text&nbsp;becomes&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>abc</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;again.&nbsp;<BR>Finally,
we are asked to print its&nbsp;1st&nbsp;character, which is&nbsp;</FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif"><B>a</B></FONT></FONT><FONT COLOR="#00000a"><FONT FACE="Calibri, serif">&nbsp;at
this point.</FONT></FONT></P>