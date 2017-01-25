<H2 CLASS="western">Master Numbers</H2>
  
<P STYLE="margin-top: 0.06in">A master number is an integer that
holds the following properties:</P>
<UL>
	  <P STYLE="margin-top: 0.06in">Is <B>symmetric</B> (palindrome),
	e.g. 5, 77, 282, 14341, 9553559.</P>
	  <P STYLE="margin-top: 0.06in">Its <B>sum of digits is divisible
	by 7</B>, e.g. 77, 313, 464, 5225, 37173.</P>
	  <P STYLE="margin-top: 0.06in">Holds at least <B>one even digit</B>,
	e.g. 232, 707, 6886, 87578.</P>
</UL>
<P STYLE="margin-top: 0.06in">Write a program to <B>print all master
numbers</B> in the range [1…<B>n</B>].</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=262 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=42>
	<COL WIDTH=54>
	<COL WIDTH=27>
	<COL WIDTH=43>
	<COL WIDTH=53>
	<TR VALIGN=TOP>
		<TD WIDTH=42 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=54 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
		<TD WIDTH=27 BGCOLOR="#ffffff" STYLE="border-top: none; border-bottom: none; border-left: 1px solid #00000a; border-right: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><BR>
			</P>
		</TD>
		<TD WIDTH=43 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=53 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=42 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P>600</P>
		</TD>
		<TD WIDTH=54 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">232</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">383</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">464</FONT></P>
			<P><FONT FACE="Consolas, serif">545</FONT></P>
		</TD>
		<TD WIDTH=27 STYLE="border-top: none; border-bottom: none; border-left: 1px solid #00000a; border-right: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.06in; padding-right: 0.06in">
			<P><BR>
			</P>
		</TD>
		<TD WIDTH=43 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P>5000</P>
		</TD>
		<TD WIDTH=53 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">232</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">383</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">464</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">545</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">626</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">696</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">707</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">858</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="da-DK">1661</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="da-DK">2552</SPAN></FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif"><SPAN LANG="da-DK">3443</SPAN></FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="da-DK">4334</SPAN></FONT></P>
		</TD>
	</TR>
</TABLE>
<H3 CLASS="western">Hints</H3>
 
	  <P STYLE="margin-top: 0.06in">Write 3 utility methods:</P>
  
<UL>
	  <P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>IsPalindrome(int</B></FONT>
	<FONT FACE="Consolas, serif"><B>num)</B></FONT></P>
	  <P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>SumOfDigits(int</B></FONT>
	<FONT FACE="Consolas, serif"><B>num)</B></FONT></P>
	  <P STYLE="margin-top: 0.06in"><FONT FACE="Consolas, serif"><B>ContainsEvenDigit(int</B></FONT><FONT FACE="Consolas, serif"><B><FONT FACE="Calibri, serif">
	</FONT></B></FONT><FONT FACE="Consolas, serif"><B>num)</B></FONT></P>
</UL>
<P STYLE="margin-top: 0.06in">Loop through all numbers in range
	[1…<FONT FACE="Consolas, serif"><B>n</B></FONT>] and check every
	number with the helper methods.</P>
