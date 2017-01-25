<H2 CLASS="western">Debugging Exercise: Sequence of Commands</H2>
  
<P STYLE="margin-top: 0.06in">The goal of this exercise is to
practice <B>debugging techniques </B>in scenarios where a piece of
code does not work correctly. Your task is to <B>pinpoint the bug</B>
and <B>fix it</B> (without rewriting the entire code). Test your
fixed solution in the judge system: 
</P>
<P STYLE="margin-top: 0.06in">You can download the broken solution
from <A HREF="https://softuni.bg/downloads/svn/soft-tech/Sep-2016/Programming-Fundamentals-Sep-2016/03.%20Programming-Fundamentals-Methods-Debugging-and-Troubleshooting-Code/03.%20Programming-Fundamentals-Methods-and-Debugging-Exercises-Broken-Solutions.zip">here</A>.</P>
<H3 CLASS="western">Problem Description</H3>
<P STYLE="margin-top: 0.06in">You are given a program that reads a <FONT FACE="Consolas, serif"><B>n</B></FONT><B>
numbers</B> and a <B>sequence of commands</B> to be executed over
these numbers.</P>
<H3 CLASS="western">Input</H3>
<UL>
	  <P STYLE="margin-top: 0.06in">The first line holds an <B>integer</B>
	<FONT FACE="Consolas, serif"><B>n</B></FONT> – the <B>count</B> of
	numbers.</P>
	  <P STYLE="margin-top: 0.06in">The second line holds <B>n numbers
	</B>– integers separated by space.</P>
	  <P STYLE="margin-top: 0.06in">Each of the next few lines hold
	<B>commands</B> in format: <B>“[action] [i-th element] [value]”</B>.</P>
	  <P STYLE="margin-top: 0.06in">The commands sequence end with a
	command <B>“stop”</B>.</P>
</UL>
<H3 CLASS="western">Commands</H3>
<P STYLE="margin-top: 0.06in">Commands are given in format <B>“[action]
[i-th element] [value]”</B>. Elements are indexed from <B>1</B> to
<B>n</B>.</P>
<P STYLE="margin-top: 0.06in">The <B>action</B> can be <B>“multiply”</B>,
<B>“add”</B>,<B> “subtract”</B>,<B> “rshift” </B>or<B>
“lshift”</B>.</P>
<UL>
	  <P STYLE="margin-top: 0.06in">The actions <B>“multiply”,
	“add” </B>and <B>“subtract” </B>have parameters. The first
	parameter is the <B>index</B> of the element that needs to be
	changed (in range [<B>1</B>...<B>n</B>]). The second parameter is
	the <B>value</B> with which we manipulate the element.</P>
	  <P STYLE="margin-top: 0.06in">The command <B>“lshift”</B><FONT COLOR="#000000">
	moves the first element last. E.g. “</FONT><FONT COLOR="#000000"><B>lshift</B></FONT><FONT COLOR="#000000">”
	over {1, 2, 3} will produce {2, 3, 1}.</FONT></P>
	  <P STYLE="margin-top: 0.06in"><FONT COLOR="#000000">The command
	</FONT><FONT COLOR="#000000"><B>“rshift”</B></FONT><FONT COLOR="#000000">
	moves the last element first. E.g. “</FONT><FONT COLOR="#000000"><B>rshift</B></FONT><FONT COLOR="#000000">”
	over {1, 2, 3} will produce {3, 1, 2}.</FONT></P>
</UL>
<H3 CLASS="western">Output</H3>
<P STYLE="margin-top: 0.06in">Print the values of the <B>n elements</B>
after the execution of each command (except the last “<B>stop</B>”
command).</P>
<H3 CLASS="western">Constraints</H3>
<UL>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 0.07in">
	The <B>number </B><FONT FACE="Consolas, serif"><B>n</B></FONT> will
	be an integer in the range [1 … 15].</P>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 0.07in">
	Each <B>element of the array</B> will be an integer in the range [0
	… 2<SUP>63</SUP>-1].</P>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 0.07in">
	The <B>number </B><FONT FACE="Consolas, serif"><B>i</B></FONT> and
	the <B>number of commands</B> will be integers in the range [1 …
	10].</P>
	  <P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; line-height: 0.07in">
	The <B>number value</B> will be an integer in the range [-100 …
	100]. If the command is “<B>rshift</B>” or “<B>lshift</B>”
	there are no parameters.</P>
</UL>
<H3 CLASS="western">Tests</H3>
<TABLE WIDTH=409 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=101>
	<COL WIDTH=167>
	<COL WIDTH=115>
	<TR VALIGN=TOP>
		<TD WIDTH=101 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.08in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=167 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.08in">
			<P ALIGN=CENTER><B>Program Output (Wrong)</B></P>
		</TD>
		<TD WIDTH=115 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.08in">
			<P ALIGN=CENTER><B>Expected Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=101 HEIGHT=83 STYLE="border: 1px solid #00000a; padding: 0.04in 0.08in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>5</FONT></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>3
			0 9 333 11</FONT></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>add
			2 2</FONT></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>subtract
			1 1</FONT></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>multiply
			3 3</FONT></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><FONT SIZE=2>rshift</FONT></FONT></P>
			<P><FONT FACE="Consolas, serif"><FONT SIZE=2>stop</FONT></FONT></P>
		</TD>
		<TD WIDTH=167 STYLE="border: 1px solid #00000a; padding: 0.04in 0.08in">
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#ff420e"><FONT FACE="Consolas, serif"><FONT SIZE=2>3
			0 9 333 11</FONT></FONT></FONT></P>
			<P><FONT COLOR="#ff420e"><FONT FACE="Consolas, serif"><FONT SIZE=2>3
			0 9 333 11</FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=115 STYLE="border: 1px solid #00000a; padding: 0.04in 0.08in">
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#00b050"><FONT FACE="Consolas, serif"><FONT SIZE=2>3
			</FONT></FONT></FONT><FONT COLOR="#00b050"><FONT FACE="Consolas, serif"><FONT SIZE=2><B><SPAN STYLE="background: #c0c0c0">2</SPAN></B></FONT></FONT></FONT><FONT COLOR="#00b050"><FONT FACE="Consolas, serif"><FONT SIZE=2>
			9 333 11 </FONT></FONT></FONT>
			</P>
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#00b050"><FONT FACE="Consolas, serif"><FONT SIZE=2><SPAN STYLE="background: #c0c0c0">2</SPAN></FONT></FONT></FONT><FONT COLOR="#00b050"><FONT FACE="Consolas, serif"><FONT SIZE=2>
			2 9 333 11 </FONT></FONT></FONT>
			</P>
			<P STYLE="margin-bottom: 0in"><FONT COLOR="#00b050"><FONT FACE="Consolas, serif"><FONT SIZE=2>2
			2 </FONT></FONT></FONT><FONT COLOR="#00b050"><FONT FACE="Consolas, serif"><FONT SIZE=2><B><SPAN STYLE="background: #c0c0c0">27</SPAN></B></FONT></FONT></FONT><FONT COLOR="#00b050"><FONT FACE="Consolas, serif"><FONT SIZE=2>
			333 11</FONT></FONT></FONT></P>
			<P><FONT COLOR="#00b050"><FONT FACE="Consolas, serif"><FONT SIZE=2><SPAN LANG="bg-BG">11
			</SPAN></FONT></FONT></FONT><FONT COLOR="#00b050"><FONT FACE="Consolas, serif"><FONT SIZE=2>2
			2 27 333</FONT></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>