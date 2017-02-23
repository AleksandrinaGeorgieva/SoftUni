<H1 CLASS="western" ALIGN=CENTER><SPAN LANG="bg-BG"></SPAN>
Files</H1>
<P STYLE="margin-top: 0.06in">You are given number of files with
their <B>full file paths</B> and <B>file sizes</B>. You need to <B>print
all file names</B> with <B>a given extension </B>that are present in<B>
a given root directory sorted by their file size </B>in<B> descending
order</B>. If two files have <B>same size</B>, order them <B>by
alphabetical order</B>. 
</P>
<P STYLE="margin-top: 0.06in">If a <B>file name (file name +
extension) appears more than once in a given root</B>, <B>save only
its latest value. </B>If a file name appears in more than one root,
they are treated as different files.</P>
<P STYLE="margin-top: 0.06in">If there <B>aren't any files</B> that
correspond to the query, print <B>&quot;No&quot;</B>.</P>
<H2 CLASS="western" ALIGN=JUSTIFY>Input / Constrains</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the <B>first line</B>
	of input you will get <B>N</B> the <B>number of files to be read
	from the console</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">On the next N lines,
	you receive <B>the actual files in the format
	&quot;root\folder\filename.extension;filesize&quot;</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">There may be more
	than one folder e.g. <B>files can be deeply nested</B></P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in"><A NAME="_GoBack"></A>
	On the last line you receive a query string in format <B>&quot;{extension}
	in {root}&quot;</B>. You need to print all files with the given
	extension that are in present in the given root</P>
</UL>
<H2 CLASS="western" ALIGN=JUSTIFY>Output</H2>
<UL>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">You need to print
	all files sorted by their size in descending order. 
	</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">If two files have
	the same size, order them by alphabetical order. 
	</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">Files should be
	printed in the given format <B>&quot;filename.extension - filesize
	KB&quot; </B>
	</P>
	<LI><P ALIGN=JUSTIFY STYLE="margin-top: 0.06in">If there <B>aren't
	any movies</B> that correspond to the query, print <B>&quot;No&quot;</B>.</P>
</UL>
<H2 CLASS="western">Examples</H2>
<TABLE WIDTH=699 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=426>
	<COL WIDTH=256>
	<TR VALIGN=TOP>
		<TD WIDTH=426 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=256 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=426 HEIGHT=25 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">4</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Windows\Temp\win.exe;5423</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Games\Wow\wow.exe;1024</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Games\Wow\patcher.cs;65212</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Games\Pirates\Start\keygen.exe;1024</FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">exe in </SPAN></FONT><FONT FACE="Consolas, serif">Games</FONT></P>
		</TD>
		<TD WIDTH=256 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">keygen.exe
			- 1024 KB </FONT>
			</P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">wow.exe
			- 1024 KB</FONT></P>
			<P><BR>
			</P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=426 HEIGHT=24 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">3</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">C:\Documents\01.
			problems.docx;6521</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">D:\Documents\02.
			Documents\ presentation.pptx;44234</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">E:\Movies\Classics\someclassicmovie.avi;6221235212</FONT></P>
			<P><FONT FACE="Consolas, serif"><SPAN LANG="en-GB">docx in </SPAN></FONT><FONT FACE="Consolas, serif">E:</FONT></P>
		</TD>
		<TD WIDTH=256 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P><FONT FACE="Consolas, serif">No</FONT></P>
		</TD>
	</TR>
</TABLE>
