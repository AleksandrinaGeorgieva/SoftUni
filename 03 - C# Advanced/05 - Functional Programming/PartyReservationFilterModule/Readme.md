<OL START=6>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY>*Party Reservation Filter
	Module</H2>
</OL>
<P CLASS="western" STYLE="margin-bottom: 0.14in">You are a young and
talented developer. The first task you need to do is to implement a
filtering module to a party reservation software. First, The Party
Reservation Filter Module (TPRF Module for short) is passed a list
with invitations. Next the TPRF receives a sequence of commands that
specify if you need to add or remove a given filter. 
</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in">TPRF Commands are in
the given format <B>{command;filter type;filter parameter}</B></P>
<P CLASS="western" STYLE="margin-bottom: 0.14in">You can receive the
following TPRF commands: &quot;Add filter&quot;, &quot;Remove filter&quot;
or &quot;Print&quot;. The possible TPRF filter types are: &quot;Starts
with&quot;, &quot;Ends with&quot;, &quot;Length&quot; and &quot;Contains&quot;.
All TPRF filter parameters will be a string (or an integer for the
length filter).</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in">The input will end
with a &quot;Print&quot; command after which you should print all the
party-goers that are left after the filtration. See the examples
below:</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=600 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=247>
	<COL WIDTH=334>
	<TR VALIGN=TOP>
		<TD WIDTH=247 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=334 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=247 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho
			Misho Slav</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Add
			filter;Starts with;P</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Add
			filter;Starts with;M</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif">Print</FONT></P>
		</TD>
		<TD WIDTH=334 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif">Slav</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=247 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho
			Misho Jica</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Add
			filter;Starts with;P</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Add
			filter;Starts with;M</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Remove
			filter;Starts with;M</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif">Print</FONT></P>
		</TD>
		<TD WIDTH=334 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif">Misho
			Jica</FONT></P>
		</TD>
	</TR>
</TABLE>