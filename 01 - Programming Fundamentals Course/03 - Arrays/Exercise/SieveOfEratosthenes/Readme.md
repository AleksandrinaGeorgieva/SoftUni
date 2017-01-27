<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Sieve of
	Eratosthenes</SPAN></H2>

<P STYLE="margin-top: 0.06in">Write a program to find <B>all prime
numbers in range [1…n]</B><SPAN LANG="bg-BG">. </SPAN>Implement the
algorithm called “Sieve of Eratosthenes”:
<A HREF="https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes">https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes</A><SPAN LANG="bg-BG">.</SPAN>
Steps in the “Sieve of Eratosthenes” algorithm:</P>
<OL>
	<LI><P STYLE="margin-top: 0.06in">Assign <B>primes</B>[0…<B>n</B>]
	= <B>true</B></P>
	<LI><P STYLE="margin-top: 0.06in">Assign <B>primes</B>[0] =
	<B>primes</B>[1] = <B>false</B></P>
	<LI><P STYLE="margin-top: 0.06in">Find the smallest <B>p</B>, which<SPAN LANG="bg-BG">
	</SPAN>holds <B>primes</B>[<B>p</B>] = <B>true</B></P>
	<UL>
		<LI><P STYLE="margin-top: 0.06in">Print <B>p</B> (it is prime)</P>
		<LI><P STYLE="margin-top: 0.06in">Assign <B>primes</B>[2*<B>p</B>]
		= <B>primes</B>[3*<B>p</B>] =<SPAN LANG="bg-BG"> </SPAN><B>primes</B>[4*<B>p</B>]
		= … = <B>false</B></P>
	</UL>
	<LI><P STYLE="margin-top: 0.06in">Repeat for the next smallest <B>p</B>
	&lt; <B>n</B>.</P>
</OL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=252 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=46>
	<COL WIDTH=188>
	<TR VALIGN=TOP>
		<TD WIDTH=46 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=188 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=46 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P>6</P>
		</TD>
		<TD WIDTH=188 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">2 3 5</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=46 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P>25</P>
		</TD>
		<TD WIDTH=188 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">2 3 5 7 11 13 17 19 23</FONT></P>
		</TD>
	</TR>
</TABLE>