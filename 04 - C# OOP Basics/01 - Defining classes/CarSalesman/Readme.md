
<OL START=7>
	<LI><H2 CLASS="western" ALIGN=JUSTIFY>Car Salesman</H2>
</OL>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">Define two
classes <B>Car</B> and <B>Engine. </B>A<B> Car </B>has a <B>model,
engine, weight</B> and <B>color</B>. An Engine has <B>model</B>,
<B>power, displacement</B> and <B>efficiency</B>. A Car’s <B>weight</B>
and <B>color</B> and its Engine’s <B>displacements</B> and
<B>efficiency</B> are <B>optional</B>. 
</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">On the first line
you will read a number <B>N</B> which will specify how many lines of
engines you will receive, on each of the next <B>N</B> lines you will
receive information about an <B>Engine</B> in the following format
“&lt;<B>Model&gt; &lt;Power&gt; &lt;Displacement&gt; &lt;Efficiency&gt;</B>”.
After the lines with engines, on the next line you will receive a
number <B>M</B> – specifying the number of Cars that will follow,
on each of the next <B>M</B> lines information about a <B>Car</B>
will follow in the following format “&lt;<B>Model&gt; &lt;Engine&gt;
&lt;Weight&gt; &lt;Color&gt;</B>”, where the engine in the format
will be the <B>model of an existing</B> <B>Engine</B>. When creating
the object for a <B>Car</B>, you should keep a <B>reference to the
real engine</B> in it, instead of just the engine’s model, note
that the optional properties <B>might be missing</B> from the
formats.</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">Your task is to
print each car (in the order you received them) and its information
in the format defined bellow, if any of the optional fields has not
been given print “<B>n/a</B>” in its place instead:</P>
<P STYLE="margin-bottom: 0.14in; line-height: 115%"><B>&lt;CarModel&gt;:<BR>
 &lt;EngineModel&gt;:<BR>    Power: &lt;EnginePower&gt;<BR>   
Displacement: &lt;EngineDisplacement&gt;<BR>    Efficiency:
&lt;EngineEfficiency&gt;<BR>  Weight: &lt;CarWeight&gt;<BR>  Color:
&lt;CarColor&gt;</B></P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Bonus*</H3>
<P STYLE="margin-bottom: 0.14in; line-height: 115%">Override the
classes’s ToString() methods to have a reusable way of displaying
the objects.</P>
<H3 CLASS="western" ALIGN=JUSTIFY STYLE="margin-top: 0in">Examples</H3>
<TABLE WIDTH=706 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=325>
	<COL WIDTH=363>
	<TR>
		<TD WIDTH=325 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=363 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=325 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">2</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">V8-101
			220 50</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">V4-33
			140 28 B</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">FordFocus
			V4-33 1300 Silver</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">FordMustang
			V8-101</FONT></P>
			<P><FONT FACE="Consolas, serif">VolkswagenGolf V4-33 Orange </FONT>
			</P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">FordFocus:</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">V4-33:</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Power:
			140</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Displacement:
			28</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Efficiency:
			B</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">Weight:
			1300</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">Color:
			Silver</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">FordMustang:</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">V8-101:<BR>
			   Power: 220<BR>    Displacement: 50</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Efficiency:
			n/a</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">Weight:
			n/a</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">Color:
			n/a</FONT></P>
			<P STYLE="margin-bottom: 0in"><A NAME="_GoBack"></A><FONT FACE="Consolas, serif">VolkswagenGolf:</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">V4-33:</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Power:
			140</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Displacement:
			28</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Efficiency:
			B</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">Weight:
			n/a</FONT></P>
			<P>  <FONT FACE="Consolas, serif">Color: Orange</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=325 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">DSL-10
			280 B</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">V7-55
			200 35</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">DSL-13
			305 55 A+</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">V7-54
			190 30 D</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">FordMondeo
			DSL-13 Purple</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">VolkswagenPolo
			V7-54 1200 Yellow</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">VolkswagenPassat
			DSL-10 1375 Blue</FONT></P>
			<P><FONT FACE="Consolas, serif">FordFusion DSL-13</FONT></P>
		</TD>
		<TD WIDTH=363 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">FordMondeo:</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">DSL-13:</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Power:
			305</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Displacement:
			55</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Efficiency:
			A+</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">Weight:
			n/a</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">Color:
			Purple</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">VolkswagenPolo:</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">V7-54:</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Power:
			190</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Displacement:
			30</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Efficiency:
			D</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">Weight:
			1200</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">Color:
			Yellow</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">VolkswagenPassat:</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">DSL-10:</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Power:
			280</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Displacement:
			n/a</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Efficiency:
			B</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">Weight:
			1375</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">Color:
			Blue</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">FordFusion:</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">DSL-13:</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Power:
			305</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Displacement:
			55</FONT></P>
			<P STYLE="margin-bottom: 0in">    <FONT FACE="Consolas, serif">Efficiency:
			A+</FONT></P>
			<P STYLE="margin-bottom: 0in">  <FONT FACE="Consolas, serif">Weight:
			n/a</FONT></P>
			<P>  <FONT FACE="Consolas, serif">Color: n/a</FONT></P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-bottom: 0.14in; line-height: 115%"><BR><BR>
</P>