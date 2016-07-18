<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>PrintLines</title>
</head>
<body>
    <?php
        if(isset($_GET['lines'])){
            $lines = $_GET['lines'];
            $arr = explode("\n", $lines);
            $arr = array_map('trim',$arr);
            for($i = 0; $i < count($arr); $i++){
                if($arr[$i] == 'Stop'){
                    break;
                }
                echo $arr[$i] . '<br>';
            }
        }
    ?>
    <form>
        <div>
            Input:
            <textarea name="lines" rows="10"></textarea>
        </div>
        <div>
            <input type="submit" value="Submit">
        </div>
    </form>
</body>
</html>