<OL START=8>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY>Pokemon Trainer</H2>
</OL>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 0.24in">You
wanna be the very best pokemon trainer, like no one ever was, so you
set out to catch pokemon. Define a class <B>Trainer</B> and a class
<B>Pokemon</B>. Trainers have a <B>name</B>, <B>number of badges</B>
and a <B>collection of pokemon</B>, <B>Pokemon</B> have a <B>name</B>,
an <B>element</B> and <B>health</B>, all values are <B>mandatory</B>.
Every Trainer <B>starts with 0 badges</B>.</P>
<P ALIGN=JUSTIFY STYLE="margin-bottom: 0.08in; line-height: 0.24in">From
the console you will receive an unknown number of lines until you
receive the command “<B>Tournament</B>”, each line will carry
information about a pokemon and the trainer who caught it in the
format “&lt;<B>TrainerName&gt; &lt;PokemonName&gt; &lt;PokemonElement&gt;
&lt;PokemonHealth&gt;” </B>where <B>TrainerName</B> is the name of
the Trainer who caught the pokemon, names are <B>unique </B>there
cannot be 2 trainers with the same name. After receiving the command
“<B>Tournament</B>” an unknown number of lines containing one of
three elements “<B>Fire</B>”, “<B>Water</B>”, “<B>Electricity</B>”
will follow until the command “<B>End</B>” is received. For every
command you must check if a trainer has atleast 1 pokemon with the
given element, if he does he receives 1 badge, otherwise all his
pokemon <B>lose 10 health</B>, if a pokemon falls <B>to 0 or less
health he dies</B> and must be deleted from the trainer’s
collection. After the command “<B>End</B>” is received you should
print all trainers <B>sorted by the amount of badges they have in
descending order</B> (if two trainers have the same amount of badges
they should be sorted by order of appearance in the input)<B> </B>in
the format “&lt;<B>TrainerName&gt; &lt;Badges&gt;
&lt;NumberOfPokemon&gt;</B>”.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=688 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=343>
	<COL WIDTH=326>
	<TR VALIGN=TOP>
		<TD WIDTH=343 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=326 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER STYLE="margin-left: -0.06in"><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=343 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho
			Charizard Fire 100</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Gosho
			Squirtle Water 38</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho
			Pikachu Electricity 10</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Tournament</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Fire</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Electricity</FONT></P>
			<P><FONT FACE="Consolas, serif">End</FONT></P>
		</TD>
		<TD WIDTH=326 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Pesho 2
			2</FONT></P>
			<P><FONT FACE="Consolas, serif">Gosho 0 1</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=343 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Stamat
			Blastoise Water 18</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Nasko
			Pikachu Electricity 22</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Jicata
			Kadabra Psychic 90</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Tournament</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Fire</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Electricity</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Fire</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">End</FONT></P>
		</TD>
		<TD WIDTH=326 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Nasko
			1 1</FONT></P>
			<P ALIGN=JUSTIFY STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Stamat
			0 0</FONT></P>
			<P ALIGN=JUSTIFY><FONT FACE="Consolas, serif">Jicata 0 1</FONT></P>
		</TD>
	</TR>
</TABLE>