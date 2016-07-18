<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Nums 1 to N</title>
</head>
<body>
    <?php
        if (isset($_GET['num'])) {
            $num = $_GET['num'];
            for ($i = 1; $i <= $num; $i++){
                if($i % 2 == 0)
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