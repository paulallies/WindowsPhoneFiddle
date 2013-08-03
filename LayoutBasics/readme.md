##Grid
The grid layout control is used to position controls on the page

The main grid element is defined as follows
```xml
<Grid>
	<Grid.RowDefinitions>
		<RowDefinition  Height="auto"></RowDefinition>
		<RowDefinition  Height="*"></RowDefinition>
    </Grid.RowDefinitions>
</Grid>
```

The RowDefinition define that the page will be divided into 2 sections(rows) with the first row having a
height of whatever is in the row.  The 2nd row will have a height of whatever is remaining of the page.

