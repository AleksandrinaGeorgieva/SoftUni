<H2 CLASS="western" ALIGN=JUSTIFY>*Use Your Chains, Buddy</H2>

<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%"><B>This
problem is from the JavaScript Basics Exam (9 January 2015). You may
check your solution </B><FONT COLOR="#0000ff"><SPAN LANG="zxx"><U><A HREF="https://judge.softuni.bg/Contests/Practice/Index/56#2"><B>here</B></A></U></SPAN></FONT><B>.</B></P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">You
are in Cherny Vit now and there are 12km to Anchova Bichkiya Hut. You
need to get there by car. But there is so much snow that you need to
use car chains. In order to put them on the wheels correctly, you
need to read the manual. But it is encrypted…</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">As
input you will receive <B>an HTML document</B> as a <B>single string</B>.
You need to get the text from <B>all the &lt;p&gt; tags </B>and
replace all characters which are <B>not small letters and numbers</B>
with a space <B>&quot; &quot;</B>. After that you must decrypt the
text – all letters <B>from a to m</B> are <B>converted</B> to
letters <B>from n to z</B> (a <FONT FACE="Wingdings, serif"></FONT>
n; b <FONT FACE="Wingdings, serif"></FONT> o; … m <FONT FACE="Wingdings, serif"></FONT>
z). The letters <B>from n to z</B> are <B>converted</B> to letters
<B>from a to m</B> (n <FONT FACE="Wingdings, serif"></FONT> a; o <FONT FACE="Wingdings, serif"></FONT>
b; … z <FONT FACE="Wingdings, serif"></FONT> m). All <B>multiple</B>
spaces should then be replaced by only <B>one space</B>.</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">For
example, if we have <B>&quot;&lt;div&gt;Santa&lt;/div&gt;&lt;p&gt;znahny
# grkg ()&amp;^^^&amp;12&lt;/p&gt;&quot;</B> we extract <B>&quot;znahny
# grkg ()&amp;^^^&amp;12&quot;</B>. Every <B>character</B> that<FONT COLOR="#000000">
is </FONT><FONT COLOR="#000000"><B>not a small letter or a number</B></FONT><FONT COLOR="#ff0000">
</FONT>is replaced with a<B> </B>space (<B>&quot;znahny grkg      
12&quot;</B>). We convert each small letter as described above
(<B>&quot;znahny grkg       12&quot; </B><FONT FACE="Wingdings, serif"><B></B></FONT><B>
&quot;manual text       12&quot;</B>) and replace all multiple spaces
with only <B>one space</B> (<B>&quot;manual text 12&quot;</B>).
Finally, we concatenate the decrypted text from all <B>&lt;p&gt;&lt;/p&gt;</B>
tags (in this case, it's only one). And there you go – you have the
manual ready to read!</P>
<H3 CLASS="western" ALIGN=JUSTIFY><FONT SIZE=4>Input</FONT></H3>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">The input is read
from the console and consists of just one line – the <B>string</B>
with the <B>HTML document</B>.</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">The input data
will always be valid and in the format described. There is no need to
check it explicitly.</P>
<H3 CLASS="western" ALIGN=JUSTIFY><FONT SIZE=4>Output</FONT></H3>
<P STYLE="margin-bottom: 0.14in; line-height: 115%"><B>Print</B> on a
single line the decrypted text of the manual. See the given <B>examples</B>
below.</P>
<H3 CLASS="western" ALIGN=JUSTIFY><FONT SIZE=4>Constraints</FONT></H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">Allowed
	working time: 0.2 seconds. Allowed memory: 16 MB.</P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY><FONT SIZE=4>Examples</FONT></H3>
<TABLE WIDTH=576 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=566>
	<TR>
		<TD WIDTH=566 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=2><B>Input</B></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=566 VALIGN=TOP BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>&lt;html&gt;&lt;head&gt;&lt;title&gt;&lt;/title&gt;&lt;/head&gt;&lt;body&gt;&lt;h1&gt;hello&lt;/h1&gt;&lt;p&gt;</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>znahny!@#%&amp;&amp;&amp;&amp;****</B></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>&lt;/p&gt;&lt;div&gt;&lt;button&gt;dsad&lt;/button&gt;&lt;/div&gt;&lt;p&gt;</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>grkg^^^^%%%)))([]12</B></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>&lt;/p&gt;&lt;/body&gt;&lt;/html&gt;</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=566 HEIGHT=1 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=2><B>Output</B></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=566 VALIGN=TOP BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>manual
			text 12</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=566 VALIGN=TOP BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><BR>
			</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=566 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=2><B>Input</B></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=566 VALIGN=TOP BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><A NAME="_GoBack"></A><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>&lt;html&gt;&lt;head&gt;&lt;title&gt;&lt;/title&gt;&lt;/head&gt;&lt;body&gt;&lt;h1&gt;Intro&lt;/h1&gt;&lt;ul&gt;&lt;li&gt;Item01&lt;/li&gt;&lt;li&gt;Item02&lt;/li&gt;&lt;li&gt;Item03&lt;/li&gt;&lt;/ul&gt;&lt;p&gt;</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>jura
			qevivat va jrg fyvccrel fabjl</B></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>&lt;/p&gt;&lt;div&gt;&lt;button&gt;Click
			me, baby!&lt;/button&gt;&lt;/div&gt;&lt;p&gt; </FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>pbaqvgvbaf
			fabj  qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu
			fabj punvaf znl ybbx</B></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>
			&lt;/p&gt;&lt;span&gt;This manual is false, do not trust it! The
			illuminati wrote it down to trick you!&lt;/span&gt;&lt;p&gt;</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>vagvzvqngvat
			gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir
			sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg</B></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>&lt;/p&gt;&lt;p&gt;</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>
			pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe
			gverf</B></FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>&lt;/p&gt;&lt;/body&gt;</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=566 HEIGHT=1 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT SIZE=2><B>Output</B></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=566 VALIGN=TOP BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>when
			driving in wet slippery snowy conditions snow dchains are
			absolutely essential for safe handling although snow chains may
			look intimidating the basic idea is really simple fit them over
			your tires drive forward slowly and tighten them up in cold wet
			conditions this is easier said than done but if you put on your
			tires</FONT></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>