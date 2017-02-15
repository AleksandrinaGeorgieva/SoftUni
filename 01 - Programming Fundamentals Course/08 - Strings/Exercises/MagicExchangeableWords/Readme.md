<H2 CLASS="western">Magic exchangeable words</H2>

<P STYLE="margin-bottom: 0.14in; line-height: 115%">Write a <B>method
</B>that takes as input two strings, and returns Boolean if they are
exchangeable or not. Exchangeable are words where the characters in
the first string can be replaced to get the second string. Example:
&quot;<B>egg&quot;</B> and &quot;<B>add&quot; </B>are exchangeable,
but &quot;<B>aabbccbb&quot;</B> and &quot;<B>nnooppzz&quot;</B> are
not. (First '<B>b'</B> corresponds to '<B>o'</B>, but then it also
corresponds to '<B>z'</B>). The two words may not have the same
length, if such is the case they are exchangeable only if the longer
one doesn't have more types of characters then the shorter one
(&quot;<B>Clint&quot; </B>and<B> &quot;Eastwaat&quot;</B> are
exchangeable because '<B>a' </B>and<B> 't'</B> are already mapped as
'<B>l' </B>and<B> 'n'</B>, but &quot;<B>Clint&quot; </B>and<B>
&quot;Eastwood</B>&quot; aren't exchangeable because '<B>o'</B> and
'<B>d'</B> are not contained in &quot;<B>Clint&quot;</B>).</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=216 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=131>
	<COL WIDTH=67>
	<TR>
		<TD WIDTH=131 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=67 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=131 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">gosho hapka</FONT></P>
		</TD>
		<TD WIDTH=67 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">true</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=131 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">aabbaa ddeedd</FONT></P>
		</TD>
		<TD WIDTH=67 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">true</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=131 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">foo bar</FONT></P>
		</TD>
		<TD WIDTH=67 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">false</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=131 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">Clint Eastwood</FONT></P>
		</TD>
		<TD WIDTH=67 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">false</FONT></P>
		</TD>
	</TR>
</TABLE>