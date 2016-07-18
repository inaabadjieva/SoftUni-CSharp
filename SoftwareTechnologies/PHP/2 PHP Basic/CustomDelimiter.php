<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Custom Delimiter</title>
    <style>
        div {
            display: inline-block;
        }
    </style>
</head>
<body>
    <?php
         if(isset($_GET['delimiter']) && isset($_GET['lines'])){
             $delimiter = $_GET['delimiter'];
             $lines = $_GET['lines'];
             $arr = explode($delimiter, $lines);
             $arr = array_map('trim', $arr);
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
            Delimiter:
            <input type="text" name="delimiter">
        </div>
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