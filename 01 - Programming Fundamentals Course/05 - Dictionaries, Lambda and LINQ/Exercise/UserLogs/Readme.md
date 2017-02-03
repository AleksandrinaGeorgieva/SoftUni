<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">* User Logs</SPAN></H2>

<P STYLE="margin-top: 0.06in">Marian is a famous system
administrator. The person to overcome the security of his servers has
not yet been born. However, there is a new type of threat where users
flood the server with messages and are hard to be detected since they
change their IP address all the time. Well, Marian is a system
administrator and is not so into programming. Therefore, he needs a
skillful programmer to track the user logs of his servers. You are
the chosen one to help him!</P>
<P STYLE="margin-top: 0.06in">You are given an input in the format:</P>
<P STYLE="margin-top: 0.06in"><B>IP=(IP.Address)
message=(A&amp;sample&amp;message) user=(username)</B></P>
<P STYLE="margin-top: 0.06in">Your task is to parse the IP and the
username from the input and for <B>every user</B>, you have to
display <B>every IP</B> from which the corresponding user has sent a
message and the <B>count of the messages</B> sent with the
corresponding IP. In the output, the usernames must be <B>sorted
alphabetically</B> while their IP addresses should be displayed in
the <B>order of their first appearance. </B>The output should be in
the following format:</P>
<P STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 100%"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>username:
</B></FONT></FONT></FONT>
</P>
<P STYLE="margin-top: 0.06in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>IP
=&gt; count, IP =&gt; count.</B></FONT></FONT></FONT></P>
<P STYLE="margin-top: 0.06in">For example, given the following input
- <B>IP=192.23.30.40 message='Hello&amp;derps.' user=destroyer</B>,
you have to get the<B> </B>username <B>destroyer</B> and the IP
<B>192.23.30.40</B> and display it in the following format:</P>
<P STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 100%"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>destroyer:
</B></FONT></FONT></FONT>
</P>
<P STYLE="margin-top: 0.06in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>192.23.30.40
=&gt; 1.</B></FONT></FONT></FONT></P>
<P STYLE="margin-top: 0.06in"><FONT COLOR="#000000">The username
destroyer has sent a message from IP 192.23.30.40 once.</FONT></P>
<P STYLE="margin-top: 0.06in"><FONT COLOR="#000000">Check the
examples below. They will further clarify the assignment.</FONT></P>
<H3 CLASS="western">Input</H3>
<P STYLE="margin-top: 0.06in">The input comes from the console as
<B>varying number</B> of lines. You have to parse every command until
the command that follows is <B>end.</B> The input will be in the
format displayed above, there is no need to check it explicitly.</P>
<H3 CLASS="western">Output</H3>
<P STYLE="margin-top: 0.06in">For every user found, you have to
display each log in the format:</P>
<P STYLE="margin-top: 0.06in; margin-bottom: 0in; line-height: 100%"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>username:
</B></FONT></FONT></FONT>
</P>
<P STYLE="margin-top: 0.06in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2><B>IP
=&gt; count, IP =&gt; count…</B></FONT></FONT></FONT></P>
<P STYLE="margin-top: 0.06in"><FONT COLOR="#000000">The IP addresses
must be split with a comma, and each line of IP addresses must end
with a dot.</FONT></P>
<H3 CLASS="western">Constraints</H3>
<UL>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">The number of
	commands will be in the range [1..50]</P>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">The IP
	addresses will be in the format of either<B> IPv4</B> or <B>IPv6.</B></P>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">The messages
	will be in the format: <B>This&amp;is&amp;a&amp;message</B></P>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">The username
	will be a string with length in the range [3..50]</P>
	<LI><P STYLE="margin-bottom: 0in; line-height: 100%">Time limit: 0.3
	sec. Memory limit: 16 MB.</P>
</UL>
<P STYLE="margin-left: 0.5in; margin-top: 0.06in; margin-bottom: 0in; line-height: 100%">
<BR>
</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=690 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=492>
	<COL WIDTH=180>
	<TR VALIGN=TOP>
		<TD WIDTH=492 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER STYLE="margin-top: 0.06in"><B>Input</B></P>
		</TD>
		<TD WIDTH=180 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P ALIGN=CENTER STYLE="margin-top: 0.06in"><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=492 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">IP=192.23.30.40
			message='Hello&amp;derps.' user=destroyer</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">IP=192.23.30.41
			message='Hello&amp;yall.' user=destroyer</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">IP=192.23.30.40
			message='Hello&amp;hi.' user=destroyer</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">IP=192.23.30.42
			message='Hello&amp;Dudes.' user=destroyer</FONT></P>
			<P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif">end</FONT></P>
		</TD>
		<TD WIDTH=180 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>destroyer:
			</FONT></FONT></FONT>
			</P>
			<P STYLE="margin-top: 0.06in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>192.23.30.40
			=&gt; 2, 192.23.30.41 =&gt; 1, 192.23.30.42 =&gt; 1.</FONT></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=492 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in; background: #ffffff"><FONT FACE="Courier New, serif"><FONT SIZE=2><FONT FACE="Consolas, serif">IP=</FONT><FONT COLOR="#333333"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 11pt">FE80:0000:0000:0000:0202:B3FF:FE1E:8329
			</FONT></FONT></FONT><FONT FACE="Consolas, serif">message='Hey&amp;son'
			user=mother</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">IP=192.23.33.40
			message='Hi&amp;mom!' user=child0</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">IP=192.23.30.40
			message='Hi&amp;from&amp;me&amp;too' user=child1</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">IP=192.23.30.42
			message='spam' user=destroyer</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">IP=192.23.30.42
			message='spam' user=destroyer</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">IP=192.23.50.40
			message='' user=yetAnotherUsername</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">IP=192.23.50.40
			message='comment' user=yetAnotherUsername</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif">IP=192.23.155.40
			message='Hello.' user=unknown</FONT></P>
			<P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif">end</FONT></P>
		</TD>
		<TD WIDTH=180 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>child0:
			</FONT></FONT></FONT>
			</P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>192.23.33.40
			=&gt; 1.</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>child1:
			</FONT></FONT></FONT>
			</P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>192.23.30.40
			=&gt; 1.</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>destroyer:
			</FONT></FONT></FONT>
			</P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>192.23.30.42
			=&gt; 2.</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>mother:
			</FONT></FONT></FONT>
			</P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>FE80:0000:0000:0000:0202:B3FF:FE1E:8329
			=&gt; 1.</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>unknown:
			</FONT></FONT></FONT>
			</P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>192.23.155.40
			=&gt; 1.</FONT></FONT></FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>yetAnotherUsername:
			</FONT></FONT></FONT>
			</P>
			<P STYLE="margin-top: 0.06in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2>192.23.50.40
			=&gt; 2.</FONT></FONT></FONT></P>
		</TD>
	</TR>
</TABLE>