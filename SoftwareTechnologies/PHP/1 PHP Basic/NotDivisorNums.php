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
            for ($i = $num; $i >=1 ; $i--){
                if($num % $i != 0)
                    echo "$i\n";
            }
        }
    ?>
    <form>
        <div>Number:</div><input type="number" name="num">
        <div><input type="submit" value="Submit"></div>
    </form>
</body>
</html>