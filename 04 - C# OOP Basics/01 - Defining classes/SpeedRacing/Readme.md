
<OL START=5>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY>*Speed Racing</H2>
</OL>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">Your task is to
implement a program that keeps track of cars and their fuel and
supports methods for moving the cars. Define a class <B>Car</B> that
keeps track of a car’s <B>Model, fuel amount, fuel cost for 1
kilometer </B>and <B>distance traveled</B>. A Car’s Model is <B>unique</B>
- there will never be 2 cars with the same model.</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%"> On the first
line of the input you will receive a number <B>N</B> – the number
of cars you need to track, on each of the next <B>N</B> lines you
will receive information for a car in the following format “&lt;<B>Model&gt;
&lt;FuelAmount&gt; &lt;FuelCostFor1km&gt;</B>”, all <B>cars start
at 0 kilometers traveled</B>.</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%"><A NAME="OLE_LINK10"></A><A NAME="OLE_LINK9"></A><A NAME="OLE_LINK8"></A><A NAME="OLE_LINK7"></A>
<BR>After the <B>N</B> lines until the command “<B>End</B>” is
received, you will receive a commands in the following format “<B>Drive
&lt;CarModel&gt;  &lt;amountOfKm&gt;</B>”, implement a method in
the <B>Car</B> class to calculate whether or not a car can move that
distance, if it can the car’s <B>fuel amount</B> should be <B>reduced</B>
by the amount of used fuel and its <B>distance traveled</B> should be
increased by the amount of kilometers traveled, otherwise the car
should not move (Its fuel amount and distance traveled should stay
the same) and you should print on the console “<B>Insufficient fuel
for the drive</B>”. After the “<B>End</B>” command is received,
print each car and its current fuel amount and distance traveled in
the format “<B>&lt;Model&gt; &lt;fuelAmount&gt; 
&lt;distanceTraveled&gt;</B>”, where the fuel amount should be
printed to <B>two decimal places</B> after the separator.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=720 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=417>
	<COL WIDTH=285>
	<TR>
		<TD WIDTH=417 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><B>Input</B></P>
		</TD>
		<TD WIDTH=285 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=417 HEIGHT=86 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">AudiA4
			23 0.3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">BMW-M2
			45 0.42</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Drive
			BMW-M2 56</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Drive
			AudiA4 5</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Drive
			AudiA4 13</FONT></P>
			<P><FONT FACE="Consolas, serif">End</FONT></P>
		</TD>
		<TD WIDTH=285 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">AudiA4
			17.60 18</FONT></P>
			<P><FONT FACE="Consolas, serif">BMW-M2 21.48 56</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=417 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">AudiA4
			18 0.34</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">BMW-M2
			33 0.41</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Ferrari-488Spider
			50 0.47</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Drive
			Ferrari-488Spider 97</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Drive
			Ferrari-488Spider 35</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Drive
			AudiA4 85</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Drive
			AudiA4 50</FONT></P>
			<P><FONT FACE="Consolas, serif">End</FONT></P>
		</TD>
		<TD WIDTH=285 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Insufficient
			fuel for the drive</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Insufficient
			fuel for the drive</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">AudiA4
			1.00 50</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">BMW-M2
			33.00 0</FONT></P>
			<P><FONT FACE="Consolas, serif">Ferrari-488Spider 4.41 97</FONT></P>
		</TD>
	</TR>
</TABLE>
