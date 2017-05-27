<OL START=9>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY>Google</H2>
</OL>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">Google is always
watching you, so it should come as no surprise that they know
everything about you (even your pokemon collection), since you’re
really good at writing classes Google asked you to design a Class
that can hold all the information they need for people.</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">From the console
you will receive an unkown amount of lines until the command “<B>End</B>”
is read, on each of those lines there will be information about a
person in one of the following formats:</P>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>&lt;Name&gt;
	company &lt;companyName&gt; &lt;department&gt; &lt;salary&gt;</B>”
	 
	</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>&lt;Name&gt;
	pokemon &lt;pokemonName&gt; &lt;pokemonType&gt;”</B></P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>&lt;Name&gt;
	parents &lt;parentName&gt; &lt;parentBirthday&gt;</B>”</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>&lt;Name&gt;
	children &lt;childName&gt; &lt;childBirthday&gt;</B>”</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>&lt;Name&gt;
	car &lt;carModel&gt; &lt;carSpeed&gt;</B>”</P>
</UL>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">You should
structure all information about a person in a class with nested
subclasses. People’s names are <B>unique </B>- there won’t be 2
people with the same name, a person can also have <B>only 1</B>
<B>company</B> and <B>car</B>, but can have <B>multiple</B> <B>parents,
chidlren</B> and <B>pokemon</B>. After the command “<B>End</B>”
is received on the next line you will receive a single name, you
should print all information about that person. Note that information
can change during the input, for instance if we receive multiple
lines which specify a person’s company, only the <B>last one</B>
should be the one remembered. The salary must be formated to <B>two
decimal places</B> after the seperator.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=720 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=399>
	<COL WIDTH=303>
	<TR VALIGN=TOP>
		<TD WIDTH=399 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=303 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=399 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">PeshoPeshev
			company PeshInc Management 1000.00</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">TonchoTonchev
			car Trabant 30</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">PeshoPeshev
			pokemon Pikachu Electricity</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">PeshoPeshev
			parents PoshoPeshev 22/02/1920</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">TonchoTonchev
			pokemon Electrode Electricity</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">End</FONT></P>
			<P><FONT FACE="Consolas, serif">TonchoTonchev</FONT></P>
		</TD>
		<TD WIDTH=303 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">TonchoTonchev</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Company:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Car:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Trabant
			30</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pokemon:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Electrode
			Electricity</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Parents:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Children:</FONT></P>
			<P><BR>
			</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=399 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">JelioJelev
			pokemon Onyx Rock</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">JelioJelev
			parents JeleJelev 13/03/1933</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">GoshoGoshev
			pokemon Moltres Fire</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">JelioJelev
			company JeleInc Jelior 777.77</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">JelioJelev
			children PudingJelev 01/01/2001</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">StamatStamatov
			pokemon Blastoise Water</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">JelioJelev
			car AudiA4 180</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">JelioJelev
			pokemon Charizard Fire</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">End</FONT></P>
			<P><FONT FACE="Consolas, serif">JelioJelev</FONT></P>
		</TD>
		<TD WIDTH=303 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">JelioJelev</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Company:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">JeleInc
			Jelior 777.77</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Car:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">AudiA4
			180</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pokemon:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Onyx
			Rock</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Charizard
			Fire</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Parents:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">JeleJelev
			13/03/1933</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Children:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">PudingJelev
			01/01/2001</FONT></P>
			<P><BR>
			</P>
		</TD>
	</TR>
</TABLE>