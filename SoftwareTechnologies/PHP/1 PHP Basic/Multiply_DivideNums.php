<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Multiply/Divide Nums</title>
</head>
<body>
    <?php
    if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num2'])) {
        $nums = [$num1 = $_GET['num1'],
        $num2 = $_GET['num2'],
        $num3 = $_GET['num3']];
        $count = 0;
        foreach ($nums as $num) {
            if ($num < 0)
                $count++;
        }
        if($num1 == 0 || $num2 == 0 || $num3 == 0 || $count % 2 == 0)
            echo "positive";
        else
            echo "negative";
    }
    ?>
    <form>
        <div>First Number:</div><input type="number" name="num1">
        <div>Second Number:</div><input type="number" name="num2">
        <div>Third Number:</div><input type="number" name="num3">
        <div><input type="submit" value="Submit"></div>
    </form>
</body>
</html>