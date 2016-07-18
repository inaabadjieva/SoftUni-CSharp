<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>ReverseNumbers</title>
    <style>
        div {
            display: inline-block;
        }
    </style>
</head>
<body>
<?php
    if(isset($_GET['numbers']) && isset($_GET['delimiter'])){
        $delimiter = $_GET['delimiter'];
        $lines = $_GET['numbers'];
        $arr = explode($delimiter, $lines);
        $arr = array_map('trim',$arr);
        for($i = count($arr)-1; $i>=0; $i--){
            echo $arr[$i] . '<br>';
        }
    }
?>
    <form>
        <div>
            Delimiter:
            <input type="text" name="delimiter">
        </div>
        <div>
            Input:
            <input type="text" name="numbers">
        </div>
        <div>
            <input type="submit" value="Submit">
        </div>
    </form>
</body>
</html>