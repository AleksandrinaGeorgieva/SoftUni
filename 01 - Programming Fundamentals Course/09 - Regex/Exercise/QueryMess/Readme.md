<H2 CLASS="western" ALIGN=JUSTIFY>*Query Mess</H2>

<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%"><B>This
problem is originally from the JavaScript Basics Exam (22 November
2014). You may check your solution </B><FONT COLOR="#0000ff"><SPAN LANG="zxx"><U><A HREF="https://judge.softuni.bg/Contests/Practice/Index/84#3"><B>here</B></A></U></SPAN></FONT><B>.</B></P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%"><B>Ivancho</B>
participates in a team <B>project</B> with colleagues at <B>SoftUni</B>.
 They have to develop <B>an application</B>, but something <I>mysterious</I>
happened – at the last moment all team members… disappeared!  And
guess what? He is left <B>alone</B> to finish the project.  All that
is left to do is to parse the input data and store it in a special
way, but Ivancho has no idea how to do that! Can you help him?</P>
<H3 CLASS="western">Input</H3>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">The input comes
from the console on a variable number of lines and ends when the
keyword &quot;END&quot; is received.  
</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">For each row of
the input, the query string contains pairs field=value. Within each
pair, the field name and value are separated by an equals sign, '='.
The series of pairs are separated by an ampersand, '&amp;'. The
question mark is used as a separator and is not part of the query
string. A URL query string may contain another URL as value. The
input data will always be valid and in the format described. There is
no need to check it explicitly.</P>
<H3 CLASS="western">Output</H3>
<P STYLE="margin-bottom: 0.14in; line-height: 115%"><B>For each input
line, print</B> on the console a line containing the <B>processed
string as follows</B>:  key=[value]nextkey=[another  value] … etc. 
</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%"><B>Multiple
whitespace</B> characters should be reduced to one inside value/key
names, but there shouldn’t be any whitespaces before/after
extracted <B>keys</B> and <B>values</B>. If a key <B>already exists</B>,
the value is added with comma and space after other values of the
existing key in the current string.  See the <B>examples</B> below.  
</P>
<H3 CLASS="western" ALIGN=JUSTIFY>Constraints</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 115%"><FONT COLOR="#252525"><SPAN STYLE="background: #ffffff">SPACE
	is encoded as '+' or &quot;%20&quot;.</SPAN></FONT><FONT FACE="Courier New, serif"><FONT SIZE=2>
	</FONT></FONT><FONT COLOR="#252525">Letters (A-Z&nbsp;and a-z),
	numbers (0-9), the characters '*', '-', '.', '_' and </FONT><FONT COLOR="#252525"><I>other
	non-special symbols</I></FONT><FONT COLOR="#252525"> are left as-is.</FONT></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 115%">Allowed
	working time: 0.1 seconds. Allowed memory: 16 MB.</P>
</UL>
<H3 CLASS="western" ALIGN=JUSTIFY>Examples</H3>
<TABLE WIDTH=699 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=331>
	<COL WIDTH=350>
	<TR VALIGN=TOP>
		<TD WIDTH=331 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=350 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=331 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif">login=student&amp;password=student</FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif">END</FONT></FONT></P>
		</TD>
		<TD WIDTH=350 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif">login=[student]password=[student]</FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=689 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=689 VALIGN=TOP BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif">field=value1&amp;field=value2&amp;field=value3</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#0000ff"><SPAN LANG="zxx"><U><A HREF="http://example.com/over/there?name=ferret"><FONT FACE="Consolas, serif">http://example.com/over/there?name=ferret</FONT></A></U></SPAN></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000">END</FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=689 HEIGHT=1 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=689 VALIGN=TOP BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif">field=[value1,
			value2, value3]</FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif">name=[ferret]</FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=689 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=689 VALIGN=TOP BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif">foo=%20foo&amp;value=+val&amp;foo+=5+%20+203</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif">foo=poo%20&amp;value=valley&amp;dog=wow+</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif">url=https://softuni.bg/trainings/coursesinstances/details/1070</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#0000ff"><SPAN LANG="zxx"><U><A HREF="https://softuni.bg/trainings.asp?trainer=nakov&amp;course=oop&amp;course=php"><FONT FACE="Consolas, serif">https://softuni.bg/trainings.asp?trainer=nakov&amp;course=oop&amp;course=php</FONT></A></U></SPAN></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif">END</FONT></FONT></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=689 HEIGHT=1 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 WIDTH=689 VALIGN=TOP BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif">foo=[foo,
			5 203]value=[val]</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif">foo=[poo]value=[valley]dog=[wow]</FONT></FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT COLOR="#000000"><FONT FACE="Consolas, serif">url=[https://softuni.bg/trainings/coursesinstances/details/1070]</FONT></FONT></P>
			<P ALIGN=JUSTIFY><FONT COLOR="#000000"><FONT FACE="Consolas, serif">trainer=[nakov]course=[oop,
			php]</FONT></FONT></P>
		</TD>
	</TR>
</TABLE>