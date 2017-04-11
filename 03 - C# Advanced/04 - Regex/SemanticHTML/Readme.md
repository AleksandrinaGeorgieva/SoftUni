<OL START=3>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY> ** Semantic HTML</H2>
</OL>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
<SPAN LANG="en-US"><B>This problem is originally from the PHP Basics
Exam (31 August 2014). You may check your solution </B></SPAN><FONT COLOR="#0563c1"><SPAN LANG="zxx"><U><A HREF="https://judge.softuni.bg/Contests/Practice/Index/84#4"><SPAN LANG="en-US"><B>here</B></SPAN></A></U></SPAN></FONT><SPAN LANG="en-US"><B>.</B></SPAN></P>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0.08in; line-height: 100%">
<SPAN LANG="en-US">You are given an </SPAN><SPAN LANG="en-US"><B>HTML
code</B></SPAN><SPAN LANG="en-US">, written in the old </SPAN><SPAN LANG="en-US"><B>non-semantic</B></SPAN><SPAN LANG="en-US">
style using tags like </SPAN><SPAN LANG="en-US"><B>&lt;div
id=&quot;header&quot;&gt;</B></SPAN><SPAN LANG="en-US">, </SPAN><SPAN LANG="en-US"><B>&lt;div
class=&quot;section&quot;&gt;</B></SPAN><SPAN LANG="en-US">, etc.
Your task is to write a program that </SPAN><SPAN LANG="en-US"><B>converts
this HTML to semantic HTML</B></SPAN><SPAN LANG="en-US"> by changing
tags like </SPAN><SPAN LANG="en-US"><B>&lt;div id=&quot;header&quot;&gt;</B></SPAN><SPAN LANG="en-US">
to their semantic equivalent like </SPAN><SPAN LANG="en-US"><B>&lt;header&gt;</B></SPAN><SPAN LANG="en-US">.</SPAN></P>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0.08in; line-height: 100%">
<SPAN LANG="en-US">The non-semantic tags that should be converted are
</SPAN><SPAN LANG="en-US"><B>always &lt;div&gt;</B></SPAN><SPAN LANG="en-US">s
and have either </SPAN><SPAN LANG="en-US"><B>id</B></SPAN><SPAN LANG="en-US">
or </SPAN><SPAN LANG="en-US"><B>class</B></SPAN><SPAN LANG="en-US">
with one of the following values: &quot;</SPAN><SPAN LANG="en-US"><B>main</B></SPAN><SPAN LANG="en-US">&quot;,
&quot;</SPAN><SPAN LANG="en-US"><B>header</B></SPAN><SPAN LANG="en-US">&quot;,
&quot;</SPAN><SPAN LANG="en-US"><B>nav</B></SPAN><SPAN LANG="en-US">&quot;,
&quot;</SPAN><SPAN LANG="en-US"><B>article</B></SPAN><SPAN LANG="en-US">&quot;,
&quot;</SPAN><SPAN LANG="en-US"><B>section</B></SPAN><SPAN LANG="en-US">&quot;,
&quot;</SPAN><SPAN LANG="en-US"><B>aside</B></SPAN><SPAN LANG="en-US">&quot;
or &quot;</SPAN><SPAN LANG="en-US"><B>footer</B></SPAN><SPAN LANG="en-US">&quot;.
Their corresponding closing tags are always followed by a comment
like </SPAN><SPAN LANG="en-US"><B>&lt;!-- header --&gt;</B></SPAN><SPAN LANG="en-US">,
</SPAN><SPAN LANG="en-US"><B>&lt;!-- nav --&gt;</B></SPAN><SPAN LANG="en-US">,
etc. staying at the same line, after the tag.</SPAN></P>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><SPAN LANG="en-US">Input</SPAN></H3>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 100%">
<SPAN LANG="en-US">The input will be read from the console. It will
contain a variable number of lines and will end with the keyword
&quot;</SPAN><SPAN LANG="en-US"><B>END</B></SPAN><SPAN LANG="en-US">&quot;.</SPAN></P>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><SPAN LANG="en-US">Output</SPAN></H3>
<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 100%">
<SPAN LANG="en-US">The output is the semantic version of the input
HTML. In all converted tags you should </SPAN><SPAN LANG="en-US"><B>replace
multiple spaces</B></SPAN><SPAN LANG="en-US"> (like </SPAN><SPAN LANG="en-US"><B>&lt;header</B></SPAN><SPAN LANG="en-US"><B><SPAN STYLE="background: #bfbfbf">
     </SPAN></B></SPAN><SPAN LANG="en-US"><B>style=&quot;color:red&quot;&gt;</B></SPAN><SPAN LANG="en-US">)
with a single space and remove excessive spaces at the end (like
</SPAN><SPAN LANG="en-US"><B>&lt;footer</B></SPAN><SPAN LANG="en-US"><B><SPAN STYLE="background: #bfbfbf">
     </SPAN></B></SPAN><SPAN LANG="en-US"><B>&gt;</B></SPAN><SPAN LANG="en-US">).
See the examples.</SPAN></P>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><SPAN LANG="en-US">Constraints</SPAN></H3>
<UL>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">Each line from the input holds either an HTML
	</SPAN><SPAN LANG="en-US"><B>opening tag</B></SPAN><SPAN LANG="en-US">
	or an HTML </SPAN><SPAN LANG="en-US"><B>closing tag</B></SPAN><SPAN LANG="en-US">
	or HTML </SPAN><SPAN LANG="en-US"><B>text content</B></SPAN><SPAN LANG="en-US">.</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">There will be no tags that span several lines and
	no lines that hold multiple tags.</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">Attributes values will always be enclosed in
	</SPAN><SPAN LANG="en-US"><B>double quotes</B></SPAN><SPAN LANG="en-US">
	</SPAN><SPAN LANG="en-US"><B>&quot;</B></SPAN><SPAN LANG="en-US">.</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">Tags will never have </SPAN><SPAN LANG="en-US"><B>id</B></SPAN><SPAN LANG="en-US">
	and </SPAN><SPAN LANG="en-US"><B>class</B></SPAN><SPAN LANG="en-US">
	at the same time.</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">The HTML will be </SPAN><SPAN LANG="en-US"><B>valid</B></SPAN><SPAN LANG="en-US">.
	Opening and closing tags will match correctly.</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US"><B>Whitespace</B></SPAN><SPAN LANG="en-US"> may
	occur between attribute names, values and around comments (see the
	examples).</SPAN></P>
	<LI><P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">
	<SPAN LANG="en-US">Allowed working time: 0.1 seconds. Allowed
	memory: 16</SPAN><SPAN LANG="en-US"> MB.</SPAN></P>
</UL>
<H3 LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><SPAN LANG="en-US">Examples</SPAN></H3>
<TABLE WIDTH=692 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=373>
	<COL WIDTH=301>
	<TR VALIGN=TOP>
		<TD WIDTH=373 HEIGHT=1 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Input</B></SPAN></P>
		</TD>
		<TD WIDTH=301 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><SPAN LANG="en-US"><B>Output</B></SPAN></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=373 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;div
			id=&quot;header&quot;&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/div&gt;
			&lt;!-- header --&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">END</SPAN></FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=301 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;header&gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/header&gt;</SPAN></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=373 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;div
			style=&quot;color:red&quot; id=&quot;header&quot;&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/div&gt;
			&lt;!-- header --&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">END</SPAN></FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=301 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;header
			style=&quot;color:red&quot;&gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/header&gt;</SPAN></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=373 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;div
			class=&quot;header&quot; style=&quot;color:blue&quot;&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/div&gt;
			&lt;!-- header --&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">END</SPAN></FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=301 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;header
			style=&quot;color:blue&quot;&gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/header&gt;</SPAN></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=373 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;div
			align=&quot;left&quot; id=&quot;nav&quot; style=&quot;color:blue&quot;&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">  <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;ul
			class=&quot;header&quot;&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">    <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;li
			id=&quot;main&quot;&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">      <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">Hi,
			I have id=&quot;main&quot;.</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">    <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/li&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">  <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/ul&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/div&gt;
			&lt;!-- nav --&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">END</SPAN></FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=301 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;nav
			align=&quot;left&quot; style=&quot;color:blue&quot;&gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			  <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;ul
			class=&quot;header&quot;&gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			    <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;li
			id=&quot;main&quot;&gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			      <FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">Hi,
			I have id=&quot;main&quot;.</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			    <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/li&gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			  <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/ul&gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/nav&gt;</SPAN></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=373 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">  <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;p
			class = &quot;section&quot; &gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">    <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;div
			style = &quot;border: 1px&quot; id = &quot;header&quot; &gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">        <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">Header</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">        <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;div
			id = &quot;nav&quot; &gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">            <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">Nav</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">        <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/div&gt;
			  &lt;!--   nav   --&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">    <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/div&gt;
			 &lt;!--header--&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			<FONT COLOR="#000000">  <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/p&gt;
			&lt;!-- end paragraph section --&gt;</SPAN></FONT></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">END</SPAN></FONT></FONT></FONT></P>
		</TD>
		<TD WIDTH=301 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			  <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;p
			class = &quot;section&quot; &gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			    <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;header
			style = &quot;border: 1px&quot;&gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			        <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">Header</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			        <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;nav&gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			            <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">Nav</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			        <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/nav&gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in">
			    <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/header&gt;</SPAN></FONT></FONT></P>
			<P LANG="bg-BG" CLASS="western" ALIGN=JUSTIFY>  <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 10pt"><SPAN LANG="en-US">&lt;/p&gt;
			&lt;!-- end paragraph section --&gt;</SPAN></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>