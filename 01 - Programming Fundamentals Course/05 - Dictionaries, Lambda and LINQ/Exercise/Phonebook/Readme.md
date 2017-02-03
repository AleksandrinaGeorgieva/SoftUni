<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Phonebook</SPAN></H2>

<P ALIGN=JUSTIFY>Write a program that receives some info from the
console about <B>people</B> and their <B>phone numbers</B>. Each
<B>entry</B> should have just <B>one name</B> and <B>one number</B>
(both of them strings). 
</P>
<P ALIGN=JUSTIFY>On each line you will receive some of the following
commands:</P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in"><B>A {name}
	{phone}</B> – adds entry to the phonebook. In case of trying to
	add a name that is already in the phonebook you should change the
	existing phone number with the new one provided.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in"><B>S {name}</B> –
	searches for a contact by given name and prints it in format &quot;<FONT FACE="Consolas, serif"><B>{name}
	-&gt; {number}</B></FONT>&quot;. In case the contact isn't found,
	print &quot;<FONT FACE="Consolas, serif"><B>Contact {name} does not
	exist.</B></FONT>&quot;.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in"><B>END</B> –
	stop receiving more commands.</P>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=463 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=180>
	<COL WIDTH=265>
	<TR VALIGN=TOP>
		<TD WIDTH=180 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=265 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=180 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">A
			Nakov 0888080808</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">S
			Mariika</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">S Nakov</FONT></P>
			<P><FONT FACE="Consolas, serif">END</FONT></P>
		</TD>
		<TD WIDTH=265 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Contact
			Mariika does not exist.</FONT></P>
			<P><FONT FACE="Consolas, serif">Nakov -&gt; 0888080808</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=180 HEIGHT=6 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">A
			Nakov +359888001122</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">A
			RoYaL(Ivan) 666</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">A
			Gero 5559393</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">A
			Simo 02/987665544</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">S
			Simo</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">S
			simo</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">S
			RoYaL</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">S
			RoYaL(Ivan)</FONT></P>
			<P><FONT FACE="Consolas, serif">END</FONT></P>
		</TD>
		<TD WIDTH=265 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Simo -&gt;
			02/987665544</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Contact
			simo does not exist.</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Contact
			RoYaL does not exist.</FONT></P>
			<P><FONT FACE="Consolas, serif">RoYaL(Ivan) -&gt; 666</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=180 HEIGHT=5 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">A
			Misho +359883123</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">A
			Misho 02/3123</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">S
			Misho</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">END</FONT></P>
		</TD>
		<TD WIDTH=265 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">Misho -&gt; 02/3123</FONT></P>
		</TD>
	</TR>
</TABLE>