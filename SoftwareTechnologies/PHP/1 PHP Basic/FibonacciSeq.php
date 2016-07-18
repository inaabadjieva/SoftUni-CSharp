<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Fibonacci</title>
</head>
<body>
    <?php
        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
            $x = 0;
            $y = 1;
            $z = 1;
            $count = 0;
            while($count < $num){
                echo "$z\n";
                $z = $x + $y;
                $x = $y;
                $y = $z;
                $count++;
            }
        }
    ?>
    <form>
        <div>Number:</div><input type="number" name="num">
        <div><input type="submit" value="Submit"></div>
    </form>
</body>
</html>