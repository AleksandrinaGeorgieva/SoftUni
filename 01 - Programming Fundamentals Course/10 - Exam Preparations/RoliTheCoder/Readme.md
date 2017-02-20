<H1 CLASS="western" ALIGN=CENTER>Roli - The Coder</H1>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Roli is really busy with
the recently started JS Core and DB Fundamentals modules at SoftUni.
She is used to going out with friends on a various events. However,
when the times comes, you need to tell her to start coding.</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Roli is the organizer of
those events, so she needs to <B>keep track of the unique
participants for each event</B>. She saves the events by '<B>ID</B>',
which is the <B>unique code</B> for each event. <B>For each ID</B>,
she <B>keeps the event name and the participants</B> for it.</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">She receives request in
the following format:</P>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">{<FONT FACE="Consolas, serif"><B>id</B></FONT>}
	#{<FONT FACE="Consolas, serif"><B>eventName</B></FONT>}
	@{<FONT FACE="Consolas, serif"><B>participant1</B></FONT>}
	@{<FONT FACE="Consolas, serif"><B>participant2</B></FONT>} …
	@{<FONT FACE="Consolas, serif"><B>participantN</B></FONT>}</P>
</UL>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">If she is given <SPAN LANG="en-GB">event
in an </SPAN><B>invalid format </B>(such as without a hashtag), she
<B>ignores that line of input</B>. If she is given ID that <B>already
exists </B>she needs to check if the <B>eventName</B> is the same. If
it is, she <B>adds</B> the <B>participants</B> from the <B>request</B>
to the <SPAN LANG="en-GB">other </SPAN>registered participants. If
the event id exists but the name doesn’t, it is invalid and you
need to ignore it.</P>
<P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">After you receive <SPAN LANG="bg-BG">&quot;</SPAN><B>Time
for Code</B><SPAN LANG="bg-BG">&quot;</SPAN>, you need to <B>print</B>
the results. All events must <B>be sorted by participant count in
descending order and then by alphabetical order</B>. For each event,
the <B>participants</B> must be sorted in <B>alphabetical order</B>.</P>
<H2 CLASS="western" ALIGN=JUSTIFY>Input / Constrains</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Unil you receive
	“Time for Code” you will get lines of input in which everything
	is separated by one or more blank spaces</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Until you receive
	&quot;<FONT FACE="Consolas, serif"><B>Time for Code</B></FONT>&quot;,
	you will be receiving events in the following format:</P>
	<UL>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><A NAME="_GoBack"></A>
		{id} #{eventName} @{participant1} @{participant2} …
		@{participantN}</P>
	</UL>
</UL>
<H2 CLASS="western" ALIGN=JUSTIFY>Output</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">All events must be
	sorted<SPAN LANG="bg-BG"> </SPAN>in <B>descending</B> order by
	participant count and <B>then by alphabetical order</B>. For each
	event you need to print:</P>
	<UL>
		<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif">{eventName}</FONT>
		– <FONT FACE="Consolas, serif">{participantCount}</FONT></P>
	</UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the next lines
	you need to print all participants. All participants for an event
	must be sorted alphabetically.</P>
</UL>
<H2 CLASS="western">Examples</H2>
<TABLE WIDTH=684 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=391>
	<COL WIDTH=275>
	<TR VALIGN=TOP>
		<TD WIDTH=391 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=275 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=391 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1
			#Beers @roli @trophon @alice</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2
			#GameDevMeetup @sino @valyo</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3
			#Karaoke @nakov @royal @ROYAL @ivo</FONT></P>
			<P><FONT FACE="Consolas, serif">Time for Code</FONT></P>
		</TD>
		<TD WIDTH=275 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Karaoke
			- 4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@ivo</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@nakov</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@royal</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@ROYAL</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Beers -
			3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@alice</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@roli</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@trophon</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">GameDevMeetup
			- 2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@sino</FONT></P>
			<P><FONT FACE="Consolas, serif">@valyo</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=391 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=275 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=391 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1
			#Beers @roli @trophon @alice</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2
			#GameDevMeetup @sino @valyo</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1
			#Beers2 @nakov @royal @ROYAL @ivo</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1
			#Beers @roli @trophon @alice @sino</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3
			#Rakia</FONT></P>
			<P><FONT FACE="Consolas, serif">Time for Code</FONT></P>
		</TD>
		<TD WIDTH=275 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Beers -
			4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@alice</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@roli</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@sino</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@trophon</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">GameDevMeetup
			- 2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@sino</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">@valyo</FONT></P>
			<P><FONT FACE="Consolas, serif">Rakia - 0</FONT></P>
		</TD>
	</TR>
</TABLE>
