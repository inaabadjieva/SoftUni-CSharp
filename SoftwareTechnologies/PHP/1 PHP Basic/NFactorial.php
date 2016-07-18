<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Factorial</title>
</head>
<body>
    <?php
        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
            $fact = 1;
            for ($i = 1; $i <= $num; $i++){
                $fact = $fact * $i;
            }
            echo "$fact";
        }
    ?>
    <form>
        <div>Number:</div><input type="number" name="num">
        <div><input type="submit" value="Submit"></div>
    </form>
</body>
</html>