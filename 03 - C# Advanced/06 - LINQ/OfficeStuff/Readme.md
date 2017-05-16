<OL START=13>
	<LI><H2 CLASS="western"> * Office Stuff</H2>
</OL>
<P STYLE="margin-bottom: 0.14in; line-height: 115%"><B>This problem
is from the Java Basics Exam (21 Sept 2014 Evening). You can test
your solution <A HREF="https://judge.softuni.bg/Contests/Practice/Index/34#3">here</A>.</B></P>
<P STYLE="margin-bottom: 0.08in; line-height: 115%">You are given a
sequence of<B> n</B> companies in format |<B>&lt;company&gt; -
&lt;amount&gt; - &lt;product&gt;|</B>. Example:</P>
<UL>
	<LI><P STYLE="margin-bottom: 0.08in; line-height: 115%">|SoftUni -
	600 - paper|</P>
	<LI><P STYLE="margin-bottom: 0.08in; line-height: 115%">|Vivacom -
	600 - pen|</P>
	<LI><P STYLE="margin-bottom: 0.08in; line-height: 115%">|XS - 20 -
	chair|</P>
	<LI><P STYLE="margin-bottom: 0.08in; line-height: 115%">|Vivacom -
	200 - chair|</P>
	<LI><P STYLE="margin-bottom: 0.08in; line-height: 115%">|SoftUni -
	40 - chair|</P>
	<LI><P STYLE="margin-bottom: 0.08in; line-height: 115%">|XS - 40 -
	chair|</P>
	<LI><P STYLE="margin-bottom: 0.08in; line-height: 115%">|SoftUni - 1
	- printer|</P>
</UL>
<P STYLE="margin-bottom: 0.08in; line-height: 115%">Write a program
that prints <B>all companies</B> in <B>alphabetical </B>order. For
each company print the product type and their aggregated ordered
amounts. Order the products by <B>order of appearance</B>. <B>Print</B>
the result in the following format: <B>&lt;company&gt;:
&lt;product&gt;-&lt;amount&gt;, &lt;product&gt;-&lt;amount&gt;,…</B>
For the orders above the output should be:</P>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">SoftUni:
	paper-600, chair-40, printer-1</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">Vivacom:
	pen-600, chair-200</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">XS: chair-60</P>
</UL>
<H3 CLASS="western">Input</H3>
<P STYLE="margin-bottom: 0.08in; line-height: 115%">The input comes
from the console. At the first line the number <B>n</B> stays alone.
At the next <B>n</B> lines, we have <B>n</B> orders in format
|<B>&lt;company&gt; - &lt;amount&gt; - &lt;product&gt;|</B>.</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">The input data
will always be valid and in the format described. There is no need to
check it explicitly.</P>
<H3 CLASS="western">Output</H3>
<P STYLE="margin-bottom: 0.08in; line-height: 115%">Print <B>one line
for each company</B>. Company lines should be ordered in <B>alphabetical</B>
<B>order</B>. For each company print the <B>products</B> ordered by
this company in <B>order</B> of <B>appearance</B>, along with the
total amount for the given product. Each line should be in format
<B>&lt;company&gt;: &lt;product&gt;-&lt;amount&gt;,
&lt;product&gt;-&lt;amount&gt;, … &lt;product&gt;-&lt;amount&gt;</B></P>
<H3 CLASS="western">Constraints</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">The <B>count</B>
	of the lines <B>n</B> will be in the range [1 … 100].</P>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">The <B>&lt;company&gt;</B>
	and <B>&lt;product&gt;</B> will consist of only of <B>Latin
	characters</B>, with length of [1 … 20].</P>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">The <B>&lt;amount&gt;</B>
	will be an integer number in the range [1 … 1000].</P>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">Time limit: 0.1
	sec. Memory limit: 16 MB.</P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=698 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=190>
	<COL WIDTH=136>
	<COL WIDTH=2>
	<COL WIDTH=209>
	<COL WIDTH=89>
	<TR VALIGN=TOP>
		<TD WIDTH=190 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=136 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD ROWSPAN=2 WIDTH=2 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=CENTER><BR>
			</P>
		</TD>
		<TD WIDTH=209 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=89 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=190 VALIGN=TOP BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">7</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">|SoftUni
			- 600 - paper|</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">|Vivacom
			- 600 - pen|</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">|XS -
			20 - chair|</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">|Vivacom
			- 200 - chair|</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">|SoftUni
			- 40 - chair|</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">|XS -
			40 - chair|</FONT></P>
			<P><FONT FACE="Consolas, serif">|SoftUni - 1 - printer|</FONT></P>
		</TD>
		<TD WIDTH=136 VALIGN=TOP BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">SoftUni:
			paper-600, chair-40, printer-1</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Vivacom:
			pen-600, chair-200</FONT></P>
			<P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif">XS:
			chair-60</FONT></P>
		</TD>
		<TD WIDTH=209 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">5</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">|SoftUni
			- 200 - desk|</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">|SoftUni
			- 40 - PC|</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">|SoftUni
			- 200 - desk|</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">|SoftUni
			- 600 - paper|</FONT></P>
			<P><FONT FACE="Consolas, serif">|SoftUni - 600 - textbook|</FONT></P>
		</TD>
		<TD WIDTH=89 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif">SoftUni:
			desk-400, PC-40, paper-600, textbook-600</FONT></P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-bottom: 0.14in; line-height: 115%"><BR><BR>
</P>