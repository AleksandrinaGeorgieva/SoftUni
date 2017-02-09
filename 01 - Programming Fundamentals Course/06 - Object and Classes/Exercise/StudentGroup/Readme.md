<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">** Student
	Groups</SPAN></H2>

<P STYLE="margin-top: 0.06in">At the Software University we often
organize programming courses for beginners in different towns. We
usually run a <B>registration form</B> and after the registration
finishes, we distribute the <B>students</B> into <B>study groups</B>.
Groups have different sizes in each town.</P>
<P STYLE="margin-top: 0.06in">You are given a report holding the
<B>registrations for each town</B> and the <B>lab capacity</B> (seats
count) for each town. It comes in the following format:</P>
<UL>
	<LI><P STYLE="margin-top: 0.06in"><B>Town name</B> =&gt; <B>X</B>
	seats (where <B>X</B> is the capacity of the training lab in this
	town).</P>
	<UL>
		<LI><P STYLE="margin-top: 0.06in"><B>Student name</B> | <B>student
		email</B> | <B>registration</B> <B>date</B> (in format
		day-month-year). The month name is given as 3 letters in English,
		e.g. “May”, “Aug” or “Nov”.</P>
		<LI><P STYLE="margin-top: 0.06in">The next student come after the
		first, etc.</P>
	</UL>
	<LI><P STYLE="margin-top: 0.06in">Then the next town and its
	students come, etc.</P>
	<LI><P STYLE="margin-top: 0.06in">The input ends by a line holding
	“<B>End</B>”.</P>
</UL>
<P STYLE="margin-top: 0.06in">The <B>input</B> comes in the following
structure:</P>
<TABLE WIDTH=612 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=602>
	<TR>
		<TD WIDTH=602 HEIGHT=26 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Town1
			=&gt; X seats</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Student1
			Name | student1_email@somewhere.com | day-month-year</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Student2
			Name | student2_email@somewhere.com | day-month-year</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Student3
			Name | student3_email@somewhere.com | day-month-year</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in">…</P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Town2
			=&gt; X seats</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Student1
			Name | student1_email@somewhere.com | day-month-year</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Student2
			Name | student2_email@somewhere.com | day-month-year</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in">…</P>
			<P STYLE="margin-top: 0.04in"><FONT FACE="Consolas, serif">End</FONT></P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-top: 0.08in">Your task is to <B>create </B>and<B>
print the study groups</B> for each town as follows:</P>
<UL>
	<LI><P STYLE="margin-top: 0.06in">For <B>each town</B> create and
	print one or several <B>study groups</B> (depends of the number or
	registered students and the capacity of the lab in this town).</P>
	<LI><P STYLE="margin-top: 0.06in">For each town <B>order the
	students</B> by registration date (ascending), then by name
	(ascending) then by email (ascending), then fill them into groups.
	If the students are less or equal to the lab capacity, create only
	one group. When the students are more than the lab capacity,
	distribute them in multiple groups.</P>
	<LI><P STYLE="margin-top: 0.06in">Print all <B>groups ordered by
	town</B> (ascending) in the following format:</P>
	<UL>
		<LI><P STYLE="margin-top: 0.06in"><B>Created G groups and T towns:</B></P>
		<LI><P STYLE="margin-top: 0.06in"><B>Town1 =&gt; email1, email2, …</B></P>
		<LI><P STYLE="margin-top: 0.06in"><B>Town1 =&gt; email1, email2, …</B></P>
		<LI><P STYLE="margin-top: 0.06in">…</P>
		<LI><P STYLE="margin-top: 0.06in"><B>Town2 =&gt; email1, email2, …</B></P>
		<LI><P STYLE="margin-top: 0.06in">…</P>
	</UL>
</UL>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=692 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=682>
	<TR>
		<TD WIDTH=682 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=682 HEIGHT=28 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>Plovdiv</B></FONT><FONT FACE="Consolas, serif">
			=&gt; </FONT><FONT FACE="Consolas, serif"><B>5</B></FONT><FONT FACE="Consolas, serif">
			seats</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ani
			Kirilova   |ani88@abv.bg             |27-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Todor
			Nikolov  | tod92@mente.org         | 28-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Kiril
			Stoyanov |  kirtak@gmail.com       | 27-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Stefka
			Petrova |   st96@abv.bg           | 26-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ani
			Kirilova   |     ani.k@yahoo.co.uk   | 27-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			Ivanov    |  ivan.i.ivanov@gmail.com| 27-May-2016</FONT></P>
			<P STYLE="margin-top: 0.06in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>Veliko
			Tarnovo</B></FONT><FONT FACE="Consolas, serif"> =&gt; </FONT><FONT FACE="Consolas, serif"><B>3</B></FONT><FONT FACE="Consolas, serif">
			seats</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Petya
			Stoyanova | stoyanova_p@abv.bg    | 27-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Stoyan
			Kirilov  | 100yan@gmail.com      | 24-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Didi
			Miteva     | miteva_d@yahoo.co.uk  | 28-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Kiril
			Nikolov   | kiro@kiro.net         | 25-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			Stefanov   | ivan.stef86@gmail.com | 27-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Maria
			Kirova    | maria.k@abv.bg        | 26-May-2016</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>Varna</B></FONT><FONT FACE="Consolas, serif">
			=&gt; </FONT><FONT FACE="Consolas, serif"><B>2</B></FONT><FONT FACE="Consolas, serif">
			seats</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			Ivanov      | ivan.ivanov96@gmail.com| 29-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Stoyan
			Petrov    | sto.sto.sto@gmail.com  | 27-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			Ivanov      | vankata@mail.bg        | 1-Jun-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Kiril
			Anev       | anev_k@yahoo.co.uk     | 27-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			Ivanov      | vanyo98@abv.bg         | 29-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Petya
			Vladimirova|pete98@abv.bg           | 20-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			Ivanov      | ivan.94.ivan@gmail.com | 29-May-2016</FONT></P>
			<P STYLE="margin-top: 0.04in"><FONT FACE="Consolas, serif"><B>End</B></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=682 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=682 HEIGHT=28 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Created
			</FONT><FONT FACE="Consolas, serif"><B>8</B></FONT><FONT FACE="Consolas, serif">
			groups in </FONT><FONT FACE="Consolas, serif"><B>3</B></FONT><FONT FACE="Consolas, serif">
			towns:</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Plovdiv
			=&gt; st96@abv.bg, ani.k@yahoo.co.uk, ani88@abv.bg,
			ivan.i.ivanov@gmail.com, kirtak@gmail.com</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Plovdiv
			=&gt; tod92@mente.org</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Varna
			=&gt; pete98@abv.bg, anev_k@yahoo.co.uk</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Varna
			=&gt; sto.sto.sto@gmail.com, ivan.94.ivan@gmail.com</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Varna
			=&gt; ivan.ivanov96@gmail.com, vanyo98@abv.bg</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Varna
			=&gt; vankata@mail.bg</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">Veliko
			Tarnovo =&gt; 100yan@gmail.com, kiro@kiro.net, maria.k@abv.bg</FONT></P>
			<P STYLE="margin-top: 0.04in"><FONT FACE="Consolas, serif">Veliko
			Tarnovo =&gt; ivan.stef86@gmail.com, stoyanova_p@abv.bg,
			miteva_d@yahoo.co.uk</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=682 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=682 HEIGHT=27 VALIGN=TOP STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>Plovdiv
			(group 1 – 5/5 students)</B></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Stefka
			Petrova | st96@abv.bg | 26-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ani
			Kirilova | ani.k@yahoo.co.uk | 27-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ani
			Kirilova | ani88@abv.bg | 27-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			Ivanov | ivan.i.ivanov@gmail.com | 27-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Kiril
			Stoyanov | kirtak@gmail.com | 27-May-2016</FONT></P>
			<P STYLE="margin-top: 0.08in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>Plovdiv
			(group 2 – 1/5 students)</B></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Todor
			Nikolov | tod92@mente.org | 28-May-2016</FONT></P>
			<P STYLE="margin-top: 0.08in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>Varna
			(group 1 – 2/2 students)</B></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Petya
			Vladimirova | pete98@abv.bg | 20-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Kiril
			Anev | anev_k@yahoo.co.uk | 27-May-2016</FONT></P>
			<P STYLE="margin-top: 0.08in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>Varna
			(group 2 – 2/2 students)</B></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Stoyan
			Petrov | sto.sto.sto@gmail.com | 27-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			Ivanov | ivan.94.ivan@gmail.com | 29-May-2016</FONT></P>
			<P STYLE="margin-top: 0.08in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>Varna
			(group 3 – 2/2 students)</B></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			Ivanov | ivan.ivanov96@gmail.com | 29-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			Ivanov | vanyo98@abv.bg | 29-May-2016</FONT></P>
			<P STYLE="margin-top: 0.08in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>Varna
			(group 4 – 1/2 students)</B></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			Ivanov | vankata@mail.bg | 1-Jun-2016</FONT></P>
			<P STYLE="margin-top: 0.08in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>Veliko
			Tarnovo (group 1 – 3/3 students)</B></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Stoyan
			Kirilov | 100yan@gmail.com | 24-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Kiril
			Nikolov | kiro@kiro.net | 25-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Maria
			Kirova | maria.k@abv.bg | 26-May-2016</FONT></P>
			<P STYLE="margin-top: 0.08in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><B>Veliko
			Tarnovo (group 2 – 3/3 students)</B></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ivan
			Stefanov | ivan.stef86@gmail.com | 27-May-2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Petya
			Stoyanova | stoyanova_p@abv.bg | 27-May-2016</FONT></P>
			<P><FONT FACE="Consolas, serif">Didi Miteva | miteva_d@yahoo.co.uk
			| 28-May-2016</FONT></P>
		</TD>
	</TR>
</TABLE>