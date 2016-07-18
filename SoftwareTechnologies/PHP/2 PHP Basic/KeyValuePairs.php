<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Key-Value Pairs</title>
</head>
<body>
    <?php
        if(isset($_GET['delimiter']) && isset($_GET['target-key']) && isset($_GET['key-value-pairs'])) {
            $delimiter = $_GET['delimiter'];
            $targetKey = $_GET['target-key'];
            $lines = $_GET['key-value-pairs'];

            $arr = [];

            $lines = explode("\n", $lines);
            $lines = array_map('trim', $lines);
            for ($i = 0; $i < count($lines); $i++) {
                $pair = explode($delimiter, $lines[$i]);
                $key = $pair[0];
                $value = $pair[1];

                $arr[$key] = $value;
            }
            if (!array_key_exists($targetKey,$arr))
            {
                echo "None";
            } else {
                foreach($arr as $k => $val){
                    if($k == $targetKey)
                        echo $val;
                }
            }

    }
    ?>
    <form>
        Delimiter:<input type="text" name="delimiter">
        Target:<input type="text" name="target-key">
        Input:<textarea name="key-value-pairs" rows="10"></textarea>
        <input type="submit" value="Submit">
    </form>
</body>
</html>