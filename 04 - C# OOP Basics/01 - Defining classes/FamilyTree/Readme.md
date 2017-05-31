<OL START=10>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY>***Family Tree</H2>
</OL>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">You
want to build your family tree, so you went to ask your grandmother,
sadly your grandmother keeps remembering information about your
predecessors in pieces, so it falls to you to group the information
and build the family tree.</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">On
the first line of the input you will receive either a name or a
birthdate in the format “&lt;<B>FirstName&gt; &lt;LastName&gt;”
</B>or <B>“day/month/year</B>” – your task is to find the
person’s information in the family tree. On the next lines until
the command “<B>End</B>” is received you will receive information
about your predecessors that you will use to build the family tree. 
</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">The information
will be in one of the following formats: 
</P>
<UL>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>FirstName
	LastName - FirstName LastName</B>”</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>FirstName
	LastName - day/month/year</B>”</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>day/month/year
	- FirstName LastName</B>”</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>day/month/year
	- day/month/year</B>”</P>
	<LI><P STYLE="margin-bottom: 0.14in; line-height: 115%">“<B>FirstName
	LastName day/month/year</B>”</P>
</UL>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">The first 4
formats reveal a family tie – <B>the person on the left is parent
to the person on the right</B> (as you can see the format does not
need to contain names, for example the 4<SUP>th</SUP> format means
the person born on the left date is parent to the person born on the
right date). The last format ties different information together –
i.e. <B>the person with that name was born on that date</B>. <B>Names</B>
and <B>birthdates</B> are <B>unique</B> – there won’t be 2 people
with the same name or birthdate, there will <B>always</B> be enough
entries to construct the family tree (all people’s names and
birthdates are known and they have atleast one connection to another
person in the tree). 
</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">After
the command “<B>End</B>” is received you should print all
information about the person whose name or birthdate you received on
the first line – his <B>name, birthday, parents and children</B>
(check the examples for the format). The people in the parents and
childrens lists should be ordered by their first appearance in the
input (regardless if they appeared as a birthdate or a name, for
example in the first input Stamat is before Penka because he first
appeared in the second line, while she appears in the third.).</P>
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
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho
			Peshev</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">11/11/1951
			- 23/5/1980</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Penka
			Pesheva - 23/5/1980</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Penka
			Pesheva 9/2/1953</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho
			Peshev - Gancho Peshev</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Gancho
			Peshev 1/1/2005</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Stamat
			Peshev 11/11/1951</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho
			Peshev 23/5/1980</FONT></P>
			<P><FONT FACE="Consolas, serif">End</FONT></P>
		</TD>
		<TD WIDTH=303 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho
			Peshev 23/5/1980</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Parents:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Stamat
			Peshev 11/11/1951</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Penka
			Pesheva 9/2/1953</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Children:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Gancho
			Peshev 1/1/2005</FONT></P>
			<P><BR>
			</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=399 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">13/12/1993</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">25/3/1934
			- 4/4/1961</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Poncho
			Tonchev 25/3/1934</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">4/4/1961
			- Moncho Tonchev</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Toncho
			Tonchev - Lomcho Tonchev</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Moncho
			Tonchev 13/12/1993</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Lomcho
			Tonchev 7/7/1995</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Toncho
			Tonchev 4/4/1961</FONT></P>
			<P><FONT FACE="Consolas, serif">End</FONT></P>
		</TD>
		<TD WIDTH=303 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Moncho
			Tonchev 13/12/1993</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Parents:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Toncho
			Tonchev 4/4/1961</FONT></P>
			<P><FONT FACE="Consolas, serif">Children:</FONT></P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-bottom: 0.14in; line-height: 115%"><BR><BR>
</P>
