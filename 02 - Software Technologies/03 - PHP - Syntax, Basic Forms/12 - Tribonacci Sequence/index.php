<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
    if(isset($_GET['num'])){
        $n = $_GET['num'];

        $n1 = 1;
        $n2 = 1;
        $n3 = 2;

        echo "$n1 $n2 $n3 ";

        for($i = 3; $i < $n; $i++){
            $sum = $n1 + $n2 + $n3;
            echo "$sum ";
            $n1 = $n2;
            $n2 = $n3;
            $n3 = $sum;
        }
    }
?>
</body>
</html>