<H2 LANG="bg-BG" CLASS="western"><SPAN LANG="en-US">Book Library
	</SPAN>
	</H2>

<P STYLE="margin-top: 0.06in">To model a <B>book library</B>, define
classes to hold a <B>book</B> and a <B>library</B>. The library must
have a <B>name</B> and a <B>list of books</B>. The books must contain
the <B>title</B>, <B>author</B>,<B> publisher</B>,<B> release date</B>,<B>
ISBN-number </B>and<B> price. </B>
</P>
<P STYLE="margin-top: 0.06in">Read a <B>list of books</B>, add them
to the library and print the <B>total sum of prices by author</B>,<B>
</B>ordered <B>descending by price</B> and <B>then by author’s name
lexicographically</B>.</P>
<P STYLE="margin-top: 0.06in">Books in the input will be in format
<B>{title} {author} {publisher} {release date} {ISBN} {price}</B>.</P>
<H3 CLASS="western">Examples</H3>
<TABLE WIDTH=603 CELLPADDING=4 CELLSPACING=0>
	<COL WIDTH=430>
	<COL WIDTH=156>
	<TR>
		<TD WIDTH=430 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Input</B></P>
		</TD>
		<TD WIDTH=156 BGCOLOR="#d9d9d9" STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P ALIGN=CENTER><B>Output</B></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=430 HEIGHT=27 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0.04in"><FONT FACE="Consolas, serif">5</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">LOTR
			Tolkien GeorgeAllen 29.07.1954 0395082999 30.00</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Hobbit
			Tolkien GeorgeAll 21.09.1937 0395082888 10.25</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">HP1
			JKRowling Bloomsbury 26.06.1997 0395082777 15.50</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">HP7
			JKRowling Bloomsbury 21.07.2007 0395082666 20.00</FONT></P>
			<P><FONT FACE="Consolas, serif">AC OBowden PenguinBooks 20.11.2009
			0395082555 14.00</FONT></P>
		</TD>
		<TD WIDTH=156 STYLE="border: 1px solid #00000a; padding-top: 0.04in; padding-bottom: 0.04in; padding-left: 0.06in; padding-right: 0.06in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">Tolkien
			-&gt; 40.25</FONT></P>
			<P STYLE="margin-bottom: 0in"><FONT FACE="Consolas, serif">JKRowling
			-&gt; 35.50</FONT></P>
			<P><FONT FACE="Consolas, serif">OBowden -&gt; 14.00</FONT></P>
		</TD>
	</TR>
</TABLE>