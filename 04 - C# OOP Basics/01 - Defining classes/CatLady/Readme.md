<OL START=11>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY>**Cat Lady</H2>
</OL>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">Ginka has many
cats in her house of various breeds, since some breeds have specific
characteristics, Ginka needs some way to catalogue the cats, help her
by creating a class hierarchy with all her breeds of cats so that she
can easily check on their characteristics. Ginka has 3 specific
breeds of cats “Siamese”, “Cymric” and the very famous
bulgarian breed “Street Extraordinaire”,  each breed has a
specific characteristic about which information should be kept. For
the Siamese cats their ear size should be kept, for Cymric cats - the
length of their fur in centimeters and for the Street Extraordinaire
the decibels of their meowing during the night.</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">From the console
you will receive lines of cat information until the command “<B>End</B>”
is received, the information will come in one of the following
formats:</P>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>Siamese
	&lt;name&gt; &lt;earSize&gt;”</B></P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>Cymric
	&lt;name&gt; &lt;furLength&gt;”</B></P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>StreetExtraordinaire
	&lt;name&gt; &lt;decibelsOfMeows&gt;”</B></P>
</UL>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">On the last line
after the “<B>End</B>” command you will receive the name of a
cat, you should print that cat’s information in the same format in
which you received it (with <B>fur size</B> being formated to <B>two
decimal places</B> after the separator). Ear size and decibels will
always be <B>positive integer</B> numbers, cat names are <B>unique</B>.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Example</H3>
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
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">StreetExtraordinaire
			Maca 85</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Siamese
			Sim 4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Cymric
			Tom 2.80</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">End</FONT></P>
			<P><FONT FACE="Consolas, serif">Tom</FONT></P>
		</TD>
		<TD WIDTH=303 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">Cymric Top 2.80</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=399 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">StreetExtraordinaire
			Koti 80</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">StreetExtraordinaire
			Maca 100</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Cymric
			Tim 3.10</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">End</FONT></P>
			<P><FONT FACE="Consolas, serif">Maca</FONT></P>
		</TD>
		<TD WIDTH=303 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">StreetExtraordinaire Maca 100</FONT></P>
		</TD>
	</TR>
</TABLE>
