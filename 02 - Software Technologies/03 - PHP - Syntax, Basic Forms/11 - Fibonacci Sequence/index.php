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
        $N = intval($_GET['num']);
        $n1 = 1;
        $n2 = 1;
        echo "$n1 $n2 ";
        for($i = 2; $i < $N; $i++){
            $sum = $n1 + $n2;
            echo "$sum ";
            $n1 = $n2;
            $n2 = $sum;
        }
    }
?>
</body>
</html>