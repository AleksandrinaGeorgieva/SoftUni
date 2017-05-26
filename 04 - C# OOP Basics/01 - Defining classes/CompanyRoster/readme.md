
<OL START=4>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY>Company Roster</H2>
</OL>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">Define a class
<B>Employee</B> that holds the following information: <B>name,
salary, position, department, email</B> and <B>age</B>. The <B>name,
salary</B>, <B>position</B> and <B>department</B> are <B>mandatory</B>
while the rest are <B>optional</B>. 
</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">Your task is to
write a program which takes <B>N</B> lines of employees from the
console and calculates the department with the highest average salary
and prints for each employee in that department his <B>name, salary,
email and age</B> – <B>sorted by salary in descending order</B>. If
an employee <B>doesn’t have</B> an <B>email</B> – in place of
that field you should print “<B>n/a</B>” instead, if he doesn’t
have an <B>age</B> – print “<B>-1</B>” instead. The <B>salary</B>
should be printed to <B>two decimal places</B> after the seperator.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=720 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=417>
	<COL WIDTH=285>
	<TR>
		<TD WIDTH=417 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><B>Input</B></P>
		</TD>
		<TD WIDTH=285 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=417 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho
			120.00 Dev Development pesho@abv.bg 28</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Toncho
			333.33 Manager Marketing 33</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			840.20 ProjectLeader Development ivan@ivan.com</FONT></P>
			<P><FONT FACE="Consolas, serif">Gosho 0.20 Freeloader Nowhere 18</FONT></P>
		</TD>
		<TD WIDTH=285 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><A NAME="OLE_LINK2"></A><A NAME="OLE_LINK1"></A>
			<FONT FACE="Consolas, serif">Highest Average Salary: Development</FONT></P>
			<P STYLE="margin-bottom: 0in"><A NAME="OLE_LINK6"></A><FONT FACE="Consolas, serif">Ivan
			840.20 ivan@ivan.com -1</FONT></P>
			<P><FONT FACE="Consolas, serif">Pesho 120.00 pesho@abv.bg 28</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=417 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">6</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Stanimir
			496.37 Temp Coding stancho@yahoo.com</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Yovcho
			610.13 Manager Sales</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Toshko
			609.99 Manager Sales toshko@abv.bg 44</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Venci
			0.02 Director BeerDrinking beer@beer.br 23</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Andrei
			700.00 Director Coding</FONT></P>
			<P><FONT FACE="Consolas, serif">Popeye 13.3333 Sailor SpinachGroup
			<A HREF="mailto:popeye@pop.ey">popeye@pop.ey</A></FONT></P>
		</TD>
		<TD WIDTH=285 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Highest
			Average Salary: Sales</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Yovcho
			610.13 n/a -1</FONT></P>
			<P><FONT FACE="Consolas, serif">Toshko 609.99 toshko@abv.bg 44</FONT></P>
		</TD>
	</TR>
</TABLE>