<OL START=12>
	<LI><H2 CLASS="western">* Little John</H2>
</OL>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%"><B>This
problem is originally from the PHP Basics Exam (3 May 2015). You may
check your solution <A HREF="https://judge.softuni.bg/Contests/Practice/Index/84#10">here</A>.</B></P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">As
you probably know Little John is the right hand of the famous English
hero - Robin Hood.<B> </B>A little known fact is<B> </B>that Little
John can't handle Math very well. Before Robin Hood left to see Marry
Ann, he asked John to <B>count</B> his hay of arrows<B> </B>and send
him an <B>encrypted</B> message containing the<B> </B>arrow's count<B>.
</B>The message should be encrypted since it can be intercepted by
the Nottingham’s evil Sheriff. Your task is to help Little John
before it is too late (0.10 sec).</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">You
are given<B> 4 input</B> strings<B> </B>(hay). Those strings <B>may
or may not</B> contain arrows. The arrows can be of different type as
follows:</P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	&quot;<FONT FACE="Consolas, serif">&gt;-----&gt;</FONT>&quot; – a
	small arrow</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	&quot;<FONT FACE="Consolas, serif">&gt;&gt;-----&gt;</FONT>&quot; –
	a medium arrow</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">
	&quot;<FONT FACE="Consolas, serif">&gt;&gt;&gt;-----&gt;&gt;</FONT>&quot;
	– a large arrow</P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">Note
that the <B>body</B> of each arrow will always be <B>5 dashes long</B>.
The <B>difference</B> between the arrows is in their <B>tip</B> and
<B>tail</B>. The given 3 types are the only ones you should count,
the <B>rest should be ignored</B> (Robin Hood does not like them).
You should start searching the hays <B>from the largest</B> arrow
type down <B>to the smallest</B> arrow type.</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">After
you find the <B>count </B>of each arrow type you should <B>concatenate
</B>them into one number in order: small,<B> </B>medium, large arrow<B>
</B>(even if the arrow count is 0). Then you <B>convert</B> the
number in <B>binary</B> representation, <B>reverse</B> it and
<B>concatenate it again</B> with the initial binary representation of
the number. You <B>convert</B> the final binary number again <B>back
to decimal</B>. This is the encrypted message you should send to
Robin Hood.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0.14in">
Input</H3>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.08in; margin-bottom: 0.08in; line-height: 100%">
The input will be read from the console. The <B>data</B> will be
received from 4 input <B>lines containing strings</B>.</P>
<H3 CLASS="western" ALIGN=JUSTIFY>Output</H3>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 115%">The
output should be a decimal number, representing the encrypted count
of arrows.</P>
<H3 CLASS="western" ALIGN=JUSTIFY>Constraints</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	input strings will contain any ASCII character.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">Allowed
	working time: 0.1 seconds. Allowed memory: 16 MB.<FONT FACE="Times New Roman, serif"><FONT SIZE=1 STYLE="font-size: 1pt"><SPAN STYLE="background: #000000">
	</SPAN></FONT></FONT>
	</P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=709 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=268>
	<COL WIDTH=411>
	<TR VALIGN=TOP>
		<TD WIDTH=268 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=411 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=268 HEIGHT=78 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&gt;&gt;&gt;-----&gt;&gt;abc&gt;&gt;&gt;-----&gt;&gt;</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&gt;&gt;&gt;-----&gt;&gt;</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">&gt;-----&gt;s</FONT></P>
			<P><FONT FACE="Consolas, serif">&gt;&gt;-----&gt;</FONT></P>
		</TD>
		<TD WIDTH=411 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">14535</FONT></P>
			<P STYLE="margin-bottom: 0in"><BR>
			</P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><I>The
			count is: 1 small, 1 medium and 3 large arrows</I></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><I>113(dec)
			= 1110001(bin) -&gt; reversed is 1000111(bin)</I></FONT></P>
			<P><FONT FACE="Consolas, serif"><I>1110001</I></FONT><FONT FACE="Consolas, serif"><I><SPAN STYLE="background: #c0c0c0">1000111</SPAN></I></FONT><FONT FACE="Consolas, serif"><I>(bin)
			= 14535(dec)</I></FONT></P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-bottom: 0.08in; line-height: 115%"><BR><BR>
</P>