<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<body>
<?php
    $rowStart = 0;
    for($i = 0; $i < 5; $i++){
        $rowTemp = $rowStart;
        for($j = 0; $j < 10; $j++){
            echo "<div style=\"background-color: rgb($rowTemp, $rowTemp, $rowTemp);\"></div>";
            $rowTemp += 5;
        }
        $rowStart += 51;
        echo "<br>";
    }
?>
</body>
</html>