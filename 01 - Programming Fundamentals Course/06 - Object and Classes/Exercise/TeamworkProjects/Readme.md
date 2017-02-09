<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Teamwork
	projects</SPAN></H2>

<P STYLE="margin-top: 0.06in">It's time for teamwork projects and you
are responsible for making the teams. First you will receive an
integer - the <B>count</B> of the teams you will have to <B>register</B>.
You will be given a <B>user</B> and a <B>team</B> (separated with
<I>&quot;-&quot;</I>).  The user is the <B>creator</B> of that team.
For every newly created team you should <B>print</B> a message: &quot;<I>Team
{team Name} has been created by {user}!</I>&quot;. Next you will
receive user with team (separated with &quot;<I>-&gt;</I>&quot;)
which means that the user wants to <B>join</B> that <B>team</B>. Upon
receiving command: &quot;<I>end of assignment</I>&quot; you should
print every team <B>ordered</B> by members count (<I>descending</I>)
and then by <B>name</B> (<I>ascending</I>). For each team you have to
print it's members <B>sorted</B> by name (<I>ascending</I>). However
there are several <B>rules</B>:</P>
<UL>
	<LI><P STYLE="margin-top: 0.06in">If user tries to <B>create</B> a
	team more than once a message should be displayed: 
	</P>
	<UL>
		<LI><P STYLE="margin-top: 0.06in">&quot;<FONT SIZE=3><I>Team
		{teamName} was already created!</I></FONT><I>&quot;</I></P>
	</UL>
	<LI><P STYLE="margin-top: 0.06in">Creator of a team cannot <B>create</B>
	another team - message should be thrown: 
	</P>
	<UL>
		<LI><P STYLE="margin-top: 0.06in"><FONT SIZE=3>&quot;</FONT><FONT SIZE=3><I>{user}
		cannot create another team!</I></FONT>&quot;</P>
	</UL>
	<LI><P STYLE="margin-top: 0.06in">If user tries to <B>join</B>
	currently non-existing team a message should be displayed: 
	</P>
	<UL>
		<LI><P STYLE="margin-top: 0.06in">&quot;<FONT SIZE=3><I>Team
		{teamName} does not exist!</I></FONT><I>&quot;</I></P>
	</UL>
	<LI><P STYLE="margin-top: 0.06in">Member of a team cannot <B>join</B>
	another team - message should be thrown:</P>
	<UL>
		<LI><P STYLE="margin-top: 0.06in">&quot;<FONT SIZE=3><I>Member
		{user} cannot join team {team Name}!</I></FONT>&quot;</P>
	</UL>
	<LI><P STYLE="margin-top: 0.06in">In the <B>end </B>(<I>after teams'
	report</I>) teams with <B>zero</B> members (with <B>only a creator</B>)
	should <B>disband</B>.  Every team to disband should be printed
	ordered by <B>name</B> (ascending) in this format:</P>
	<UL>
		<LI><P STYLE="margin-top: 0.06in">&quot;<FONT SIZE=3><I>{teamName}:</I></FONT></P>
	</UL>
</UL>
<P STYLE="margin-left: 1in; margin-top: 0.06in"><FONT SIZE=3><I>-
{creator}</I></FONT></P>
<P STYLE="margin-left: 0.5in; text-indent: 0.5in; margin-top: 0.06in">
<FONT SIZE=3><I>-- {member}…</I></FONT>&quot;</P>
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
		<TD WIDTH=271 HEIGHT=28 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">Didi-PowerPuffsCoders</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">Toni-Toni
			is the best</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ffff">Petq-&gt;PowerPuffsCoders</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ff0000">Toni-&gt;Toni
			is the best</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">end of
			assignment</FONT></P>
			<P STYLE="margin-top: 0.04in"><BR>
			</P>
		</TD>
		<TD WIDTH=222 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">Team
			PowerPuffsCoders has been created by Didi!</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">Team
			Toni is the best has been created by Toni!</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT SIZE=3><SPAN STYLE="background: #ff0000">Member
			Toni cannot join team Toni is the best!</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT SIZE=3>PowerPuffsCoders</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT SIZE=3><SPAN STYLE="background: #ffff00">-
			Didi</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT SIZE=3><SPAN STYLE="background: #00ffff">--
			Petq</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT SIZE=3>Teams to disband:</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT SIZE=3><SPAN STYLE="background: #c0c0c0">Toni
			is the best</SPAN></FONT></P>
			<P><BR>
			</P>
		</TD>
		<TD WIDTH=175 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">Toni created a team in which he
			tried later to join. So message was shown. Since there is noone
			other who is trying to join his team the team have to </FONT><FONT FACE="Consolas, serif"><SPAN STYLE="background: #c0c0c0">disband</SPAN></FONT><FONT FACE="Consolas, serif">.</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=271 HEIGHT=27 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Tatyana-CloneClub</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">Helena-CloneClub</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Trifon-AiNaBira</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">Pesho-&gt;aiNaBira</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho-&gt;AiNaBira</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #808080">Tatyana-&gt;Leda</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">PeshO-&gt;AiNaBira</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Cossima-&gt;CloneClub</FONT></P>
			<P><FONT FACE="Consolas, serif">end of assignment</FONT></P>
		</TD>
		<TD WIDTH=222 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Team
			CloneClub has been created by Tatyana!</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #ffff00">Team
			CloneClub was already created!</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Team
			AiNaBira has been created by Trifon!</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #00ff00">Team
			aiNaBira does not exist!</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN STYLE="background: #808080">Team
			Leda does not exist!</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">AiNaBira</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-
			Trifon</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">--
			Pesho</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">--
			PeshO</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">CloneClub</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">-
			Tatyana</FONT></P>
			<P><FONT FACE="Consolas, serif">-- Cossima</FONT></P>
		</TD>
		<TD WIDTH=175 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Note
			that when you join a team you should check </FONT><FONT FACE="Consolas, serif"><B>first</B></FONT><FONT FACE="Consolas, serif">
			if it exists, </FONT><FONT FACE="Consolas, serif"><B>then</B></FONT><FONT FACE="Consolas, serif">
			check if the user is already in a team:</FONT></P>
			<P STYLE="margin-bottom: 0in"><BR>
			</P>
			<P><FONT FACE="Consolas, serif">Tatyana has created CloneClub,
			then she tries to join a non-existing team – so message for
			non-existing team is shown.</FONT></P>
		</TD>
	</TR>
</TABLE>