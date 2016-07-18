<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>DrawButtons</title>
</head>
<body>
    <?php
        for ($i = 1; $i <= 5; $i++){
            echo "<button style='background-color:blue;'>1</button>";
        }
        echo "<br/>";
        for ($i = 1; $i <= 15; $i++){
            if($i==1 || $i==6 || $i==11){
                echo "<button style='background-color:blue;'>1</button>";
            }
            if($i%5==0){
                echo "<br/>";
            }
            else{
                echo "<button>0</button>";
            }
        }
        for ($i = 1; $i <= 5; $i++){
            echo "<button style='background-color:blue;'>1</button>";
        }
        echo "<br/>";
        for ($i = 1; $i <= 15; $i++){
            if($i%5==0){
                echo "<button style='background-color:blue;'>1</button><br/>";
            }
            else{
                echo "<button>0</button>";
            }
        }
        for ($i = 1; $i <= 5; $i++){
            echo "<button style='background-color:blue;'>1</button>";
        }
    ?>
</body>
</html>