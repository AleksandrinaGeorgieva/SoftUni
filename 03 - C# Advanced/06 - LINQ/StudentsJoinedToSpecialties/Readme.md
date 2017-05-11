<OL START=11>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY>* Students Joined to
	Specialties</H2>
</OL>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">Create
a new class <B>StudentSpecialty</B> that holds <B>specialty name</B>
and <B>faculty number</B>. Create a <B>Student </B>class that holds
<B>student name </B>and <B> faculty number</B>. Create a list of
<B>student specialties,</B> where each specialty corresponds to a
certain student (via the faculty number). Print all student names
alphabetically along with their faculty number and specialty name.
Use the &quot;<B>join</B>&quot; LINQ operator. 
</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">You
will recieve several specialties in format :</P>
<P ALIGN=JUSTIFY STYLE="text-indent: 0.5in; margin-bottom: 0.14in; line-height: 115%">
 {specialty name} {specialty name} {faculty number}</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">Until
you reach &quot;Students:&quot; , you should add specialties to the
collection. After you reach &quot;Students:&quot;, you should start
reading students in format :</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">	{faculty
number} {student's first name} {student's second name}</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">You
should add the students untill you recieve &quot;END&quot; command.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=678 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=93>
	<COL WIDTH=50>
	<COL WIDTH=24>
	<COL WIDTH=50>
	<COL WIDTH=85>
	<COL WIDTH=19>
	<COL WIDTH=85>
	<COL WIDTH=50>
	<COL WIDTH=93>
	<TR>
		<TD COLSPAN=2 WIDTH=157 HEIGHT=9 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>Student Specialties</B></P>
		</TD>
		<TD ROWSPAN=8 WIDTH=24 STYLE="border-top: none; border-bottom: none; border-left: 1px solid #000001; border-right: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>join</B></P>
		</TD>
		<TD COLSPAN=2 WIDTH=149 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>Students</B></P>
		</TD>
		<TD ROWSPAN=8 WIDTH=19 STYLE="border-top: none; border-bottom: none; border-left: 1px solid #000001; border-right: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>→</P>
		</TD>
		<TD COLSPAN=3 WIDTH=256 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>Result (Joined Students with Specialties)</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=93 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>SpecialtyName</B></P>
		</TD>
		<TD WIDTH=50 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>FacNum</B></P>
		</TD>
		<TD WIDTH=50 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>FacNum</B></P>
		</TD>
		<TD WIDTH=85 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>Name</B></P>
		</TD>
		<TD WIDTH=85 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>Name</B></P>
		</TD>
		<TD WIDTH=50 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>FacNum</B></P>
		</TD>
		<TD WIDTH=93 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>Specialty</B></P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=93 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Web Developer</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203314</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>215314</P>
		</TD>
		<TD WIDTH=85 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Milena Kirova</P>
		</TD>
		<TD WIDTH=85 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Asya Manova</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203314</P>
		</TD>
		<TD WIDTH=93 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Web Developer</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=93 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Web Developer</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203114</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203114</P>
		</TD>
		<TD WIDTH=85 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Stefan Popov</P>
		</TD>
		<TD WIDTH=85 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Asya Manova</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203314</P>
		</TD>
		<TD WIDTH=93 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>QA Engineer</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=93 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>PHP Developer</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203814</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203314</P>
		</TD>
		<TD WIDTH=85 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Asya Manova</P>
		</TD>
		<TD WIDTH=85 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Diana Petrova</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203914</P>
		</TD>
		<TD WIDTH=93 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>PHP Developer</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=93 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>PHP Developer</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203914</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203914</P>
		</TD>
		<TD WIDTH=85 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Diana Petrova</P>
		</TD>
		<TD WIDTH=85 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Diana Petrova</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203914</P>
		</TD>
		<TD WIDTH=93 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Web Developer</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=93 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>QA Engineer</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203314</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203814</P>
		</TD>
		<TD WIDTH=85 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Ivan Ivanov</P>
		</TD>
		<TD WIDTH=85 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Ivan Ivanov</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203814</P>
		</TD>
		<TD WIDTH=93 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>PHP Developer</P>
		</TD>
	</TR>
	<TR>
		<TD WIDTH=93 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Web Developer</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203914</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><BR>
			</P>
		</TD>
		<TD WIDTH=85 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><BR>
			</P>
		</TD>
		<TD WIDTH=85 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Stefan Popov</P>
		</TD>
		<TD WIDTH=50 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>203114</P>
		</TD>
		<TD WIDTH=93 STYLE="border: 1px solid #000001; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY>Web Developer</P>
		</TD>
	</TR>
</TABLE>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><BR>
</P>

<TABLE WIDTH=526 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=241>
	<COL WIDTH=255>
	<TR VALIGN=TOP>
		<TD WIDTH=241 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>Input</B></P>
		</TD>
		<TD WIDTH=255 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=241 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Web Developer 203314</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Web Developer 203114</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">PHP Developer 203814</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">PHP Developer 203914</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">QA Engineer 203314</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Web Developer 203914</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Students:</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">215314 Milena Kirova</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">203114	 Stefan Popov</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">203314 Asya Manova</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">203914 Diana Petrova</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">203814 Ivan Ivanov</P>
			<P ALIGN=JUSTIFY>END</P>
		</TD>
		<TD WIDTH=255 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Asya Manova 203314 Web
			Developer</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Asya Manova 203314 QA
			Engineer</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Diana Petrova 203914
			PHP Developer</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Diana Petrova 203914
			Web Developer</P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in">Ivan Ivanov 203814 PHP
			Developer</P>
			<P ALIGN=JUSTIFY>Stefan Popov 203114 Web Developer</P>
		</TD>
	</TR>
</TABLE>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><BR>
</P>