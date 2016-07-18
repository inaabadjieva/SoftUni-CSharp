<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>SubList</title>
</head>
    <body>
        <?php
            if (isset($_GET['num1']) && isset($_GET['num2'])) {
                $num1 = intval($_GET['num1']);
                $num2 = intval($_GET['num2']);
                $list = "<ul>";
                for ($i = 1; $i <= $num1; $i++){
                    $list .= "<li>List $i";
                    $list .= "<ul>";
                    for ($j = 1; $j <= $num2; $j++) {
                        $list .= "<li>Element $i.$j</li>";
                    }
                    $list .= "</ul>";
                    $list .= "</li>";
                }
                $list .= "</ul>";
                echo "$list";
            }
        ?>
    <form>
        <div>Number 1:</div><input type="number" name="num1">
        <div>Number 2:</div><input type="number" name="num2">
        <div><input type="submit" value="Submit"></div>
    </form>
</body>
</html>