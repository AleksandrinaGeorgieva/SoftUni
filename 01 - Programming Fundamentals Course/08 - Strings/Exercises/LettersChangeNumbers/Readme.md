<H2 CLASS="western">*Letters Change Numbers</H2>

<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 115%"><B>This
problem is from the Java Basics exam (8 February 2015). You may check
your solution </B><A HREF="https://judge.softuni.bg/Contests/Practice/Index/69#1">here</A><B>.</B></P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 115%">Nakov
likes Math. But he also likes the English alphabet a lot. He invented
a game with numbers and letters from the <B>English</B> alphabet. The
game was simple. You get a string consisting of a <B>number between
two letters</B>. Depending on whether the letter was in front of the
number or after it you would perform different mathematical
operations on the number to achieve the result. 
</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 115%"><B>First</B>
you start with the letter <B>before </B>the number. If it's <B>Uppercase</B>
you <B>divide</B> the number by the letter's <B>position</B> in the
alphabet. If it's <B>lowercase</B> you <B>multiply</B> the number
with the letter's position. <B>Then</B> you move to the <B>letter
after</B> the number. If it's <B>Uppercase</B> you <B>subtract</B>
its position from the resulted number. If it's <B>lowercase</B> you
<B>add</B> its position to the resulted number. But the game became
too easy for Nakov really quick. He decided to complicate it a bit by
doing the same but with <B>multiple</B> strings keeping track of only
the <B>total sum</B> of all results. Once he started to solve this
with more strings and bigger numbers it became quite hard to do it
only in his mind. So he kindly asks you to write a program that
<B>calculates the sum of all numbers after the operations on each
number have been done</B>.</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 115%"><B>For
example</B>, you are given the sequence &quot;<B>A12b s17G</B>&quot;.
We have two strings – <B>&quot;A12b&quot;</B> and <B>&quot;s17G&quot;</B>.
We do the operations on each and sum them. We start with the letter
before the number on the first string. <B>A is Uppercase</B> and its
position in the alphabet is <B>1</B>. So we divide the number 12 with
the position 1 (<B>12/1 = 12)</B>. Then we move to the letter after
the number. <B>b is lowercase</B> and its position is 2. So we add 2
to the resulted number (<B>12+2=14)</B>. Similarly for the second
string <B>s is lowercase</B> and its position is 19 so we multiply it
with the number (<B>17*19 = 323)</B>. Then we have Uppercase G with
position 7, so we subtract it from the resulted number&nbsp;(<B>323 –
7 = 316)</B>. Finally we sum the 2 results and we get <B>14 +
316=330</B>;</P>
<H3 CLASS="western">Input</H3>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">The
input comes from the console as a <B>single line, holding the
sequence of strings</B>. Strings are separated by <B>one or more
white spaces</B>.</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">The
input data will always be valid and in the format described. There is
no need to check it explicitly.</P>
<H3 CLASS="western">Output</H3>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 115%">Print
at the console a single number: the <B>total sum of all processed
numbers </B>rounded up to<B> two digits </B>after the decimal
separator.</P>
<H3 CLASS="western">Constraints</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	<B>count</B> of the strings will be in the range <B>[1 … 10].</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	numbers between the letters will be integers in range <B>[1 … 2
	147 483 647].</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">Time
	limit: 0.3 sec. Memory limit: 16 MB.</P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=707 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=197>
	<COL WIDTH=77>
	<COL WIDTH=407>
	<TR VALIGN=TOP>
		<TD WIDTH=197 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=77 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=407 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=CENTER><B>Comment</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=197 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">A12b s17G</FONT></P>
		</TD>
		<TD WIDTH=77 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">330.00</FONT></P>
		</TD>
		<TD WIDTH=407 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">12/1=12, 12+2=14,
			17*19=323, 323–7=316, </FONT><FONT FACE="Consolas, serif"><B>14+316=330</B></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=197 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">P34562Z q2576f  
			H456z</FONT></P>
		</TD>
		<TD WIDTH=77 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">46015.13</FONT></P>
		</TD>
		<TD WIDTH=407 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=197 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">a1A</FONT></P>
		</TD>
		<TD WIDTH=77 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">0.00</FONT></P>
		</TD>
		<TD WIDTH=407 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
</TABLE>