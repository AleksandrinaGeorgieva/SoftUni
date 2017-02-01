<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">* Array
	Manipulator</SPAN></H2>
<P STYLE="margin-top: 0.06in">Write a program that <B>reads an array
of integers</B> from the console and <B>set of commands</B> and
<B>executes them over the array</B>. The commands are as follows:</P>
<UL>
	<LI><P STYLE="margin-top: 0.06in"><B>add &lt;index&gt; &lt;element&gt;</B>
	– adds element at the specified index (elements right from this
	position inclusively are shifted to the right).</P>
	<LI><P STYLE="margin-top: 0.06in"><B>addMany &lt;index&gt; &lt;element
	1&gt; &lt;element 2&gt; … &lt;element n&gt;</B> – adds a set of
	elements at the specified index.</P>
	<LI><P STYLE="margin-top: 0.06in"><B>contains &lt;element&gt;</B> –
	prints the index of the first occurrence of the specified element
	(if exists) in the array or <B>-1</B> if the element is not found.</P>
	<LI><P STYLE="margin-top: 0.06in"><B>remove &lt;index&gt;</B> –
	removes the element at the specified index.</P>
	<LI><P STYLE="margin-top: 0.06in"><B>shift &lt;positions&gt;</B> –
	<B>shifts every element</B> of the array the number of positions <B>to
	the</B> <B>left</B> (with rotation).</P>
	<UL>
		<LI><P STYLE="margin-top: 0.06in">For example, [1, 2, 3, 4, 5] -&gt;
		shift 2 -&gt; [3, 4, 5, 1, 2]</P>
	</UL>
	<LI><P STYLE="margin-top: 0.06in"><B>sumPairs</B> – sums the
	elements in the array by pairs (first + second, third + fourth, …).</P>
	<UL>
		<LI><P STYLE="margin-top: 0.06in">For example, [1, 2, 4, 5, 6, 7,
		8] -&gt; [3, 9, 13, 8].</P>
	</UL>
	<LI><P STYLE="margin-top: 0.06in"><B>print</B> – stop receiving
	more commands and print the last state of the array.</P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=442 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=196>
	<COL WIDTH=228>
	<TR VALIGN=TOP>
		<TD WIDTH=196 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=228 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=196 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 2 4 5
			6 7</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">add 1 8</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">contains
			1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">contains
			-3</FONT></P>
			<P><FONT FACE="Consolas, serif">print</FONT></P>
		</TD>
		<TD WIDTH=228 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">0</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-1</FONT></P>
			<P><FONT FACE="Consolas, serif">[1, 8, 2, 4, 5, 6, 7]</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=196 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 2 3 4
			5</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">addMany
			5 9 8 7 6 5</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">contains
			15</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">remove
			3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">shift 1</FONT></P>
			<P><FONT FACE="Consolas, serif">print</FONT></P>
		</TD>
		<TD WIDTH=228 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-1</FONT></P>
			<P><FONT FACE="Consolas, serif">[2, 3, 5, 9, 8, 7, 6, 5, 1]</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=196 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2 2 4 2
			4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">add 1 4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">sumPairs</FONT></P>
			<P><FONT FACE="Consolas, serif">print</FONT></P>
		</TD>
		<TD WIDTH=228 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">[6, 6, 6]</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=196 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1 2 1 2
			1 2 1 2 1 2 1 2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">sumPairs</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">sumPairs</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">addMany
			0 -1 -2 -3</FONT></P>
			<P><FONT FACE="Consolas, serif">print</FONT></P>
		</TD>
		<TD WIDTH=228 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">[-1, -2, -3, 6, 6, 6]</FONT></P>
		</TD>
	</TR>
</TABLE>