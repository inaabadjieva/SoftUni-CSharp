<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Object to JSON string</title>
</head>
<body>
<?php
    if(isset($_GET['delimiter'])&&isset($_GET['input'])) {
        $delimiter = $_GET['delimiter'];
        $arr = explode("\n", $_GET['input']);
        $kvp = array();
        for ($i=0; $i < count($arr) ; $i++) {
            $temp = explode($delimiter, $arr[$i]);
            $temp = array_map('trim', $temp);
            if ($temp[0]!= "" && $temp[1]!= null) {
                if (is_numeric($temp[1])) {
                    $temp[1] = doubleval($temp[1]);
                }
                $kvp[$temp[0]] = $temp[1];
            }
        }
        $jsonObj = json_encode($kvp, JSON_UNESCAPED_SLASHES);
        echo $jsonObj;
    }
?>
    <form>
        Delimiter:<input type="text" name="delimiter">
        Input:<textarea name="input" rows="10"></textarea>
        <input type="submit" value="Submit">
    </form>
</body>
</html>