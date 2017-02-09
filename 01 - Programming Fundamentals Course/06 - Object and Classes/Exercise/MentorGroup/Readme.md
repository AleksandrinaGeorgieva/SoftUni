<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Mentor group</SPAN></H2>

<P STYLE="margin-top: 0.06in">You are mentor of a group. You have
done your job well and now you have to generate a report about your
group's activity. You will be given usernames and dates
(&quot;<I><B>dd/MM/yyyy</B></I>&quot;), dates (<B>if any</B>) are
separated with comma, until you receive command &quot;<B>end of
dates</B>&quot;. After that you will receive user and some comment
(separated with dash). You can add comment for every user who is <B>in</B>
your group<B> </B>(if <B>not</B> ignore the line). Adding
comment/date to same user more than once should <B>append</B> to that
user the comment/date. Upon receiving command &quot;<B>end of
comments</B>&quot; you should generate report in format:</P>
<P STYLE="text-indent: 0.5in; margin-top: 0.06in"><FONT SIZE=3>{</FONT><FONT SIZE=3><I>user</I></FONT><FONT SIZE=3>}
-</FONT></P>
<P STYLE="text-indent: 0.5in; margin-top: 0.06in"><FONT SIZE=3><I>Comments:</I></FONT></P>
<P STYLE="text-indent: 0.5in; margin-top: 0.06in"><FONT SIZE=3><I>-
{firstComment} …</I></FONT></P>
<P STYLE="text-indent: 0.5in; margin-top: 0.06in"><FONT SIZE=3><I>Dates
attended:</I></FONT></P>
<P STYLE="text-indent: 0.5in; margin-top: 0.06in"><FONT SIZE=3>--
{</FONT><FONT SIZE=3><I>firstDate</I></FONT><FONT SIZE=3>}</FONT></P>
<P STYLE="text-indent: 0.5in; margin-top: 0.06in"><FONT SIZE=3>--
{</FONT><FONT SIZE=3><I>secondDate</I></FONT><FONT SIZE=3>}</FONT></P>
<P STYLE="margin-top: 0.06in"><FONT SIZE=3>Users should be printed
ordered by name (</FONT><FONT SIZE=3><I>ascending</I></FONT><FONT SIZE=3>).
For every user dates should be sorted again in ascending order. Input
will be valid for in the format described - you should </FONT><FONT SIZE=3><B>not
check</B></FONT><FONT SIZE=3> it explicitly!</FONT></P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=693 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=271>
	<COL WIDTH=222>
	<COL WIDTH=175>
	<TR>
		<TD WIDTH=271 HEIGHT=9 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=222 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=175 VALIGN=TOP BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=271 HEIGHT=27 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">nakov
			22/08/2016,20/08/2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">simeon10
			22/08/2016</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">end of
			dates</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">nakov-Excellent
			algorithmetic thinking.</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">Gesh4o-Total
			noob.</SPAN></FONT></P>
			<P STYLE="margin-top: 0.04in"><FONT FACE="Consolas, serif">end of
			comments</FONT></P>
		</TD>
		<TD WIDTH=222 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">nakov</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Comments:</FONT></P>
			<P STYLE="margin-top: 0.04in; margin-bottom: 0in"><FONT FACE="Consolas, serif">-
			</FONT><FONT FACE="Consolas, serif">Excellent algorithmetic
			thinking.</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Dates
			attended:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">--
			</FONT><FONT FACE="Consolas, serif">20/08/2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">--
			22/08/2016</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">simeon10</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">Comments:</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">Dates
			attended:</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">--
			22/08/2016</SPAN></FONT></P>
		</TD>
		<TD WIDTH=175 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">Not that </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">simeon10</SPAN></FONT><FONT FACE="Consolas, serif">
			has no comments but we still leave the comments section. User
			</FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">Gesh4o</SPAN></FONT><FONT FACE="Consolas, serif">
			does not have attendancy date so he is not registered in your
			group therefore he is not a part from the report.</FONT></P>
		</TD>
	</TR>
</TABLE>