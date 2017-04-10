<H2 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in; margin-bottom: 0in">
	*Valid Usernames</H2>

<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%"><B>This
problem is from the Java Basics Exam (21 September 2014 Evening). You
may check your solution </B><FONT COLOR="#0000ff"><SPAN LANG="zxx"><U><A HREF="https://judge.softuni.bg/Contests/Practice/Index/34#2"><B>here</B></A></U></SPAN></FONT><B>.</B></P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in; line-height: 115%">You
are part of the back-end development team of the next Facebook. You
are given <B>a line of usernames</B>, between one of the following
symbols<B>: space, “/”, “\”, “(“, “)”.</B> First you
have to export all <B>valid </B>usernames. A valid username <B>starts
with a letter</B> and can contain <B>only letters, digits and “_”</B>.
It cannot be <B>less than 3 or more than 25 symbols</B> long. Your
task is to <B>sum</B> the length of <B>every</B> <B>2 consecutive</B>
<B>valid </B>usernames and print on the console the 2 valid usernames
with <B>biggest</B> <B>sum</B> of their <B>lengths, </B>each on a
separate line. 
</P>
<H3 CLASS="western" ALIGN=JUSTIFY>Input</H3>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 115%">The
input comes from the console. One line will hold all the data. It
will hold <B>usernames, </B>divided by the symbols:<B> space, “/”,
“\”, “(“, “)”.</B> 
</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 115%">The
input data will always be valid and in the format described. There is
no need to check it explicitly.</P>
<H3 CLASS="western" ALIGN=JUSTIFY>Output</H3>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 115%">Print
at the console the 2 <B>consecutive</B> <B>valid usernames</B> with
the <B>biggest</B> <B>sum</B> of their lengths each on a separate
line. If there are <B>2 or more couples</B> of usernames with the
same sum of their lengths, print he <B>left most</B>.</P>
<H3 CLASS="western" ALIGN=JUSTIFY>Constraints</H3>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	input line will hold characters in the range [0 … 9999].</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	usernames should <B>start with a letter</B> and can contain <B>only
	letters, digits and “_”</B>.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">The
	username cannot be <B>less than 3 or</B> <B>more than 25 symbols</B>
	long.</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%">Time
	limit: 0.5 sec. Memory limit: 16 MB.</P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><BR>
</P>
<H3 CLASS="western" ALIGN=JUSTIFY>Examples</H3>
<TABLE WIDTH=594 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=396>
	<COL WIDTH=180>
	<TR VALIGN=TOP>
		<TD WIDTH=396 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=180 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=396 HEIGHT=13 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><A NAME="OLE_LINK4"></A><A NAME="OLE_LINK5"></A><A NAME="OLE_LINK11"></A>
			<FONT FACE="Consolas, serif">ds3bhj y1ter/wfsdg 1nh_jgf
			ds2c_vbg\4htref</FONT></P>
		</TD>
		<TD WIDTH=180 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">wfsdg</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">ds2c_vbg</FONT></P>
		</TD>
	</TR>
</TABLE>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><BR>
</P>
<TABLE WIDTH=594 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=397>
	<COL WIDTH=179>
	<TR VALIGN=TOP>
		<TD WIDTH=397 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=179 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=397 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><A NAME="OLE_LINK6"></A><A NAME="OLE_LINK7"></A><A NAME="OLE_LINK10"></A><A NAME="OLE_LINK12"></A>
			<FONT FACE="Consolas, serif">min23/ace hahah21 (    sasa  ) 
			att3454/a/a2/abc</FONT></P>
		</TD>
		<TD WIDTH=179 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">hahah21</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">sasa</FONT></P>
		</TD>
	</TR>
</TABLE>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in; line-height: 100%"><BR>
</P>
<TABLE WIDTH=594 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=397>
	<COL WIDTH=179>
	<TR VALIGN=TOP>
		<TD WIDTH=397 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=179 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=397 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.05in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY><A NAME="OLE_LINK8"></A><A NAME="OLE_LINK9"></A><A NAME="OLE_LINK13"></A>
			<FONT FACE="Consolas, serif">chico/ gosho \ sapunerka (3sas) mazut
			 lelQ_Van4e</FONT></P>
		</TD>
		<TD WIDTH=179 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">mazut</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">lelQ_Van4e</FONT></P>
		</TD>
	</TR>
</TABLE>