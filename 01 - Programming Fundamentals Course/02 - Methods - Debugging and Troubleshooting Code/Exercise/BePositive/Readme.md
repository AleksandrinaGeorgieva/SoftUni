<H2 CLASS="western">Debugging Exercise: Be Positive</H2>
  
<P STYLE="margin-top: 0.06in">The goal of this exercise is to
practice <B>debugging techniques </B>in scenarios where a piece of
code does not work correctly. Your task is to <B>pinpoint the bug</B>
and <B>fix it</B> (without rewriting the entire code). Test your
fixed solution in the judge system: 
</P>
<P STYLE="margin-top: 0.06in">You can download the broken solution
from <A HREF="https://softuni.bg/downloads/svn/soft-tech/Sep-2016/Programming-Fundamentals-Sep-2016/03.%20Programming-Fundamentals-Methods-Debugging-and-Troubleshooting-Code/03.%20Programming-Fundamentals-Methods-and-Debugging-Exercises-Broken-Solutions.zip">here</A>.</P>
<H3 CLASS="western">Problem Description</H3>
<P STYLE="margin-top: 0.06in">A program is designed to take some
<B>sequences of numbers</B> from the console, to <B>process them </B>as
described below and <B>print</B> each obtained sequence.</P>
<H3 CLASS="western">Input</H3>
<UL>
	  <P STYLE="margin-top: 0.06in">On the first line of input you are
	given a <B>count N – the number of sequences</B>.</P>
	  <P STYLE="margin-top: 0.06in">On each of <B>the next N lines </B>you
	will receive some <B>numbers surrounded by whitespaces</B>.</P>
</UL>
<H3 CLASS="western">Processing Logic</H3>
<P STYLE="margin-top: 0.06in">You need to check each number, if it’s
<B>positive</B> – print it on the console; if it’s <B>negative</B>,
add to its value the value of the next number and only <B>print the
result if it’s not negative</B>. You only perform the addition
once, e.g. if you have the sequence: -3, 1, 3, the algorithm is as
follows:</P>
<UL>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">-3
	is negative =&gt; add to it the next number (1) =&gt; -3 + 1 = -2
	still negative =&gt; do not print anything (and don’t keep adding
	numbers, you stop here).</P>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">The
	next number we consider is 3 which is positive =&gt; print it. 
	</P>
</UL>
<P STYLE="margin-top: 0.06in">If no numbers can be obtained in this
manner for the given sequence, print <B>“(empty)”</B>.</P>
<H3 CLASS="western">Example</H3>
<TABLE WIDTH=520 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=135>
	<COL WIDTH=110>
	<COL WIDTH=231>
	<TR>
		<TD WIDTH=135 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.06in"><B>Input</B></P>
		</TD>
		<TD WIDTH=110 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.06in"><B>Expected Output</B></P>
		</TD>
		<TD WIDTH=231 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.06in"><B>Comments</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=135 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>3</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in">  <FONT FACE="Consolas, serif"><FONT SIZE=2>3
			-4    5 2  123 </FONT></FONT>
			</P>
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>-1
			-1 3 4</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>-2
			      1</FONT></FONT></P>
		</TD>
		<TD WIDTH=110 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>3
			1 2 123</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>3
			4</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>(empty)</FONT></FONT></P>
		</TD>
		<TD WIDTH=231 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>(3)
			</FONT></FONT><FONT COLOR="#00b050"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>(-4
			+ 5 = 1 &gt; 0)</B></FONT></FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2>
			(2) (123)</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>(-1
			+ (-1) &lt; 0)</B></FONT></FONT></FONT><FONT FACE="Consolas, serif"><FONT SIZE=2>
			(3) (4)</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>(-2
			+ 1 &lt; 0)</B></FONT></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>
<H3 CLASS="western">Output</H3>
<P STYLE="margin-top: 0.06in">Print on the console <B>each modified
sequence on a separate line.</B></P>
<H3 CLASS="western">Constraints</H3>
<UL>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">The
	<B>number N</B> will be an integer in the range [1 … 15].</P>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">The
	<B>numbers in the sequences</B> will be integers in the range [-1000
	… 1000].</P>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">The
	<B>count of numbers in each sequence</B> will be in the range [1 …
	20].</P>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 100%">There
	may be <B>whitespaces anywhere around the numbers</B> in a given
	sequence</P>
</UL>
<H3 CLASS="western">Tests</H3>
<TABLE WIDTH=460 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=146>
	<COL WIDTH=161>
	<COL WIDTH=109>
	<TR VALIGN=TOP>
		<TD WIDTH=146 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.04in"><B>Input</B></P>
		</TD>
		<TD WIDTH=161 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.04in"><B>Program Output (Wrong)</B></P>
		</TD>
		<TD WIDTH=109 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.04in"><B>Expected Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=146 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>3</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in">  <FONT FACE="Consolas, serif"><FONT SIZE=2>3
			-4    5 2  123 </FONT></FONT>
			</P>
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>-1
			-1 3 4</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>-2
			      1</FONT></FONT></P>
		</TD>
		<TD WIDTH=161 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>Exception…</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=109 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>3
			1 2 123</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>3
			4</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>(empty)</FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=146 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>1</FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>0
			-2 2 -2 3</FONT></FONT></P>
		</TD>
		<TD WIDTH=161 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in; margin-bottom: 0in"><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2>Exception…</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.03in"><BR>
			</P>
		</TD>
		<TD WIDTH=109 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.03in"><FONT FACE="Consolas, serif"><FONT SIZE=2>0
			0 1</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>