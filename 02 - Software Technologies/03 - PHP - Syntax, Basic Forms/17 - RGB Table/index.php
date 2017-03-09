<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        table * {
            border: 1px solid black;
            width: 50px;
            height: 50px;
        }
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red
        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
    </tr>
    <?php
        $n = 51;
        while ($n <= 256){
            echo "<tr><td style='background-color: rgb($n, 0, 0);'></td>";
            echo "<td style='background-color: rgb(0, $n, 0);'></td>";
            echo "<td style='background-color: rgb(0, 0, $n);'></td></tr>";
            $n += 51;
        }
    ?>
</table>
</body>
</html>