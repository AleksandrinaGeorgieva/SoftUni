<OL START=16>
	<LI><H2 CLASS="western" STYLE="margin-top: 0in">*** Extract
	Hyperlinks</H2>
</OL>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 115%">Write
a program to <B>extract all hyperlinks</B> (<B>&lt;href=…&gt;</B>)
from a given text. The text comes from the console on a variable
number of lines and ends with the command &quot;END&quot;. Print at
the console the <B>href</B> values in the text.</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 115%">The
input text is <B>standard HTML code</B>. It may hold many tags and
can be formatted in many different forms (with or without
whitespace). The <B>&lt;a&gt;</B> elements may have many attributes,
not only <B>href</B>. You should extract only the values of the <B>href</B>
attributes of all <B>&lt;a&gt;</B> elements.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Input</H3>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 100%">The
input data comes from the console. It ends when the &quot;END&quot;
command is received.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Output</H3>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 115%">Print
at the console the <B>href</B> values in the text, each at a separate
line, in the order they come from the input.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Constraints</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 100%">
	The input will be <B>well formed HTML fragment</B> (all tags and
	attributes will be correctly closed).</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 100%">
	Attribute values will never hold tags and hyperlinks, e.g. &quot;<B>&lt;img
	alt='&lt;a href=&quot;hello&quot;&gt;' /&gt;</B>&quot; is invalid.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 100%">
	Commented links are also extracted.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0in; line-height: 100%">
	The number of input lines will be in the range [1 ... 100].</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">Allowed
	working time: 0.1 seconds. Allowed memory: 16 MB.</P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
Examples</H3>
<TABLE WIDTH=698 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=475>
	<COL WIDTH=204>
	<TR VALIGN=TOP>
		<TD WIDTH=475 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><B>Input</B></P>
		</TD>
		<TD WIDTH=204 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=475 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;a
			href=&quot;http://softuni.bg&quot; class=&quot;new&quot;&gt;&lt;/a&gt;</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">END</FONT></P>
		</TD>
		<TD WIDTH=204 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">http://softuni.bg</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=475 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;p&gt;This
			text has no links&lt;/p&gt;</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">END</FONT></P>
		</TD>
		<TD WIDTH=204 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=475 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;!DOCTYPE
			html&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;html&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;head&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;title&gt;Hyperlinks&lt;/title&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;link
			href=&quot;theme.css&quot; rel=&quot;stylesheet&quot; /&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;/head&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;body&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;ul&gt;&lt;li&gt;&lt;a
			  </FONT><FONT FACE="Consolas, serif"><B>href=&quot;/&quot;</B></FONT><FONT FACE="Consolas, serif">
			 id=&quot;home&quot;&gt;Home&lt;/a&gt;&lt;/li&gt;&lt;li&gt;&lt;a</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">class=&quot;selected&quot;
			</FONT><FONT FACE="Consolas, serif"><B>href=/courses</B></FONT><FONT FACE="Consolas, serif">&gt;Courses&lt;/a&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;/li&gt;&lt;li&gt;&lt;a
			</FONT><FONT FACE="Consolas, serif"><B>href =</B></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>'/forum'
			</B></FONT><FONT FACE="Consolas, serif">&gt;Forum&lt;/a&gt;&lt;/li&gt;&lt;li&gt;&lt;a
			class=&quot;href&quot;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">onclick=&quot;go()&quot;
			</FONT><FONT FACE="Consolas, serif"><B>href= &quot;#&quot;</B></FONT><FONT FACE="Consolas, serif">&gt;Forum&lt;/a&gt;&lt;/li&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;li&gt;&lt;a
			id=&quot;js&quot; </FONT><FONT FACE="Consolas, serif"><B>href =</B></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>&quot;javascript:alert('hi
			yo')&quot;</B></FONT><FONT FACE="Consolas, serif">
			class=&quot;new&quot;&gt;click&lt;/a&gt;&lt;/li&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;li&gt;&lt;a
			id='nakov' </FONT><FONT FACE="Consolas, serif"><B>href =</B></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>http://www.nakov.com</B></FONT><FONT FACE="Consolas, serif">
			class='new'&gt;nak&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;a
			</FONT><FONT FACE="Consolas, serif"><B>href=&quot;#empty&quot;</B></FONT><FONT FACE="Consolas, serif">&gt;&lt;/a&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;a
			id=&quot;href&quot;&gt;href='fake'&lt;img
			src='http://abv.bg/i.gif'</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">alt='abv'/&gt;&lt;/a&gt;&lt;a
			</FONT><FONT FACE="Consolas, serif"><B>href=&quot;#&quot;</B></FONT><FONT FACE="Consolas, serif">&gt;&amp;lt;a
			href='hello'&amp;gt;&lt;/a&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;!--
			This code is commented:</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;a
			href=&quot;#commented&quot;&gt;commentex hyperlink&lt;/a&gt; --&gt;</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&lt;/body&gt;</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">END</FONT></P>
		</TD>
		<TD WIDTH=204 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">/</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">/courses</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">/forum</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">#</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">javascript:alert('hi
			yo')</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">http://www.nakov.com</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">#empty</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">#</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">#commented</FONT></P>
		</TD>
	</TR>
</TABLE>