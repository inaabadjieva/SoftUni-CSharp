<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Tribonacci</title>
</head>
<body>
    <?php
        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
            $a = 0;
            $b = 0;
            $c = 1;
            $result = 1;
            $count = 0;
            while($count < $num){
                echo "$result\n";
                $result = $a + $b + $c;
                $a = $b;
                $b = $c;
                $c = $result;
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