<OL START=6>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY>*Raw Data</H2>
</OL>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">You are the owner
of a courier company and want to make a system for tracking your cars
and their cargo. Define a class <B>Car</B> that holds information
about <B>model, engine, cargo</B> and a <B>collection of exactly 4
tires</B>. The engine, cargo and tire <B>should be separate classes</B>,
create a constructor that receives all information about the Car and
creates and initializes its inner components (engine, cargo and
tires).</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">On the first line
of input you will receive a number <B>N</B> - the amount of cars you
have, on each of the next <B>N</B> lines you will receive information
about a car in the format “<B>&lt;Model&gt; &lt;EngineSpeed&gt;
&lt;EnginePower&gt; &lt;CargoWeight&gt; &lt;CargoType&gt;
&lt;Tire1Pressure&gt; &lt;Tire1Age&gt; &lt;Tire2Pressure&gt;
&lt;Tire2Age&gt; &lt;Tire3Pressure&gt; &lt;Tire3Age&gt;
&lt;Tire4Pressure&gt; &lt;Tire4Age&gt;”</B> where the speed, power,
weight and tire age are<B> integers</B>, tire pressure is a <B>double.
</B>
</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">After the <B>N</B>
lines you will receive a single line with one of 2 commands “<B>fragile</B>”
or “<B>flamable</B>” , if the command is “<B>fragile</B>”
print all cars whose <B>Cargo Type is “fragile”</B> with a tire
whose <B>pressure is</B>  <B>&lt; 1</B>, if the command is “<B>flamable</B>”
print all cars whose <B>Cargo Type is “flamable”</B> and have
<B>Engine Power &gt; 250</B>. The cars should be printed in order of
appearing in the input.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=706 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=511>
	<COL WIDTH=177>
	<TR>
		<TD WIDTH=511 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=177 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=511 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">ChevroletAstro
			200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Citroen2CV
			190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1</FONT></P>
			<P><FONT FACE="Consolas, serif">fragile</FONT></P>
		</TD>
		<TD WIDTH=177 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">Citroen2CV</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=511 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">ChevroletExpress
			215 255 1200 flamable 2.5 1 2.4 2 2.7 1 2.8 1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">ChevroletAstro
			210 230 1000 flamable 2 1 1.9 2 1.7 3 2.1 1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">DaciaDokker
			230 275 1400 flamable 2.2 1 2.3 1 2.4 1 2 1</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Citroen2CV
			190 165 1200 fragile 0.8 3 0.85 2 0.7 5 0.95 2</FONT></P>
			<P><FONT FACE="Consolas, serif">flamable</FONT></P>
		</TD>
		<TD WIDTH=177 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">ChevroletExpress</FONT></P>
			<P><FONT FACE="Consolas, serif">DaciaDokker</FONT></P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-bottom: 0.14in; line-height: 115%"><BR><BR>
</P>