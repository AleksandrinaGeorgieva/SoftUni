<OL START=6>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY>*Inferno III</H2>
</OL>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in">Your
game studio’s next triple A big-budget-killer app is the Hack and
Slash Action RPG Inferno III. The main purpose of the game is well,
to hack and slash things. But the secondary purpose is to craft items
and recently the main fan base has started complaining that once you
craft an item you can’t change it. So your next job is to implement
a feature for one time reforging an item.</P>
<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0.14in">On the
first line you are given the gems already inserted in the form of
numbers, representing their power. On the next lines, until you
receive the &quot;Forge&quot; command, you can receive commands in
the following format <B>{command;filter type;filter parameter}</B>:</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in">Commands can be:
&quot;Exclude&quot;, &quot;Reverse&quot; or &quot;Forge&quot;. The
possible filter types are: &quot;Sum Left&quot;, &quot;Sum Right&quot;
and &quot;Sum Left Right&quot;. All filter parameters will be an
integer. 
</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in">&quot;Exclude&quot;
marks a gem for exclusion from the set if it meets a given condition.
&quot;Reverse&quot; deletes a previous exclusion.</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in">&quot;Sum Left&quot;
tests if a gems power summed with the gem standing to its right gives
a certain value. &quot;Sum Right&quot; is the same but looks to a
gems right peer. &quot;Sum Left Right&quot; sums the gems power with
both its left and right neighbors. If a gem has no neighbor to its
right or to its left (first or last element), then simply add 0 to
the gem.</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in">Note that changes on
to the item are made only after forging. This means that the gems are
fixed at their positions and every function occurs on the original
set, so every gems power is considered, no matter if it is marked or
not. 
</P>
<P CLASS="western" STYLE="margin-bottom: 0.14in">To better understand
the problem, see the examples below:</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=624 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=201>
	<COL WIDTH=196>
	<COL WIDTH=201>
	<TR VALIGN=TOP>
		<TD WIDTH=201 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=196 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=201 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P CLASS="western" ALIGN=CENTER><B>Comments</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=201 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1
			2 3 4 5</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Exclude;Sum
			Left;1</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Exclude;Sum
			Left Right;9</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif">Forge</FONT></P>
		</TD>
		<TD WIDTH=196 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif">2 4</FONT></P>
		</TD>
		<TD WIDTH=201 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1.
			Marks for exclusion all gems for which the sum with neighbors to
			their left equals 1, e.g. 0 + </FONT><FONT FACE="Consolas, serif"><B>1</B></FONT><FONT FACE="Consolas, serif">
			= 1</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><BR>
			</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2.
			Marks for exclusion all gems for which the sum with neighbors to
			their left and their right equals 9, e.g. </FONT>
			</P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2
			+ </FONT><FONT FACE="Consolas, serif"><B>3</B></FONT><FONT FACE="Consolas, serif">
			+ 4 = 9</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif">4 +
			</FONT><FONT FACE="Consolas, serif"><B>5</B></FONT><FONT FACE="Consolas, serif">
			+ 0 = 9</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=201 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1
			2 3 4 5</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Exclude;Sum
			Left;1</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Reverse;Sum
			Left;1</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif">Forge</FONT></P>
		</TD>
		<TD WIDTH=196 BGCOLOR="#ffffff" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif">1 2
			3 4 5</FONT></P>
		</TD>
		<TD WIDTH=201 STYLE="border: 1px solid #00000a; padding: 0.04in 0.06in">
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">1.
			Marks for exclusion all gems for which the sum with their gem
			peers to the left equals 1, e.g. 0 + 1 = 1</FONT></P>
			<P CLASS="western" ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><BR>
			</P>
			<P CLASS="western" ALIGN=JUSTIFY><FONT FACE="Consolas, serif">2.
			Reverses the previous exclusion.</FONT></P>
		</TD>
	</TR>
</TABLE>