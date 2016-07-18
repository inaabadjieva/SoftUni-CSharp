<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>DrawButtons</title>
    <style>
        div {


            display: inline-block;
            height: 50px;
            width: 50px;
        }
    </style>
</head>
<body>
        <?php
        $colorValue = 0;
        for ($i = 1; $i <= 5; $i++){
            for ($j = 1; $j <= 10; $j++){
                $color = "rgb($colorValue, $colorValue, $colorValue)";
                echo '<div style="background-color: ' . $color . ';"></div>';
                $colorValue+=5;
            }
            $colorValue+=1;
            echo "<br>";
        }
        ?>
</body>
</html>