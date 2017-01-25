<H3 CLASS="western">Problem Description</H3>
<P STYLE="margin-top: 0.06in">Write an <B>instruction interpreter</B>
that executes an arbitrary number of <B>instructions</B>. The program
should <B>parse the instructions</B>, <B>execute</B> them and <B>print
the result</B>. The following instruction set should be supported:</P>
<UL>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%"><FONT FACE="Consolas, serif"><B>INC</B></FONT><FONT FACE="Consolas, serif"><B><FONT FACE="Calibri, serif">
	</FONT></B></FONT><FONT FACE="Consolas, serif"><B>&lt;operand1&gt;</B></FONT>
	– increments the operand by 1</P>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%"><FONT FACE="Consolas, serif"><B>DEC</B></FONT>
	<B>&lt;operand1&gt;</B> – decrements the operand by 1</P>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%"><FONT FACE="Consolas, serif"><B>ADD</B></FONT>
	<FONT FACE="Consolas, serif"><B>&lt;operand1&gt;</B></FONT><FONT FACE="Consolas, serif"><B><FONT FACE="Calibri, serif">
	</FONT></B></FONT><FONT FACE="Consolas, serif"><B>&lt;operand2&gt;</B></FONT>
	– performs addition on the two operands</P>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%"><FONT FACE="Consolas, serif"><B>MLA</B></FONT>
	<FONT FACE="Consolas, serif"><B>&lt;operand1&gt;</B></FONT><FONT FACE="Consolas, serif"><B><FONT FACE="Calibri, serif">
	</FONT></B></FONT><FONT FACE="Consolas, serif"><B>&lt;operand2&gt;</B></FONT>
	– performs multiplication on the two operands</P>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%"><FONT FACE="Consolas, serif"><B>END</B></FONT>
	– end of input</P>
</UL>
<H3 CLASS="western">Output</H3>
<H3 CLASS="western"><FONT COLOR="#00000a"><FONT SIZE=3><SPAN STYLE="font-weight: normal">The
result of each instruction should be printed on a separate line on
the console.</SPAN></FONT></FONT></H3>
<H3 CLASS="western">Constraints</H3>
<UL>
	  <P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><FONT COLOR="#000000"><FONT FACE="Calibri, serif"><FONT SIZE=3>The
	operands will be valid integers in the range [−2 147 483 648 … 2
	147 483 647]. </FONT></FONT></FONT>
	</P>
</UL>
<H3 CLASS="western">Tests</H3>
<TABLE WIDTH=530 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=159>
	<COL WIDTH=161>
	<COL WIDTH=167>
	<TR VALIGN=TOP>
		<TD WIDTH=159 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.06in"><B>Input</B></P>
		</TD>
		<TD WIDTH=161 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.06in"><B>Program Output</B><SPAN LANG="bg-BG"><B>
			</B></SPAN><B>(Wrong)</B></P>
		</TD>
		<TD WIDTH=167 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.06in"><B>Expected Output (Correct)</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=159 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>INC
			0</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>END</FONT></FONT></P>
		</TD>
		<TD WIDTH=161 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>0</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>0</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT COLOR="#ff0000">… <FONT FACE="Consolas, serif"><FONT SIZE=2>(infinite)</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=167 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>1</FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=159 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>ADD
			1323134 421315521</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>END</FONT></FONT></P>
		</TD>
		<TD WIDTH=161 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>422638655</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>422638655</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT COLOR="#ff0000">… <FONT FACE="Consolas, serif"><FONT SIZE=2>(infinite)</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=167 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>422638655</FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=159 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>DEC
			57314183</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>END</FONT></FONT></P>
		</TD>
		<TD WIDTH=161 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>57314183</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>57314183</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT COLOR="#ff0000">… <FONT FACE="Consolas, serif"><FONT SIZE=2>(infinite)</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=167 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>57314182</FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=159 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>MLA
			252621 324532</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>END</FONT></FONT></P>
		</TD>
		<TD WIDTH=161 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>379219748</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>379219748</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT COLOR="#ff0000">… <FONT FACE="Consolas, serif"><FONT SIZE=2>(infinite)</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=167 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>81983598372</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>